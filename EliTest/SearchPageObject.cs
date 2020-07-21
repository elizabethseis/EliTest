using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliTest
{
    class SearchPageObject
    {
        public SearchPageObject()
        {
            PageFactory.InitElements(Program.driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//button[@id='search']")]
        public IWebElement BtnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='cli_shellHeaderSearchInput']")]
        public IWebElement InputSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'$799.00')]")]
        public IWebElement FirstPrice { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'$5,999.00')]")]
        public IWebElement SecondPrice { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'$899.00')]")]
        public IWebElement ThirdPrice { get; set; }


    }
}

