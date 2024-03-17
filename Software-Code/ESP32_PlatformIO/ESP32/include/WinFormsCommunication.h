/**
 * @file WinFormsCommunication.h
 * @brief Header file for WinForms communication.
 */

#ifndef WINFORMS_COMMUNICATION_H
#define WINFORMS_COMMUNICATION_H

#include <Arduino.h>
#include <WiFi.h>

/**
 * @brief Extract IP address from the input data string.
 * 
 * @param inputString The input data string.
 * @return The extracted IP address.
 */
String extractIPAddress(String inputString);

/**
 * @brief Check if a string starts with "IP:".
 * 
 * @param str The string to check.
 * @return True if the string starts with "IP:", otherwise False.
 */
bool startsWithIP(String str);

/**
 * @brief Send data to the WinForms application via TCP connection.
 * 
 * @param data The data string to send.
 */
void sendToWinForms(String data);

#endif
