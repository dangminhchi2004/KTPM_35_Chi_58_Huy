using System;
using _35_Chi_58_Huy_ConvertDecimal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _35_Chi_58_Huy_ConVertDecimalTester
{
    [TestClass]
    public class UnitTest_35_Chi_58_Huy
    {
        private Radix_35_Chi_58_Huy radix_35_Chi_58_Huy;

        [TestInitialize]
        public void SetUp_35_Chi_58_Huy()
        {
            radix_35_Chi_58_Huy = new Radix_35_Chi_58_Huy(0);
        }

        [TestMethod] // TC1: Convert 10 to binary (radix = 2) => Expected = "1010"
        public void TC1_ConvertDecimalToBinary_35_Chi_58_Huy()
        {
            radix_35_Chi_58_Huy = new Radix_35_Chi_58_Huy(10);
            string expected_35_Chi_58_Huy = "1010";
            string actual_35_Chi_58_Huy = radix_35_Chi_58_Huy.ConvertDecimalToAnother_35_Chi_58_Huy(2);

            if (expected_35_Chi_58_Huy == actual_35_Chi_58_Huy)
                Console.WriteLine("TC1 PASSED: 10 (Decimal) => 1010 (Binary)");
            else
                Console.WriteLine($"TC1 FAILED: Expected: {expected_35_Chi_58_Huy}, Actual: {actual_35_Chi_58_Huy}");

            Assert.AreEqual(expected_35_Chi_58_Huy, actual_35_Chi_58_Huy);
        }

        [TestMethod] // TC2: Convert 255 to Hexadecimal (radix = 16) => Expected = "FF"
        public void TC2_ConvertDecimalToHex_35_Chi_58_Huy()
        {
            radix_35_Chi_58_Huy = new Radix_35_Chi_58_Huy(255);
            string expected_35_Chi_58_Huy = "FF";
            string actual_35_Chi_58_Huy = radix_35_Chi_58_Huy.ConvertDecimalToAnother_35_Chi_58_Huy(16);

            if (expected_35_Chi_58_Huy == actual_35_Chi_58_Huy)
                Console.WriteLine("TC2 PASSED: 255 (Decimal) => FF (Hexadecimal)");
            else
                Console.WriteLine($"TC2 FAILED: Expected: {expected_35_Chi_58_Huy}, Actual: {actual_35_Chi_58_Huy}");

            Assert.AreEqual(expected_35_Chi_58_Huy, actual_35_Chi_58_Huy);
        }

        [TestMethod] // TC3: Convert 100 to Octal (radix = 8) => Expected = "144"
        public void TC3_ConvertDecimalToOctal_35_Chi_58_Huy()
        {
            radix_35_Chi_58_Huy = new Radix_35_Chi_58_Huy(100);
            string expected_35_Chi_58_Huy = "144";
            string actual_35_Chi_58_Huy = radix_35_Chi_58_Huy.ConvertDecimalToAnother_35_Chi_58_Huy(8);

            if (expected_35_Chi_58_Huy == actual_35_Chi_58_Huy)
                Console.WriteLine("TC3 PASSED: 100 (Decimal) => 144 (Octal)");
            else
                Console.WriteLine($"TC3 FAILED: Expected: {expected_35_Chi_58_Huy}, Actual: {actual_35_Chi_58_Huy}");

            Assert.AreEqual(expected_35_Chi_58_Huy, actual_35_Chi_58_Huy);
        }

        [TestMethod] // TC4: Exception - Negative number input (Nhập số âm)
        [ExpectedException(typeof(ArgumentException))]
        public void TC4_InvalidNumber_35_Chi_58_Huy()
        {
            try
            {
                radix_35_Chi_58_Huy = new Radix_35_Chi_58_Huy(-5);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("TC4 PASSED: Nhập số âm => Báo lỗi đúng");
                throw;
            }
            Console.WriteLine("TC4 FAILED: Không báo lỗi khi nhập số âm");
        }

        [TestMethod] // TC5: Exception - Invalid radix input (Nhập cơ số không hợp lệ)
        [ExpectedException(typeof(ArgumentException))]
        public void TC5_InvalidRadix_35_Chi_58_Huy()
        {
            radix_35_Chi_58_Huy = new Radix_35_Chi_58_Huy(10);
            try
            {
                radix_35_Chi_58_Huy.ConvertDecimalToAnother_35_Chi_58_Huy(20);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("TC5 PASSED: Nhập cơ số > 16 => Báo lỗi đúng");
                throw;
            }
            Console.WriteLine("TC5 FAILED: Không báo lỗi khi nhập cơ số > 16");
        }

        //Doc File csv
        //TC01_35_Chi_58_Huy: Convert 10 (radix = 2) => Expected = "1010"
        //TC02_35_Chi_58_Huy: Convert 255 (radix = 16) => Expected = "FF"
        //TC03_35_Chi_58_Huy: Convert 100 (radix = 8) => Expected = "144"
        //TC04_35_Chi_58_Huy: Convert -5 (radix = 2) => Expected = "Exception"
        //TC05_35_Chi_58_Huy: Convert 10 (radix = 20) => Expected = "Exception"
        //TC06_35_Chi_58_Huy: Convert 0 (radix = 2) => Expected = "0"
        //TC07_35_Chi_58_Huy: Convert 1 (radix = 2) => Expected = "1"
        //TC08_35_Chi_58_Huy: Convert 15 (radix = 2) => Expected = "1111"
        //TC09_35_Chi_58_Huy: Convert 31 (radix = 16) => Expected = "1F"
        //TC010_35_Chi_58_Huy: Convert 64 (radix = 8) => Expected = "100"
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data_35_Chi_58_Huy\TestData_35_Chi_58_Huy.csv", "TestData_35_Chi_58_Huy#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource_35_Chi_58_Huy()
        {
            int number_35_Chi_58_Huy = int.Parse(TestContext.DataRow[0].ToString());
            int radix_35_Chi_58_Huy = int.Parse(TestContext.DataRow[1].ToString());
            string expected_35_Chi_58_Huy = TestContext.DataRow[2].ToString();

            try
            {
                Radix_35_Chi_58_Huy converter_35_Chi_58_Huy = new Radix_35_Chi_58_Huy(number_35_Chi_58_Huy);
                string actual_35_Chi_58_Huy = converter_35_Chi_58_Huy.ConvertDecimalToAnother_35_Chi_58_Huy(radix_35_Chi_58_Huy);

                TestContext.WriteLine($"Testing: number = {number_35_Chi_58_Huy}, radix = {radix_35_Chi_58_Huy}");
                TestContext.WriteLine($"Expected: {expected_35_Chi_58_Huy}, Actual: {actual_35_Chi_58_Huy}");

                Assert.AreEqual(expected_35_Chi_58_Huy, actual_35_Chi_58_Huy);
                TestContext.WriteLine("Test Passed!");
            }
            catch (Exception ex)
            {
                if (expected_35_Chi_58_Huy == "Exception")
                {
                    TestContext.WriteLine("Expected Exception occurred!");
                    Assert.IsTrue(true); // Kiểm tra đúng ngoại lệ
                }
                else
                {
                    TestContext.WriteLine($" Unexpected Exception: {ex.Message}");
                    Assert.Fail($"Exception occurred: {ex.Message}");
                }
            }
        }
    }

}
