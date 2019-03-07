using DbConnectionDemo.IRepository;
using DbConnectionDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbConnectionDemo.Controllers
{
    [ApiController]
    [Route("api/persons")]
    public class PersonsController : ControllerBase
    {

        private readonly IPersonRepository repository;

        public PersonsController(IPersonRepository repository)
        {
            this.repository = repository;
        }

   
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return Ok(repository.Get());
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            return Ok(repository.Get(id));
        }
    }
}
