using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            //prepare
            app.Auth.Logout();

            // action
            AccauntData accaunt = new AccauntData("admin", "secret");
            app.Auth.Login(accaunt);

            //verification
            Assert.IsTrue(app.Auth.IsLoggedIn(accaunt));
        }

        [Test]
        public void LoginWithInvalidCredentials()
        {
            //prepare
            app.Auth.Logout();

            // action
            AccauntData accaunt = new AccauntData("admin", "123456");
            app.Auth.Login(accaunt);

            //verification
            Assert.IsFalse(app.Auth.IsLoggedIn(accaunt));
        }

    }
}
