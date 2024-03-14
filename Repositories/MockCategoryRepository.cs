using THLTWEB_LAB3.Models;

namespace THLTWEB_LAB3.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private readonly List<Category> _categoryList;
        public MockCategoryRepository()
        {
            _categoryList =
            [
                new Category { Id = 1, Name = "Laptop" },
                new Category { Id = 2, Name = "Desktop" },
            // Thêm các category khác
            ];
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryList;
        }
    }
}
