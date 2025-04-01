using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestWeb_35_Chi_58_Huy
{
    [TestClass]
    public class UnitTest_35_Chi_58_Huy
    {
        IWebDriver driver_35_Chi_58_Huy;

        public void LoginToCellPhones_35_Chi_58_Huy(string sdt, string matkhau)
        {
            // driver_35_Chi_58_Huy = new ChromeDriver();
            //driver_35_Chi_58_Huy.Navigate().GoToUrl("https://cellphones.com.vn/");
            //Thread.Sleep(1000);
            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#cpsHeader > div.cps-container.nav-container > nav > div.login-btn > div")).Click();
            Thread.Sleep(1000);
            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#modalLogin > div.modal-content.modal-login > div.group-login-btn > div.login-btn")).Click();
            Thread.Sleep(1000);

            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > div > div:nth-child(1) > div > input")).SendKeys(sdt);
            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > div > div.mt-4 > div > input ")).SendKeys(matkhau);

            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > button")).Click();

            Thread.Sleep(1000);
        }

        /****************
 *  Login Test
 ****************/
        //[TestMethod]
        public void LoginSucess_35_Chi_58_Huy()
        {
            driver_35_Chi_58_Huy = new ChromeDriver();
            driver_35_Chi_58_Huy.Navigate().GoToUrl("https://cellphones.com.vn/");
            Thread.Sleep(1000);
            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#cpsHeader > div.cps-container.nav-container > nav > div.login-btn > div")).Click();
            Thread.Sleep(1000);
            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#modalLogin > div.modal-content.modal-login > div.group-login-btn > div.login-btn")).Click();
            Thread.Sleep(1000);

            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > div > div:nth-child(1) > div > input")).SendKeys("0379038920");
            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > div > div.mt-4 > div > input ")).SendKeys("19t6n2k4Chi");

            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > button")).Click();

            Thread.Sleep(1000);

            try
            {
                driver_35_Chi_58_Huy.FindElement(By.CssSelector("#cpsHeader > div.cps-container.nav-container > nav > div.login-btn > div"));
            }
            catch (NoSuchElementException)
            {
                Assert.IsTrue(false, "Login fail");
            }
        }
        //[TestMethod]
        public void LoginFail1_35_Chi_58_Huy()
        {
            driver_35_Chi_58_Huy = new ChromeDriver();
            driver_35_Chi_58_Huy.Navigate().GoToUrl("https://cellphones.com.vn/");
            Thread.Sleep(1000);
            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#cpsHeader > div.cps-container.nav-container > nav > div.login-btn > div")).Click();
            Thread.Sleep(1000);
            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#modalLogin > div.modal-content.modal-login > div.group-login-btn > div.login-btn")).Click();
            Thread.Sleep(1000);
            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > div > div:nth-child(1) > div > input")).SendKeys("0379038920");
            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > div > div.mt-4 > div > input ")).SendKeys("MatKhau");

            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > button")).Click();

            Thread.Sleep(3000);

            try
            {
                var errorMessage = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > button"));
                Assert.IsTrue(errorMessage.Displayed, "Error message not displayed");
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Expected error message not found, test failed.");
            }
        }

        //[TestMethod]
        public void LoginFai2__35_Chi_58_Huy()
        {
            driver_35_Chi_58_Huy = new ChromeDriver();
            driver_35_Chi_58_Huy.Navigate().GoToUrl("https://cellphones.com.vn/");
            Thread.Sleep(1000);
            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#cpsHeader > div.cps-container.nav-container > nav > div.login-btn > div")).Click();
            Thread.Sleep(1000);
            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#modalLogin > div.modal-content.modal-login > div.group-login-btn > div.login-btn")).Click();
            Thread.Sleep(1000);

            // Nhập số điện thoại không tồn tại
            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > div > div:nth-child(1) > div > input")).SendKeys("0999999999");
            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > div > div.mt-4 > div > input ")).SendKeys("19t6n2k4Chi");

            driver_35_Chi_58_Huy.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > button")).Click();

            Thread.Sleep(3000);

            try
            {
                var errorMessage = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#login-form > div.cps-login-form > form > button"));
                Assert.IsTrue(errorMessage.Displayed, "Error message not displayed");
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Expected error message not found, test failed.");
            }
        }
        /****************
         *  Search Test
         ****************/
        //[TestMethod]
        public void Seach1_35_Chi_58_Huy()
        {
            string keyWord_35_Chi_58_Huy = "Iphone 11";

            driver_35_Chi_58_Huy = new ChromeDriver();
            driver_35_Chi_58_Huy.Manage().Window.Maximize();
            driver_35_Chi_58_Huy.Navigate().GoToUrl("https://cellphones.com.vn/");

            Thread.Sleep(1000);

            IWebElement seachBar_35_Chi_58_Huy = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#inp\\$earch"));
            seachBar_35_Chi_58_Huy.SendKeys(keyWord_35_Chi_58_Huy);
            seachBar_35_Chi_58_Huy.SendKeys(Keys.Enter);

            Thread.Sleep(2000);

            /*
             * Check if the error message contains "Tìm thấy 0 sản phẩm cho từ khoá".
             */
            try
            {
                IWebElement errorMessage = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#search-catalog-page > h1"));
                if (errorMessage.Text.Contains("Tìm thấy 0 sản phẩm cho từ khoá"))
                {
                    Assert.Fail(keyWord_35_Chi_58_Huy + " returned 0 results, search failed.");
                }
            }
            catch (NoSuchElementException)
            {
                // Test case passed
            }
        }
        //[TestMethod]
        public void Seach2_35_Chi_58_Huy()
        {
            string keyWord_35_Chi_58_Huy = "aaaaa12345";

            driver_35_Chi_58_Huy = new ChromeDriver();
            driver_35_Chi_58_Huy.Manage().Window.Maximize();
            driver_35_Chi_58_Huy.Navigate().GoToUrl("https://cellphones.com.vn/");

            Thread.Sleep(1000);

            IWebElement seachBar_35_Chi_58_Huy = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#inp\\$earch"));
            seachBar_35_Chi_58_Huy.SendKeys(keyWord_35_Chi_58_Huy);
            seachBar_35_Chi_58_Huy.SendKeys(Keys.Enter);

            Thread.Sleep(2000);

            /*
             * Check if the error message contains "Tìm thấy 0 sản phẩm cho từ khoá".
             */
            try
            {
                IWebElement errorMessage = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#search1-catalog-page > h1"));
                Assert.IsFalse(errorMessage.Text.Contains("Tìm thấy 0 sản phẩm cho từ khoá"),
                    keyWord_35_Chi_58_Huy + " search should return results but found none.");
            }
            catch (NoSuchElementException)
            {
                // Test case passed
            }
        }
        /****************
        *  AddProduct
        ****************/

        //[TestMethod]
        public void AddProductToCart1_35_Chi_58_Huy()
        {
            driver_35_Chi_58_Huy = new ChromeDriver();
            driver_35_Chi_58_Huy.Manage().Window.Maximize();
            driver_35_Chi_58_Huy.Navigate().GoToUrl("https://cellphones.com.vn/");
            Thread.Sleep(2000);
            LoginToCellPhones_35_Chi_58_Huy("0379038920", "19t6n2k4Chi");//Hàm đăng nhập

            // Tìm kiếm sản phẩm
            IWebElement searchBar = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#inp\\$earch"));
            searchBar.SendKeys("iPhone 15");
            searchBar.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

            // Chọn sản phẩm đầu tiên trong danh sách kết quả
            IWebElement firstProduct = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#productListSearch > div.product-list-filter.is-flex.is-flex-wrap-wrap > div:nth-child(1) > div.product-info > a > div.product__name > h3"));
            firstProduct.Click();
            Thread.Sleep(2000);

            // Nhấn nút thêm vào giỏ hàng
            IWebElement addToCartButton = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#productDetailV2 > section > div.box-detail-product.columns.m-0 > div.box-detail-product__box-center.column > div:nth-child(6) > div > div:nth-child(1) > button.btn-cta.button.button--small.add-to-cart-button"));
            ((IJavaScriptExecutor)driver_35_Chi_58_Huy).ExecuteScript("arguments[0].scrollIntoView(true);", addToCartButton);
            Thread.Sleep(500);

            // Click vào nút
            addToCartButton.Click();
            Thread.Sleep(4000);

            // Kiểm tra sản phẩm đã được thêm vào giỏ hàng
            IWebElement cartIcon = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#cpsHeader > div.cps-container.nav-container > nav > a.header-item.about-cart.button__link-to-cart"));
            cartIcon.Click();
            Thread.Sleep(2000);

            try
            {
                IWebElement cartItem = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#listItemSuperCart > div.block__product-item__outer > div.block__product-item"));
                Assert.IsTrue(cartItem.Displayed, "Sản phẩm không hiển thị trong giỏ hàng");
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Không tìm thấy sản phẩm trong giỏ hàng");
            }

            driver_35_Chi_58_Huy.Quit();
        }

        //[TestMethod]
        public void AddProductToCart2_35_Chi_58_Huy()
        {
            driver_35_Chi_58_Huy = new ChromeDriver();
            driver_35_Chi_58_Huy.Manage().Window.Maximize();
            driver_35_Chi_58_Huy.Navigate().GoToUrl("https://cellphones.com.vn/");
            Thread.Sleep(2000);
            LoginToCellPhones_35_Chi_58_Huy("0379038920", "19t6n2k4Chi");

            // Tìm kiếm sản phẩm không tồn tại
            IWebElement searchBar = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#inp\\$earch"));
            searchBar.SendKeys("asdfghj123456");
            searchBar.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

            bool productFound = true;

            try
            {
                // Cố gắng tìm sản phẩm đầu tiên trong danh sách kết quả
                IWebElement firstProduct = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#productListSearch > div.product-list-filter.is-flex.is-flex-wrap-wrap > div:nth-child(1) > div.product-info > a > div.product__name > h3"));
                firstProduct.Click();
                Thread.Sleep(2000);

                // Nhấn nút thêm vào giỏ hàng
                IWebElement addToCartButton = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#productDetailV2 > section > div.box-detail-product.columns.m-0 > div.box-detail-product__box-center.column > div:nth-child(6) > div > div:nth-child(1) > button.btn-cta.button.button--small.add-to-cart-button"));
                addToCartButton.Click();
                Thread.Sleep(4000);
            }
            catch (NoSuchElementException)
            {
                productFound = false;
            }

            // Mở giỏ hàng
            IWebElement cartIcon = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#cpsHeader > div.cps-container.nav-container > nav > a.header-item.about-cart.button__link-to-cart"));
            cartIcon.Click();
            Thread.Sleep(2000);

            if (!productFound)
            {
                // Nếu không tìm thấy sản phẩm, kiểm tra xem giỏ hàng có trống không
                try
                {
                    IWebElement errorMessage = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#indexSuperCart > div.container.block-info.mt-3 > div > span"));
                    Assert.IsTrue(errorMessage.Text.Contains("Giỏ hàng của bạn đang trống"), "Giỏ hàng đáng lẽ phải trống nhưng không trống.");
                    Console.WriteLine("Test passed: Không tìm thấy sản phẩm, giỏ hàng trống.");

                }
                catch (NoSuchElementException)
                {
                    Assert.Fail("Không tìm thấy thông báo giỏ hàng trống.");
                    Console.WriteLine("Không tìm thấy thông báo giỏ hàng trống.");
                }
            }
            driver_35_Chi_58_Huy.Quit();
        }

        //[TestMethod]
        public void RemoveProductFromCart1_35_Chi_58_Huy()
        {
            driver_35_Chi_58_Huy = new ChromeDriver();
            driver_35_Chi_58_Huy.Manage().Window.Maximize();
            driver_35_Chi_58_Huy.Navigate().GoToUrl("https://cellphones.com.vn/");
            Thread.Sleep(2000);

            // Đăng nhập vào hệ thống
            LoginToCellPhones_35_Chi_58_Huy("0379038920", "19t6n2k4Chi");

            // Tìm kiếm sản phẩm và thêm vào giỏ hàng
            IWebElement searchBar = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#inp\\$earch"));
            searchBar.SendKeys("iPhone 15");
            searchBar.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

            IWebElement firstProduct = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#productListSearch > div.product-list-filter.is-flex.is-flex-wrap-wrap > div:nth-child(1) > div.product-info > a > div.product__name > h3"));
            firstProduct.Click();
            Thread.Sleep(2000);

            IWebElement addToCartButton = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#productDetailV2 > section > div.box-detail-product.columns.m-0 > div.box-detail-product__box-center.column > div:nth-child(6) > div > div:nth-child(1) > button.btn-cta.button.button--small.add-to-cart-button"));
            //((IJavaScriptExecutor)driver_35_Chi_58_Huy).ExecuteScript("arguments[0].scrollIntoView(true);", addToCartButton);
            Thread.Sleep(500);
            addToCartButton.Click();
            Thread.Sleep(4000);

            // Mở giỏ hàng
            IWebElement cartIcon = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#cpsHeader > div.cps-container.nav-container > nav > a.header-item.about-cart.button__link-to-cart"));
            cartIcon.Click();
            Thread.Sleep(2000);

            try
            {
                // Kiểm tra sản phẩm đã thêm vào giỏ hàng
                IWebElement cartItem = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#listItemSuperCart > div.block__product-item__outer > div.block__product-item"));
                Assert.IsTrue(cartItem.Displayed, "Không tìm thấy sản phẩm trong giỏ hàng");

                // Nhấn nút xóa sản phẩm khỏi giỏ hàng
                IWebElement removeButton = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#listItemSuperCart > div.block__product-item__outer > div.block__product-item > div.product-info > div.d-flex.justify-content-between.align-items-start > button > svg"));
                removeButton.Click();
                Thread.Sleep(3000);

                // Kiểm tra xem giỏ hàng có trống không
                try
                {
                    IWebElement emptyCartMessage = driver_35_Chi_58_Huy.FindElement(By.CssSelector("#indexSuperCart > div.container.block-info.mt-3 > div > span"));
                    Assert.IsTrue(emptyCartMessage.Text.Contains("Giỏ hàng của bạn đang trống"), "Giỏ hàng không trống sau khi xóa sản phẩm.");
                    Console.WriteLine("Test passed: Sản phẩm đã bị xóa và giỏ hàng trống.");
                }
                catch (NoSuchElementException)
                {
                    Assert.Fail("Test failed: Giỏ hàng vẫn có sản phẩm sau khi xóa.");
                }
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("Test failed: Không tìm thấy sản phẩm trong giỏ hàng để xóa.");
            }

            driver_35_Chi_58_Huy.Quit();
        }



    }
}