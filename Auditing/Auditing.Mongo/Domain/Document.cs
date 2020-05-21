using MongoDB.Bson;
using System;

namespace Auditing.Mongo.Domain
{
    public abstract class Document : IDocument
    {
        public ObjectId Id { get; set; }

        //public DateTime CreatedAt => Id.CreationTime;
    }
}
