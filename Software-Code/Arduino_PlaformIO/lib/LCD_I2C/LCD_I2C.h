#ifndef LCD_I2C_H
#define LCD_I2C_H

#include <Arduino.h>
#include <Wire.h>

#define LCD_ADDRESS 0x27 // Địa chỉ I2C của LCD
#define LCD_COLS 16      // Số cột của LCD
#define LCD_ROWS 2       // Số hàng của LCD

class LCD_I2C {
public:
    LCD_I2C();
    void init();
    void backlight();
    void setCursor(uint8_t col, uint8_t row);
    void print(const char* message);
    void clear();
private:
    void sendCommand(uint8_t command);
    void sendData(uint8_t data);
};

#endif
