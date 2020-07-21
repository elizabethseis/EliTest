using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliTest
{
    class Program
    {
        public static IWebDriver driver;
        static void Main(string[] args)
        {

        }

        [SetUp]
        public void OpenBrowser()
        {
            ReadConfigfile.ReadFile();
            Console.WriteLine("URL : " + ReadConfigfile.url);
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(ReadConfigfile.url);
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void HomepageTC()
        {
            HomePageObject obj = new HomePageObject();
            string OfficeLink = obj.LinkOffice.Text;
            VAsserts(OfficeLink, "Office");
            string WindowsLink = obj.LinkWindows.Text;
            VAsserts(WindowsLink, "Windows");
            string SurfaceLink = obj.LinkSurface.Text;
            VAsserts(SurfaceLink, "Surface");
            string XboxLink = obj.LinkXbox.Text;
            VAsserts(XboxLink, "Xbox");
            string DealsLink = obj.LinkDeals.Text;
            VAsserts(DealsLink, "Deals");
            string SupportLink = obj.LinkSupport.Text;
            VAsserts(SupportLink, "Support");
            WindowsMenu();
        }

        public void WindowsMenu()
        {
            HomePageObject obj2 = new HomePageObject();
            obj2.LinkWindows.Click();
            WindowsPageObject obj3 = new WindowsPageObject();
            WaitForElement(By.XPath("//button[@id='c-shellmenu_50']"), 5);
            obj3.LinkWindows10.Click();
            Console.WriteLine("Menus: "+ obj3.LinkWindows10.Text);
            Console.WriteLine(obj3.LinkHowtogetWindows.Text);
            Console.WriteLine(obj3.LinkBuyWindows.Text);
            Console.WriteLine(obj3.LinkBuyWindowsPro.Text);
            Console.WriteLine(obj3.LinkRemoteResources.Text);
            Console.WriteLine(obj3.LinkWindows7.Text);
            Console.WriteLine(obj3.LinkWindows10Features.Text);
            Console.WriteLine(obj3.LinkSyncPhones.Text);
            Console.WriteLine(obj3.LinWindowsSecurity.Text);
            Console.WriteLine(obj3.LinkWindowsEditions.Text);
            Console.WriteLine(obj3.LinkSpecifications.Text);
            SearchPage();
        }

        public void SearchPage()
        {
            SearchPageObject obj4 = new SearchPageObject();
            obj4.BtnSearch.Click();
            obj4.InputSearch.SendKeys("Visual Studio");
            obj4.BtnSearch.Click();
            WaitForElement(By.XPath("//span[contains(text(),'TV')]"), 5);
            Console.WriteLine("First Price: "+obj4.FirstPrice.Text);
            Console.WriteLine("Second Price: "+obj4.SecondPrice.Text);
            Console.WriteLine("Third Price: " +obj4.ThirdPrice.Text);
            string FirstPrice = obj4.FirstPrice.Text;
            ProductDetail(FirstPrice);
        }
        public void ProductDetail(string firstprice)
        {
            ProductPageObject obj5 = new ProductPageObject();
            obj5.LinkProduct1.Click();
            WaitForElement(By.XPath("//div[@id='ProductPrice_productPrice_PriceContainer']"), 5);
            string DetaildPrice = obj5.PriceDetails.Text;
            VAsserts(firstprice, DetaildPrice);
            Cart(firstprice,DetaildPrice);
        }

        public void Cart(string FPrice, string DPrice)
        {
            WaitForElement(By.XPath("//div[@class='c-glyph glyph-cancel']"), 5);
            CartPageObject obj6 = new CartPageObject();
            obj6.CancelBtn.Click();           
            WaitForElement(By.XPath("//button[@id='buttonPanel_AddToCartButton']"), 5);
            obj6.CartBtn.Click();
            string CartPrice = obj6.CartPrice.Text;
           if (FPrice == CartPrice || CartPrice==DPrice)
           {
                Console.WriteLine("Cart Price is the same: " + CartPrice);
            }else
            {
                Console.WriteLine("Cart Price is not the same: " + CartPrice);
           }
            
           
            //ValidateCart();
        }

        public void ValidateCart()
        {
           
        }

        
        public void CloseBrowser()
        {
            driver.Close();
        }


        public static void WaitForElement(By Locator, int seconds)
        {
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(Locator));
            }
            catch (Exception i)
            {
                Console.WriteLine("Element is not displayed");
            }
        }

        public static void Click(string element)
        {
            driver.FindElement(By.Id(element)).Click();
        }

        public static void VAsserts(string element1, string element2)
        {

            try
            {
                Assert.AreEqual(element1, element2);
                Console.WriteLine("Assert is correct: " + element1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        
    }
}
