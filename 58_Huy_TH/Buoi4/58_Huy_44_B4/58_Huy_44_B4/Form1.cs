using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
namespace _58_Huy_44_B4
{
    public partial class Form1_58_Huy : Form
    {
        public Form1_58_Huy()
        {
            InitializeComponent();
        }

        private void btn1_58_Huy_44_Click(object sender, EventArgs e)
        {
            IWebDriver driver_58_Huy = new ChromeDriver();
            driver_58_Huy.Url = "https://en.wikipedia.org/wiki/I_Want_to_Love_You";
            driver_58_Huy.Navigate();

            /*bai2 _58_Huy:  IWebElement element_58_Huy = driver_58_Huy.FindElement(By.TagName("h2"));
             Console.WriteLine(element_58_Huy.Text);
             */

            //Bai2_58_Huy: IWebElement element_58_Huy = driver_58_Huy.FindElement(By.TagName("h2"));
            IReadOnlyCollection<IWebElement> ee_58_Huy = driver_58_Huy.FindElements(By.TagName("h2"));
            foreach (var element in ee_58_Huy)
            {
                Console.WriteLine(element.Text);
            }

            //Bai3_58_Huy: Tai tap tin
            //Vai3_58_Huy Chuyen huong den trang demo
            driver_58_Huy.Navigate().GoToUrl("https://demo.guru99.com/test/upload/");
            //Bai3_58_Huy: Tao Web element upload_58_Huy dựa vào id:uploadfile_0
            IWebElement upload_58_Huy = driver_58_Huy.FindElement(By.Id("uploadfile_0"));
            upload_58_Huy.SendKeys(@"D:\dhmo.png");
            //Bai3_58_Huy: Tao Web element accept_58_Huy dựa vào id:terms
            IWebElement accept_58_Huy = driver_58_Huy.FindElement(By.Id("terms"));
            accept_58_Huy.Click();
            //Bai3_58_Huy: Tao Web element submit_58_Huy dựa vào id:submitbutton
            IWebElement submit_58_Huy = driver_58_Huy.FindElement(By.Id("submitbutton"));
            submit_58_Huy.Click();

            //Bai4_58_Huy: Selenium Alert & Popup Window Handling: How to Handle?
            //Bai4_58_Huy: Chuyen huong den trang 
            driver_58_Huy.Navigate().GoToUrl("https://www.demo.guru99.com/test/delete_customer.php");

            //Bai4_58_Huy Xoa nhan vien va nhan ok
            IWebElement deleteCus_58_Huy = driver_58_Huy.FindElement(By.Name("cusid"));
            deleteCus_58_Huy.SendKeys("53920");
            Thread.Sleep(3000);
            IWebElement sub_delete_58_Huy = driver_58_Huy.FindElement(By.Name("submit"));
            sub_delete_58_Huy.Click();
            Thread.Sleep(3000);
            driver_58_Huy.SwitchTo().Alert().Accept();
            Thread.Sleep(3000);
            driver_58_Huy.SwitchTo().Alert().Accept();
            Thread.Sleep(3000);
            //Bai4_58_Huy Xoa nhan vien va nhan Cacel
            deleteCus_58_Huy.SendKeys("53920");
            Thread.Sleep(3000);
            sub_delete_58_Huy.Click();
            Thread.Sleep(3000);
            driver_58_Huy.SwitchTo().Alert().Dismiss();
            Thread.Sleep(3000);
        }

        private void Form1_58_Huy_Load(object sender, EventArgs e)
        {

        }
    }
}
