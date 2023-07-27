using DataAccessLayer.Abstract;
using DataAccessLayer.DBSettings;
using EntityLayer.Concrete;
using MongoDB.Driver;

namespace DataAccessLayer.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _product;

        public ProductService(IDbSettings dbSettings, IMongoClient mongoClient)
        {
            var db = mongoClient.GetDatabase(dbSettings.DatabaseName);
            _product = db.GetCollection<Product>(dbSettings.ProductCollectionName);
        }

        public Product Add(Product product)
        {
            _product.InsertOne(product);
            return product;
        }

        public void Delete(string id)
        {
            _product.DeleteOne(x => x.ProductId == id);
        }

        public Product GetById(string id)
        {
            return _product.Find(x => x.ProductId == id).FirstOrDefault();
        }

        public List<Product> GetList()
        {
            return _product.Find(x => true).ToList();
        }

        public void Update(string id, Product product)
        {
            _product.ReplaceOne(x => x.ProductId == id, product);
        }
    }
}
