using Identity.Service.EventHandlers;
using Identity.Service.EventHandlers.Commands;
using Identity.Tests.Config;
using Identity.Domain;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Identity.Tests
{
    [TestClass]
    public class UserCreateEventHandlerTest
    {

        private ILogger<UserCreateEventHandler> GetIlogger
        {
            get
            {
                return new Mock<ILogger<UserCreateEventHandler>>().Object;
            }
        }

        [TestMethod]
        public async Task CreateUser()
        {
            var context = ApplicationDbIdentityContextInMemory.Get();
           // var user = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            var firstName = "Roberto";
            var lastName = "de Madrid";
            var email = "roberdm@gmail.com";
            var password = "abc1357";

            // Add user
            context.Users.Add(new ApplicationUser
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                UserName = email
            });

            context.SaveChanges();



            var command = new UserCreateEventHandler(context);

            await command.Handle(new UserCreateCommand
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password

            }, new System.Threading.CancellationToken());

            Assert.AreEqual(context.Users.First(x => x.FirstName == firstName).FirstName, "Roberto");
            Assert.AreEqual(context.Users.First(x => x.LastName == lastName).LastName, "de Madrid");
            Assert.AreEqual(context.Users.First(x => x.Email == email).Email, "roberdm@gmail.com");
        }
    }
}
