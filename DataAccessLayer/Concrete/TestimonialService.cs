using DataAccessLayer.Abstract;
using DataAccessLayer.DBSettings;
using EntityLayer.Concrete;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class TestimonialService : ITestimonialService
    {
        private readonly IMongoCollection<Testimonial> _testimonial;

        public TestimonialService(IDbSettings dbSettings, IMongoClient mongoClient)
        {
            var db = mongoClient.GetDatabase(dbSettings.DatabaseName);
            _testimonial = db.GetCollection<Testimonial>(dbSettings.TestimonialCollectionName);
        }

        public Testimonial Add(Testimonial testimonial)
        {
            _testimonial.InsertOne(testimonial);
            return testimonial;
        }

        public void Delete(string id)
        {
            _testimonial.DeleteOne(x => x.TestimonialId == id);
        }

        public Testimonial GetById(string id)
        {
            return _testimonial.Find(x => x.TestimonialId == id).FirstOrDefault();
        }

        public List<Testimonial> GetList()
        {
            return _testimonial.Find(x => true).ToList();
        }

        public void Update(string id, Testimonial testimonial)
        {
            _testimonial.ReplaceOne(x => x.TestimonialId == id, testimonial);
        }
    }

}
