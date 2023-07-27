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
    public class Contact
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ContactId { get; set; } = string.Empty;
        [BsonElement("Address")]
        public string Address { get; set; }
        [BsonElement("Email")]
        public string Email { get; set; }
        [BsonElement("Phone")]
        public string Phone { get; set; }
        [BsonElement("Location")]
        public string Location { get; set; }
    }
}
