using UnitOfWork.Domain.Model;
using UnitOfWork.Infrastructure.Context;
using UnitOfWork.Infrastructure.Interfaces;

namespace UnitOfWork.Infrastructure.Repository
{
    public class ProductRepository : DAL<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
