using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DBSettings
{
    public class DbSettings : IDbSettings
    {
        public string AbautCollectionName { get; set; } = string.Empty;
        public string ContactCollectionName { get; set; } = string.Empty;
        public string ProductCollectionName { get; set; } = string.Empty;
        public string TestimonialCollectionName { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
    }
}
