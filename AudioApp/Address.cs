using System.ComponentModel.DataAnnotations;

namespace AudioApp
{
    public class Address
    {
        [Key] // 👈 This tells EF: "This is the primary key"
        public int Id { get; set; }

        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public int PostalBoxNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}