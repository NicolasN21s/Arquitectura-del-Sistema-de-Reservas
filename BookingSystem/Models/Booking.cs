namespace BookingSystem.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty; // Inicialización por defecto
        public string ServiceName { get; set; } = string.Empty;  // Inicialización por defecto
        public DateTime Date { get; set; }
    }
}

