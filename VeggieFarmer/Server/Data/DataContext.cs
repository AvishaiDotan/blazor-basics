namespace VeggieFarmer.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Tomato",
                    Description = "Tomato is a juicy berry used in cooking, high in vitamins and minerals.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/89/Tomato_je.jpg/330px-Tomato_je.jpg",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "Cucumber",
                    Description = "Cucumber is a green, refreshing vegetable, low in calories and high in vitamins and minerals.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/96/ARS_cucumber.jpg/800px-ARS_cucumber.jpg",
                    Price = 5.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Carrot",
                    Description = "Carrot is an orange root vegetable, sweet and crunchy, high in vitamins and minerals.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a2/Vegetable-Carrot-Bundle-wStalks.jpg/1024px-Vegetable-Carrot-Bundle-wStalks.jpg",
                    Price = 2.99m
                },
                new Product
                {
                    Id = 4,
                    Title = "Radish",
                    Description = "Radish is a crunchy, spicy root vegetable, low in calories and high in vitamins and minerals.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Radish_3371103037_4ab07db0bf_o.jpg/800px-Radish_3371103037_4ab07db0bf_o.jpg",
                    Price = 12.99m
                },
                new Product
                {
                    Id = 5,
                    Title = "Turnip",
                    Description = "Turnip is a root vegetable with a slightly sweet and earthy flavor.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d3/Turnip_2622027.jpg",
                    Price = 3.99m
                }
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}
