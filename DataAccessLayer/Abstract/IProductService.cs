using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IProductService
    {
        List<Product> GetList();
        Product GetById(string id);
        Product Add(Product product);
        void Update(string id, Product product);
        void Delete(string id);
    }
}
