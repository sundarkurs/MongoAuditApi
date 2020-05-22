using Auditing.Core;
using Auditing.Repo.Models;

namespace Auditing.Repo
{
    public class AuditRepository : MongoRepository<AuditLog, AuditSettings>, IAuditRepository
    {
        public AuditRepository(AuditSettings mongoContext) : base(mongoContext)
        {

        }
    }
}
