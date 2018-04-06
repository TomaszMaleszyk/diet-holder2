using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DietHolder2WebApplication.Models;
using DietHolder2WebApplication.Repositories;

namespace DietHolder2WebApplication.Controllers
{
    public class ProductsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Products> GetProducts()
        {
            var productsDatabaseManager = new ProductDatabaseManager();
            return productsDatabaseManager.GetAll();
        }

        [ResponseType(typeof(Products))]
        public async Task<IHttpActionResult> GetProducts(int id)
        {
            var productDatabaseManager = new ProductDatabaseManager();
            var product = await productDatabaseManager.GetSingle(id);

            if(product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProducts(int id, Products products)
        {
            using(var databaseConnection = new DietHolder2Entities())
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if(id != products.productId)
                {
                    return BadRequest();
                }

                databaseConnection.Entry(products).State = EntityState.Modified;

                try
                {
                    await databaseConnection.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException)
                {
                    if(!ProductsExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return StatusCode(HttpStatusCode.NoContent);
            }
        }

        [ResponseType(typeof(Products))]
        public async Task<IHttpActionResult> PostProducts([FromBody] Products products)
        {
            if(!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }

            var productDatabaseManager = new ProductDatabaseManager();

            try
            {
                await productDatabaseManager.Post(products);
            }
            catch(Exception)
            {
                return Conflict();
            }

            return CreatedAtRoute("DefaultApi", new { id = products.productId }, products);
        }

        [ResponseType(typeof(Products))]
        public async Task<IHttpActionResult> DeleteProducts(int id)
        {

            var productDatabaseManager = new ProductDatabaseManager();

            try
            {
                await productDatabaseManager.Delete(id);
            }
            catch(Exception)
            {
                throw;
            }

            return Ok("Deleting process was completed.");
        }

        private static bool ProductsExists(int id) // do usuniecia po implementacji put'a
        {
            using(var databaseConnection = new DietHolder2Entities())
            {
                return databaseConnection.Products.Count(e => e.productId == id) > 0;
            }
        }
    }
}