using Microsoft.EntityFrameworkCore;
using VirtualPetAdoption.Models;

namespace VirtualPetAdoption.Data {
    public class PetAdoptionContext :  DbContext {
        //Declare a constructor method - this create a new object (a new PetAdoptionContext object)
        public PetAdoptionContext(DbContextOptions<PetAdoptionContext> options) : base(options) {

        }//end constructor

        //Attributes of the database context
        public DbSet<Pet> Pets {get;set;}
        public DbSet<User> Users {get;set;}

        //Ovveride the OnModelCreating method that is in the parent class
        //This method allows us to add data to the database.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed the database with a small amount of pet data
            modelBuilder.Entity<Pet>().HasData(
                new Pet
                {
                    Id = 1,
                    Name = "Fluffy",
                    Species = "Cat",
                    Description = "A playful and affectionate cat.",
                    ImageUrl = "/images/cat.png",
                    Playfulness = 4,
                    Affection = 5
                },
                new Pet
                {
                    Id = 2,
                    Name = "Rex",
                    Species = "Dog",
                    Description = "An energetic dog that loves to play.",
                    ImageUrl = "/images/dog.png",
                    Playfulness = 5,
                    Affection = 4
                },
                new Pet
                {
                    Id = 3,
                    Name = "Whiskers",
                    Species = "Cat",
                    Description = "A quiet and independent cat.",
                    ImageUrl = "/images/cat2.png",
                    Playfulness = 2,
                    Affection = 3
                } //end pets
            ); //ends the set
        } //end onModelCreating method
    } //end class 
} //end namespace