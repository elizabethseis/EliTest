using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliTest
{
    class CartDetailsPageObject
    {
        public CartDetailsPageObject()
        {
            PageFactory.InitElements(Program.driver, this);
        }


        

    }
}
