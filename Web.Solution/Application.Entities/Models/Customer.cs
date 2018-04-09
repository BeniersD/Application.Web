namespace Application.Entities.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
    }
}
