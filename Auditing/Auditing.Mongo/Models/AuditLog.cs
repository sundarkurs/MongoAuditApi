using Auditing.Mongo.Domain;
using System;

namespace Auditing.Mongo.Models
{
    [BsonCollection("audit_log")]
    public class AuditLog : Document
    {
        public string Type { get; set; }
        public string Application { get; set; }
        public DateTime CreatedOn { get; set; }

        public string UserId { get; set; }
        public string Username { get; set; }
        
        public string Page { get; set; }
        public string Component { get; set; }

        public string URI { get; set; }
        public string ActionMethod { get; set; }
        public string RequestBody { get; set; }
        public string ResponseCode { get; set; }
        public string Response { get; set; }
        public string Exception { get; set; }


        public string Browser { get; set; }
        public string IPAddress { get; set; }
        public string Device { get; set; }
        public string Resolution { get; set; }
        public string OS { get; set; }
        public string Location { get; set; }

    }
}
