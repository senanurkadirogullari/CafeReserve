using System.Linq;

namespace CafeReserve
{
    public class ReservationManager
    {
        private readonly AppDbContext _db;

        public ReservationManager(AppDbContext db)
        {
            _db = db;
        }

        public string CheckAndSave(Reservation newRes)
        {
            bool isBooked = _db.Reservations.Any(r =>
                r.ReservationDate == newRes.ReservationDate &&
                r.ReservationTime == newRes.ReservationTime &&
                r.TableNumber == newRes.TableNumber &&
                r.Status == ReservationStatus.Active);

            if (isBooked) return "Error: This table is already booked!";

            _db.Reservations.Add(newRes);
            _db.SaveChanges();
            return "Success";
        }
        public string CancelReservation(int reservationId)
        {
            var reservation = _db.Reservations.Find(reservationId);

            if (reservation == null)
                return "Error: Reservation not found.";

            if (reservation.Status == ReservationStatus.Cancelled)
                return "Error: This reservation is already cancelled.";

            reservation.Status = ReservationStatus.Cancelled;
            _db.SaveChanges();
            return "Success";
        }
        public string UpdateReservation(int reservationId, DateTime newDate,
                                string newTime, int newTable, int newGuests)
        {
            var reservation = _db.Reservations.Find(reservationId);

            if (reservation == null)
                return "Error: Reservation not found.";

            if (reservation.Status != ReservationStatus.Active)
                return "Error: Only active reservations can be updated.";

            bool isBooked = _db.Reservations.Any(r =>
                r.ReservationDate == newDate &&
                r.ReservationTime == newTime &&
                r.TableNumber == newTable &&
                r.Status == ReservationStatus.Active &&
                r.ReservationId != reservationId);

            if (isBooked)
                return "Error: This table is already booked for the selected date and time.";

            reservation.ReservationDate = newDate;
            reservation.ReservationTime = newTime;
            reservation.TableNumber = newTable;
            reservation.NumberOfGuests = newGuests;
            _db.SaveChanges();
            return "Success";
        }
    }
}