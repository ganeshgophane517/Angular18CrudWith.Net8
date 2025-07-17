namespace MyApi.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Foreign key to State
        public int StateId { get; set; }
        public State State { get; set; }
    }
}