using Microsoft.EntityFrameworkCore;

namespace CafeReserve
{
    public partial class MainForm : Form
    {
        AppDbContext _db = new AppDbContext();
        ReservationManager _manager;

        public MainForm()
        {
            InitializeComponent();

            _manager = new ReservationManager(_db);

            LoadReservations();
        }

        private void LoadReservations()
        {

            var pastReservations = _db.Reservations
    .Where(r => r.Status == ReservationStatus.Active)
    .ToList()
    .Where(r => DateTime.Parse(r.ReservationDate.ToString("yyyy-MM-dd") + " " + r.ReservationTime.Replace(".", ":")) < DateTime.Now)
    .ToList();

            foreach (var r in pastReservations)
                r.Status = ReservationStatus.Completed;

            if (pastReservations.Any())
                _db.SaveChanges();

            dgvReservations.DataSource = null;

            var displayList = _db.Reservations
                .Select(r => new
                {
                    ReservationId = r.ReservationId,
                    CustomerName = r.Customer.Name, 
                    Phone = r.Customer.PhoneNumber,
                    Date = r.ReservationDate.ToShortDateString(), 
                    Time = r.ReservationTime,
                    Guests = r.NumberOfGuests,
                    Table = r.TableNumber,
                    Status = r.Status.ToString() 
                }).ToList();

            dgvReservations.DataSource = displayList;
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            ReservationForm newForm = new ReservationForm();
            if (newForm.ShowDialog() == DialogResult.OK)
            {

                string result = _manager.CheckAndSave(newForm.CreatedReservation);

                if (result == "Success")
                {
                    MessageBox.Show("Reservation successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadReservations(); 
                }
                else
                {
                    MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to cancel.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedId = Convert.ToInt32(dgvReservations.SelectedRows[0].Cells["ReservationId"].Value);

            string result = _manager.CancelReservation(selectedId);

            if (result == "Success")
            {
                MessageBox.Show("Reservation successfully cancelled!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReservations();
            }
            else
            {
                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to update.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedId = Convert.ToInt32(dgvReservations.SelectedRows[0].Cells["ReservationId"].Value);

            var reservation = _db.Reservations
                .Include(r => r.Customer)
                .FirstOrDefault(r => r.ReservationId == selectedId);

            if (reservation == null) return;

            if (reservation.Status != ReservationStatus.Active)
            {
                MessageBox.Show("Only active reservations can be updated.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (ReservationForm form = new ReservationForm(reservation))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var updated = form.CreatedReservation;
                    string result = _manager.UpdateReservation(
                        selectedId,
                        updated.ReservationDate,
                        updated.ReservationTime,
                        updated.TableNumber,
                        updated.NumberOfGuests);

                    if (result == "Success")
                    {
                        MessageBox.Show("Reservation successfully updated!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadReservations();
                    }
                    else
                    {
                        MessageBox.Show(result, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
         