namespace UnitOfWork.Domain.Model
{
    public class Category
    {
        public Guid CategoryId { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public virtual List<Product>? Products { get; set; }
    }
}
