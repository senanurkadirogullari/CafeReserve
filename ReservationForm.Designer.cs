namespace CafeReserve
{
    partial class ReservationForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCustomerName = new TextBox();
            dtpDate = new DateTimePicker();
            numGuests = new NumericUpDown();
            numTable = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            cmbTime = new ComboBox();
            txtPhone = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)numGuests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTable).BeginInit();
            SuspendLayout();
            
            label1.AutoSize = true;
            label1.Location = new Point(63, 85);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Name:";
            
            label2.Location = new Point(63, 126);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 18;
            label2.Text = "Phone:";
            
            label3.AutoSize = true;
            label3.Location = new Point(63, 179);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 2;
            label3.Text = "Date:";
            
            label4.AutoSize = true;
            label4.Location = new Point(63, 229);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Time:";
           
            label5.AutoSize = true;
            label5.Location = new Point(63, 278);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 4;
            label5.Text = "Number of Guests:";
            
            label6.AutoSize = true;
            label6.Location = new Point(63, 332);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 5;
            label6.Text = "Table Number:";
            
            txtCustomerName.Location = new Point(309, 78);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(250, 27);
            txtCustomerName.TabIndex = 17;
           
            dtpDate.Location = new Point(309, 172);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 8;
            
            numGuests.Location = new Point(309, 271);
            numGuests.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numGuests.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numGuests.Name = "numGuests";
            numGuests.Size = new Size(150, 27);
            numGuests.TabIndex = 10;
            numGuests.Value = new decimal(new int[] { 1, 0, 0, 0 });
             
            numTable.Location = new Point(309, 325);
            numTable.Maximum = new decimal(new int[] { 70, 0, 0, 0 });
            numTable.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTable.Name = "numTable";
            numTable.Size = new Size(150, 27);
            numTable.TabIndex = 11;
            numTable.Value = new decimal(new int[] { 1, 0, 0, 0 });
            
            btnSave.Location = new Point(636, 389);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            
            btnCancel.Location = new Point(523, 389);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            
            cmbTime.Items.AddRange(new object[] { "10.00", "10.30", "11.00", "11.30", "12.00", "12.30", "13.00", "13.30", "14.00", "14.30", "15.00", "15.30", "16.00", "16.30", "17.00", "17.30", "18.00", "18.30", "19.00", "19.30", "20.00", "20.30", "21.00" });
            cmbTime.Location = new Point(309, 221);
            cmbTime.Name = "cmbTime";
            cmbTime.Size = new Size(150, 28);
            cmbTime.TabIndex = 16;
            
            txtPhone.Location = new Point(309, 126);
            txtPhone.Mask = "(999) 000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 27);
            txtPhone.TabIndex = 15;
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPhone);
            Controls.Add(cmbTime);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(numTable);
            Controls.Add(numGuests);
            Controls.Add(dtpDate);
            Controls.Add(txtCustomerName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReservationForm";
            Text = "New Reservation - CafeReserve";
            ((System.ComponentModel.ISupportInitialize)numGuests).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCustomerName;
        private DateTimePicker dtpDate;
        private NumericUpDown numGuests;
        private NumericUpDown numTable;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cmbTime;
        private MaskedTextBox txtPhone;
    }
}