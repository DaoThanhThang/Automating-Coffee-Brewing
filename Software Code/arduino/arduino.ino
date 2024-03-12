checkSensorMilk(int ml);
checkSensorWater(int ml);
checkSensorCafe(int ml);
checkSensorSugar(int ml);
String fomular(String recipe);
//_recipe + "," + _numberOfService + "," + _sugar + "," + _milk + "," + _strengthOfCoffee
String data="";
String recipeName="";
String numberOfService="";
String sugar="";
String milk="";
String strengthOfCoffee="";

void getString(){
  // Tách chuỗi
  int lastIndex = -1; // Vị trí cuối cùng của dấu phẩy
  int index; // Vị trí của dấu phẩy
  int partIndex = 0; // Chỉ số của phần đã tách
  do {
    index = data.indexOf(",", lastIndex + 1); // Tìm vị trí của dấu phẩy kế tiếp
    if (index != -1) { // Nếu tìm thấy dấu phẩy
      // Gán phần đã tách vào biến tương ứng
      assignPart(partIndex++, data.substring(lastIndex + 1, index));
      lastIndex = index; // Cập nhật vị trí cuối cùng của dấu phẩy
    }
  } while (index != -1); // Lặp lại cho đến khi không còn dấu phẩy nữa
  
  // Gán phần còn lại của chuỗi sau dấu phẩy cuối cùng vào biến cuối cùng
  assignPart(partIndex, data.substring(lastIndex + 1));
}
void assignPart(int partIndex, String part) {
  switch (partIndex) {
    case 0:
      recipeName = part;
      break;
    case 1:
      numberOfService = part;
      break;
    case 2:
      sugar = part;
      break;
    case 3:
      milk = part;
      break;
    case 4:
      strengthOfCoffee = part;
      break;
    default:
      break;
  }
}
void setup() {
  Serial.begin(9600);

}

void loop() {
  if (Serial.available()) {
    data = Serial.readStringUntil('\r');
  }
  

}
