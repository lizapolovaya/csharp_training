using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressBookTests
{
    [TestFixture]

    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void GontactModificationTest()
        {
            if (app.Contacts.HasContact())
            {

            }
            else
            {
                ContactData contact = new ContactData("liza", "polovaya");
                app.Contacts.Create(contact);
            }

            ContactData newContact = new ContactData("mona", "lisa");

            app.Contacts.Modify(newContact);
          
        }
    }
}
