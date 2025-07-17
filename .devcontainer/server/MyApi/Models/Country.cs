using System.Collections.Generic;
namespace MyApi.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation property - 1 Country has many States
        public List<State> States { get; set; } = new();
    }
}