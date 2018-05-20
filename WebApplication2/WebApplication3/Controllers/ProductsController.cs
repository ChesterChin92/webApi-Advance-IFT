using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ProductsController : ApiController
    {
        static List<Product> products = new List<Product>()
        {
            new Product(){ ID = 0, ProductName = "Apple", Price = 20 },
            new Product(){ ID = 1, ProductName = "Banana", Price = 40 },
            new Product(){ ID = 2, ProductName = "Orange", Price = 60 }
        };

        // GET: api/Products
        public IEnumerable<Product> Get()
        {
            //return new string[] { "value1", "value2" };
            return products;


        }

        //public IHttpActionResult Get()
        //{
            //// List of ways to return status code.
            //return Ok(products);
            //return BadRequest();
            //return NotFound();
            //return new HttpResponseMessage(HttpStatusCode.NotFound);

        //}

        // GET: api/Products/5
        public Product Get(int id)
        {
            //return "value";
            return products[id];
        }

        // POST: api/Products
        public HttpResponseMessage Post([FromBody]Product product)
        {
            products.Add(product);
            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]Product product)
        {
            products[id] = product;
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
            products.RemoveAt(id);
        }
    }
}
