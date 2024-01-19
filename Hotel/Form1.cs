using System.Data;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using Google.Protobuf.WellKnownTypes;
using Hotel.DbEntities;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Hotel
{
    public partial class Form1 : MaterialForm
    {
        DataManager DataManager = new();

        readonly MaterialSkinManager skinManager;
        private bool Firstload = true;
        public Form1()
        {
            InitializeComponent();


            //Initialize MaterialSkinManager
            skinManager = MaterialSkinManager.Instance;
            skinManager.EnforceBackcolorOnAllComponents = true;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataManager = new();
            DateTime dt = DateTime.Now;
            FillHomeDatagrid(dt, dt.AddDays(DateTime.DaysInMonth(dt.Year, dt.Month) - dt.Day));
            FillClientsDataWiew();
            FillServicesDataWiew();
            FillRoomTypesDataWiew();
            FillTreatmentDataWiew();
            FillRoomsDataWiew();
            FillReservationDataWiew();
            AddPeopleToCombobox(10);
            AddRoomTypeToListBox();
            AddRoomServicesToListBox();
            AddTreatmentToListBox();
            AddClientToListBox();
            ReservationDateTimePickerEnable(true);

            //style

            StyleDataGrid(dtgClients);
            StyleDataGrid(dtgRoomsType);
            StyleDataGrid(dtgServices);
            StyleDataGrid(dtgTreatment);
            StyleAllRoomsDataGrid();
            StyleViewAllReservationsDataGrid();

        }
        #region style
        public void StyleViewAllReservationsDataGrid()
        {
            dtgViewAllReservations.AllowUserToAddRows = false;
            dtgViewAllReservations.AllowUserToDeleteRows = false;
            dtgViewAllReservations.AllowUserToResizeColumns = false;
            dtgViewAllReservations.AllowUserToResizeRows = false;
            dtgViewAllReservations.AllowDrop = false;
            for (int i = 0; i < dtgViewAllReservations.ColumnCount - 1; i++)
            {
                dtgViewAllReservations.Columns[i].ReadOnly = true;
            }
            //dtgViewAllReservations.Columns[dtgViewAllReservations.ColumnCount-1].ReadOnly = false;
            dtgViewAllReservations.MultiSelect = false;
            dtgViewAllReservations.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgViewAllReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void StyleAllRoomsDataGrid()
        {
            dtgAllRoom.AllowUserToAddRows = false;
            dtgAllRoom.AllowUserToDeleteRows = false;
            dtgAllRoom.AllowUserToResizeColumns = false;
            dtgAllRoom.AllowUserToResizeRows = false;
            dtgAllRoom.AllowDrop = false;
            dtgAllRoom.ReadOnly = true;
            dtgAllRoom.MultiSelect = false;
            dtgAllRoom.RowHeadersVisible = false;
            dtgAllRoom.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgAllRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void StyleHomeDataGrid()
        {
            dtgRoomsReservation.AllowUserToAddRows = false;
            dtgRoomsReservation.AllowUserToDeleteRows = false;
            dtgRoomsReservation.AllowUserToResizeColumns = false;
            dtgRoomsReservation.AllowUserToResizeRows = false;
            dtgRoomsReservation.AllowDrop = false;
            dtgRoomsReservation.ReadOnly = true;
            dtgRoomsReservation.MultiSelect = false;
            dtgRoomsReservation.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgRoomsReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgRoomsReservation.RowHeadersWidth = 200;
            foreach (DataGridViewColumn column in dtgRoomsReservation.Columns)
            {
                column.Width = 100;
            }
            foreach (DataGridViewRow row in dtgRoomsReservation.Rows)
            {
                row.Height = 55;
            }

        }
        public static void StyleDataGrid(DataGridView d)
        {
            d.AllowUserToAddRows = false;
            d.AllowUserToDeleteRows = false;
            d.AllowUserToResizeColumns = false;
            d.AllowUserToResizeRows = false;
            d.AllowDrop = false;
            d.MultiSelect = false;
            d.RowHeadersVisible = false;
            d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            d.Columns[0].ReadOnly = true;
        }
        #endregion
        #region Home 
        public void FillHomeDatagrid(DateTime dtStart, DateTime dtEnd)
        {
            dtgRoomsReservation.Columns.Clear();
            dtgRoomsReservation.Rows.Clear();
            int days = dtEnd.Subtract(dtStart).Days + 1;
            dtpHomeStart.Value = dtStart;
            dtpHomeEnd.Value = dtEnd;
            Firstload = false;
            SetHomeDataGrid(dtStart, days);
        }
        public void SetHomeDataGrid(DateTime startDate, int days)
        {
            //days
            dtgRoomsReservation.Columns.Clear();
            var tmp = startDate;
            for (int i = 0; i < days; i++)
            {
                dtgRoomsReservation.Columns.Add(tmp.ToString("dd/MM/yyyy"), tmp.ToString("dd/MM/yyyy"));
                tmp = tmp.AddDays(1);
            }

            //rooms
            dtgRoomsReservation.Rows.Clear();

            Dictionary<Room, List<Reservation>> rooms = DataManager.GetRoomsAndReservations();
            int index = 0;
            foreach (var room in rooms)
            {
                dtgRoomsReservation.Rows.Add();
                dtgRoomsReservation.Rows[index].HeaderCell.Value = room.Key.ToString();

                foreach (var reservation in room.Value)
                {
                    if (reservation.CheckIn != null && reservation.CheckOut != null)
                    {
                        DateTime start = (DateTime)reservation.CheckIn;
                        DateTime end = (DateTime)reservation.CheckOut;
                        if (start < startDate)
                        {
                            start = startDate;
                        }
                        if (end > tmp)
                        {
                            end = tmp;
                        }

                        int columnIndex = GetColumnIndexByDate(start.ToString("dd/MM/yyyy"));
                        Random random = new();
                        (int red, int green, int blue) = getColor(reservation);
                        var color = System.Drawing.Color.FromArgb(days, green, blue);
                        for (var i = start.Date; i <= end; i = i.AddDays(1))
                        {
                            if (columnIndex >= 0)
                            {
                                if (columnIndex < dtgRoomsReservation.ColumnCount)
                                {
                                    dtgRoomsReservation[columnIndex, index].Value = reservation.Client.Name;
                                    dtgRoomsReservation[columnIndex, index].Style.BackColor = color;
                                    columnIndex++;

                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }

                }
                index++;
            }
            StyleHomeDataGrid();
        }
        private (int,int,int) getColor(Reservation reservation)
        {
            string value = reservation.Client.Name + reservation.ID + reservation.TreatamentType;
            SHA256 sha256Hash = SHA256.Create();
            var byteArray = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(value));
            string sha256String = Convert.ToHexString(byteArray);
 

            string hashPortion = sha256String.Substring(0, 6);
            int r = Convert.ToInt32(hashPortion.Substring(0, 2), 16);
            int g = Convert.ToInt32(hashPortion.Substring(2, 2), 16);
            int b = Convert.ToInt32(hashPortion.Substring(4, 2), 16);
            int lightR = Math.Min(255, r + 100);
            int lightG = Math.Min(255, g + 100);
            int lightB = Math.Min(255, b + 100);
            return (lightR, lightG, lightB);
        }
        private int GetColumnIndexByDate(string date)
        {
            for (int i = 0; i < dtgRoomsReservation.Columns.Count; i++)
            {
                if (dtgRoomsReservation.Columns[i].HeaderText == date)
                {
                    return i;
                }
            }
            return -1;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!Firstload && dtpHomeStart.Value < dtpHomeEnd.Value)
            {
                FillHomeDatagrid(dtpHomeStart.Value, dtpHomeEnd.Value);
            }

        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (!Firstload && dtpHomeStart.Value < dtpHomeEnd.Value)
            {
                FillHomeDatagrid(dtpHomeStart.Value, dtpHomeEnd.Value);
            }
        }
        #endregion
        #region Fill DataWiew
        public void FillReservationDataWiew()
        {
            dtgViewAllReservations.DataSource = DataManager.GetAllReservationsForDataTable();
        }
        public void FillClientsDataWiew()
        {
            dtgClients.DataSource = DataManager.GetAllClientsForDataTable();
        }
        public void FillServicesDataWiew()
        {
            dtgServices.DataSource = DataManager.GetAllServicesForDataTable();
        }
        public void FillRoomTypesDataWiew()
        {
            dtgRoomsType.DataSource = DataManager.GetAllRoomsTypeForDataTable();
        }
        public void FillTreatmentDataWiew()
        {
            dtgTreatment.DataSource = DataManager.GetAllTreatmentsForDataTable();
        }
        public void FillRoomsDataWiew()
        {
            dtgAllRoom.DataSource = DataManager.GetAllRoomsForDataTable();
        }
        #endregion
        #region Validation
        private static bool NameValidation(string input)
        {

            foreach (char c in input)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
        public static Regex NumberValidation()
        {
            return new Regex("^[0-9]+(?:\\.[0-9]+)?$");
        }
        private static Regex EmailValidation()
        {
            return new Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$", RegexOptions.IgnoreCase);
        }
        #endregion
        #region button click
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string mail = null;
            //mail validation
            if (txtAddClientMail.Text != string.Empty)
            {
                if (!EmailValidation().IsMatch(txtAddClientMail.Text))
                {
                    MessageBox.Show("Mail not in correct format");
                    return;
                }
                mail = txtAddClientMail.Text;
            }
            //name validation
            if (txtAddClientName.Text == string.Empty || !NameValidation(txtAddClientName.Text))
            {
                MessageBox.Show("Name empty or in wrong format only letters");
                return;
            }
            //surname validation
            if (txtAddClientSuname.Text == string.Empty || !NameValidation(txtAddClientSuname.Text))
            {
                MessageBox.Show("Surname empty or in wrong format only letters");
                return;
            }
            //add client
            DataManager.AddClient(txtAddClientName.Text + " " + txtAddClientSuname.Text, mail);
            FillClientsDataWiew();
        }
        private void btnUpdateClients_Click(object sender, EventArgs e)
        {
            DataTable? dt = dtgClients.DataSource as DataTable;
            DataManager.UpdateClients(dt);
            FillClientsDataWiew();

        }
        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            DataTable? dt = dtgServices.DataSource as DataTable;
            DataManager.UpdateServices(dt);
            FillServicesDataWiew();
        }
        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (txtAddServiceName.Text == string.Empty)
            {
                MessageBox.Show("Name cannot be empty");
                return;
            }
            if (txtAddServicePrice.Text == string.Empty || !NumberValidation().IsMatch(txtAddServicePrice.Text))
            {
                MessageBox.Show("price must contains only numbers");
                return;
            }
            double number = double.Parse(txtAddServicePrice.Text);

            DataManager.AddService(txtAddServiceName.Text, Math.Round(number, 2));
            FillServicesDataWiew();
        }
        private void btnAddRoomType_Click(object sender, EventArgs e)
        {
            if (txtAddRoomTypeName.Text == string.Empty || !NameValidation(txtAddRoomTypeName.Text))
            {
                MessageBox.Show("name empty or not in the correct format");
                return;
            }
            if (txtAddRoomTypePrice.Text == string.Empty || !NumberValidation().IsMatch(txtAddRoomTypePrice.Text))
            {
                MessageBox.Show("price must contains only numbers");
                return;
            }
            DataManager.AddRoomType(txtAddRoomTypeName.Text, Math.Round(double.Parse(txtAddRoomTypePrice.Text), 2));
            FillRoomTypesDataWiew();
        }
        private void btnUpdateRoomType_Click(object sender, EventArgs e)
        {
            DataTable? dt = dtgRoomsType.DataSource as DataTable;
            DataManager.UpdateRoomsType(dt);
            FillRoomTypesDataWiew();
        }
        private void btnAddTreatment_Click(object sender, EventArgs e)
        {
            if (txtAddTreatmentName.Text == string.Empty || !NameValidation(txtAddTreatmentName.Text))
            {
                MessageBox.Show("name empty or not in the correct format");
                return;
            }
            if (txtAddTReatmentPrice.Text == string.Empty || !NumberValidation().IsMatch(txtAddTReatmentPrice.Text))
            {
                MessageBox.Show("price must contains only numbers");
                return;
            }
            DataManager.AddTreatment(txtAddTreatmentName.Text, Math.Round(double.Parse(txtAddTReatmentPrice.Text), 2));
            FillTreatmentDataWiew();
        }
        private void btnUpdateTreatment_Click(object sender, EventArgs e)
        {
            DataTable dataTable = dtgTreatment.DataSource as DataTable;
            DataManager.UpdateTreatments(dataTable);
            FillTreatmentDataWiew();
        }
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNumber.Text == string.Empty || !NumberValidation().IsMatch(txtRoomNumber.Text))
            {
                MessageBox.Show("Room number must contains only numbers");
                return;
            }
            if (lstAddRoomSelectType.SelectedIndex == -1)
            {
                MessageBox.Show("Room type not selected");
                return;
            }
            if (txtAddRoomMaxPeople.Text == string.Empty || !NumberValidation().IsMatch(txtAddRoomMaxPeople.Text))
            {
                MessageBox.Show("Max people must contains only numbers");
                return;
            }
            if (DataManager.NumberRoomExist(int.Parse(txtRoomNumber.Text)))
            {
                MessageBox.Show("Room number already exist");
                return;
            }
            List<RoomService> roomServices = new();
            foreach (var item in clstAddRoomServices.CheckedItems)
            {
                RoomService roomService = new()
                {
                    ServiceId = ((Service)item).ID,
                    RoomNumber = int.Parse(txtRoomNumber.Text)
                };
                roomServices.Add(roomService);
            }
            int typeID = ((RoomType)lstAddRoomSelectType.SelectedItem).ID;
            DataManager.AddRoom(int.Parse(txtRoomNumber.Text), int.Parse(txtAddRoomMaxPeople.Text), typeID);
            DataManager.AddRoomService(roomServices);
            FillRoomsDataWiew();

        }
        private void btnAddReservationDate_Click(object sender, EventArgs e)
        {
            DateTime start = dtpAddReservationCheckIn.Value;
            DateTime end = dtpAddReservationCheckOut.Value;
            if (start.Date >= end.Date)
            {
                MessageBox.Show("Check in date must be before check out date");
                return;
            }
            if (cboAddReservationPeopleNum.SelectedIndex == -1)
            {
                MessageBox.Show("Insert people number");
                return;
            }
            List<Room> rooms = DataManager.GetAllFreeRoomsByPeriod(start, end, cboAddReservationPeopleNum.SelectedIndex + 1);
            if (rooms.Count <= 0)
            {
                MessageBox.Show("No rooms available");
                ReservationDateTimePickerEnable(true);
                return;
            }
            lstAddResrvationRoomAvailable.DataSource = rooms;
            lstAddReservationClient.SelectedIndex = 0;
            ReservationDateTimePickerEnable(false);
        }
        private void btnChangeDate_Click(object sender, EventArgs e)
        {
            ReservationDateTimePickerEnable(true);
            lstAddResrvationRoomAvailable.DataSource = null;
        }
        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            DataTable? dt = dtgViewAllReservations.DataSource as DataTable;
            DataManager.DeleteReservations(dt);
            FillReservationDataWiew();
            lstAddResrvationRoomAvailable.DataSource = null;
        }
        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            DateTime start = dtpAddReservationCheckIn.Value;
            DateTime end = dtpAddReservationCheckOut.Value;
            if (lstAddResrvationRoomAvailable.SelectedIndex == -1)
            {
                MessageBox.Show("Select a room");
                return;
            }
            if (lstAddReservationClient.SelectedIndex == -1)
            {
                MessageBox.Show("Select a client");
                return;
            }
            if (lstAddReservationTreatment.SelectedIndex == -1)
            {
                MessageBox.Show("Select a treatment");
                return;
            }
            DataManager.AddReservation(start, end, ((Client)lstAddReservationClient.SelectedItem).ID, (cboAddReservationPeopleNum.SelectedIndex + 1), ((Treatment)lstAddReservationTreatment.SelectedItem).Name, ((Room)lstAddResrvationRoomAvailable.SelectedItem).Number);
            MessageBox.Show("Reservation added");
            FillReservationDataWiew();
            ReservationDateTimePickerEnable(true);
            lstAddResrvationRoomAvailable.DataSource = null;
        }
        #endregion
        #region cell validating
        private void dtgClientsCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = dtgClients.Columns[e.ColumnIndex].HeaderText;

            if (!string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                if (headerText == "Mail")
                {
                    if (!EmailValidation().IsMatch(e.FormattedValue.ToString()))
                    {
                        MessageBox.Show("Mail in wrong format");
                        e.Cancel = true;
                    }

                }
                if (headerText == "Name")
                {
                    if (!NameValidation(e.FormattedValue.ToString()))
                    {
                        MessageBox.Show("Name wrong fomat");
                        e.Cancel = true;
                    }
                }
            }
        }
        private void dtgServeiceCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }
        #endregion
        #region listbox 
        public void AddClientToListBox()
        {lstAddReservationClient.Items.Clear();
            var clients = DataManager.GetAllClients();
            foreach (var item in clients)
            {
                lstAddReservationClient.Items.Add(item);
            }
        }
        public void AddTreatmentToListBox()
        {
            lstAddReservationTreatment.Items.Clear();
            var treatments = DataManager.GetTreatmentsToList();
            foreach (var item in treatments)
            {
                lstAddReservationTreatment.Items.Add(item);
            }
        }
        public void AddRoomTypeToListBox()
        {
            lstAddRoomSelectType.Items.Clear();
            var rooms = DataManager.GetRoomsTypeList();
            foreach (var item in rooms)
            {
                lstAddRoomSelectType.Items.Add(item);
            }
        }
        public void AddRoomServicesToListBox()
        {
            clstAddRoomServices.Items.Clear();
            var services = DataManager.GetServicesToList();
            foreach (var item in services)
            {
                clstAddRoomServices.Items.Add(item);
            }
        }
        public void AddPeopleToCombobox(int peopleNumber)
        {
            cboAddReservationPeopleNum.Items.Clear();
            for (int i = 1; i <= peopleNumber; i++)
            {
                cboAddReservationPeopleNum.Items.Add(i);
            }
        }
        #endregion
        public void ReservationDateTimePickerEnable(bool enable)
        {
            dtpAddReservationCheckIn.Enabled = enable;
            dtpAddReservationCheckOut.Enabled = enable;
            cboAddReservationPeopleNum.Enabled = enable;
            btnAddReservationDate.Enabled = enable;
            btnChangeDate.Enabled = !enable;
        }
        private void HomeTabSelecting(object sender, TabControlCancelEventArgs e)
        {
            switch (e.TabPage.Name)
            {
                case "HOME":
                    FillHomeDatagrid(dtpHomeStart.Value, dtpHomeEnd.Value);
                    break;
                case "CLIENT":
                    FillClientsDataWiew();
                    break;
                case "ROOM_TYPE":
                    FillRoomTypesDataWiew();
                    break;
                case "SERVICE":
                    FillServicesDataWiew();
                    break;
                case "TREATMENT":
                    FillTreatmentDataWiew();
                    break;
                case "ROOM":
                    FillRoomsDataWiew();
                    AddRoomTypeToListBox();
                    AddRoomServicesToListBox();
                    break;
                case "RESERVATION":
                    FillReservationDataWiew();
                    AddClientToListBox();
                    AddTreatmentToListBox();
                    break;
                default:
                    break;
            }
        }

    }
}