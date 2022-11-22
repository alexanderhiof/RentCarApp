namespace API.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string? CarName { get; set; }
        public string? CarModel { get; set; }
        public int ProductionYear { get; set; }
        public string? ImageUrl { get; set; }
        public double Price { get; set; }
        public int Seats { get; set; }
        public int UserId { get; set; }
    }
}
