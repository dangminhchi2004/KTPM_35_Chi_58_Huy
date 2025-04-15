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
            chrome_Chi_35.HideCommandPromptWindow = true;//Đóng màn hình đen khi chaỵ trình duyệt

            //Bai1_Chi_35
            IWebDriver driver_Chi_35 = new ChromeDriver(chrome_Chi_35);
            //driver_Chi_35.Navigate().GoToUrl("https://www.google.com/");//Điều hướng đến trang Google

            ////Bai2_Chi_35
            //if (txtUrl_Chi_35.Text.ToString() != "")
            //{
            //    driver_Chi_35.Url = txtUrl_Chi_35.Text.ToString();//Điều hướng đến url trong textbox
            //    driver_Chi_35.Navigate();
            //}

            ////Bai3a_Chi_35
            //else//Nếu textbox trống, sẽ điều hướng đến url được lập trình sẵn
            //{
            //    driver_Chi_35.Navigate().GoToUrl("https://vnexpress.net");
            //}
            ////Bai3b_Chi_35
            //driver_Chi_35.Close(); //Đóng trình duyệt

            ////Bai3d_Chi_35
            //driver_Chi_35.Quit();//Đóng mọi cửa sổ liên kết

            ////Bai3e_Chi_35
            //String link_hientai_Chi_35 = driver_Chi_35.Url;//lấy url hiện tại
            //Console.WriteLine(link_hientai_Chi_35);

            ////Bai3f_Chi_35
            //String title_Chi_35 = driver_Chi_35.Title;//lấy title
            //Console.WriteLine(title_Chi_35);
            //txtUrl_Chi_35.Text = title_Chi_35;//hiển thị trong textbox

            ////Bai3g_Chi_35
            //String PageSource_35_Chi = driver_Chi_35.PageSource;//lấy pagesource
            //Console.WriteLine(PageSource_35_Chi);

            ////Bai3h_Chi_35
            //driver_Chi_35.Navigate().GoToUrl("https://www.google.com/");//vào google
            //Thread.Sleep(1000);
            //driver_Chi_35.Navigate().GoToUrl("https://ou.edu.vn/");//vào ou
            //Thread.Sleep(1000);
            //driver_Chi_35.Navigate().Back();//back google
            //Thread.Sleep(1000);
            //driver_Chi_35.Navigate().Forward();//forward ou
            //Thread.Sleep(1000);
            //driver_Chi_35.Navigate().Refresh();//refresh ou
            //Thread.Sleep(1000);

            //Bai4_Chi_35
            //driver_Chi_35.Navigate().GoToUrl("https://www.google.com/");
            //IWebElement element_Chi_35 = driver_Chi_35.FindElement(By.Name("q"));//lấy element
            //element_Chi_35.SendKeys("facebook");//gởi từ khóa cần điền

            //Bai5_Chi_35
            driver_Chi_35.Navigate().GoToUrl("https://www.facebook.com/login/?locale=vi_VN");
            IWebElement e_email_Chi_35 = driver_Chi_35.FindElement(By.Id("email"));
            e_email_Chi_35.SendKeys("aaa@gmail.com");//điền email by ID
            IWebElement e_password_Chi_35 = driver_Chi_35.FindElement(By.ClassName("_9npi"));
            e_password_Chi_35.SendKeys("Chi35");//điền mật khẩu by ClassName
            IWebElement e_login_CHi_35 = driver_Chi_35.FindElement(By.XPath("//button[text()='Đăng nhập']"));
            e_login_CHi_35.Click();//bấm nút đăng nhập by XPath

            //Bai6_Chi_35
            //Quên mật khẩu
            //Thread.Sleep(5000);
            //IWebElement e_forgotten_Chi_35 = driver_Chi_35.FindElement(By.LinkText("Forgotten password?"));
            //e_forgotten_Chi_35.Click();//bấm vào nút quên mật khẩu

            //driver_Chi_35.FindElement(By.Id("email")).SendKeys("teste mail");// by ID
            //driver_Chi_35.FindElement(By.Name("pass")).SendKeys("test_pw_byname");// by Name
            //driver_Chi_35.FindElement(By.ClassName("inputtext")).SendKeys("test email byclassname");//by ClassName
            //driver_Chi_35.FindElement(By.LinkText("Forgotten password?")).Click();//By LinkText
            //driver_Chi_35.FindElement(By.CssSelector("input[type='text']")).SendKeys("test email by cssselector");//by cssselector
            //driver_Chi_35.FindElement(By.XPath("//*[@id=\"email\"]")).SendKeys("test_by_xpath");//by Xpath
        }

    }
}
