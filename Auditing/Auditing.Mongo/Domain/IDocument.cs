using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Auditing.Mongo.Domain
{
    public interface IDocument
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        ObjectId Id { get; set; }

        DateTime CreatedAt { get; }
    }
}
