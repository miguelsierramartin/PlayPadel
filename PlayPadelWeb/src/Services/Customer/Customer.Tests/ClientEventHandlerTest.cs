using Customer.Tests.Config;
using Customer.Domain;
using Customer.Service.EventHandlers;
using Customer.Service.EventHandlers.Commands;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;
using System.Linq;

namespace Customer.Tests
{

    [TestClass]
    public class ClientEventHandlerTest
    {
        private ILogger<ClientEventHandler> GetIlogger
        {
            get
            {
                return new Mock<ILogger<ClientEventHandler>>().Object;
            }
        }

        [TestMethod]
        public void TryToAddSameClientAsync()
        {
            var context = ApplicationDbCustomerContextInMemory.Get();

            var name = "Manolo";

            // Add client
            context.Clients.Add(new Client
            {
                Name = name
            });

            context.SaveChanges();

            var command = new ClientEventHandler(context);

            command.Handle(new ClientCreateCommand
            {
                Name = name
            }, new System.Threading.CancellationToken()).Wait(); 
       

            Assert.AreEqual(context.Clients.First(x => x.Name == name).Name, "Manolo");


        }
        

        } 
} 
