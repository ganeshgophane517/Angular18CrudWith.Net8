namespace MyApi.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // Foreign Keys
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }

        // Navigation properties
        public Country Country { get; set; }
        public State State { get; set; }
        public City City { get; set; }
    }
}
