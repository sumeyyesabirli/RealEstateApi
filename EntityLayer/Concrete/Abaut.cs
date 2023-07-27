using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{

    public class Abaut
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string AbautId { get; set; }
        [BsonElement("ImageUrl")]
        public string ImageUrl { get; set; }
        [BsonElement("Description")]
        public string Description { get; set; }
    }
}
