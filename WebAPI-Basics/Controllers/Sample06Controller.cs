using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI_Basics.Models;

namespace WebAPI_Basics.Controllers
{
  public class Sample06Controller : ApiController
  {
    // GET api/<controller>
    public IEnumerable<Product> Get(int? categoryId = null) {
      PTC db = new PTC();
      IEnumerable<Product> ret;

      if (categoryId.HasValue) {
        ret = db.Products.Where(p => p.CategoryId == categoryId);
      }
      else {
        ret = db.Products;
      }

      return ret;
    }

    // GET api/<controller>/5
    public Product Get(int id) {
      PTC db = new PTC();
      Product product;

      product = db.Products.Find(id);

      return product;
    }

    // POST api/<controller>
    public void Post([FromBody]Product product) {
      PTC db = new PTC();

      if (product != null) {
        db.Products.Add(product);
        db.SaveChanges();
      }
    }

    // PUT api/<controller>/5
    public void Put(int id, [FromBody]string value) {
    }

    // DELETE api/<controller>/5
    public void Delete(int id) {
    }
  }
}