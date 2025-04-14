using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _58_Huy_50
{
    public partial class Form1_58_Huy : Form
    {
        public Form1_58_Huy()
        {
            InitializeComponent();
        }
        //Cau 1 58_Huy
        private void button1_58_Huy_Click(object sender, EventArgs e)
        {
            //dieu huong trinh duyet 58_Huy
            IWebDriver driver_58_Huy = new ChromeDriver();
            driver_58_Huy.Navigate().GoToUrl("https://www.google.com/");
        }

        private void button2_58_Huy_Click(object sender, EventArgs e)

        {

            //3C tat man hinh den 58_Huy
            ChromeDriverService chrom_58_Huy = ChromeDriverService.CreateDefaultService();
            chrom_58_Huy.HideCommandPromptWindow = true;
            //3C dieu huong trinh duyet 58_Huy
            IWebDriver driver_58_Huy = new ChromeDriver(chrom_58_Huy);

            //cAu 2 58_Huy
            if (textBox1_58_Huy.Text.ToString() != "") //2: Neu co nhap url vao textBox 58_Huy
            {
                driver_58_Huy.Url = textBox1_58_Huy.Text.ToString();
                driver_58_Huy.Navigate();
            }

            else // 3a: Neu khong nhap vao url 58_Huy :
            {
                driver_58_Huy.Navigate().GoToUrl("http://google.com/");
            }

            //3H Thuc hien tu dong chuyen huong 58_Huy
            Thread.Sleep(3000);
            driver_58_Huy.Navigate().GoToUrl("http://ou.edu.vn/");
            Thread.Sleep(3000);
            driver_58_Huy.Navigate().Back();
            Thread.Sleep(3000);
            driver_58_Huy.Navigate().Forward();
            Thread.Sleep(3000);
            driver_58_Huy.Navigate().Refresh();

            //3E in ra console url web 58_Huy
            String link_hien_tai_58_Huy = driver_58_Huy.Url;
            Console.WriteLine(link_hien_tai_58_Huy);

            //3F lay title web 58_Huy
            textBox2_58_Huy.Text = driver_58_Huy.Title;

            //3G Lay pagesource 58_Huy
            String PageSource_58_Huy = driver_58_Huy.PageSource;
            Console.WriteLine(PageSource_58_Huy);

            //BAI 4 58_Huy
            //them keyword tim kiem vao trang google
            driver_58_Huy.Navigate().GoToUrl("http://google.com/");
            IWebElement webElement_58_Huy = driver_58_Huy.FindElement(By.Name("q"));
            webElement_58_Huy.SendKeys(textBox3_58_Huy.Text.ToString());

            //Bai 5 58_Huy
            //Dang nhap facebook 58_Huy
                driver_58_Huy.Navigate().GoToUrl( "https://www.facebook.com/?locale=vi_VN");
                IWebElement e_email_27_Huy = driver_58_Huy.FindElement(By.Name("email"));
                e_email_27_Huy.SendKeys("aaa@gmail.com");

                IWebElement e_password_27_Huy = driver_58_Huy.FindElement(By.Name("pass"));
                e_password_27_Huy.SendKeys("123456789");

                IWebElement e_login_27_Huy = driver_58_Huy.FindElement(By.Name("login"));
                e_login_27_Huy.Click();

            //BAI 6 58_Huy
            //click vao ahref quen mat khau 58_Huy
            Thread.Sleep(3000);
            IWebElement e_FP_58_Huy = driver_58_Huy.FindElement(By.LinkText("Forgotten password?"));
            e_FP_58_Huy.Click();

            //3B Close trinh duyet 58_Huy
            Thread.Sleep(3000);
            driver_58_Huy.Close();

            //3D dong moi cua so 58_Huy
            Thread.Sleep(3000);
            driver_58_Huy.Quit();

        }


    }
}
