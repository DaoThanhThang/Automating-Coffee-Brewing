/*
 * @file main.cpp
 * @brief Main source file of the Coffee Machine project
 * 
 * @details This file contains the main functionality of the Coffee Machine project.
 * It includes setup and loop functions, as well as the main program logic.
 * 
 * @author Dao Thanh Thang
 * @email thang.techcareers@gmail.com
 * @note For any inquiries about this project or this code, please contact the author via email.
 */

#include <Arduino.h>
#include <Wire.h>
#include "LCD_I2C.h"// Include the LCD_I2C header file
#include "CoffeeMachine.h"// Include the CoffeeMachine header file
#include "Sensor.h"// Include the Sensor header file


/**
 * @brief Setup function
 * 
 * @details Initialize serial communication, LCD display, and perform initial setup.
 */
void setup() {
  Serial.begin(9600); /**< Begin serial communication */
  lcdStart(); /**< Initialize LCD display **/
}
/**
 * @brief Main loop function
 * 
 * @details Continuously checks for serial data, parses input, selects coffee recipe,
 * checks sensor status, and brews coffee accordingly.
 */
void loop() {
  if(connectionCheck()) { /**< Check serial connection */
      String data = Serial.readStringUntil('\r'); /**< Read data from serial port */
      getString(); /**< Extract individual components from input string */
      if (!makeCoffeeFlag) {/**< Check if coffee brewing process is not ongoing */
      CoffeeRecipeSelect(recipeName); /**< Select coffee recipe */
      if(sensorCheck()) { /**< Check sensor status */
        makeCoffee(recipe, numberOfService, sugar, milk, strengthOfCoffee); /**< Brew coffee */
        makeCoffeeFlag = true; /**< Set coffee brewing flag */
      }
    }
  }
}
