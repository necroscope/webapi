﻿using System.Collections.Generic;
using System.Web.Http;
using WebAPI_Basics.Models;

namespace WebAPI_Basics.Controllers
{
  public class Sample02Controller : ApiController
  {
    // GET api/<controller>
    public IEnumerable<Product> Get() {
      PTC db = new PTC();

      return db.Products;
    }
    
    // GET api/<controller>/5
    public string Get(int id) {
      return "value";
    }

    // POST api/<controller>
    public void Post([FromBody]string value) {
    }

    // PUT api/<controller>/5
    public void Put(int id, [FromBody]string value) {
    }

    // DELETE api/<controller>/5
    public void Delete(int id) {
    }
  }
}