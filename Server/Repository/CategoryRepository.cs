using Server.Data;
using Server.Model;

namespace Server.Repository.IRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) 
        {
            _db = db;
        }
        public bool addCategory(Category category)
        {
            _db.categories.Add(category);
            return Save();
        }

        public Category getCategory(int id)
        {
            var obj = _db.categories.SingleOrDefault(x=>x.CategoryId == id);
            return obj;
        }

        public bool removeCategory(int id)
        {
            var obj = _db.categories.SingleOrDefault(x => x.CategoryId == id);
            _db.categories.Remove(obj);
            return Save();
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool updateCategory(Category category)
        {
            _db.categories.Update(category);
            return Save();
        }
    }
}
