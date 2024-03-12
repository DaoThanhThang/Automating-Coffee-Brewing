#include <WiFi.h>

IPAddress staticIP(192, 168, 1, 100); // Địa chỉ IP tĩnh gán cho ESP32
IPAddress gateway(192, 168, 1, 1);    // Gateway của mạng
IPAddress subnet(255, 255, 255, 0);   // Subnet mask của mạng
WiFiServer server(80);
HardwareSerial SerialToArduino(1); // Sử dụng UART 1

void setup() {
  digitalWrite(0, LOW); // xuat pin GPI0 low
  SerialToArduino.begin(9600, SERIAL_8N1, 16, 17); // Cấu hình UART 1
   // Thiết lập cấu hình mạng Wi-Fi
  WiFi.config(staticIP, gateway, subnet);
  WiFi.begin("your_network_name", "your_network_password");

  while (WiFi.status() != WL_CONNECTED) {
    delay(1000);
    Serial.println("Connecting to WiFi");
  }
  digitalWrite(0, HIGH);// xuat pin GPI0 high
  Serial.println("Connected to WiFi");
}

void loop() {
  WiFiClient client = server.available();
  if (client) {
    while (client.connected()) {
      if (client.available()) {
        String data = client.readString();
        // Gửi dữ liệu đến Arduino
        SerialToArduino.println(data+"\r");
      }
    }
  }
}