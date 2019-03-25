using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemsWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ItemsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        static List<ItemModel> items;
        static ValuesController()
        {
            items = new List<ItemModel>
            {
                new ItemModel(1, "Pizza", 5),
                new ItemModel(2, "Burger", 3)
            };
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<ItemModel>> Get()
        {
            return items;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] ItemModel value)
        {
            items.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
