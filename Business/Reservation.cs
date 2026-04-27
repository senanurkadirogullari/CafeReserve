namespace CafeReserve.Business
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ReservationTime { get; set; }
        public int NumberOfGuests { get; set; }
        public int TableNumber { get; set; }
        public ReservationStatus Status { get; set; }

    }
    public enum ReservationStatus
    {
        Active,
        Cancelled,
        Completed
    }
}
