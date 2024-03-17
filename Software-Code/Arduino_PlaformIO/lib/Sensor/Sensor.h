#ifndef SENSOR_H
#define SENSOR_H

#include "Arduino.h"

#define TRIGGER_PIN_1 38 /**< Pin number for trigger 1 */
#define ECHO_PIN_1 40 /**< Pin number for echo 1 */
#define TRIGGER_PIN_2 42 /**< Pin number for trigger 2 */
#define ECHO_PIN_2 44 /**< Pin number for echo 2 */
#define TRIGGER_PIN_3 46 /**< Pin number for trigger 3 */
#define ECHO_PIN_3 48 /**< Pin number for echo 3 */
#define TRIGGER_PIN_4 50 /**< Pin number for trigger 4 */
#define ECHO_PIN_4 52 /**< Pin number for echo 4 */
#define DISTANCE_THRESHOLD_1 20 /**< Distance threshold for sensor 1 */
#define DISTANCE_THRESHOLD_2 20 /**< Distance threshold for sensor 2 */
#define DISTANCE_THRESHOLD_3 20 /**< Distance threshold for sensor 3 */
#define DISTANCE_THRESHOLD_4 20 /**< Distance threshold for sensor 4 */

/**
 * @brief Read distance from ultrasonic sensor
 * @param triggerPin Pin number for trigger
 * @param echoPin Pin number for echo
 * @return Distance in centimeters
 */
int readDistance(int triggerPin, int echoPin);

/**
 * @brief Check if all sensors detect enough distance
 * @return True if all sensors detect enough distance, false otherwise
 */
extern bool sensorCheck();

#endif
