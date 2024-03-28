#include <gtest/gtest.h> // Include the Google Test framework
#include "main.cpp" // Include the source file to be tested

// Test the extractIPAddress function
TEST(ExtractIPAddressTest, BasicTest) {
    // Test with a sample input string
    String inputString = "Some data IP:192.168.1.100";
    String expectedIP = "192.168.1.100";
    EXPECT_EQ(extractIPAddress(inputString), expectedIP);
}

// Test the startsWithIP function
TEST(StartsWithIPTest, BasicTest) {
    // Test with strings starting with "IP:"
    EXPECT_TRUE(startsWithIP("IP:192.168.1.100"));
    // Test with strings not starting with "IP:"
    EXPECT_FALSE(startsWithIP("Some other data"));
}

// Add more tests for other functions as needed

// Entry point for running the tests
int main(int argc, char **argv) {
    ::testing::InitGoogleTest(&argc, argv);
    return RUN_ALL_TESTS();
}
