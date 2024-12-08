using UnitOfWork.Domain.Model;
using UnitOfWork.Infrastructure.Context;
using UnitOfWork.Infrastructure.Interfaces;

namespace UnitOfWork.Infrastructure.Repository
{
    public class CategoryRepository : DAL<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
