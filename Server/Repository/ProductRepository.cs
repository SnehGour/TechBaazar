using Server.Data;
using Server.Model;
using Server.Repository.IRepository;

namespace Server.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool addProduct(Products product)
        {
            _db.products.Add(product);
            return Save();
        }

        public ICollection<Products> getAllProducts()
        {
            return _db.products.ToList();       
        }

        public Products getProduct(int id)
        {
            var obj = _db.products.SingleOrDefault(x=>x.Id == id);
            return obj;
        }

        public bool removeProduct(int id)
        {
            var obj = _db.products.SingleOrDefault(x=>x.Id == id);
            _db.products.Remove(obj);
            return Save();
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool upDateProduct(Products product)
        {
            _db.products.Update(product);
            return Save();
        }
    }
}
