/**
 * @file Sensor.cpp
 * @brief Source file for sensor functions
 * 
 * This file contains the implementation of functions related to sensor operations.
 */
#include "Sensor.h" /**< Include the corresponding header file */

/**
 * @brief Read distance from ultrasonic sensor
 * @param triggerPin Pin connected to the trigger of the ultrasonic sensor
 * @param echoPin Pin connected to the echo of the ultrasonic sensor
 * @return Distance measured by the sensor (in centimeters)
 */
int readDistance(int triggerPin, int echoPin) {
  digitalWrite(triggerPin, LOW);
  delayMicroseconds(2);
  digitalWrite(triggerPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(triggerPin, LOW);
  long duration = pulseIn(echoPin, HIGH);
  int distance = duration * 0.034 / 2;
  return distance;
}
/**
 * @brief Check sensor status
 * @return True if all sensor readings are above their respective thresholds, false otherwise
 */
extern bool sensorCheck(){
  int distance_1 = readDistance(TRIGGER_PIN_1, ECHO_PIN_1);//WATER
  int distance_2 = readDistance(TRIGGER_PIN_2, ECHO_PIN_2);//MILK
  int distance_3 = readDistance(TRIGGER_PIN_3, ECHO_PIN_3);//SUGAR
  int distance_4 = readDistance(TRIGGER_PIN_4, ECHO_PIN_4);//COFFEE
  if (distance_1 > DISTANCE_THRESHOLD_1){
    Serial.write("LOW INVENTORY WATER");
    return false;
  }  
  if (distance_2 > DISTANCE_THRESHOLD_2){
    Serial.write("LOW INVENTORY MILK");
    return false;
  }
  if (distance_3 > DISTANCE_THRESHOLD_3){
    Serial.write("LOW INVENTORY SUGAR");
    return false;
  }
  if (distance_4 > DISTANCE_THRESHOLD_4){
    Serial.write("LOW INVENTORY COFFEE");
    return false;
  }
  return true;
  delay(1000); // This delay statement is unreachable
}
