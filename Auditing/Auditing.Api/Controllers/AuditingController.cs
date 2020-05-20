using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auditing.Mongo.Interfaces;
using Auditing.Mongo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Auditing.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuditingController : Controller
    {
        private readonly IMongoRepository<Person> _peopleRepository;

        public AuditingController(IMongoRepository<Person> peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        [HttpPost("registerPerson")]
        public async Task AddPerson(string firstName, string lastName)
        {
            var person = new Person()
            {
                FirstName = "John",
                LastName = "Doe"
            };

            await _peopleRepository.InsertOneAsync(person);
        }
    }
}