using System;
using B1_Demo_Chi_35;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace B1_demo_Chi_35_UnitTest
{
    [TestClass]
    public class UnitTest_35_Chi
    {
        public Class1_demo_Chi_35 c_35_Chi;
        public TestContext TestContext { get; set; }
        [TestInitialize] // thiet lap du lieu dung chung cho TC
        public void SetUp_35_Chi()
        {
            c_35_Chi = new Class1_demo_Chi_35(8, 4);
        }
        //8TC, 4 TC pass, 4 TC fail
        [TestMethod] //TC1: a =8, b = 4, kq= 12 Pass
        public void TC1_Cong_35_Chi()
        {
            int expected_35_Chi, actual_35_Chi;
            expected_35_Chi = 12;
            actual_35_Chi = c_35_Chi.Execute_35_Chi("+");
            Assert.AreEqual(expected_35_Chi, actual_35_Chi);
        }

        [TestMethod] //TC2: a =8, b = 4, kq= 12 Fail
        public void TC2_Cong_35_Chi()
        {
            int expected_35_Chi, actual_35_Chi;
            expected_35_Chi = 13;
            actual_35_Chi = c_35_Chi.Execute_35_Chi("+");
            Assert.AreEqual(expected_35_Chi, actual_35_Chi);
        }

        [TestMethod] //TC3: a =8, b = 4, kq= 4 Pass
        public void TC3_Tru_35_Chi()
        {
            int expected_35_Chi, actual_35_Chi;
            expected_35_Chi = 4;
            actual_35_Chi = c_35_Chi.Execute_35_Chi("-");
            Assert.AreEqual(expected_35_Chi, actual_35_Chi);
        }

        [TestMethod] //TC4: a =8, b = 4, kq= 4 Fail
        public void TC4_Tru_35_Chi()
        {
            int expected_35_Chi, actual_35_Chi;
            expected_35_Chi = 5;
            actual_35_Chi = c_35_Chi.Execute_35_Chi("-");
            Assert.AreEqual(expected_35_Chi, actual_35_Chi);
        }

        [TestMethod] //TC5: a =8, b = 4, kq= 32 Pass
        public void TC5_Nhan_35_Chi()
        {
            int expected_35_Chi, actual_35_Chi;
            expected_35_Chi = 32;
            actual_35_Chi = c_35_Chi.Execute_35_Chi("*");
            Assert.AreEqual(expected_35_Chi, actual_35_Chi);
        }

        [TestMethod] //TC6: a =8, b = 4, kq= 32 Fail
        public void TC6_Nhan_35_Chi()
        {
            int expected_35_Chi, actual_35_Chi;
            expected_35_Chi = 33;
            actual_35_Chi = c_35_Chi.Execute_35_Chi("*");
            Assert.AreEqual(expected_35_Chi, actual_35_Chi);
        }

        [TestMethod] //TC7: a =8, b = 4, kq= 2 Pass
        public void TC7_Chia_35_Chi()
        {
            int expected_35_Chi, actual_35_Chi;
            expected_35_Chi = 2;
            actual_35_Chi = c_35_Chi.Execute_35_Chi("/");
            Assert.AreEqual(expected_35_Chi, actual_35_Chi);
        }

        [TestMethod] //TC8: a =8, b = 4, kq= 2 Fail
        public void TC8_Chia_35_Chi()
        {
            int expected_35_Chi, actual_35_Chi;
            expected_35_Chi = 3;
            actual_35_Chi = c_35_Chi.Execute_35_Chi("/");
            Assert.AreEqual(expected_35_Chi, actual_35_Chi);
        }

        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero_35_Chi()
        {
            c_35_Chi = new Class1_demo_Chi_35(10, 0);
            c_35_Chi.Execute_35_Chi("/");
        }

        //Doc file csv 3 dong, 2TC Pass 2TC Fail
        [TestMethod]
        //TC1: Line 2: a= 3, b= 3, expected =6, PASS
        //TC2: Line 3: a= 3, b= 7, expected =9, FAIL
        //TC3: Line 4: a= 3, b= 9, expected =12, PASS
        //TC4: Line 5: a= 2, b= 4, expected =7, FAIL
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\35_Chi_Data\35_Chi_TestData.csv", "35_Chi_TestData#csv",
            DataAccessMethod.Sequential)]
        public void TestWithDataSource_Chi_35()
        {
            int a_Chi_35, b_Chi_35, expected_Chi_35, actual_Chi_35;
            a_Chi_35 = int.Parse(TestContext.DataRow[0].ToString());
            b_Chi_35 = int.Parse(TestContext.DataRow[1].ToString());
            expected_Chi_35 = int.Parse(TestContext.DataRow[2].ToString());
            Class1_demo_Chi_35 c = new Class1_demo_Chi_35(a_Chi_35, b_Chi_35);
            actual_Chi_35 = c.Execute_35_Chi("+");
            Assert.AreEqual(expected_Chi_35, actual_Chi_35);
        }

        //Doc file csv 4 dong, 8TC Pass, 8TC Fail
        [TestMethod]
        //TC1: Line 2: a= 3, b= 5, operator =+ , expected =8, PASS
        //TC2: Line 3: a= -3, b= -5, operator =- , expected =2, PASS
        //TC3: Line 4: a= -3, b= 3, operator =* , expected =-9, PASS
        //TC4: Line 5: a= -12, b= 4, operator =/ , expected =-3, PASS
        //TC5: Line 6: a= 4, b= 6, operator =+ , expected =10, PASS
        //TC6: Line 7: a= -3, b= -4, operator =- , expected =1, PASS
        //TC7: Line 8: a= 3, b= 3, operator =* , expected =9, PASS
        //TC8: Line 9: a= 8, b= 4, operator =/ , expected =2, PASS
        //TC9: Line 10: a= 3, b= 5, operator =+ , expected =1, FAIL
        //TC10: Line 11: a= -3, b= -5, operator =- , expected =-2, FAIL
        //TC11: Line 12: a= -3, b= 3, operator =* , expected =3, FAIL
        //TC12: Line 13: a= -12, b= 4, operator =/ , expected =4, FAIL
        //TC13: Line 14: a= 4, b= 6, operator =+ , expected =5, FAIL
        //TC14: Line 15: a= -3, b= -4, operator =- , expected =6, FAIL
        //TC15: Line 16: a= 3, b= 3, operator =* , expected =7, FAIL
        //TC16: Line 17: a= 8, b= 4, operator =/ , expected =8, FAIL
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\35_Chi_Data\35_Chi_TestData_cotToanTu.csv", "35_Chi_TestData_cotToanTu#csv",
            DataAccessMethod.Sequential)]
        public void TestWithDataSource_Chi_35_cotToanTu()
        {
            int a_Chi_35, b_Chi_35, expected_Chi_35, actual_Chi_35;
            string operation_Chi_35;
            a_Chi_35 = int.Parse(TestContext.DataRow[0].ToString());
            b_Chi_35 = int.Parse(TestContext.DataRow[1].ToString());
            operation_Chi_35 = (TestContext.DataRow[2].ToString());
            operation_Chi_35 = operation_Chi_35.Remove(0, 1);
            expected_Chi_35 = int.Parse(TestContext.DataRow[3].ToString());
            Class1_demo_Chi_35 c = new Class1_demo_Chi_35(a_Chi_35, b_Chi_35);
            actual_Chi_35 = c.Execute_35_Chi(operation_Chi_35);
            Assert.AreEqual(expected_Chi_35, actual_Chi_35);
        }

    }
}
