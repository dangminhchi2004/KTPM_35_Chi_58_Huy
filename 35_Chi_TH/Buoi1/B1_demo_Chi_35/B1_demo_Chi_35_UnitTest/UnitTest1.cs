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
        [TestMethod] //TC1: a =8, b = 4, kq= 12 Pass
        public void Test_Cong1_Chi_35()
        {
            int expected_35_Chi, actual_35_Chi;
            expected_35_Chi = 12;
            actual_35_Chi = c_Chi_35.Execute("+");
            Assert.AreEqual(expected_35_Chi, actual_35_Chi);
        }

        [TestMethod] //TC2: a =8, b = 4, kq= 12 Fail
        public void Test_Cong2_Chi_35()
        {
            int expected_35_Chi, actual_35_Chi;
            expected_35_Chi = 13;
            actual_35_Chi = c_Chi_35.Execute("+");
            Assert.AreEqual(expected_35_Chi, actual_35_Chi);
        }

        [TestMethod] //TC3: a =8, b = 4, kq= 4 Pass
        public void Test_Tru1_Chi_35()
        {
            int expected_35_Chi, actual_35_Chi;
            expected_35_Chi = 4;
            actual_35_Chi = c_Chi_35.Execute("-");
            Assert.AreEqual(expected_35_Chi, actual_35_Chi);
        }

        [TestMethod] //TC4: a =8, b = 4, kq= 4 Fail
        public void Test_Tru2_Chi_35()
        {
            int expected_35_Chi, actual_35_Chi;
            expected_35_Chi = 5;
            actual_35_Chi = c_Chi_35.Execute("-");
            Assert.AreEqual(expected_35_Chi, actual_35_Chi);
        }

        [TestMethod] //TC5: a =8, b = 4, kq= 32 Pass
        public void Test_Nhan1_Chi_35()
        {
            int expected_35_Chi, actual_35_Chi;
            expected_35_Chi = 32;
            actual_35_Chi = c_Chi_35.Execute("*");
            Assert.AreEqual(expected_35_Chi, actual_35_Chi);
        }

        [TestMethod] //TC6: a =8, b = 4, kq= 32 Fail
        public void Test_Nhan2_Chi_35()
        {
            int expected_35_Chi, actual_35_Chi;
            expected_35_Chi = 33;
            actual_35_Chi = c_Chi_35.Execute("*");
            Assert.AreEqual(expected_35_Chi, actual_35_Chi);
        }

        [TestMethod] //TC7: a =8, b = 4, kq= 2 Pass
        public void Test_Chia1_Chi_35()
        {
            int expected_35_Chi, actual_35_Chi;
            expected_35_Chi = 2;
            actual_35_Chi = c_Chi_35.Execute("/");
            Assert.AreEqual(expected_35_Chi, actual_35_Chi);
        }

        [TestMethod] //TC8: a =8, b = 4, kq= 2 Fail
        public void Test_Chia2_Chi_35()
        {
            int expected_35_Chi, actual_35_Chi;
            expected_35_Chi = 3;
            actual_35_Chi = c_Chi_35.Execute("/");
            Assert.AreEqual(expected_35_Chi, actual_35_Chi);
        }

        //[ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero_35_Chi()
        {
            c_Chi_35 = new Class1_demo_Chi_35(10, 0);
            c_Chi_35.Execute("/");
        }

    }
}
