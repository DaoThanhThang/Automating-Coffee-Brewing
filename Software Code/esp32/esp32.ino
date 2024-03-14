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
  digitalWrite(0, HIGH); // xuat pin GPI0 high
  Serial.println("Connected to WiFi");
}
void loop() {
  WiFiClient client = server.available();
  if (client) {
    while (client.connected()) {
      if (client.available()) {
        String data = client.readString();
        // Gửi dữ liệu đến Arduino
        SerialToArduino.println(data + "\r");
      }
    }
  }
  // Đọc dữ liệu từ cổng serial của Arduino
  if (SerialToArduino.available()) {
    String receivedData = SerialToArduino.readStringUntil('\r');
    // Gửi dữ liệu đến ứng dụng WinForms
    sendToWinForms(receivedData);
  }
}
void sendToWinForms(String data) {
  // Kết nối tới ứng dụng WinForms thông qua kết nối TCP
  WiFiClient client;
  if (client.connect("winforms_ip_address", 8080)) { // Thay "winforms_ip_address" bằng địa chỉ IP của máy chạy ứng dụng WinForms
    client.print(data);
    client.flush();
    client.stop();
  }
}
String extractIPAddress(String inputString) {
    int index = inputString.indexOf(':'); // Tìm vị trí của dấu ':' trong chuỗi
    if (index != -1) {
        return inputString.substring(index + 1); // Trả về phần sau dấu ':'
    } else {
        return ""; // Trả về chuỗi rỗng nếu không tìm thấy dấu ':'
    }
}
