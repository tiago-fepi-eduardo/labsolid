using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solid.Infra.Data;

namespace Solid.Presentation.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly LibraryContext _libraryContext;

        public ValuesController(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        /// <summary>
        /// Return a list of values when no parametters are send
        /// </summary>
        /// <returns></returns>
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "My", "get", "list" };
        }

        /// <summary>
        /// Return a specific parametters.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "My unique get";
        }

        /// <summary>
        /// Post a new data.
        /// </summary>
        /// <param name="value"></param>
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// Put a new data or imagem.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// delete a data by id.
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
