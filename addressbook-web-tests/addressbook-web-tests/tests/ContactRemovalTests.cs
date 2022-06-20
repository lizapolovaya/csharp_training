using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactRemovalTests : TestBase
    {
        [Test]
        public void GontactRemovalTest()
        {
            app.Contacts.Remove(5);

            app.Auth.Logout();
        }
    }
}
