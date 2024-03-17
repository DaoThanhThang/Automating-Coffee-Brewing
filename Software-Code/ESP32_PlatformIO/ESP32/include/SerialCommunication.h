/**
 * @file SerialCommunication.h
 * @brief Header file for serial communication setup.
 */

#ifndef SERIAL_COMMUNICATION_H
#define SERIAL_COMMUNICATION_H

#include <Arduino.h>

/**
 * @brief HardwareSerial object for communication with Arduino.
 */
HardwareSerial SerialToArduino(1); // Using UART 1

/**
 * @brief Configure serial communication settings.
 */
void setupSerialCommunication();

#endif
