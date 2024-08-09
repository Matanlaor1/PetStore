using Microsoft.EntityFrameworkCore;
using PetStore.Models;

namespace PetStore.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<Animal>? Animals { get; set; }
        public DbSet<Categories>? Categories { get; set; }
        public DbSet<Comment>? Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(
                new Categories { CategoryId = 1, Name = "Mammals" },
                new Categories { CategoryId = 2, Name = "Birds" },
                new Categories { CategoryId = 3, Name = "Reptiles" }
                );

            modelBuilder.Entity<Animal>().HasData(
            new Animal
            {
                AnimalId = 1,
                CategoryId = 1,
                Age = 2,
                Name = "Armadillo",
                Description = "Armadillos are small mammals with distinctive armor-like shells, native to the Americas. They are known for their digging abilities and can roll into a ball for protection.",
                ImagePath = "/Images/Armadillo.jpg"
            },
            new Animal
            {
                AnimalId = 2,
                CategoryId = 1,
                Age = 5,
                Name = "Elephant",
                Description = "Elephants are the largest land animals, known for their tusks and long trunks. They are found in various habitats in Africa and Asia.",
                ImagePath = "/Images/Elephant.jpg"
            },
            new Animal
            {
                AnimalId = 3,
                CategoryId = 1,
                Age = 3,
                Name = "Tiger",
                Description = "Tigers are large cats known for their distinctive orange coat with black stripes. They are apex predators found primarily in Asia.",
                ImagePath = "/Images/Tiger.jpg"
            },
            new Animal
            {
                AnimalId = 4,
                CategoryId = 1,
                Age = 2,
                Name = "Gorilla",
                Description = "Gorillas are large primates native to Africa. They are known for their strength and live in family groups called troops.",
                ImagePath = "/Images/Gorilla.jpg"
            },
            new Animal
            {
                AnimalId = 5,
                CategoryId = 1,
                Age = 1,
                Name = "Panda",
                Description = "Pandas are bears native to central China, known for their distinctive black and white fur. They primarily eat bamboo.",
                ImagePath = "/Images/Panda.jpg"
            },
            new Animal
            {
                AnimalId = 6,
                CategoryId = 2,
                Age = 3,
                Name = "Owl",
                Description = "Owls are nocturnal birds of prey known for their large eyes and ability to rotate their heads almost completely around.",
                ImagePath = "/Images/Owl.jpg"
            },
            new Animal
            {
                AnimalId = 7,
                CategoryId = 2,
                Age = 2,
                Name = "Peacock",
                Description = "Peacocks are large and brightly colored birds known for their iridescent tails, which they display as part of courtship.",
                ImagePath = "/Images/Peacock.jpg"
            },
            new Animal
            {
                AnimalId = 8,
                CategoryId = 2,
                Age = 1,
                Name = "Penguin",
                Description = "Penguins are flightless birds found primarily in the Southern Hemisphere. They are excellent swimmers and often live in colonies.",
                ImagePath = "/Images/Penguin.jpg"
            },
            new Animal
            {
                AnimalId = 9,
                CategoryId = 2,
                Age = 4,
                Name = "Parrot",
                Description = "Parrots are colorful birds known for their ability to mimic human speech. They are found in tropical and subtropical regions.",
                ImagePath = "/Images/Parrot.jpg"
            },
            new Animal
            {
                AnimalId = 10,
                CategoryId = 3,
                Age = 6,
                Name = "Komodo Dragon",
                Description = "Komodo dragons are large lizards native to the Indonesian islands. They are known for their size, powerful bite, and venomous saliva.",
                ImagePath = "/Images/KomodoDragon.jpg"
            },
            new Animal
            {
                AnimalId = 11,
                CategoryId = 3,
                Age = 8,
                Name = "Chameleon",
                Description = "Chameleons are distinctive reptiles known for their ability to change color to blend in with their environment. They are found in Africa, Madagascar, and southern Europe.",
                ImagePath = "/Images/Chameleon.jpg"
            },
            new Animal
            {
                AnimalId = 12,
                CategoryId = 3,
                Age = 2,
                Name = "Tortoise",
                Description = "Tortoises are terrestrial reptiles with a bony or cartilaginous shell. They are found in various habitats worldwide.",
                ImagePath = "/Images/Tortoise.jpg"
            },
            new Animal
            {
                AnimalId = 13,
                CategoryId = 3,
                Age = 5,
                Name = "Anaconda",
                Description = "Anacondas are large non-venomous snakes found in tropical South America. They are powerful constrictors and can reach impressive lengths.",
                ImagePath = "/Images/Anaconda.jpg"
            }
              );

            modelBuilder.Entity<Comment>().HasData(
             new Comment { CommentId = 1, AnimalId = 1, Content = "Such a fascinating creature!" },
             new Comment { CommentId = 2, AnimalId = 1, Content = "I love armadillos!" },
             new Comment { CommentId = 3, AnimalId = 1, Content = "Armadillos are so unique!" },

             new Comment { CommentId = 4, AnimalId = 2, Content = "Elephants are majestic animals." },
             new Comment { CommentId = 5, AnimalId = 2, Content = "I saw elephants at the zoo once!" },

             new Comment { CommentId = 6, AnimalId = 3, Content = "Tigers are powerful predators." },

             new Comment { CommentId = 7, AnimalId = 4, Content = "Gorillas are so strong!" },
             new Comment { CommentId = 8, AnimalId = 4, Content = "I saw gorillas in the wild." },
             new Comment { CommentId = 9, AnimalId = 4, Content = "Gorillas are fascinating to watch." },
             new Comment { CommentId = 10, AnimalId = 4, Content = "They are gentle giants." },

             new Comment { CommentId = 11, AnimalId = 5, Content = "Pandas are adorable!" },
             new Comment { CommentId = 12, AnimalId = 5, Content = "I wish I could hug a panda." },
             new Comment { CommentId = 13, AnimalId = 5, Content = "Pandas love eating bamboo." },

             new Comment { CommentId = 14, AnimalId = 6, Content = "Owls are wise birds." },

             new Comment { CommentId = 15, AnimalId = 7, Content = "Peacocks have beautiful feathers." },
             new Comment { CommentId = 16, AnimalId = 7, Content = "Their displays are amazing." },
             new Comment { CommentId = 17, AnimalId = 7, Content = "I saw a peacock in full display once." },

             new Comment { CommentId = 18, AnimalId = 8, Content = "Penguins are great swimmers." },
             new Comment { CommentId = 19, AnimalId = 8, Content = "They look so cute waddling around." },
             new Comment { CommentId = 20, AnimalId = 8, Content = "I saw penguins in Antarctica." },

             new Comment { CommentId = 21, AnimalId = 9, Content = "Parrots can mimic human speech." },
             new Comment { CommentId = 22, AnimalId = 9, Content = "I taught my parrot to say 'hello!'" },

             new Comment { CommentId = 23, AnimalId = 10, Content = "Komodo dragons are fearsome predators." },
             new Comment { CommentId = 24, AnimalId = 10, Content = "Their saliva is venomous." },

             new Comment { CommentId = 25, AnimalId = 11, Content = "Chameleons can change color!" },
             new Comment { CommentId = 26, AnimalId = 11, Content = "They blend into their surroundings." },
             new Comment { CommentId = 27, AnimalId = 11, Content = "Chameleons are fascinating to study." },

             new Comment { CommentId = 28, AnimalId = 12, Content = "Tortoises live for a long time." },
             new Comment { CommentId = 29, AnimalId = 12, Content = "They move slowly but steadily." },
             new Comment { CommentId = 30, AnimalId = 12, Content = "I had a tortoise as a pet once." },

             new Comment { CommentId = 31, AnimalId = 13, Content = "Anacondas are massive snakes." },
             new Comment { CommentId = 32, AnimalId = 13, Content = "They squeeze their prey to death." },
             new Comment { CommentId = 33, AnimalId = 13, Content = "Anacondas are found in South America." },
             new Comment { CommentId = 34, AnimalId = 13, Content = "I saw an anaconda at the zoo." }
            );



        }

    }
}
