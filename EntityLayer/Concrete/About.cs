using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    [BsonIgnoreExtraElements]
    public class About
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string AboutId { get; set; } = string.Empty;
        [BsonElement("ImageUrl")]
        public string ImageUrl { get; set; }
        [BsonElement("Description")]
        public string Description { get; set; }
    }
}
