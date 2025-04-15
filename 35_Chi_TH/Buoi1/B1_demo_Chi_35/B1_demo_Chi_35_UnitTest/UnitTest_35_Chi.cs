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

    }
}
