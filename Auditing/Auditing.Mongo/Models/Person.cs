using Auditing.Mongo.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auditing.Mongo.Models
{
    [BsonCollection("people")]
    public class Person : Document
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
