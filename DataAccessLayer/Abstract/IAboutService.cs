using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();
        About GetById(string id);
        About Add(About about);
        void Update(string id, About about);
        void Delete(string id);
    }
}
