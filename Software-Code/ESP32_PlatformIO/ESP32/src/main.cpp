/**
 * @file main.cpp
 * @brief Main file containing setup and loop functions.
 */

#include "WiFiConnection.h"
#include "WinFormsCommunication.h"
#include "SerialCommunication.h"

WiFiServer server(80);
String WinformIP;
/**
 * @brief Initialize serial communication.
 * 
 * This function configures serial communication settings. It initializes the serial
 * communication port and sets the baud rate to 9600 with 8 data bits, no parity, and 1 stop bit.
 */
void setupSerialCommunication() {
    // Using UART 1 for serial communication
    HardwareSerial SerialToArduino(1);

    // Initialize serial communication with baud rate 9600, 8 data bits, no parity, 1 stop bit
    SerialToArduino.begin(9600, SERIAL_8N1, 16, 17); // Configure UART 1
}
/**
 * @brief Initialize WiFi connection.
 * 
 * This function configures the WiFi connection settings, including SSID, password,
 * and static IP address. It initializes the WiFi module and connects to the specified network.
 */
void setupWiFiConnection() {
    // Define WiFi network settings
    const char* ssid = "YourSSID"; // Replace "YourSSID" with your WiFi SSID
    const char* password = "YourPassword"; // Replace "YourPassword" with your WiFi password
    IPAddress staticIP(192, 168, 1, 100); // Static IP address assigned to ESP32
    IPAddress gateway(192, 168, 1, 1);    // Network gateway
    IPAddress subnet(255, 255, 255, 0);   // Subnet mask of the network

    // Configure WiFi network settings
    WiFi.config(staticIP, gateway, subnet);
    WiFi.begin(ssid, password);

    // Wait for WiFi connection
    while (WiFi.status() != WL_CONNECTED) {
        Serial.println("Connecting to WiFi...");
        delay(1000);
    }
    Serial.println("WiFi connected!");
}
/**
 * @brief Begin server.
 * 
 * This function starts the server on port 80, allowing it to listen for incoming client connections.
 * It enables the ESP32 to act as a server, ready to receive and process client requests.
 */
void beginServer() {
    // Start the server on port 80
    server.begin();
    Serial.println("Server started.");
}

/**
 * @brief Send data to WinForms application via TCP connection.
 * 
 * @param data The data string to send.
 */
void sendToWinForms(String data) {
    // Connect to the WinForms application via TCP connection
    WiFiClient client;
    if (client.connect("winforms_ip_address", 8080)) { // Replace "winforms_ip_address" with the IP address of the WinForms application
        client.print(data);
        client.flush();
        client.stop();
    }
}

/**
 * @brief Extract IP address from the input data string.
 * 
 * @param inputString The input data string.
 * @return The extracted IP address.
 */
String extractIPAddress(String inputString) {
    int index = inputString.indexOf(':'); // Find the position of ':' in the string
    if (index != -1) {
        return inputString.substring(index + 1); // Return the part after ':'
    } else {
        return ""; // Return an empty string if ':' is not found
    }
}

/**
 * @brief Check if a string starts with "IP:".
 * 
 * @param str The string to check.
 * @return True if the string starts with "IP:", otherwise False.
 */
bool startsWithIP(String str) {
    // Check if the string has at least 3 characters
    if (str.length() < 3) {
        return false;
    }
    // Check if the first 3 characters are "IP:"
    return (str.substring(0, 3) == "IP:");
}



void setup() {
    /**
     * @brief Initialize WiFi connection, serial communication, and server.
     */
    setupWiFiConnection();
    setupSerialCommunication();
    server.begin();
}


void loop() {
    // Check for client connection
    WiFiClient client = server.available();
    if (client) {
        while (client.connected()) {
            if (client.available()) {
                // Read data from client
                String data = client.readString();
                // Check if the string starts with "IP:"
                if (startsWithIP(data)) {
                    // Extract IP address from the string
                    WinformIP = extractIPAddress(data);
                } 
                // Send data to Arduino
                SerialToArduino.println(data);
            }
        }
    }

    // Read data from Arduino's serial port and send it to the WinForms application
    if (SerialToArduino.available()) {
        String receivedData = SerialToArduino.readStringUntil('\r');
        // Send data to the WinForms application
        sendToWinForms(receivedData);
    }
}
