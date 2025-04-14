using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Buoi1_58_Huy_50;
namespace UnitTest_Buoi1_58_Huy_50
{
    [TestClass]
    public class UnitTest_58_Huy_50
    {
        private Class_58_Huy_50 c_58_Huy_50;
        public TestContext TestContext { get; set; }
        [TestInitialize] // thiet lap du lieu dung chung cho TC
        public void Setup()
        {
            c_58_Huy_50 = new Class_58_Huy_50(20, 5);
        }



        [TestMethod] //TC1_58_Huy_50: a = 20, b = 5, kq= 25
        public void Test_Cong_58_Huy_50_True()
        {
            int expected_58_Huy_50, actual_58_Huy_50;
            expected_58_Huy_50 = 25;
            actual_58_Huy_50 = c_58_Huy_50.Excute_58_Huy("+");
            Assert.AreEqual(expected_58_Huy_50, actual_58_Huy_50);
        }

        [TestMethod] //TC2_58_Huy_50: a = 20, b = 5, kq= 25
        public void Test_Cong_58_Huy_50_Fail()
        {
            int expected_58_Huy_50, actual_58_Huy_50;
            expected_58_Huy_50 = 15;
            actual_58_Huy_50 = c_58_Huy_50.Excute_58_Huy("+");
            Assert.AreEqual(expected_58_Huy_50, actual_58_Huy_50);
        }

        [TestMethod] //TC3_58_Huy_50: a = 20, b = 5, kq= 15
        public void Test_Tru_58_Huy_50_True()
        {
            int expected_58_Huy_50, actual_58_Huy_50;
            expected_58_Huy_50 = 15;
            actual_58_Huy_50 = c_58_Huy_50.Excute_58_Huy("-");
            Assert.AreEqual(expected_58_Huy_50, actual_58_Huy_50);
        }

        [TestMethod] //TC4_58_Huy_50: a = 20, b = 5, kq= 6
        public void Test_Tru_58_Huy_50_Fail()
        {
            int expected_58_Huy_50, actual_58_Huy_50;
            expected_58_Huy_50 = 6;
            actual_58_Huy_50 = c_58_Huy_50.Excute_58_Huy("-");
            Assert.AreEqual(expected_58_Huy_50, actual_58_Huy_50);
        }

        [TestMethod] //TC5_58_Huy_50: a = 20, b = 5, kq= 100
        public void Test_Nhan_58_Huy_50_True()
        {
            int expected_58_Huy_50, actual_58_Huy_50;
            expected_58_Huy_50 = 100;
            actual_58_Huy_50 = c_58_Huy_50.Excute_58_Huy("*");
            Assert.AreEqual(expected_58_Huy_50, actual_58_Huy_50);
        }

        [TestMethod] //TC6_58_Huy_50: a = 20, b = 5, kq= 100
        public void Test_Nhan_58_Huy_50_Fail()
        {
            int expected_58_Huy_50, actual_58_Huy_50;
            expected_58_Huy_50 = 99;
            actual_58_Huy_50 = c_58_Huy_50.Excute_58_Huy("*");
            Assert.AreEqual(expected_58_Huy_50, actual_58_Huy_50);
        }

        [TestMethod] //TC7_58_Huy_50: a = 20, b = 5, kq= 4
        public void Test_Chia_58_Huy_50_True()
        {
            int expected_58_Huy_50, actual_58_Huy_50;
            expected_58_Huy_50 = 4;
            actual_58_Huy_50 = c_58_Huy_50.Excute_58_Huy("/");
            Assert.AreEqual(expected_58_Huy_50, actual_58_Huy_50);
        }

