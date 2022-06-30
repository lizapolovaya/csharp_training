using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressBookTests
{
    public class NavigationHelper : HelperBase
    {
        public string baseUrl;

        public NavigationHelper(ApplicationManager manager, string baseUrl) : base(manager)
        {
            this.baseUrl = baseUrl;
        }

        public void OpenHomePage()
        {
            if (driver.Url == baseUrl)
            {
                return;
            }
            driver.Navigate().GoToUrl(baseUrl);
        }

        public void GoToGroupsPage()
        {
            if (driver.Url == baseUrl + "/group.php" &&
                IsElementPresent(By.Name("new")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}
