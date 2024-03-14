using THLTWEB_LAB3.Models;

namespace THLTWEB_LAB3.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
