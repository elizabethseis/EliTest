using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliTest
{
    public class HomePageObject
    {

        public  HomePageObject()
        {   
            PageFactory.InitElements(Program.driver,this);
        }


        [FindsBy(How = How.XPath, Using = "//a[@id='shellmenu_1']")]
        public IWebElement LinkOffice { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='shellmenu_2']")]
        public IWebElement LinkWindows { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='shellmenu_3']")]
        public IWebElement LinkSurface { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='shellmenu_4']")]
        public IWebElement LinkXbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='shellmenu_5']")]
        public IWebElement LinkDeals { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='l1_support']")]
        public IWebElement LinkSupport { get; set; }
    }
}
