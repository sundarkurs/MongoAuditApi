using Auditing.Core;
using Auditing.Repo.Models;

namespace Auditing.Repo
{
    public interface IAuditRepository : IMongoRepository<AuditLog>
    {
    }
}
