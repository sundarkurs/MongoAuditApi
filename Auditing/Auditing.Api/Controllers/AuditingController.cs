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
        private readonly IMongoRepository<AuditLog> _auditRepository;

        public AuditingController(IMongoRepository<AuditLog> auditRepository)
        {
            _auditRepository = auditRepository;
        }

        [HttpPost]
        public async Task Post(AuditLog auditLog)
        {
            await _auditRepository.InsertAsync(auditLog);
        }

        [HttpGet("{userId}")]
        public IEnumerable<AuditLog> Get(string userId)
        {
            var logs = _auditRepository.FilterBy(
                filter => filter.UserId == userId
            );

            return logs;
        }

        [HttpGet("application/{applicationName}")]
        public IEnumerable<AuditLog> GetByApplication(string applicationName)
        {
            var logs = _auditRepository.FilterBy(
                filter => filter.Application == applicationName
            );

            return logs;
        }

    }
}