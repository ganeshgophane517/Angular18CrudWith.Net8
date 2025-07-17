using System.Collections.Generic;

namespace MyApi.Models
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Foreign key to Country
        public int CountryId { get; set; }
        public Country Country { get; set; }

        // Navigation property - 1 State has many Cities
        public List<City> Cities { get; set; } = new();
    }
}