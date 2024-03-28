#include <Arduino.h>
#include <unity.h>
#include "CoffeeMachine.h"
#include "CoffeeMachine.cpp"
#include "Sensor.h"


/**
 * @brief Test for assignPart function
 */
void test_assignPart() {
    String data = "Espresso,1,50,50,100";
    assignPart(0, data);
    TEST_ASSERT_EQUAL_STRING("Espresso", recipeName.c_str());
    TEST_ASSERT_EQUAL(1, numberOfService);
    TEST_ASSERT_EQUAL(50, sugar);
    TEST_ASSERT_EQUAL(50, milk);
    TEST_ASSERT_EQUAL(100, strengthOfCoffee);
}

/**
 * @brief Test for CoffeeRecipeSelect function
 */
void test_CoffeeRecipeSelect() {
    CoffeeRecipeSelect("Espresso");
    TEST_ASSERT_EQUAL(espresso.water, recipe.water);
    TEST_ASSERT_EQUAL(espresso.milk, recipe.milk);
    TEST_ASSERT_EQUAL(espresso.sugar, recipe.sugar);
    TEST_ASSERT_EQUAL(espresso.coffee, recipe.coffee);
}

/**
 * @brief Test for makeCoffee function
 */
void test_makeCoffee() {
    // Test for one service of Espresso
    makeCoffee(espresso, 1, 50, 50, 100);
    TEST_ASSERT_EQUAL(RELAY_WATER, HIGH); // Assuming RELAY_WATER is the correct pin
    // Add more assertions based on the expected behavior of makeCoffee()
}

/**
 * @brief Test for controlRelay function
 */
void test_controlRelay() {
    // Test controlRelay() for turning on and off relay pin
    digitalWrite(RELAY_WATER, LOW);
    controlRelay(RELAY_WATER, 100);
    TEST_ASSERT_EQUAL(RELAY_WATER, HIGH);
    // Add more assertions based on the expected behavior of controlRelay()
}

/**
 * @brief Test for connectionCheck function
 */
void test_connection_check() {
    Serial.begin(9600); // Bắt đầu serial communication để kích hoạt connection
    delay(100); // Đợi serial communication được khởi động
    TEST_ASSERT_TRUE(connectionCheck()); // Đảm bảo kết nối Serial là hoạt động
}

/**
 * @brief Setup function for Unity test framework
 */
void setup() {
    delay(2000);
    UNITY_BEGIN();
    RUN_TEST(test_connection_check);
    RUN_TEST(test_assignPart);
    RUN_TEST(test_CoffeeRecipeSelect);
    RUN_TEST(test_makeCoffee);
    RUN_TEST(test_controlRelay);
    UNITY_END();
}

/**
 * @brief Loop function for Unity test framework
 */
void loop() {}
