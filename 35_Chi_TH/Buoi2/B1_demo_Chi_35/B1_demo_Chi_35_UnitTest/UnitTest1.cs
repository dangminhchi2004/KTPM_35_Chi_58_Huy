using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using B1_demo_Chi_35;

namespace B1_demo_Chi_35_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public Class1_demo_Chi_35 c_Chi_35;
        public TestContext TestContext { get; set; }
        [TestInitialize] // thiet lap du lieu dung chung cho TC
        public void SetUp()
        {
            c_Chi_35 = new Class1_demo_Chi_35(8, 4);
        }
        [TestMethod] //TC1: a =8, b = 4, kq= 12
        public void Test_Cong1_Chi_35()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 12;
            actual = c_Chi_35.Execute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //TC2: a =8, b = 4, kq= 13
        public void Test_Cong2_Chi_35()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 13;
            actual = c_Chi_35.Execute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //TC3: a =8, b = 4, kq= 4
        public void Test_Tru1_Chi_35()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 4;
            actual = c_Chi_35.Execute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //TC4: a =8, b = 4, kq= 5
        public void Test_Tru2_Chi_35()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 5;
            actual = c_Chi_35.Execute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //TC5: a =8, b = 4, kq= 32
        public void Test_Nhan1_Chi_35()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 32;
            actual = c_Chi_35.Execute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //TC6: a =8, b = 4, kq= 33
        public void Test_Nhan2_Chi_35()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 33;
            actual = c_Chi_35.Execute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Chia1_Chi_35()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 2;
            actual = c_Chi_35.Execute("/");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_Chia2_Chi_35()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 3;
            actual = c_Chi_35.Execute("/");
            Assert.AreEqual(expected, actual);
        }
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero()
        {
            c_Chi_35 = new Class1_demo_Chi_35(10, 0);
            c_Chi_35.Execute("/");
        }
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
            actual_Chi_35 = c.Execute("+");
            Assert.AreEqual(expected_Chi_35, actual_Chi_35);
        }
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
        //TC110: Line 11: a= -3, b= -5, operator =- , expected =-2, FAIL
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
            actual_Chi_35 = c.Execute(operation_Chi_35);
            Assert.AreEqual(expected_Chi_35, actual_Chi_35);
        }
    }

}
