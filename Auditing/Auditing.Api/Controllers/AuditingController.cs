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
    [Route("api/[controller]")]
    public class AuditingController : Controller
    {
        private readonly IMongoRepository<Person> _peopleRepository;

        public AuditingController(IMongoRepository<Person> peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        [HttpPost]
        public async Task Post(Person person)
        {
            await _peopleRepository.InsertOneAsync(person);
        }

        [HttpGet]
        public IEnumerable<Person> Get(string firstName)
        {
            var people = _peopleRepository.FilterBy(
                filter => filter.FirstName == firstName
            );

            return people;
        }

    }
}