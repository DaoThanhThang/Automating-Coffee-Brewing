/*
@Author: Dao Thanh Thang
@Email: thang.techcareers@gmail.com
For any wonder about this project or this code please to contact with me via email address.
*/
//----START INCLUDE---
#include <Wire.h>
#include <LiquidCrystal_I2C.h>


//----END INCLUDE-----

//----START DEFINE----
#define TRIGGER_PIN_1 38
#define ECHO_PIN_1 40
#define TRIGGER_PIN_2 42
#define ECHO_PIN_2 44
#define TRIGGER_PIN_3 46
#define ECHO_PIN_3 48
#define TRIGGER_PIN_4 50
#define ECHO_PIN_4 52
#define DISTANCE_THRESHOLD_1 20 // Threshold for sensor 1 in centimeters
#define DISTANCE_THRESHOLD_2 20 // Threshold for sensor 2 in centimeters
#define DISTANCE_THRESHOLD_3 20 // Threshold for sensor 3 in centimeters
#define DISTANCE_THRESHOLD_4 20 // Threshold for sensor 4 in centimeters
#define RELAY_WATER 30
#define RELAY_MILK 32
#define RELAY_SUGAR 34
#define RELAY_COFFEE 36

//-----END DEFINE------
// Define a structure to hold the coffee recipe
struct CoffeeRecipe {
  int water;  // Water in milliliters
  int milk;   // Milk in milliliters
  int sugar;  // Sugar in grams
  int coffee; // Coffee in grams
};
//END-----------
//-----START VARIABLE DEFINATION----
String data="";
String recipeName="";
int numberOfService=0;
int sugar=0;
int milk=0;
int strengthOfCoffee=0;
bool makeCoffeeFlag = false; // Biến flag để kiểm tra đã gọi hàm makeCoffee chưa
CoffeeRecipe recipe; // Đối tượng CoffeeRecipe để lưu thông tin về công thức pha cà phê
//-----END VARIABLE DEFINATION----

//-----SOME COMMAND BEFORE MAIN----
LiquidCrystal_I2C lcd(0x27, 20, 4);  //I2C address for PCF8574
// Define coffee recipes using the structure {water,milk,sugar,coffee} 330ml per service
CoffeeRecipe espresso = {99, 0, 0, 33}; // Espresso
CoffeeRecipe americano = {198, 0, 0, 50}; // Americano
CoffeeRecipe cappuccino = {99, 99, 33, 33}; // Cappuccino
CoffeeRecipe latte = {99, 198, 33, 33}; // Latte
CoffeeRecipe blackCoffee = {99, 0, 16, 33}; // Black Coffee
CoffeeRecipe mocha = {99, 99, 49, 33}; // Mocha
CoffeeRecipe cafeAuLait = {198, 66, 16, 33}; // Cafe au Lait
CoffeeRecipe macchiato = {66, 0, 16, 33}; // Macchiato

//END--------------------------------

//-----PURPOSE OF THIS IS TAKE UART SERIAL SIGNAL AND ASSIGN IT TO VARIABLE--
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
// END --------------------

//ASSIGN RECIPE
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
//
// SENSOR CHECK FUNCTION
bool sensorCheck(){
  // Read distance from each sensor
  int distance_1 = readDistance(TRIGGER_PIN_1, ECHO_PIN_1);
  int distance_2 = readDistance(TRIGGER_PIN_2, ECHO_PIN_2);
  int distance_3 = readDistance(TRIGGER_PIN_3, ECHO_PIN_3);
  int distance_4 = readDistance(TRIGGER_PIN_4, ECHO_PIN_4);

  // Check if any sensor reading is greater than the threshold
  if (distance_1 > DISTANCE_THRESHOLD_1 || 
      distance_2 > DISTANCE_THRESHOLD_2 || 
      distance_3 > DISTANCE_THRESHOLD_3 || 
      distance_4 > DISTANCE_THRESHOLD_4) {
    return true;
  } else {
    return false;
  }
  delay(1000); // Delay between readings
}
// END -----------------
// READ DISTANCE FUNCTION
int readDistance(int triggerPin, int echoPin) {
  // Send a pulse to the trigger pin
  digitalWrite(triggerPin, LOW);
  delayMicroseconds(2);
  digitalWrite(triggerPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(triggerPin, LOW);

  // Measure the duration of the pulse on the echo pin
  long duration = pulseIn(echoPin, HIGH);

  // Convert the duration to distance in centimeters
  int distance = duration * 0.034 / 2;
  return distance;
}
// END ------------
//MAKE COFFEE
void makeCoffee(CoffeeRecipe recipe, int numberOfService, int _sugar, int _milk, int _strengthOfCoffee) {
  controlRelay(RELAY_WATER, recipe.water * numberOfService); 
  controlRelay(RELAY_MILK, recipe.milk * (_milk / 100) * numberOfService); 
  controlRelay(RELAY_SUGAR, recipe.sugar * (_sugar / 100) * numberOfService); 
  controlRelay(RELAY_COFFEE, recipe.coffee * (_strengthOfCoffee / 100) * numberOfService);
  makeCoffeeFlag = false; // Gán lại cờ makeCoffeeFlag thành false sau khi pha cà phê
}

//END
//RELAY CONTROL
void controlRelay(int RELAY_PIN,int value) { 
  digitalWrite(RELAY_PIN, HIGH); // Bật relay
  delay(value * 1000/30); // Giả sử 1s rót được 30ml chất lỏng
  digitalWrite(RELAY_PIN, LOW); // Tắt relay
}
//END
// LCD
void lcdStart(){
     lcd.begin(20, 4);                    
     lcd.backlight();
     lcd.setCursor(1,0);
     lcd.print("Hello,PLEASE WAIT..");
     lcd.setCursor(1,1);
     lcd.print("CHECKING CONNECTION..");
     lcd.setCursor(1,2);
     lcd.print("CHECKING INVENTORY");  
     lcd.setCursor(1,3);
     lcd.print(".....................");  
}
//END---
void setup() {
  Serial.begin(9600);

  lcdStart();
}
//INFINITY LOOP
void loop() {
   if (Serial.available() > 0 && !makeCoffeeFlag) {
    String data = Serial.readStringUntil('\r');
    getString();
    CoffeeRecipeSelect(recipeName);
    makeCoffee(recipe, numberOfService, sugar, milk, strengthOfCoffee);
    makeCoffeeFlag = true;
  } else {
    lcd.clear();
    delay(1000);
    lcd.setCursor(1, 0);
    lcd.print("CONNECTION ERROR");
  }
  if(!sensorCheck()){
    lcd.setCursor(1,1);
    lcd.print("INVENTORY LOW..");
  }
}
