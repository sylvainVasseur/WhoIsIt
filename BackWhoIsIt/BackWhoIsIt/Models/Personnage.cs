using MongoDB.Bson.Serialization.Attributes;

namespace BackWhoIsIt.Models
{
    public class Personnage
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("prenom")]
        public string Prenom { get; set; }
        [BsonElement("genre")]
        public string Genre { get; set; }
        [BsonElement("espece")]
        public string Espece { get; set; }
        [BsonElement("couleurYeux")]
        public string CouleurYeux { get; set; }
        [BsonElement("couleurCheveux")]
        public string CouleurCheveux { get; set; }
        public bool hasLunettes { get; set; }
        public bool hasChapeau { get; set; }
        public bool isWizard { get; set; }
        public string urlPhoto { get; set; }

    }
}
