using Server.Model;

namespace Server.Repository.IRepository
{
    public interface IProductRepository 
    {
        ICollection<Products> getAllProducts();
        Products getProduct(int id);
        bool addProduct(Products product);
        bool upDateProduct(Products product);
        bool removeProduct(int id);
        bool Save();
    }
}
