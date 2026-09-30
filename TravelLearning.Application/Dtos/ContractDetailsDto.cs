namespace TravelLearning.Application.Dtos
{
    public class ContractDetailsDto
    {
        public int Id { get; set; }
        public string CostumerName { get; set; } = string.Empty;
        public string ServiceType { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public ContractHotelDetails? HotelDetails { get; set; }
        public ContractFlightDetails? FlightDetails { get; set; }
    }
    public class ContractHotelDetails
    {
        public int? HotelId { get; set; }
        public string? HotelName { get; set; } = string.Empty;
        public int? Nights { get; set; } 

    }
    public class ContractFlightDetails
    {
        public int? FlightId { get; set; }
        public string? Origin { get; set; }
        public string? Destination { get; set; }
        public DateTime? FlightDate { get; set; }
        public string? FlightNumber { get; set; }
    }
}
