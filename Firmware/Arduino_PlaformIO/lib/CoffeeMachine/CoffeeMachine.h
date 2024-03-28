
#ifndef COFFEEMACHINE_H
#define COFFEEMACHINE_H

#include "Arduino.h" // Include the Arduino library to use Arduino's basic functions
#include "LCD_I2C.h"// Include the LCD_I2C header file
#include "Sensor.h"// Include the Sensor header file
/**
 * @brief Structure to store coffee brewing recipes
 */
struct CoffeeRecipe {
  int water; /**< Amount of water */
  int milk; /**< Amount of milk */
  int sugar; /**< Amount of sugar */
  int coffee; /**< Amount of coffee */
};


// Define Relay output pin 
#define RELAY_WATER 30 /**< Pin number for water relay */
#define RELAY_MILK 32 /**< Pin number for milk relay */
#define RELAY_SUGAR 34 /**< Pin number for sugar relay */
#define RELAY_COFFEE 36 /**< Pin number for coffee relay */ 

// Variable used to flag coffee brewing process
extern bool makeCoffeeFlag;

// Variables to store data related to coffee brewing process
extern bool makeCoffeeFlag;
extern String data;
extern String recipeName;
extern int numberOfService;
extern int sugar;
extern int milk;
extern int strengthOfCoffee;
extern CoffeeRecipe recipe;

/**
 * @brief Extract individual components from input string
 */
void getString();

/**
 * @brief Assign extracted parts to corresponding variables
 * @param partIndex Index of the part
 * @param part The extracted part
 */
void assignPart(int partIndex, String part);

/**
 * @brief Select a coffee recipe based on input string
 * @param _recipe The selected recipe name
 */
void CoffeeRecipeSelect(String _recipe);

/**
 * @brief Brew coffee based on selected recipe and parameters
 * @param recipe The selected coffee recipe
 * @param numberOfService Number of coffee services to brew
 * @param _sugar Amount of sugar to add (percentage)
 * @param _milk Amount of milk to add (percentage)
 * @param _strengthOfCoffee Strength of coffee (percentage)
 */
void makeCoffee(CoffeeRecipe recipe, int numberOfService, int _sugar, int _milk, int _strengthOfCoffee);

/**
 * @brief Control relay for brewing process
 * @param RELAY_PIN Pin number of the relay
 * @param value Value to control relay
 */
void controlRelay(int RELAY_PIN, int value);

/**
 * @brief Initialize and display startup message on LCD screen
 */
void lcdStart();

/**
 * @brief Display low inventory message on LCD screen
 */
void inventoryLow();

/**
 * @brief Check connection status
 * @return True if connection is available, false otherwise
 */
bool connectionCheck();

#endif
