﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GitDemo.Controllers
{
    public class DemoController : ApiController
    {
        // GET: api/Demo
        public IEnumerable<string> Get()
        {
           
            return new string[] { "value1", "value2" };
        }

        // GET: api/Demo/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Demo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Demo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Demo/5
        public void Delete(int id)
        {
            int i = 0, j = 0, k = 0;
            i = 10;j = 20;
            k = i + j;
        }

        public void Delete2(int id)
        {
        
        }
        public void Delete22(int id)
        {
        
        }
    }
}
