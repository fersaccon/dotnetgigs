namespace DotNetGigs.Models.Entities
{
    public class Admins  
    {
        public int Id { get; set; }     
        public string IdentityId { get; set; }   
        public AppUser Identity { get; set; }  // navigation property
        public string Location {get; set;}
    }
}