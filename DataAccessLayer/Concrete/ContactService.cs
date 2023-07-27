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
    public class ContactService : IContactService
    {
        private readonly IMongoCollection<Contact> _contact; 

        public ContactService(IDbSettings dbSettings, IMongoClient mongoClient)
        {
            var db = mongoClient.GetDatabase(dbSettings.DatabaseName);
            _contact = db.GetCollection<Contact>(dbSettings.ContactCollectionName);
        }

        public Contact Add(Contact contact)
        {
            _contact.InsertOne(contact);
            return contact;
        }

        public void Delete(string id)
        {
            _contact.DeleteOne(x => x.ContactId == id);
        }

        public Contact GetById(string id)
        {
            return _contact.Find(x => x.ContactId == id).FirstOrDefault();
        }

        public List<Contact> GetList()
        {
            return _contact.Find(x => true).ToList();
        }

        public void Update(string id, Contact contact)
        {
            _contact.ReplaceOne(x => x.ContactId == id, contact);
        }
    }

}

