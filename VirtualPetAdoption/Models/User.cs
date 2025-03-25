namespace VirtualPetAdoption.Models {
    public class User{
        //Attributes that describe a user of the website - these map to the columns
        //in the database table
        public int Id {get;set;}
        public string Name {get;set;}
        public string Email {get;set;}

        //Quiz answers (1-5 scale)
        public int PreferredPlayfulness {get; set;}
        public int PreferredAffection {get; set;}

        // Attributes that reference the matched pet
        public int? AdoptedPetId {get; set;}
        public Pet? AdoptedPet {get;set;}

    }//end class

} //end namespace