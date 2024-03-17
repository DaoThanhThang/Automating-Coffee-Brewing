/**
 * @file CoffeeMachine.cpp
 * @brief Source file for the Coffee Machine project
 * 
 * This file contains the implementation of functions related to coffee brewing and control.
 */
#include "CoffeeMachine.h"// Include the CoffeeMachine header file

LCD_I2C lcd; 

// Define specific coffee brewing recipes with their respective values
CoffeeRecipe espresso = {99, 0, 0, 33}; // Espresso
CoffeeRecipe americano = {198, 0, 0, 50}; // Americano
CoffeeRecipe cappuccino = {99, 99, 33, 33}; // Cappuccino
CoffeeRecipe latte = {99, 198, 33, 33}; // Latte
CoffeeRecipe blackCoffee = {99, 0, 16, 33}; // Black Coffee
CoffeeRecipe mocha = {99, 99, 49, 33}; // Mocha
CoffeeRecipe cafeAuLait = {198, 66, 16, 33}; // Cafe au Lait
CoffeeRecipe macchiato = {66, 0, 16, 33}; // Macchiato

// Define other variables 
bool makeCoffeeFlag = false; /**< Flag to control coffee brewing process */
String data="", recipeName=""; /**< Variables to store data from UART communication */
int numberOfService=0, sugar=0, milk=0, strengthOfCoffee=0; /**< Variables for coffee recipe parameters */
CoffeeRecipe recipe; /**< Variable to store selected coffee recipe */
bool sensorCheck();
/**
 * @brief Extract individual components from input string
 */
void getString(){
  int lastIndex = -1; 
  int index;
  int partIndex = 0;
  do {
    index = data.indexOf(",", lastIndex + 1); 
    if (index != -1) { 
      assignPart(partIndex++, data.substring(lastIndex + 1, index));
      lastIndex = index;
    }
  } while (index != -1);
  assignPart(partIndex, data.substring(lastIndex + 1));
}

/**
 * @brief Assign extracted parts to corresponding variables
 * @param partIndex Index of the part
 * @param part The extracted part
 */
void assignPart(int partIndex, String part) {
  switch (partIndex) {
    case 0:
      recipeName = part;
      break;
    case 1:
      numberOfService = part.toInt();
      break;
    case 2:
      sugar = part.toInt();
      break;
    case 3:
      milk = part.toInt();
      break;
    case 4:
      strengthOfCoffee = part.toInt();
      break;
    default:
      break;
  }
}

/**
 * @brief Select a coffee recipe based on input string
 * @param _recipe The selected recipe name
 */
void CoffeeRecipeSelect(String _recipe) {
  if (_recipe == "Black coffee") {
    recipe = blackCoffee;
  } else if (_recipe == "Espresso") {
    recipe = espresso;
  } else if (_recipe == "Cappuccino") {
    recipe = cappuccino;
  } else if (_recipe == "Latte") {
    recipe = latte;
  } else if (_recipe == "Mocha") {
    recipe = mocha;
  } else if (_recipe == "Café au lait") {
    recipe = cafeAuLait;
  } else if (_recipe == "Macchiato") {
    recipe = macchiato;
  }
}

/**
 * @brief Brew coffee based on selected recipe and parameters
 * @param recipe The selected coffee recipe
 * @param numberOfService Number of coffee services to brew
 * @param _sugar Amount of sugar to add (percentage)
 * @param _milk Amount of milk to add (percentage)
 * @param _strengthOfCoffee Strength of coffee (percentage)
 */
void makeCoffee(CoffeeRecipe recipe, int numberOfService, int _sugar, int _milk, int _strengthOfCoffee) {
  controlRelay(RELAY_WATER, recipe.water * numberOfService); 
  controlRelay(RELAY_MILK, recipe.milk * (_milk / 100) * numberOfService); 
  controlRelay(RELAY_SUGAR, recipe.sugar * (_sugar / 100) * numberOfService); 
  controlRelay(RELAY_COFFEE, recipe.coffee * (_strengthOfCoffee / 100) * numberOfService);
  makeCoffeeFlag = false; 
}

/**
 * @brief Control relay for brewing process
 * @param RELAY_PIN Pin number of the relay
 * @param value Value to control relay
 */
void controlRelay(int RELAY_PIN,int value) { 
  digitalWrite(RELAY_PIN, HIGH); 
  delay(value * 1000/30); 
  digitalWrite(RELAY_PIN, LOW); 
}

/**
 * @brief Initialize and display startup message on LCD screen
 */
void lcdStart(){
  lcd.init();                    
  lcd.backlight(); 
  lcd.setCursor(0,0);
  lcd.print("PLEASE WAIT...");
  lcd.setCursor(0,1);
  lcd.print(".....................");
  delay(2000);
  lcd.clear();
  delay(1000);
  lcd.setCursor(0,0);
  lcd.print("CHECK INVENTORY");  
  lcd.setCursor(0,1);
  lcd.print(".....................");
  if(sensorCheck()){    
    inventoryLow();
  }
  delay(2000);
  lcd.clear();
  delay(1000);
  lcd.setCursor(0,0);
  lcd.print("CHECK CONNECTION");
  lcd.setCursor(0,1);
  lcd.print(".....................");
  delay(2000);    
}

/**
 * @brief Display low inventory message on LCD screen
 */
void inventoryLow(){
  lcd.setCursor(0,0);
  lcd.print("INVENTORY LOW");  
  lcd.setCursor(0,1);
  lcd.print("PLEASE REFILL");
}

/**
 * @brief Check connection status
 * @return True if connection is available, false otherwise
 */
bool connectionCheck(){
  if(!Serial.available()){
      lcd.clear();
      delay(1000);
      lcd.setCursor(0, 0);
      lcd.print("CONNECTION ERROR");
      return false;
  }
  return true;
}
