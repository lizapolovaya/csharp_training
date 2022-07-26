using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            if (app.Contacts.HasContact())
            {

            }
            else
            {
                ContactData contact = new ContactData("liza", "polovaya");

                app.Contacts.Create(contact);
            }

            app.Contacts.Remove();

            app.Auth.Logout();
        }
    }
}
