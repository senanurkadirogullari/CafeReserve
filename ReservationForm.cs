using System;
using System.Linq;
using System.Windows.Forms;

namespace CafeReserve
{
    public partial class ReservationForm : Form
    {
        public Reservation CreatedReservation { get; set; }

        private int? _editingReservationId = null;

        public ReservationForm()
        {
            InitializeComponent();

            dtpDate.MinDate = DateTime.Now.Date;
        }

        public ReservationForm(Reservation existingReservation) : this()
        {
            _editingReservationId = existingReservation.ReservationId;

            txtCustomerName.Text = existingReservation.Customer.Name;
            txtPhone.Text = existingReservation.Customer.PhoneNumber;
            dtpDate.Value = existingReservation.ReservationDate;
            cmbTime.SelectedItem = existingReservation.ReservationTime;
            numGuests.Value = existingReservation.NumberOfGuests;
            numTable.Value = existingReservation.TableNumber;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill in the Customer Name and Phone Number fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (cmbTime.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid Time!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CreatedReservation = new Reservation();

            CreatedReservation.Customer = new Customer();
            CreatedReservation.Customer.Name = txtCustomerName.Text;
            CreatedReservation.Customer.PhoneNumber = txtPhone.Text;

            CreatedReservation.ReservationDate = dtpDate.Value.Date;
            CreatedReservation.ReservationTime = cmbTime.SelectedItem.ToString();
            CreatedReservation.NumberOfGuests = (int)numGuests.Value;
            CreatedReservation.TableNumber = (int)numTable.Value;

            CreatedReservation.Status = ReservationStatus.Active;

            CreatedReservation.EditingReservationId = _editingReservationId;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }
    }
}

