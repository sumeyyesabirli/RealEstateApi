using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    [BsonIgnoreExtraElements]
    public class Product 
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; } = string.Empty;
        [BsonElement("BuiltYear")]
        public int BuiltYear { get; set; }
        [BsonElement("Description")]
        public string Description { get; set; }
        [BsonElement("Bedrooms")]
        public string Bedrooms { get; set; }
        [BsonElement("Rooms")]
        public string Rooms { get; set; }
        [BsonElement("ImageUrl")]
        public string ImageUrl { get; set; }
        [BsonElement("Price")]
        public decimal Price { get; set; }
    }
}
