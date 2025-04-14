using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Buoi1_58_Huy_50;
namespace UnitTest_Buoi1_58_Huy_50
{
    [TestClass]
    public class UnitTest_58_Huy_50
    {
        private Class_58_Huy_50 c_58_Huy_50;
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
    }
}
