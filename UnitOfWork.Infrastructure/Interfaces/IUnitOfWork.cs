namespace UnitOfWork.Infrastructure.Interfaces
{
    public interface IUnitOfWork :IDisposable
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        Task<int> CompleteAsync();// Commit das transações
    }
}
