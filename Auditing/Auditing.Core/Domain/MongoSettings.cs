
namespace Auditing.Core.Domain
{
    public class MongoSettings
    {
        public readonly string ConnectionString;
        public readonly string Database;

        public MongoSettings(string connectionString, string database)
        {
            ConnectionString = connectionString;
            Database = database;
        }
    }
}
