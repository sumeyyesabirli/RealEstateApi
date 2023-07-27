using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DBSettings
{
    public interface IDbSettings
    {
        public string AboutCollectionName { get; set; }
        public string ContactCollectionName { get; set; }
        public string ProductCollectionName { get; set; }
        public string TestimonialCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
