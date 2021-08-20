using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MassaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<M,R> : ControllerBase where M: Base where R : BaseRepository<M>
    {
        R repo = Activator.CreateInstance<R>();
        [HttpGet]
        public List<M> Get()
        {
            return repo.Read();
        }

        [HttpGet("{id}")]
        public M Get(int id)
        {
            return repo.Read(id);
        }

        [HttpPost]
        public void Post([FromBody] M value)
        {
            repo.Create(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] M value)
        {
            repo.Update(value);
        }

        // DELETE api/<MassaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repo.Delete(repo.Read(id));
        }
    }
}
