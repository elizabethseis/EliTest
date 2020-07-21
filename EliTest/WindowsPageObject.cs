using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliTest
{
    class WindowsPageObject
    {
        public WindowsPageObject()
        {
            PageFactory.InitElements(Program.driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//button[@id='c-shellmenu_50']")]
        public IWebElement LinkWindows10 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='c-shellmenu_51']")]
        public IWebElement LinkHowtogetWindows { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='c-shellmenu_52']")]
        public IWebElement LinkBuyWindows { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='c-shellmenu_53']")]
        public IWebElement LinkBuyWindowsPro { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='c-shellmenu_54']")]
        public IWebElement LinkRemoteResources { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='c-shellmenu_55']")]
        public IWebElement LinkWindows7 { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='c-shellmenu_56']")]
        public IWebElement LinkWindows10Features { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='c-shellmenu_57']")]
        public IWebElement LinkSyncPhones { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='c-shellmenu_58']")]
        public IWebElement LinWindowsSecurity { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='c-shellmenu_59']")]
        public IWebElement LinkWindowsEditions { get; set; }
   

        [FindsBy(How = How.XPath, Using = "//a[@id='c-shellmenu_60']")]
        public IWebElement LinkSpecifications { get; set; }












    }
}
