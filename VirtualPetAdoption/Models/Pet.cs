namespace VirtualPetAdoption.Models
{
    public class Pet {
        //Attibutes that describe a pet (these map to the columns in our Pet database table)
        //Each attribute has a getter and setter (accessor methods)
        public int Id {get; set;}
        public string Name {get;set;}
        public string Species {get;set;}
        public string Description {get;set;}
        public string ImageUrl {get; set;}

        //Simple traits of the pet (1-5 scale)
        public int Playfulness {get;set;}
        public int Affection {get;set;}

    } //end class
}//end namespace