        [TestMethod] //TC8_58_Huy_50: a = 20, b = 5, kq= 4
        public void Test_Chia_58_Huy_50_Fail()
        {
            int expected_58_Huy_50, actual_58_Huy_50;
            expected_58_Huy_50 = 6;
            actual_58_Huy_50 = c_58_Huy_50.Excute_58_Huy("/");
            Assert.AreEqual(expected_58_Huy_50, actual_58_Huy_50);
        }

        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero()
        {
            c_58_Huy_50 = new Class_58_Huy_50(10, 0);
            c_58_Huy_50.Excute_58_Huy("/");
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @".\Data_58_Huy\TestData_58_Huy.csv", "TestData_58_Huy#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        /* 
        
        */
        public void TC9_TestWithDataSource_58_Huy() //2 pass 2 fail
        {
            int a_58_Huy = int.Parse(TestContext.DataRow[0].ToString());
            int b_58_Huy = int.Parse(TestContext.DataRow[1].ToString());
            int expected_58_Huy = int.Parse(TestContext.DataRow[2].ToString());

            Class_58_Huy_50 c_58_Huy = new Class_58_Huy_50(a_58_Huy, b_58_Huy);
            int actual_58_Huy = c_58_Huy.Excute_58_Huy("+");
            Assert.AreEqual(expected_58_Huy, actual_58_Huy);
        }
        /*
        TC1_58_Huy: dòng 2: a = 2, b = 5,Phương thức: "+", kết quả mong đợi = 7, kết quả thực tế = 7, kết quả testcase: PASS 
        TC2_58_Huy: dòng 3: a = -2, b = 5,Phương thức: "+", kết quả mong đợi = 3, kết quả thực tế = 3, kết quả testcase: PASS 
        TC3_58_Huy: dòng 4: a = 3, b = 5,Phương thức: "+", kết quả mong đợi = 8, kết quả thực tế = 12, kết quả testcase: FAIL 
        TC4_58_Huy: dòng 5:a = -5, b = -7,Phương thức: "+", kết quả mong đợi = -12, kết quả thực tế = -10, kết quả testcase: FAIL
        */


        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @".\Data_58_Huy\Datatest_cotToantu_58_Huy.csv", "Datatest_cotToantu_58_Huy#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithDataSource_58_Huy() //8 pass 2 fail
        {
            int a_58_Huy = int.Parse(TestContext.DataRow[0].ToString());
            int b_58_Huy = int.Parse(TestContext.DataRow[1].ToString());
            string operation_58_Huy = (TestContext.DataRow[2].ToString());
            operation_58_Huy = operation_58_Huy.Remove(0, 1);

            int expected_58_Huy = int.Parse(TestContext.DataRow[3].ToString());

            Class_58_Huy_50 c_58_Huy = new Class_58_Huy_50(a_58_Huy, b_58_Huy);
            int actual_58_Huy = c_58_Huy.Excute_58_Huy(operation_58_Huy);
            Assert.AreEqual(expected_58_Huy, actual_58_Huy);
        }
        /*
        TC1_58_Huy: dòng 2: a = 2, b = 5,Phương thức: "+", kết quả mong đợi = 7, kết quả thực tế = 7, kết quá testcase: PASS  
        TC2_58_Huy: dòng 3: a = 5, b = 3,Phương thức: "-", kết quả mong đợi = 2, kết quả thực tế = 2, kết quá testcase: PASS
        TC3_58_Huy: dòng 4: a = 5, b = 6,Phương thức: "*", kết quả mong đợi = 30, kết quả thực tế = 30, kết quá testcase: PASS5
        TC4_58_Huy: dòng 5: a = 12, b = 3,Phương thức: "/", kết quả mong đợi = 4, kết quả thực tế = 4, kết quá testcase: PASS
        TC5_58_Huy: dòng 6: a = 3, b = 7,Phương thức: "+", kết quả mong đợi = 10, kết quả thực tế = 10, kết quá testcase: PASS
        TC6_58_Huy: dòng 7: a = 6, b = 3,Phương thức: "-", kết quả mong đợi = 3, kết quả thực tế = 3, kết quá testcase: PASS
        TC7_58_Huy: dòng 8: a = 5, b = 3,Phương thức: "*", kết quả mong đợi = 15, kết quả thực tế = 15, kết quá testcase: PASS
        TC8_58_Huy: dòng 9: a = 6, b = 2,Phương thức: "/", kết quả mong đợi = 3, kết quả thực tế = 3, kết quá testcase: PASS
        TC9_58_Huy: dòng 10: a = 5, b = 6,Phương thức: "+", kết quả mong đợi = 11, kết quả thực tế = 12, kết quá testcase: FAIL
        TC2_58_Huy: dòng 11: a = 54, b = 6,Phương thức: "*", kết quả mong đợi = 24, kết quả thực tế = 21, kết quá testcase: FAIL
        */

    }
}
