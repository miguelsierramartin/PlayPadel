using Catalog.Domain;
using Catalog.Service.EventHandlers;
using Catalog.Service.EventHandlers.Commands;
using Catalog.Service.EventHandlers.Exceptions;
using Catalog.Services.Queries.DTOs;
using Catalog.Tests.Config;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Tests
{
    [TestClass]
    public class ProductCreateEventHandlerTest
    {

        private ILogger<ProductCreateEventHandler> GetIlogger
        {
            get
            {
                return new Mock<ILogger<ProductCreateEventHandler>>().Object;
            }
        }
        
        [TestMethod]
        public async Task  CreateProduct()
        {
            var context = ApplicationDbContextInMemory.Get();

            
            var productId = 1;
            var nombre = "Camiseta manga corta";
            var descripcion = "Esta es una camiseta azul de manga corta";
            var precio = 50;



            // Add product
            context.Products.Add(new Product
            {
                ProductId = productId,
                Nombre = nombre,
                Descripcion = descripcion,
                Precio = precio
            });

            context.SaveChanges();

             

            var command = new ProductCreateEventHandler(context);

             await command.Handle(new ProductCreateCommand
            {         
                        Nombre = nombre,
                        Descripcion = descripcion,
                        Precio = precio                      

        }, new System.Threading.CancellationToken());

            Assert.AreEqual(context.Products.First(x => x.Nombre == nombre).Nombre, "Camiseta manga corta");
            Assert.AreEqual(context.Products.First(x => x.Descripcion == descripcion).Descripcion, "Esta es una camiseta azul de manga corta");
            Assert.AreEqual(context.Products.First(x => x.Precio == precio).Precio, 50);
        }
      
        /*
        [TestMethod]
        [ExpectedException(typeof(ProductInStockUpdateStockCommandException))]
        public void TryToSubstractStockWhenProductHasntStock()
        {
            var context = ApplicationDbContextInMemory.Get();

            var productInStockId = 3;
            var productId = 3;

            // Add product
            context.Stocks.Add(new ProductInStock
            {
                ProductInStockId = productInStockId,
                ProductId = productId,
                Stock = 1
            });

            context.SaveChanges();

            var command = new ProductInStockUpdateStockEventHandler(context, GetIlogger);

            try
            {
                command.Handle(new ProductInStockUpdateStockCommand
                {
                    Items = new List<ProductInStockUpdateItem> {
                    new ProductInStockUpdateItem {
                        ProductId = productId,
                        Stock = 2,
                        Action = Common.Enums.ProductInStockAction.Substract
                    }
                }
                }, new System.Threading.CancellationToken()).Wait();
            }
            catch (AggregateException ae)
            {
                if (ae.GetBaseException() is ProductInStockUpdateStockCommandException)
                {
                    throw new ProductInStockUpdateStockCommandException(ae.InnerException?.Message);
                }
            }
        }

        [TestMethod]
        public void TryToAddStockWhenProductExists()
        {
            var context = ApplicationDbContextInMemory.Get();

            var productInStockId = 5;
            var productId = 5;

            // Add product
            context.Stocks.Add(new ProductInStock
            {
                ProductInStockId = productInStockId,
                ProductId = productId,
                Stock = 1
            });

            context.SaveChanges();

            var command = new ProductInStockUpdateStockEventHandler(context, GetIlogger);
            command.Handle(new ProductInStockUpdateStockCommand
            {
                Items = new List<ProductInStockUpdateItem> {
                    new ProductInStockUpdateItem {
                        ProductId = productId,
                        Stock = 4,
                        Action = Common.Enums.ProductInStockAction.Add
                    }
                }
            }, new System.Threading.CancellationToken()).Wait();

            Assert.AreEqual(context.Stocks.First(x => x.ProductInStockId == productInStockId).Stock, 5);
        }

        [TestMethod]
        public void TryToAddStockWhenProductNotExists()
        {
            var context = ApplicationDbContextInMemory.Get();
            var command = new ProductInStockUpdateStockEventHandler(context, GetIlogger);

            var productId = 7;

            command.Handle(new ProductInStockUpdateStockCommand
            {
                Items = new List<ProductInStockUpdateItem> {
                    new ProductInStockUpdateItem {
                        ProductId = productId,
                        Stock = 15,
                        Action = Common.Enums.ProductInStockAction.Add
                    }
                }
            }, new System.Threading.CancellationToken()).Wait();

            Assert.AreEqual(context.Stocks.First(x => x.ProductId == productId).Stock, 15);
        }
        */
    }
}
