using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    [BsonIgnoreExtraElements]
    public class Testimonial 
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string TestimonialId { get; set; } = string.Empty;
        [BsonElement("CustomerName")]
        public string CustomerName { get; set; }
        [BsonElement("CustomerTitle")]
        public string CustomerTitle { get; set; }
        [BsonElement("Comment")]
        public string Comment { get; set; }
        [BsonElement("ImageUrl")]
        public string ImageUrl { get; set; }
        [BsonElement("Location")]
        public string Location { get; set; }
    }
}
