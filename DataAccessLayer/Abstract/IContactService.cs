using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetList();
        Contact GetById(string id);
        Contact Add(Contact contact);
        void Update(string id, Contact contact);
        void Delete(string id);
    }
}
