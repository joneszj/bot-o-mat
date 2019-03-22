using System.Collections.Generic;
using CommonPatterns.Filters;
using CommonPatterns.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace RedVentures.Bot_O_Mat.API.Controllers
{
    [ServiceFilter(typeof(ExceptionFilter))]
    [ServiceFilter(typeof(RequestResponseFilter))]
    [Route("api/[controller]")]
    [ApiController]
    public class RobotController : ControllerBase
    {
        #region constructor && private members
        private HelpersManager _helpersManager;

        public RobotController(HelpersManager helperManager)
        {
            _helpersManager = helperManager;
        }
        #endregion

        #region public members
        // GET: api/Robot
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Robot/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Robot
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Robot/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Robot/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        } 
        #endregion
    }
}
