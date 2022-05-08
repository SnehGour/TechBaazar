using Server.Model;

namespace Server.Repository.IRepository
{
    public interface ICategoryRepository
    {
        bool addCategory(Category category);
        bool removeCategory(int id);
        Category getCategory(int id);
        bool updateCategory(Category category);
        bool Save();
    }
}
