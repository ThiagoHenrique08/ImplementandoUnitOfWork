﻿namespace UnitOfWork.Domain.Model
{
    public class Product
    {
        public Guid ProductId { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public double? Price { get; set; }
        public string? Description { get; set; }

        public Guid CategoryId { get; set; }

        public virtual Category? Category { get; set; }
    }
}
