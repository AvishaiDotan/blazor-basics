namespace VeggieFarmer.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Vegetables",
                    Url = "vegetables"

                },
                new Category
                {
                    Id = 2,
                    Name = "Fruits",
                    Url = "fruits"

                },
                new Category
                {
                    Id = 3,
                    Name = "Seeds",
                    Url = "seeds"
                }



            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Tomato",
                    Description = "Tomato is a juicy berry used in cooking, high in vitamins and minerals.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/89/Tomato_je.jpg/330px-Tomato_je.jpg",
                    Price = 9.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "Cucumber",
                    Description = "Cucumber is a green, refreshing vegetable, low in calories and high in vitamins and minerals.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/96/ARS_cucumber.jpg/800px-ARS_cucumber.jpg",
                    Price = 5.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Carrot",
                    Description = "Carrot is an orange root vegetable, sweet and crunchy, high in vitamins and minerals.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a2/Vegetable-Carrot-Bundle-wStalks.jpg/1024px-Vegetable-Carrot-Bundle-wStalks.jpg",
                    Price = 2.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Title = "Radish",
                    Description = "Radish is a crunchy, spicy root vegetable, low in calories and high in vitamins and minerals.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Radish_3371103037_4ab07db0bf_o.jpg/800px-Radish_3371103037_4ab07db0bf_o.jpg",
                    Price = 12.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 5,
                    Title = "Turnip",
                    Description = "Turnip is a root vegetable with a slightly sweet and earthy flavor.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d3/Turnip_2622027.jpg",
                    Price = 3.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 6,
                    Title = "Peanuts",
                    Description = "Peanut is a legume crop grown mainly for its edible seeds. It is widely grown in the tropics and subtropics, important to both small and large commercial producers.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a4/Arachis_hypogaea_-_K%C3%B6hler%E2%80%93s_Medizinal-Pflanzen-163.jpg/330px-Arachis_hypogaea_-_K%C3%B6hler%E2%80%93s_Medizinal-Pflanzen-163.jpg",
                    Price = 0.99m,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 7,
                    Title = "Watermelon",
                    Description = "Watermelon (Citrullus lanatus) is a flowering plant species of the Cucurbitaceae family and the name of its edible fruit. ",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/47/Taiwan_2009_Tainan_City_Organic_Farm_Watermelon_FRD_7962.jpg/800px-Taiwan_2009_Tainan_City_Organic_Farm_Watermelon_FRD_7962.jpg",
                    Price = 32.99m,
                    CategoryId = 2
                }
                );
        }
        
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
