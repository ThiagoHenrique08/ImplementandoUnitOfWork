using UnitOfWork.Infrastructure.Context;
using UnitOfWork.Infrastructure.Interfaces;

namespace UnitOfWork.Infrastructure.Repository
{

    public class UnitOfWorkRepository : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IProductRepository ProductRepository { get; private  set; }
        public ICategoryRepository CategoryRepository { get; private set; }

        public UnitOfWorkRepository(AppDbContext context, IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _context = context;
            ProductRepository = productRepository;
            CategoryRepository = categoryRepository;

        }

        // Método para confirmar as transações
        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync(); // Commit das mudanças
        }

        // Dispose do contexto para liberar recursos
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
