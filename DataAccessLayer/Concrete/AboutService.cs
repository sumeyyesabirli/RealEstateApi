using DataAccessLayer.Abstract;
using DataAccessLayer.DBSettings;
using EntityLayer.Concrete;
using MongoDB.Driver;

namespace DataAccessLayer.Concrete
{
    public class AboutService : IAboutService
    {
        private readonly IMongoCollection<About> _about;

        public AboutService(IDbSettings dbSettings, IMongoClient mongoClient)
        {
            var db = mongoClient.GetDatabase(dbSettings.DatabaseName);
            _about = db.GetCollection<About>(dbSettings.AboutCollectionName);
        }

        public About Add(About about)
        {
            _about.InsertOne(about);
            return about;
        }

        public void Delete(string id)
        {
            _about.DeleteOne(x => x.AboutId == id);
        }

        public About GetById(string id)
        {
            return _about.Find(x => x.AboutId == id).FirstOrDefault();
        }

        public List<About> GetList()
        {
            return _about.Find(x => true).ToList();
        }

        public void Update(string id, About about)
        {
            _about.ReplaceOne(x => x.AboutId == id, about);
        }
    }
}
