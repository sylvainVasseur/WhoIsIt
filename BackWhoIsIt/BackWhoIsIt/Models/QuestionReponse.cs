using MongoDB.Bson.Serialization.Attributes;

namespace BackWhoIsIt.Models
{
    public class QuestionReponse
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Question { get; set; }
        public bool Reponse { get; set; }
        public bool Asked { get; set; }
    }
}
