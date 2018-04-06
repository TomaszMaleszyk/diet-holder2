using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using DietHolder2WebApplication.Interfaces;
using DietHolder2WebApplication.Repositories;

namespace DietHolder2WebApplication.Models
{
    public class ProductDatabaseManager : IProductDatabaseManager
    {
        public IEnumerable<Products> GetAll()
        {
            using(var databaseConnection = new DietHolder2Entities())
            {
                return databaseConnection.Products.ToList();
                ;
            }
        }

        public async Task<Products> GetSingle(int id)
        {
            using(var databaseConnection = new DietHolder2Entities())
            {
                var products = await databaseConnection.Products.FindAsync(id);
                return products;
            }
        }

        public string Put()
        {
            throw new NotImplementedException();
        }

        public async Task Post(Products product)
        {
            using(var databaseConnection = new DietHolder2Entities())
            {
                databaseConnection.Products.Add(product);

                try
                {
                    await databaseConnection.SaveChangesAsync();
                }
                catch(DbUpdateException)
                {
                    if(ProductsExists(product.productId))
                    {
                        throw new Exception("Product existed in database");
                    }
                    throw;
                }
            }
        }

        public async Task Delete(int id)
        {
            using(var databaseConnection = new DietHolder2Entities())
            {
                var products = await databaseConnection.Products.FindAsync(id);

                if(products != null)
                {
                    databaseConnection.Products.Remove(products);
                    try
                    {
                        await databaseConnection.SaveChangesAsync();
                    }
                    catch(DbUpdateException)
                    {
                        throw;
                    }
                }
                else
                {
                    throw new Exception("Product is not existed id database.");
                }

            }
        }

        private static bool ProductsExists(int id)
        {
            using(var databaseConnection = new DietHolder2Entities())
            {
                return databaseConnection.Products.Count(e => e.productId == id) > 0;
            }
        }
    }
}