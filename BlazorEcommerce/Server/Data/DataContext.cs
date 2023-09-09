﻿namespace BlazorEcommerce.Server.Data
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
                    Title = "The Hitchhiker's Guide to the Galaxy Vol 1",
                    Description = "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.00m
                },
                new Product
                {
                    Id = 2,
                    Title = "Ready Player One",
                    Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Ready_Player_One_cover.jpg/220px-Ready_Player_One_cover.jpg",
                    Price = 7.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "The Cuckoo's Egg",
                    Description = "The Cuckoo's Egg: Tracking a Spy Through the Maze of Computer Espionage is a 1989 book written by Clifford Stoll. It is his first-person account of the hunt for a computer hacker who broke into a computer at the Lawrence Berkeley National Laboratory (LBNL).",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/2/28/The_Cuckoo%27s_Egg.jpg/220px-The_Cuckoo%27s_Egg.jpg",
                    Price = 9.00m
                }
            );
        }

        public DbSet<Product> Products { get; set; }
    }
}
