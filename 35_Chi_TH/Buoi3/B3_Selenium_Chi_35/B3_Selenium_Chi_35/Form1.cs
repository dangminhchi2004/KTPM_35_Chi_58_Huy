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


namespace B3_Selenium_Chi_35
{
    public partial class Selenium_Chi_35 : Form
    {
        public Selenium_Chi_35()
        {
            InitializeComponent();
        }

        private void btn1_Chi_35_Click(object sender, EventArgs e)
        {
            //Bai3c_Chi_35
            ChromeDriverService chrome_Chi_35 = ChromeDriverService.CreateDefaultService();
            chrome_Chi_35.HideCommandPromptWindow = true;
            //Bai1_Chi_35
            IWebDriver driver_Chi_35 = new ChromeDriver(chrome_Chi_35);
            driver_Chi_35.Navigate().GoToUrl("https://www.google.com/");


            //Bai1_Cach2_Chi_35
            //driver_Chi_35.Url = "https://www.google.com/";
            //driver_Chi_35.Navigate();
            //Bai2_Chi_35
            if (txtUrl_Chi_35.Text.ToString() != "")
            {
                driver_Chi_35.Url = txtUrl_Chi_35.Text.ToString();
                driver_Chi_35.Navigate();
            }
            //Bai3a_Chi_35
            //driver_Chi_35.Navigate().GoToUrl("https://vnexpress.net");

            //Bai3b_Chi_35
            //driver_Chi_35.Close();

            //Bai3e_Chi_35
            String link_hientai_Chi_35 = driver_Chi_35.Url;
            Console.WriteLine(link_hientai_Chi_35);
            //Bai3d_Chi_35
            //driver_Chi_35.Quit();

            //Bai3f_Chi_35
            String title_Chi_35 = driver_Chi_35.Title;
            Console.WriteLine(title_Chi_35);
            txtUrl_Chi_35.Text = title_Chi_35;

            //Bai3g_Chi_35
            String PageSource_35_Chi = driver_Chi_35.PageSource;
            Console.WriteLine(PageSource_35_Chi);

            //Bai3h_Chi_35
            //driver_Chi_35.Navigate().GoToUrl("https://www.google.com/");
            //Thread.Sleep(1000);
            //driver_Chi_35.Navigate().GoToUrl("https://ou.edu.vn/");
            //Thread.Sleep(1000);
            //driver_Chi_35.Navigate().Back();
            //Thread.Sleep(1000);
            //driver_Chi_35.Navigate().Forward();
            //Thread.Sleep(1000);
            //driver_Chi_35.Navigate().Refresh();
            //driver_Chi_35.Navigate().Forward();
            //Thread.Sleep(1000);
            //driver_Chi_35.Navigate().Refresh();

            //Bai4_Chi_35
            //driver_Chi_35.Navigate().GoToUrl("https://www.google.com/");
            //IWebElement element_Chi_35 = driver_Chi_35.FindElement(By.Name("q"));
            //element_Chi_35.SendKeys("facebook");

            //Bai5_Chi_35
            driver_Chi_35.Navigate().GoToUrl("https://www.facebook.com/login/?locale=vi_VN");
            IWebElement e_email_Chi_35 = driver_Chi_35.FindElement(By.Id("email"));
            e_email_Chi_35.SendKeys("aaa@gmail.com");
            IWebElement e_password_Chi_35 = driver_Chi_35.FindElement(By.ClassName("_9npi"));
            e_password_Chi_35.SendKeys("Chi35");
            IWebElement e_login_CHi_35 = driver_Chi_35.FindElement(By.XPath("//button[text()='Đăng nhập']"));
            e_login_CHi_35.Click();

            //Bai6_Chi_35
            //Quen mat khau
            Thread.Sleep(5000);
            IWebElement e_forgotten_Chi_35 = driver_Chi_35.FindElement(By.LinkText("Forgotten password?"));
            e_forgotten_Chi_35.Click();

        }

    }
}
