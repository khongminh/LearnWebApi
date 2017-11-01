using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Web.Http.Results;

namespace LearnWebApi.Controller
{
    public class HelloController : ApiController
    {
		public JsonResult<Person> Get()
		{
			return Json(new Person { id = 1, MyLove = "bichphuong" });
		}
    }

	
}
