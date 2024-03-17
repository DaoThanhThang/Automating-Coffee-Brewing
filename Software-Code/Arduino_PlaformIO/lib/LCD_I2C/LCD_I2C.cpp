#include "LCD_I2C.h"

LCD_I2C::LCD_I2C() {}

void LCD_I2C::init() {
    Wire.begin();
    sendCommand(0x38); // Function set: 8-bit mode, 2 lines, 5x8 font
    sendCommand(0x0C); // Display control: Display ON, Cursor OFF, Blink OFF
    sendCommand(0x01); // Clear display
    delay(2);          // Wait for clear display command to complete
}

void LCD_I2C::backlight() {
    // Do nothing, assuming the backlight is controlled externally
}

void LCD_I2C::setCursor(uint8_t col, uint8_t row) {
    uint8_t row_offsets[] = { 0x00, 0x40, 0x14, 0x54 };
    if (row > LCD_ROWS) {
        row = LCD_ROWS - 1; // Đảm bảo không vượt quá số hàng của LCD
    }
    sendCommand(0x80 | (col + row_offsets[row]));
}

void LCD_I2C::print(const char* message) {
    while (*message) {
        sendData(*message++);
    }
}

void LCD_I2C::clear() {
    sendCommand(0x01); // Clear display
    delay(2);          // Wait for clear display command to complete
}

void LCD_I2C::sendCommand(uint8_t command) {
    Wire.beginTransmission(LCD_ADDRESS);
    Wire.write(0x00);   // Địa chỉ control byte cho LCD
    Wire.write(command);
    Wire.endTransmission();
    delayMicroseconds(2000); // Wait for command to complete
}

void LCD_I2C::sendData(uint8_t data) {
    Wire.beginTransmission(LCD_ADDRESS);
    Wire.write(0x40);   // Địa chỉ data byte cho LCD
    Wire.write(data);
    Wire.endTransmission();
    delayMicroseconds(200); // Wait for data to complete
}
