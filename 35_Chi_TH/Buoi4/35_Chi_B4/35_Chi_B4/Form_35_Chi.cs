using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace _35_Chi_B4
{
    public partial class Form_35_Chi: Form
    {
        public Form_35_Chi()
        {
            InitializeComponent();
        }

        private void bt1_35_Chi_Click(object sender, EventArgs e)
        {
            // Bài 2
            //IWebDriver driver_35_Chi = new ChromeDriver();
            //driver_35_Chi.Navigate().GoToUrl("https://en.wikipedia.org/wiki/I_Want_to_Love_You");
            //IReadOnlyCollection<IWebElement> ee_35_Chi = driver_35_Chi.FindElements(By.TagName("h2"));
            //foreach (var element_35_Chi in ee_35_Chi)
            //{
            //    Console.WriteLine(element_35_Chi.Text);
            //}
            //Thread.Sleep(2000);

            // Bài 3: Tải tệp lên
            //driver_35_Chi.Navigate().GoToUrl("https://www.demo.guru99.com/test/upload/");
            //Thread.Sleep(2000);
            //IWebElement upload_35_Chi = driver_35_Chi.FindElement(By.Id("uploadfile_0"));

            //// Gửi đường dẫn tệp lên
            //upload_35_Chi.SendKeys(@"D:\background.jpg");

            //IWebElement submitBtn_35_Chi = driver_35_Chi.FindElement(By.Id("submitbutton"));
            //submitBtn_35_Chi.Click();
            //Thread.Sleep(3000);

            // Bài 4
            //Xóa mã nhân viên
            //driver_35_Chi.Navigate().GoToUrl("https://www.demo.guru99.com/test/delete_customer.php");
            //IWebElement cusIdInput_35_Chi = driver_35_Chi.FindElement(By.CssSelector("input[name=\"cusid\"]"));
            //cusIdInput_35_Chi.SendKeys("123");

            //IWebElement submitDeleteBtn_35_Chi = driver_35_Chi.FindElement(By.CssSelector("input[name=\"submit\"]"));
            //submitDeleteBtn_35_Chi.Click();
            //Thread.Sleep(2000);
            // accept alert
            //driver_35_Chi.SwitchTo().Alert().Accept();
            //Thread.Sleep(2000);
            //driver_35_Chi.SwitchTo().Alert().Accept();
            //Thread.Sleep(4000);

            //Nhập mã nhưng không xóa
            //cusIdInput_35_Chi = driver_35_Chi.FindElement(By.CssSelector("input[name=\"cusid\"]"));
            //cusIdInput_35_Chi.SendKeys("1234");
            //submitDeleteBtn_35_Chi = driver_35_Chi.FindElement(By.CssSelector("input[name=\"submit\"]"));
            //submitDeleteBtn_35_Chi.Click();
            //Thread.Sleep(2000);
            //driver_35_Chi.SwitchTo().Alert().Dismiss();


        }
    }
}
