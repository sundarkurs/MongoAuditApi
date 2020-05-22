using Auditing.Core.Domain;

namespace Auditing.Repo
{
    public class AuditSettings : MongoSettings
    {
        public AuditSettings(string connectionString, string database)
            : base(connectionString, database)
        {

        }
    }
}
