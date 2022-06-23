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
            ContactData newContact = new ContactData("mona", "lisa");

            app.Contacts.Modify(newContact);
        }
    }
}
