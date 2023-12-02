using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        DataManager DataManager = new DataManager();
        public Form1()
        {
            InitializeComponent();
        }
        #region DataGrid
        public void SetDateToDataGrid(DateTime dtStart, DateTime dtEnd)
        {
            //Get tota no of days
            int days = dtEnd.Subtract(dtStart).Days + 1;
            SetDataGrid(dtStart, days);
        }
        public void SetDateToDataGrid(DateTime dt)
        {
            //Get first date
            var startDate = new DateTime(dt.Year, dt.Month, 1);
            //Get tota no of days
            int days = DateTime.DaysInMonth(dt.Year, dt.Month);
            SetDateTimes(startDate, startDate.AddDays(days - 1));
            SetDataGrid(startDate, days);
        }
        public void SetDataGrid(DateTime startDate, int days)
        {
            //days
            dtgRoomsReservation.Columns.Clear();
            for (int i = 0; i < days; i++)
            {
                dtgRoomsReservation.Columns.Add(startDate.ToShortDateString(), startDate.ToString("yyyy/MM/dd"));
                startDate = startDate.AddDays(1);
            }

            //rooms
            dtgRoomsReservation.Rows.Clear();

            var rooms = DataManager.GetAllRooms();
            for (int i = 0; i < rooms.Count; i++)
            {
                dtgRoomsReservation.Rows.Add();
                dtgRoomsReservation.Rows[i].HeaderCell.Value = "Room " + rooms[i].Number.ToString();
            }
        }

        #endregion
        #region DateTimePicker
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < dateTimePicker2.Value)
            {
                SetDateToDataGrid(dateTimePicker1.Value, dateTimePicker2.Value);
            }

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < dateTimePicker2.Value)
            {
                SetDateToDataGrid(dateTimePicker1.Value, dateTimePicker2.Value);
            }
        }
        public void SetDateTimes(DateTime dtStart, DateTime dtEnd)
        {
            dateTimePicker1.Value = dtStart;
            dateTimePicker2.Value = dtEnd;
        }
        #endregion
        #region comboBox
        public void SetMonthsComboBox()
        {
            cboMonths.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cboMonths.Items.Add(new DateTime(DateTime.Now.Year, i, 1).ToString("MMMM"));
            }
            cboMonths.SelectedIndex = DateTime.Now.Month - 1;
        }
        public void LoadComboBox()
        {
            SetMonthsComboBox();
        }

        private void cboMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(DateTime.Now.Year, cboMonths.SelectedIndex + 1, 1);
            SetDateToDataGrid(dt);
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            DataManager = new();
            DateTime dt = DateTime.Now;
            SetDateToDataGrid(dt);
            LoadComboBox();
        }

    }
}