using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {

        [Test]
        public void ContactCreationTest()
        {
            app.Contacts
                .InitContactCreation()
                .FillInContactForm(new ContactData("liza", "polovaya"))
                .SubmitContactCreation()
                .ReturnToHomePage();
            app.Auth.Logout();

        }
    }
}

