using System.Collections.Generic;
using System.Linq;
using KabloomLocationsApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KabloomLocationsApi.Controllers
{
    public class LocationsController : Controller
    {
     // GET api/locations
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/locations/
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      return "value";
    }

    // POST api/locations
    [HttpPost]
    public void Post([FromBody] string value)
    {
      
    }

    // PUT api/locations/
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/locations/
    [HttpDelete("{id}")]
    public void Delete(int id)
    {

    }
}
}