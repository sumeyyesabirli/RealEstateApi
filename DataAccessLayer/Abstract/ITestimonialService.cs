using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ITestimonialService
    {
        List<Testimonial> GetList();
        Testimonial GetById(string id);
        Testimonial Add(Testimonial testimonial);
        void Update(string id, Testimonial testimonial);
        void Delete(string id);
    }
}
