using System.Collections.Generic;
using System.Threading.Tasks;
using Auditing.Repo;
using Auditing.Repo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Auditing.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuditingController : Controller
    {
        private readonly IAuditRepository _auditRepository;

        public AuditingController(IAuditRepository auditRepository)
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