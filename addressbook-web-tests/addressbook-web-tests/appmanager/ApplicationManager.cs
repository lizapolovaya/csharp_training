using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressBookTests
{
    public class ApplicationManager
    {
       
        protected IWebDriver driver;
        protected string baseUrl;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;

        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        private ApplicationManager()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            baseUrl = "http://localhost/addressbook";

            loginHelper = new LoginHelper(this);
            navigator = new NavigationHelper(this, baseUrl);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
        }

        ~ApplicationManager()
        {
            try
            {

                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public static ApplicationManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                newInstance.Navigation.OpenHomePage();
                app.Value = newInstance;
            }
            return app.Value;
        }

        public LoginHelper Auth
        {
            get { return loginHelper; }
        }

        public NavigationHelper Navigation
        {
            get { return navigator; }
        }

        public GroupHelper Groups
        {
            get { return groupHelper; }
        }

        public ContactHelper Contacts 
        {
            get { return contactHelper; } 
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }
    }
}
