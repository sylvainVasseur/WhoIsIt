using MongoDB.Bson.Serialization.Attributes;

namespace BackWhoIsIt.Models
{
    public class QuestionReponse
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("question")]
        public string Question { get; set; }
        [BsonElement("reponse")]
        public string Reponse { get; set; }
        [BsonElement("asked")]
        public bool Asked { get; set; }
    }
}
