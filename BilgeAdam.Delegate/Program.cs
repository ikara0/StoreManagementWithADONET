namespace BilgeAdam.Delegate
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            var entity = new Product { Id = 1, Name = "Deneme Ürünü",CreatedAt = DateTime.Now, isActive = true, isDeleted=false};
            var result = Mapper<Product,ProductViewDto>(entity,ProductMapper);
            var result2 = Mapper<Product, ProductViewDto>(entity, entity => new ProductViewDto { Id = entity.Id, Name = entity.Name });

        }

        public static ProductViewDto ProductMapper(Product entity)
        {
            Console.WriteLine(entity.Id);
            return new ProductViewDto {Id = entity.Id,Name = entity.Name};
        }
        public static TDto Mapper<TEntity, TDto>(TEntity entity, Func<TEntity, TDto> mapFunction)
        {
            return mapFunction(entity);
        }
        public class Product
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public DateTime CreatedAt { get; set; }
            public int MyProperty { get; set; }
            public bool isActive { get; set; }
            public bool isDeleted { get; set; }
        }


        public class ProductViewDto
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}