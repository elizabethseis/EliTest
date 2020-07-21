using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliTest
{
    class CartPageObject
    {
        public CartPageObject()
        {
            PageFactory.InitElements(Program.driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//button[@id='buttonPanel_AddToCartButton']")]                                                   
        public IWebElement CartBtn { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@class='c-glyph glyph-cancel']")]
        public IWebElement CancelBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='ProductPrice_productPrice_PriceContainer']//span[contains(text(),'$799.00')]")]
        public IWebElement CartPrice { get; set; }

    }
}
