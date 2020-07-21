using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliTest
{
    class ProductPageObject
    {
        public ProductPageObject()
        {
            PageFactory.InitElements(Program.driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//div[@id='coreui-productplacement-30l7ywa_0']")]
        public IWebElement LinkProduct1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='ProductPrice_productPrice_PriceContainer']")]
        public IWebElement PriceDetails { get; set; }
    }
}
