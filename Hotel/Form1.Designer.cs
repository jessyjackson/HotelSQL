namespace Hotel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgRoomsReservation = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            cboMonths = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgRoomsReservation).BeginInit();
            SuspendLayout();
            // 
            // dtgRoomsReservation
            // 
            dtgRoomsReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRoomsReservation.Location = new Point(279, 44);
            dtgRoomsReservation.Name = "dtgRoomsReservation";
            dtgRoomsReservation.ReadOnly = true;
            dtgRoomsReservation.RowTemplate.Height = 25;
            dtgRoomsReservation.Size = new Size(849, 579);
            dtgRoomsReservation.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(279, 15);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(523, 15);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 2;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // cboMonths
            // 
            cboMonths.FormattingEnabled = true;
            cboMonths.Location = new Point(790, 15);
            cboMonths.Name = "cboMonths";
            cboMonths.Size = new Size(121, 23);
            cboMonths.TabIndex = 3;
            cboMonths.SelectedIndexChanged += cboMonths_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 652);
            Controls.Add(cboMonths);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dtgRoomsReservation);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgRoomsReservation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgRoomsReservation;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox cboMonths;
    }
}