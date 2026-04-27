namespace CafeReserve.Business
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}