﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using WebAPI_Basics.Components;
using WebAPI_Basics.Models;

namespace WebAPI_Basics.Controllers
{
  public class Sample10Controller : BaseApiController
  {
    // GET api/<controller>
    public IHttpActionResult Get(int? categoryId = null) {
      PTC db = null;
      IEnumerable<Product> list;
      IHttpActionResult ret;

      try {
        db = new PTC();

        if (categoryId.HasValue) {
          list = db.Products.Where(p => p.CategoryId == categoryId);
        }
        else {
          list = db.Products;
        }

        if (list.Count() == 0) {
          ret = NotFound();
        }
        else {
          ret = Ok(list);
        }
      }
      catch (Exception ex) {
        ret = HandleException(ex,
          "Exception when attempting to get all products");
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
    public void Put(int id, [FromBody]Product product) {
      PTC db = new PTC();

      if (product != null) {
        db.Entry(product).State = EntityState.Modified;
        db.SaveChanges();
      }
    }

    // DELETE api/<controller>/5
    public void Delete(int id) {
      PTC db = new PTC();
      Product product;

      // Find the product  
      product = db.Products.Find(id);

      if (product != null) {
        // Remove the product
        db.Products.Remove(product);

        // Save to database
        db.SaveChanges();
      }
    }
  }
}