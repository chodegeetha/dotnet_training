using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi2.Controllers
{
    public class ValuesController : ApiController
    {
        private static List<string> values = new List<string> { "geetha" };

        // GET api/values
        public IEnumerable<string> Get()
        {
            return values;
        }

        // POST api/values
        public IHttpActionResult Post([FromBody] string value)
        {
            if (values.LastOrDefault() == "geetha")
            {
                values.Add("himaja");
            }
            else
            {
                values.Add("geetha");
            }

            return CreatedAtRoute("DefaultApi", new { controller = "values", id = values.Count - 1 }, value);
        }

        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody] string value)
        {
            if (id >= 0 && id < values.Count)
            {
                values[id] = value;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            if (id >= 0 && id < values.Count)
            {
                values.RemoveAt(id);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
