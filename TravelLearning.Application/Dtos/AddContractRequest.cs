namespace TravelLearning.Application.Dtos
{
    public class AddContractRequest
    {
        public string CustomerName { get; set; } = string.Empty;
        public string ServiceType { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string? HotelName { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public string? Origin { get; set; }
        public string? Destination { get; set; }
        public string? FlightNumber { get; set; }
        public DateTime? FlightDate { get; set; }
    }
}
