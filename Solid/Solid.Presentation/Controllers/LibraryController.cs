using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Solid.Domain.Entity;
using Solid.Domain.Interfaces;
using Solid.Infra.Data;

namespace Solid.Presentation.Controllers
{
    [Route("api/[controller]")]
    public class LibraryController : Controller
    {
        private readonly IService<BaseEntity> _service;
        private readonly IRepository<BaseEntity> _repository;

        public LibraryController(IService<BaseEntity> Service)
        {
            _service = Service;
        }

        /// <summary>
        /// Return a list of values when no parametters are send
        /// </summary>
        /// <returns></returns>
        // GET api/values
        [HttpGet]
        public IEnumerable<BaseEntity> Get()
        {
            return _service.Get();

            //return new string[] { "My", "get", "list" };
        }

        /// <summary>
        /// Return a specific parametters.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/values/5
        [HttpGet("{id}")]
        public BaseEntity Get(int id)
        {
            return _service.Get(id);

            //return "My unique get";
        }

        /// <summary>
        /// Post a new data.
        /// </summary>
        /// <param name="value"></param>
        // POST api/values
        [HttpPost]
        public bool Post([FromBody]string value)
        {
            BookEntity obj = new BookEntity();
            obj.ID = 1;
            obj.NmBook = "La Casa de Papel";
            obj.VrBook = 15;
            
            return false; //_service.Post(obj);
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
