using System;
using System.Diagnostics;
using System.Web.Http;

namespace WebAPI_Basics.Components
{
  public class BaseApiController : ApiController
  {
    protected IHttpActionResult HandleException(Exception ex, string msg) {
      IHttpActionResult ret;

      // Do exception publishing here
      Debug.WriteLine(ex.ToString());

      // Create new exception with generic message        
      ret = InternalServerError(
        new Exception(msg));

      return ret;
    }
  }
}