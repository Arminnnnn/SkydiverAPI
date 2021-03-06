using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Skydiver.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string UserName { get; set; } = null!;

        public string UserHighscore { get; set; }
    }
}
