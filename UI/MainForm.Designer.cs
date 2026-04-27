namespace CafeReserve.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvReservations = new DataGridView();
            btnAddReservation = new Button();
            btnCancel = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();
            
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Location = new Point(84, 35);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.RowHeadersWidth = 51;
            dgvReservations.Size = new Size(635, 314);
            dgvReservations.TabIndex = 0;
            
            btnAddReservation.Location = new Point(562, 378);
            btnAddReservation.Name = "btnAddReservation";
            btnAddReservation.Size = new Size(157, 29);
            btnAddReservation.TabIndex = 1;
            btnAddReservation.Text = "Add Reservation";
            btnAddReservation.UseVisualStyleBackColor = true;
            btnAddReservation.Click += btnAddReservation_Click;
            
            btnCancel.Location = new Point(84, 378);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(157, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel Reservation";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            
            btnUpdate.Location = new Point(323, 378);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(157, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnCancel);
            Controls.Add(btnAddReservation);
            Controls.Add(dgvReservations);
            Name = "MainForm";
            Text = "Dashboard - CafeReserve";
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvReservations;
        private Button btnAddReservation;
        private Button btnCancel;
        private Button btnUpdate;
    }
}