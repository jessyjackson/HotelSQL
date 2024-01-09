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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imageList1 = new ImageList(components);
            TREATMENT = new TabPage();
            btnUpdateTreatment = new MaterialSkin.Controls.MaterialButton();
            dtgTreatment = new DataGridView();
            groupBox4 = new GroupBox();
            label8 = new Label();
            btnAddTreatment = new MaterialSkin.Controls.MaterialButton();
            txtAddTreatmentName = new MaterialSkin.Controls.MaterialTextBox2();
            label9 = new Label();
            txtAddTReatmentPrice = new MaterialSkin.Controls.MaterialTextBox2();
            ROOM_TYPE = new TabPage();
            btnUpdateRoomType = new MaterialSkin.Controls.MaterialButton();
            dtgRoomsType = new DataGridView();
            groupBox3 = new GroupBox();
            label4 = new Label();
            btnAddRoomType = new MaterialSkin.Controls.MaterialButton();
            label7 = new Label();
            txtAddRoomTypeName = new MaterialSkin.Controls.MaterialTextBox2();
            txtAddRoomTypePrice = new MaterialSkin.Controls.MaterialTextBox2();
            SERVICE = new TabPage();
            btnUpdateService = new MaterialSkin.Controls.MaterialButton();
            dtgServices = new DataGridView();
            groupBox2 = new GroupBox();
            label5 = new Label();
            btnAddService = new MaterialSkin.Controls.MaterialButton();
            label6 = new Label();
            txtAddServiceName = new MaterialSkin.Controls.MaterialTextBox2();
            txtAddServicePrice = new MaterialSkin.Controls.MaterialTextBox2();
            ROOM = new TabPage();
            dtgAllRoom = new DataGridView();
            btnAddRoom = new MaterialSkin.Controls.MaterialButton();
            clstAddRoomServices = new CheckedListBox();
            lstAddRoomSelectType = new ListBox();
            groupBox6 = new GroupBox();
            label11 = new Label();
            txtRoomNumber = new MaterialSkin.Controls.MaterialTextBox2();
            label10 = new Label();
            txtAddRoomMaxPeople = new MaterialSkin.Controls.MaterialTextBox2();
            groupBox7 = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            CLIENT = new TabPage();
            btnUpdateClients = new MaterialSkin.Controls.MaterialButton();
            dtgClients = new DataGridView();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtAddClientSuname = new MaterialSkin.Controls.MaterialTextBox2();
            btnAddClient = new MaterialSkin.Controls.MaterialButton();
            label3 = new Label();
            txtAddClientName = new MaterialSkin.Controls.MaterialTextBox2();
            label1 = new Label();
            txtAddClientMail = new MaterialSkin.Controls.MaterialTextBox2();
            RESERVATION = new TabPage();
            btnDeleteReservation = new MaterialSkin.Controls.MaterialButton();
            dtgViewAllReservations = new DataGridView();
            cboAddReservationPeopleNum = new ComboBox();
            label12 = new Label();
            lstAddReservationTreatment = new ListBox();
            lstAddReservationClient = new ListBox();
            lstAddResrvationRoomAvailable = new ListBox();
            groupBox5 = new GroupBox();
            btnChangeDate = new MaterialSkin.Controls.MaterialButton();
            btnAddReservation = new MaterialSkin.Controls.MaterialButton();
            btnAddReservationDate = new MaterialSkin.Controls.MaterialButton();
            dtpAddReservationCheckIn = new DateTimePicker();
            dtpAddReservationCheckOut = new DateTimePicker();
            HOME = new TabPage();
            dtpHomeEnd = new DateTimePicker();
            dtgRoomsReservation = new DataGridView();
            dtpHomeStart = new DateTimePicker();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            TREATMENT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgTreatment).BeginInit();
            groupBox4.SuspendLayout();
            ROOM_TYPE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgRoomsType).BeginInit();
            groupBox3.SuspendLayout();
            SERVICE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgServices).BeginInit();
            groupBox2.SuspendLayout();
            ROOM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgAllRoom).BeginInit();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            CLIENT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgClients).BeginInit();
            groupBox1.SuspendLayout();
            RESERVATION.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgViewAllReservations).BeginInit();
            groupBox5.SuspendLayout();
            HOME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgRoomsReservation).BeginInit();
            materialTabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "treatment.png");
            imageList1.Images.SetKeyName(1, "room_type.png");
            imageList1.Images.SetKeyName(2, "bathrobe.png");
            imageList1.Images.SetKeyName(3, "services.png");
            imageList1.Images.SetKeyName(4, "client.png");
            imageList1.Images.SetKeyName(5, "reserve.png");
            imageList1.Images.SetKeyName(6, "home.png");
            imageList1.Images.SetKeyName(7, "bed.png");
            // 
            // TREATMENT
            // 
            TREATMENT.Controls.Add(btnUpdateTreatment);
            TREATMENT.Controls.Add(dtgTreatment);
            TREATMENT.Controls.Add(groupBox4);
            TREATMENT.ImageKey = "treatment.png";
            TREATMENT.Location = new Point(4, 31);
            TREATMENT.Name = "TREATMENT";
            TREATMENT.Size = new Size(1495, 765);
            TREATMENT.TabIndex = 6;
            TREATMENT.Text = "Treatment";
            TREATMENT.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTreatment
            // 
            btnUpdateTreatment.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateTreatment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateTreatment.Depth = 0;
            btnUpdateTreatment.HighEmphasis = true;
            btnUpdateTreatment.Icon = null;
            btnUpdateTreatment.Location = new Point(1230, 468);
            btnUpdateTreatment.Margin = new Padding(4, 6, 4, 6);
            btnUpdateTreatment.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateTreatment.Name = "btnUpdateTreatment";
            btnUpdateTreatment.NoAccentTextColor = Color.Empty;
            btnUpdateTreatment.Size = new Size(77, 36);
            btnUpdateTreatment.TabIndex = 14;
            btnUpdateTreatment.Text = "update";
            btnUpdateTreatment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateTreatment.UseAccentColor = false;
            btnUpdateTreatment.UseVisualStyleBackColor = true;
            btnUpdateTreatment.Click += btnUpdateTreatment_Click;
            // 
            // dtgTreatment
            // 
            dtgTreatment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTreatment.Location = new Point(390, 26);
            dtgTreatment.Name = "dtgTreatment";
            dtgTreatment.RowTemplate.Height = 25;
            dtgTreatment.Size = new Size(917, 403);
            dtgTreatment.TabIndex = 13;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(btnAddTreatment);
            groupBox4.Controls.Add(txtAddTreatmentName);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(txtAddTReatmentPrice);
            groupBox4.Location = new Point(18, 26);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(352, 233);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Add Treatment";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 122);
            label8.Name = "label8";
            label8.Size = new Size(54, 25);
            label8.TabIndex = 7;
            label8.Text = "Price";
            // 
            // btnAddTreatment
            // 
            btnAddTreatment.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddTreatment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddTreatment.Depth = 0;
            btnAddTreatment.HighEmphasis = true;
            btnAddTreatment.Icon = null;
            btnAddTreatment.Location = new Point(188, 156);
            btnAddTreatment.Margin = new Padding(4, 6, 4, 6);
            btnAddTreatment.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddTreatment.Name = "btnAddTreatment";
            btnAddTreatment.NoAccentTextColor = Color.Empty;
            btnAddTreatment.Size = new Size(136, 36);
            btnAddTreatment.TabIndex = 6;
            btnAddTreatment.Text = "Add Room Type";
            btnAddTreatment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddTreatment.UseAccentColor = false;
            btnAddTreatment.UseVisualStyleBackColor = true;
            btnAddTreatment.Click += btnAddTreatment_Click;
            // 
            // txtAddTreatmentName
            // 
            txtAddTreatmentName.AnimateReadOnly = false;
            txtAddTreatmentName.BackgroundImageLayout = ImageLayout.None;
            txtAddTreatmentName.CharacterCasing = CharacterCasing.Normal;
            txtAddTreatmentName.Depth = 0;
            txtAddTreatmentName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddTreatmentName.HideSelection = true;
            txtAddTreatmentName.LeadingIcon = null;
            txtAddTreatmentName.Location = new Point(74, 31);
            txtAddTreatmentName.MaxLength = 32767;
            txtAddTreatmentName.MouseState = MaterialSkin.MouseState.OUT;
            txtAddTreatmentName.Name = "txtAddTreatmentName";
            txtAddTreatmentName.PasswordChar = '\0';
            txtAddTreatmentName.PrefixSuffixText = null;
            txtAddTreatmentName.ReadOnly = false;
            txtAddTreatmentName.RightToLeft = RightToLeft.No;
            txtAddTreatmentName.SelectedText = "";
            txtAddTreatmentName.SelectionLength = 0;
            txtAddTreatmentName.SelectionStart = 0;
            txtAddTreatmentName.ShortcutsEnabled = true;
            txtAddTreatmentName.Size = new Size(250, 48);
            txtAddTreatmentName.TabIndex = 1;
            txtAddTreatmentName.TabStop = false;
            txtAddTreatmentName.TextAlign = HorizontalAlignment.Left;
            txtAddTreatmentName.TrailingIcon = null;
            txtAddTreatmentName.UseSystemPasswordChar = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(6, 45);
            label9.Name = "label9";
            label9.Size = new Size(62, 25);
            label9.TabIndex = 0;
            label9.Text = "Name";
            // 
            // txtAddTReatmentPrice
            // 
            txtAddTReatmentPrice.AnimateReadOnly = false;
            txtAddTReatmentPrice.BackgroundImageLayout = ImageLayout.None;
            txtAddTReatmentPrice.CharacterCasing = CharacterCasing.Normal;
            txtAddTReatmentPrice.Depth = 0;
            txtAddTReatmentPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddTReatmentPrice.HideSelection = true;
            txtAddTReatmentPrice.LeadingIcon = null;
            txtAddTReatmentPrice.Location = new Point(74, 99);
            txtAddTReatmentPrice.MaxLength = 32767;
            txtAddTReatmentPrice.MouseState = MaterialSkin.MouseState.OUT;
            txtAddTReatmentPrice.Name = "txtAddTReatmentPrice";
            txtAddTReatmentPrice.PasswordChar = '\0';
            txtAddTReatmentPrice.PrefixSuffixText = null;
            txtAddTReatmentPrice.ReadOnly = false;
            txtAddTReatmentPrice.RightToLeft = RightToLeft.No;
            txtAddTReatmentPrice.SelectedText = "";
            txtAddTReatmentPrice.SelectionLength = 0;
            txtAddTReatmentPrice.SelectionStart = 0;
            txtAddTReatmentPrice.ShortcutsEnabled = true;
            txtAddTReatmentPrice.Size = new Size(250, 48);
            txtAddTReatmentPrice.TabIndex = 3;
            txtAddTReatmentPrice.TabStop = false;
            txtAddTReatmentPrice.TextAlign = HorizontalAlignment.Left;
            txtAddTReatmentPrice.TrailingIcon = null;
            txtAddTReatmentPrice.UseSystemPasswordChar = false;
            // 
            // ROOM_TYPE
            // 
            ROOM_TYPE.Controls.Add(btnUpdateRoomType);
            ROOM_TYPE.Controls.Add(dtgRoomsType);
            ROOM_TYPE.Controls.Add(groupBox3);
            ROOM_TYPE.ImageKey = "room_type.png";
            ROOM_TYPE.Location = new Point(4, 31);
            ROOM_TYPE.Name = "ROOM_TYPE";
            ROOM_TYPE.Size = new Size(1495, 765);
            ROOM_TYPE.TabIndex = 5;
            ROOM_TYPE.Text = "Room type";
            ROOM_TYPE.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRoomType
            // 
            btnUpdateRoomType.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateRoomType.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateRoomType.Depth = 0;
            btnUpdateRoomType.HighEmphasis = true;
            btnUpdateRoomType.Icon = null;
            btnUpdateRoomType.Location = new Point(1188, 470);
            btnUpdateRoomType.Margin = new Padding(4, 6, 4, 6);
            btnUpdateRoomType.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateRoomType.Name = "btnUpdateRoomType";
            btnUpdateRoomType.NoAccentTextColor = Color.Empty;
            btnUpdateRoomType.Size = new Size(77, 36);
            btnUpdateRoomType.TabIndex = 11;
            btnUpdateRoomType.Text = "update";
            btnUpdateRoomType.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateRoomType.UseAccentColor = false;
            btnUpdateRoomType.UseVisualStyleBackColor = true;
            btnUpdateRoomType.Click += btnUpdateRoomType_Click;
            // 
            // dtgRoomsType
            // 
            dtgRoomsType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRoomsType.Location = new Point(419, 30);
            dtgRoomsType.Name = "dtgRoomsType";
            dtgRoomsType.RowTemplate.Height = 25;
            dtgRoomsType.Size = new Size(846, 403);
            dtgRoomsType.TabIndex = 10;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(btnAddRoomType);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtAddRoomTypeName);
            groupBox3.Controls.Add(txtAddRoomTypePrice);
            groupBox3.Location = new Point(22, 30);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(363, 233);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Add Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 122);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 9;
            label4.Text = "Price";
            // 
            // btnAddRoomType
            // 
            btnAddRoomType.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddRoomType.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddRoomType.Depth = 0;
            btnAddRoomType.HighEmphasis = true;
            btnAddRoomType.Icon = null;
            btnAddRoomType.Location = new Point(201, 156);
            btnAddRoomType.Margin = new Padding(4, 6, 4, 6);
            btnAddRoomType.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddRoomType.Name = "btnAddRoomType";
            btnAddRoomType.NoAccentTextColor = Color.Empty;
            btnAddRoomType.Size = new Size(136, 36);
            btnAddRoomType.TabIndex = 6;
            btnAddRoomType.Text = "Add Room Type";
            btnAddRoomType.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddRoomType.UseAccentColor = false;
            btnAddRoomType.UseVisualStyleBackColor = true;
            btnAddRoomType.Click += btnAddRoomType_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 45);
            label7.Name = "label7";
            label7.Size = new Size(62, 25);
            label7.TabIndex = 8;
            label7.Text = "Name";
            // 
            // txtAddRoomTypeName
            // 
            txtAddRoomTypeName.AnimateReadOnly = false;
            txtAddRoomTypeName.BackgroundImageLayout = ImageLayout.None;
            txtAddRoomTypeName.CharacterCasing = CharacterCasing.Normal;
            txtAddRoomTypeName.Depth = 0;
            txtAddRoomTypeName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddRoomTypeName.HideSelection = true;
            txtAddRoomTypeName.LeadingIcon = null;
            txtAddRoomTypeName.Location = new Point(87, 22);
            txtAddRoomTypeName.MaxLength = 32767;
            txtAddRoomTypeName.MouseState = MaterialSkin.MouseState.OUT;
            txtAddRoomTypeName.Name = "txtAddRoomTypeName";
            txtAddRoomTypeName.PasswordChar = '\0';
            txtAddRoomTypeName.PrefixSuffixText = null;
            txtAddRoomTypeName.ReadOnly = false;
            txtAddRoomTypeName.RightToLeft = RightToLeft.No;
            txtAddRoomTypeName.SelectedText = "";
            txtAddRoomTypeName.SelectionLength = 0;
            txtAddRoomTypeName.SelectionStart = 0;
            txtAddRoomTypeName.ShortcutsEnabled = true;
            txtAddRoomTypeName.Size = new Size(250, 48);
            txtAddRoomTypeName.TabIndex = 1;
            txtAddRoomTypeName.TabStop = false;
            txtAddRoomTypeName.TextAlign = HorizontalAlignment.Left;
            txtAddRoomTypeName.TrailingIcon = null;
            txtAddRoomTypeName.UseSystemPasswordChar = false;
            // 
            // txtAddRoomTypePrice
            // 
            txtAddRoomTypePrice.AnimateReadOnly = false;
            txtAddRoomTypePrice.BackgroundImageLayout = ImageLayout.None;
            txtAddRoomTypePrice.CharacterCasing = CharacterCasing.Normal;
            txtAddRoomTypePrice.Depth = 0;
            txtAddRoomTypePrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddRoomTypePrice.HideSelection = true;
            txtAddRoomTypePrice.LeadingIcon = null;
            txtAddRoomTypePrice.Location = new Point(87, 99);
            txtAddRoomTypePrice.MaxLength = 32767;
            txtAddRoomTypePrice.MouseState = MaterialSkin.MouseState.OUT;
            txtAddRoomTypePrice.Name = "txtAddRoomTypePrice";
            txtAddRoomTypePrice.PasswordChar = '\0';
            txtAddRoomTypePrice.PrefixSuffixText = null;
            txtAddRoomTypePrice.ReadOnly = false;
            txtAddRoomTypePrice.RightToLeft = RightToLeft.No;
            txtAddRoomTypePrice.SelectedText = "";
            txtAddRoomTypePrice.SelectionLength = 0;
            txtAddRoomTypePrice.SelectionStart = 0;
            txtAddRoomTypePrice.ShortcutsEnabled = true;
            txtAddRoomTypePrice.Size = new Size(250, 48);
            txtAddRoomTypePrice.TabIndex = 3;
            txtAddRoomTypePrice.TabStop = false;
            txtAddRoomTypePrice.TextAlign = HorizontalAlignment.Left;
            txtAddRoomTypePrice.TrailingIcon = null;
            txtAddRoomTypePrice.UseSystemPasswordChar = false;
            // 
            // SERVICE
            // 
            SERVICE.Controls.Add(btnUpdateService);
            SERVICE.Controls.Add(dtgServices);
            SERVICE.Controls.Add(groupBox2);
            SERVICE.ImageKey = "bathrobe.png";
            SERVICE.Location = new Point(4, 31);
            SERVICE.Name = "SERVICE";
            SERVICE.Size = new Size(1495, 765);
            SERVICE.TabIndex = 4;
            SERVICE.Text = "Service";
            SERVICE.UseVisualStyleBackColor = true;
            // 
            // btnUpdateService
            // 
            btnUpdateService.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateService.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateService.Depth = 0;
            btnUpdateService.HighEmphasis = true;
            btnUpdateService.Icon = null;
            btnUpdateService.Location = new Point(1200, 451);
            btnUpdateService.Margin = new Padding(4, 6, 4, 6);
            btnUpdateService.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateService.Name = "btnUpdateService";
            btnUpdateService.NoAccentTextColor = Color.Empty;
            btnUpdateService.Size = new Size(77, 36);
            btnUpdateService.TabIndex = 9;
            btnUpdateService.Text = "update";
            btnUpdateService.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateService.UseAccentColor = false;
            btnUpdateService.UseVisualStyleBackColor = true;
            btnUpdateService.Click += btnUpdateService_Click;
            // 
            // dtgServices
            // 
            dtgServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgServices.Location = new Point(416, 25);
            dtgServices.Name = "dtgServices";
            dtgServices.RowTemplate.Height = 25;
            dtgServices.Size = new Size(861, 403);
            dtgServices.TabIndex = 8;
            dtgServices.CellValidating += dtgServeiceCellValidating;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnAddService);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtAddServiceName);
            groupBox2.Controls.Add(txtAddServicePrice);
            groupBox2.Location = new Point(14, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(375, 233);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Service";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 122);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 9;
            label5.Text = "Price";
            // 
            // btnAddService
            // 
            btnAddService.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddService.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddService.Depth = 0;
            btnAddService.HighEmphasis = true;
            btnAddService.Icon = null;
            btnAddService.Location = new Point(234, 156);
            btnAddService.Margin = new Padding(4, 6, 4, 6);
            btnAddService.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddService.Name = "btnAddService";
            btnAddService.NoAccentTextColor = Color.Empty;
            btnAddService.Size = new Size(112, 36);
            btnAddService.TabIndex = 6;
            btnAddService.Text = "Add Service";
            btnAddService.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddService.UseAccentColor = false;
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 45);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 8;
            label6.Text = "Name";
            // 
            // txtAddServiceName
            // 
            txtAddServiceName.AnimateReadOnly = false;
            txtAddServiceName.BackgroundImageLayout = ImageLayout.None;
            txtAddServiceName.CharacterCasing = CharacterCasing.Normal;
            txtAddServiceName.Depth = 0;
            txtAddServiceName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddServiceName.HideSelection = true;
            txtAddServiceName.LeadingIcon = null;
            txtAddServiceName.Location = new Point(96, 22);
            txtAddServiceName.MaxLength = 32767;
            txtAddServiceName.MouseState = MaterialSkin.MouseState.OUT;
            txtAddServiceName.Name = "txtAddServiceName";
            txtAddServiceName.PasswordChar = '\0';
            txtAddServiceName.PrefixSuffixText = null;
            txtAddServiceName.ReadOnly = false;
            txtAddServiceName.RightToLeft = RightToLeft.No;
            txtAddServiceName.SelectedText = "";
            txtAddServiceName.SelectionLength = 0;
            txtAddServiceName.SelectionStart = 0;
            txtAddServiceName.ShortcutsEnabled = true;
            txtAddServiceName.Size = new Size(250, 48);
            txtAddServiceName.TabIndex = 1;
            txtAddServiceName.TabStop = false;
            txtAddServiceName.TextAlign = HorizontalAlignment.Left;
            txtAddServiceName.TrailingIcon = null;
            txtAddServiceName.UseSystemPasswordChar = false;
            // 
            // txtAddServicePrice
            // 
            txtAddServicePrice.AnimateReadOnly = false;
            txtAddServicePrice.BackgroundImageLayout = ImageLayout.None;
            txtAddServicePrice.CharacterCasing = CharacterCasing.Normal;
            txtAddServicePrice.Depth = 0;
            txtAddServicePrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddServicePrice.HideSelection = true;
            txtAddServicePrice.LeadingIcon = null;
            txtAddServicePrice.Location = new Point(96, 99);
            txtAddServicePrice.MaxLength = 32767;
            txtAddServicePrice.MouseState = MaterialSkin.MouseState.OUT;
            txtAddServicePrice.Name = "txtAddServicePrice";
            txtAddServicePrice.PasswordChar = '\0';
            txtAddServicePrice.PrefixSuffixText = null;
            txtAddServicePrice.ReadOnly = false;
            txtAddServicePrice.RightToLeft = RightToLeft.No;
            txtAddServicePrice.SelectedText = "";
            txtAddServicePrice.SelectionLength = 0;
            txtAddServicePrice.SelectionStart = 0;
            txtAddServicePrice.ShortcutsEnabled = true;
            txtAddServicePrice.Size = new Size(250, 48);
            txtAddServicePrice.TabIndex = 3;
            txtAddServicePrice.TabStop = false;
            txtAddServicePrice.TextAlign = HorizontalAlignment.Left;
            txtAddServicePrice.TrailingIcon = null;
            txtAddServicePrice.UseSystemPasswordChar = false;
            // 
            // ROOM
            // 
            ROOM.Controls.Add(dtgAllRoom);
            ROOM.Controls.Add(btnAddRoom);
            ROOM.Controls.Add(clstAddRoomServices);
            ROOM.Controls.Add(lstAddRoomSelectType);
            ROOM.Controls.Add(groupBox6);
            ROOM.Controls.Add(groupBox7);
            ROOM.ImageKey = "bed.png";
            ROOM.Location = new Point(4, 31);
            ROOM.Name = "ROOM";
            ROOM.Size = new Size(1495, 765);
            ROOM.TabIndex = 2;
            ROOM.Text = "Room";
            ROOM.UseVisualStyleBackColor = true;
            // 
            // dtgAllRoom
            // 
            dtgAllRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAllRoom.Location = new Point(792, 44);
            dtgAllRoom.Name = "dtgAllRoom";
            dtgAllRoom.RowTemplate.Height = 25;
            dtgAllRoom.Size = new Size(613, 673);
            dtgAllRoom.TabIndex = 13;
            // 
            // btnAddRoom
            // 
            btnAddRoom.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddRoom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddRoom.Depth = 0;
            btnAddRoom.HighEmphasis = true;
            btnAddRoom.Icon = null;
            btnAddRoom.Location = new Point(662, 657);
            btnAddRoom.Margin = new Padding(4, 6, 4, 6);
            btnAddRoom.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.NoAccentTextColor = Color.Empty;
            btnAddRoom.Size = new Size(96, 36);
            btnAddRoom.TabIndex = 10;
            btnAddRoom.Text = "Add room";
            btnAddRoom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddRoom.UseAccentColor = false;
            btnAddRoom.UseVisualStyleBackColor = true;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // clstAddRoomServices
            // 
            clstAddRoomServices.FormattingEnabled = true;
            clstAddRoomServices.Location = new Point(400, 293);
            clstAddRoomServices.Name = "clstAddRoomServices";
            clstAddRoomServices.Size = new Size(358, 346);
            clstAddRoomServices.TabIndex = 9;
            // 
            // lstAddRoomSelectType
            // 
            lstAddRoomSelectType.FormattingEnabled = true;
            lstAddRoomSelectType.ItemHeight = 15;
            lstAddRoomSelectType.Location = new Point(22, 293);
            lstAddRoomSelectType.Name = "lstAddRoomSelectType";
            lstAddRoomSelectType.Size = new Size(341, 349);
            lstAddRoomSelectType.TabIndex = 8;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label11);
            groupBox6.Controls.Add(txtRoomNumber);
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(txtAddRoomMaxPeople);
            groupBox6.Location = new Point(12, 19);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(476, 204);
            groupBox6.TabIndex = 16;
            groupBox6.TabStop = false;
            groupBox6.Text = "Numbers";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(16, 46);
            label11.Name = "label11";
            label11.Size = new Size(81, 25);
            label11.TabIndex = 8;
            label11.Text = "Number";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.AnimateReadOnly = false;
            txtRoomNumber.BackgroundImageLayout = ImageLayout.None;
            txtRoomNumber.CharacterCasing = CharacterCasing.Normal;
            txtRoomNumber.Depth = 0;
            txtRoomNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRoomNumber.HideSelection = true;
            txtRoomNumber.LeadingIcon = null;
            txtRoomNumber.Location = new Point(138, 22);
            txtRoomNumber.MaxLength = 32767;
            txtRoomNumber.MouseState = MaterialSkin.MouseState.OUT;
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.PasswordChar = '\0';
            txtRoomNumber.PrefixSuffixText = null;
            txtRoomNumber.ReadOnly = false;
            txtRoomNumber.RightToLeft = RightToLeft.No;
            txtRoomNumber.SelectedText = "";
            txtRoomNumber.SelectionLength = 0;
            txtRoomNumber.SelectionStart = 0;
            txtRoomNumber.ShortcutsEnabled = true;
            txtRoomNumber.Size = new Size(297, 48);
            txtRoomNumber.TabIndex = 12;
            txtRoomNumber.TabStop = false;
            txtRoomNumber.TextAlign = HorizontalAlignment.Left;
            txtRoomNumber.TrailingIcon = null;
            txtRoomNumber.UseSystemPasswordChar = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(16, 123);
            label10.Name = "label10";
            label10.Size = new Size(110, 25);
            label10.TabIndex = 9;
            label10.Text = "Max People";
            // 
            // txtAddRoomMaxPeople
            // 
            txtAddRoomMaxPeople.AnimateReadOnly = false;
            txtAddRoomMaxPeople.BackgroundImageLayout = ImageLayout.None;
            txtAddRoomMaxPeople.CharacterCasing = CharacterCasing.Normal;
            txtAddRoomMaxPeople.Depth = 0;
            txtAddRoomMaxPeople.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddRoomMaxPeople.HideSelection = true;
            txtAddRoomMaxPeople.LeadingIcon = null;
            txtAddRoomMaxPeople.Location = new Point(138, 100);
            txtAddRoomMaxPeople.MaxLength = 32767;
            txtAddRoomMaxPeople.MouseState = MaterialSkin.MouseState.OUT;
            txtAddRoomMaxPeople.Name = "txtAddRoomMaxPeople";
            txtAddRoomMaxPeople.PasswordChar = '\0';
            txtAddRoomMaxPeople.PrefixSuffixText = null;
            txtAddRoomMaxPeople.ReadOnly = false;
            txtAddRoomMaxPeople.RightToLeft = RightToLeft.No;
            txtAddRoomMaxPeople.SelectedText = "";
            txtAddRoomMaxPeople.SelectionLength = 0;
            txtAddRoomMaxPeople.SelectionStart = 0;
            txtAddRoomMaxPeople.ShortcutsEnabled = true;
            txtAddRoomMaxPeople.Size = new Size(297, 48);
            txtAddRoomMaxPeople.TabIndex = 3;
            txtAddRoomMaxPeople.TabStop = false;
            txtAddRoomMaxPeople.TextAlign = HorizontalAlignment.Left;
            txtAddRoomMaxPeople.TrailingIcon = null;
            txtAddRoomMaxPeople.UseSystemPasswordChar = false;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(label14);
            groupBox7.Controls.Add(label13);
            groupBox7.Location = new Point(14, 240);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(765, 477);
            groupBox7.TabIndex = 17;
            groupBox7.TabStop = false;
            groupBox7.Text = "Services";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(507, 19);
            label14.Name = "label14";
            label14.Size = new Size(80, 25);
            label14.TabIndex = 15;
            label14.Text = "Services";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(112, 19);
            label13.Name = "label13";
            label13.Size = new Size(104, 25);
            label13.TabIndex = 14;
            label13.Text = "Room Type";
            // 
            // CLIENT
            // 
            CLIENT.Controls.Add(btnUpdateClients);
            CLIENT.Controls.Add(dtgClients);
            CLIENT.Controls.Add(groupBox1);
            CLIENT.ImageKey = "client.png";
            CLIENT.Location = new Point(4, 31);
            CLIENT.Name = "CLIENT";
            CLIENT.Padding = new Padding(3);
            CLIENT.Size = new Size(1495, 765);
            CLIENT.TabIndex = 1;
            CLIENT.Text = "Client";
            CLIENT.UseVisualStyleBackColor = true;
            // 
            // btnUpdateClients
            // 
            btnUpdateClients.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateClients.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateClients.Depth = 0;
            btnUpdateClients.HighEmphasis = true;
            btnUpdateClients.Icon = null;
            btnUpdateClients.Location = new Point(1150, 442);
            btnUpdateClients.Margin = new Padding(4, 6, 4, 6);
            btnUpdateClients.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateClients.Name = "btnUpdateClients";
            btnUpdateClients.NoAccentTextColor = Color.Empty;
            btnUpdateClients.Size = new Size(119, 36);
            btnUpdateClients.TabIndex = 6;
            btnUpdateClients.Text = "Upload Data";
            btnUpdateClients.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateClients.UseAccentColor = false;
            btnUpdateClients.UseVisualStyleBackColor = true;
            btnUpdateClients.Click += btnUpdateClients_Click;
            // 
            // dtgClients
            // 
            dtgClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgClients.Location = new Point(501, 16);
            dtgClients.Name = "dtgClients";
            dtgClients.RowTemplate.Height = 25;
            dtgClients.Size = new Size(768, 403);
            dtgClients.TabIndex = 5;
            dtgClients.CellValidating += dtgClientsCellValidating;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtAddClientSuname);
            groupBox1.Controls.Add(btnAddClient);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAddClientName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtAddClientMail);
            groupBox1.Location = new Point(6, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 327);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Client";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 125);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 8;
            label2.Text = "Surname";
            // 
            // txtAddClientSuname
            // 
            txtAddClientSuname.AnimateReadOnly = false;
            txtAddClientSuname.BackgroundImageLayout = ImageLayout.None;
            txtAddClientSuname.CharacterCasing = CharacterCasing.Normal;
            txtAddClientSuname.Depth = 0;
            txtAddClientSuname.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddClientSuname.HideSelection = true;
            txtAddClientSuname.LeadingIcon = null;
            txtAddClientSuname.Location = new Point(139, 102);
            txtAddClientSuname.MaxLength = 32767;
            txtAddClientSuname.MouseState = MaterialSkin.MouseState.OUT;
            txtAddClientSuname.Name = "txtAddClientSuname";
            txtAddClientSuname.PasswordChar = '\0';
            txtAddClientSuname.PrefixSuffixText = null;
            txtAddClientSuname.ReadOnly = false;
            txtAddClientSuname.RightToLeft = RightToLeft.No;
            txtAddClientSuname.SelectedText = "";
            txtAddClientSuname.SelectionLength = 0;
            txtAddClientSuname.SelectionStart = 0;
            txtAddClientSuname.ShortcutsEnabled = true;
            txtAddClientSuname.Size = new Size(250, 48);
            txtAddClientSuname.TabIndex = 7;
            txtAddClientSuname.TabStop = false;
            txtAddClientSuname.TextAlign = HorizontalAlignment.Left;
            txtAddClientSuname.TrailingIcon = null;
            txtAddClientSuname.UseSystemPasswordChar = false;
            // 
            // btnAddClient
            // 
            btnAddClient.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddClient.Depth = 0;
            btnAddClient.HighEmphasis = true;
            btnAddClient.Icon = null;
            btnAddClient.Location = new Point(285, 260);
            btnAddClient.Margin = new Padding(4, 6, 4, 6);
            btnAddClient.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddClient.Name = "btnAddClient";
            btnAddClient.NoAccentTextColor = Color.Empty;
            btnAddClient.Size = new Size(104, 36);
            btnAddClient.TabIndex = 6;
            btnAddClient.Text = "Add Client";
            btnAddClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddClient.UseAccentColor = false;
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 199);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 5;
            label3.Text = "Mail";
            // 
            // txtAddClientName
            // 
            txtAddClientName.AnimateReadOnly = false;
            txtAddClientName.BackgroundImageLayout = ImageLayout.None;
            txtAddClientName.CharacterCasing = CharacterCasing.Normal;
            txtAddClientName.Depth = 0;
            txtAddClientName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddClientName.HideSelection = true;
            txtAddClientName.LeadingIcon = null;
            txtAddClientName.Location = new Point(139, 22);
            txtAddClientName.MaxLength = 32767;
            txtAddClientName.MouseState = MaterialSkin.MouseState.OUT;
            txtAddClientName.Name = "txtAddClientName";
            txtAddClientName.PasswordChar = '\0';
            txtAddClientName.PrefixSuffixText = null;
            txtAddClientName.ReadOnly = false;
            txtAddClientName.RightToLeft = RightToLeft.No;
            txtAddClientName.SelectedText = "";
            txtAddClientName.SelectionLength = 0;
            txtAddClientName.SelectionStart = 0;
            txtAddClientName.ShortcutsEnabled = true;
            txtAddClientName.Size = new Size(250, 48);
            txtAddClientName.TabIndex = 1;
            txtAddClientName.TabStop = false;
            txtAddClientName.TextAlign = HorizontalAlignment.Left;
            txtAddClientName.TrailingIcon = null;
            txtAddClientName.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 45);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtAddClientMail
            // 
            txtAddClientMail.AnimateReadOnly = false;
            txtAddClientMail.BackgroundImageLayout = ImageLayout.None;
            txtAddClientMail.CharacterCasing = CharacterCasing.Normal;
            txtAddClientMail.Depth = 0;
            txtAddClientMail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddClientMail.HideSelection = true;
            txtAddClientMail.LeadingIcon = null;
            txtAddClientMail.Location = new Point(139, 176);
            txtAddClientMail.MaxLength = 32767;
            txtAddClientMail.MouseState = MaterialSkin.MouseState.OUT;
            txtAddClientMail.Name = "txtAddClientMail";
            txtAddClientMail.PasswordChar = '\0';
            txtAddClientMail.PrefixSuffixText = null;
            txtAddClientMail.ReadOnly = false;
            txtAddClientMail.RightToLeft = RightToLeft.No;
            txtAddClientMail.SelectedText = "";
            txtAddClientMail.SelectionLength = 0;
            txtAddClientMail.SelectionStart = 0;
            txtAddClientMail.ShortcutsEnabled = true;
            txtAddClientMail.Size = new Size(250, 48);
            txtAddClientMail.TabIndex = 3;
            txtAddClientMail.TabStop = false;
            txtAddClientMail.TextAlign = HorizontalAlignment.Left;
            txtAddClientMail.TrailingIcon = null;
            txtAddClientMail.UseSystemPasswordChar = false;
            // 
            // RESERVATION
            // 
            RESERVATION.Controls.Add(btnDeleteReservation);
            RESERVATION.Controls.Add(dtgViewAllReservations);
            RESERVATION.Controls.Add(cboAddReservationPeopleNum);
            RESERVATION.Controls.Add(label12);
            RESERVATION.Controls.Add(lstAddReservationTreatment);
            RESERVATION.Controls.Add(lstAddReservationClient);
            RESERVATION.Controls.Add(lstAddResrvationRoomAvailable);
            RESERVATION.Controls.Add(groupBox5);
            RESERVATION.ImageKey = "reserve.png";
            RESERVATION.Location = new Point(4, 31);
            RESERVATION.Name = "RESERVATION";
            RESERVATION.Size = new Size(1495, 765);
            RESERVATION.TabIndex = 3;
            RESERVATION.Text = "Reservation";
            RESERVATION.UseVisualStyleBackColor = true;
            // 
            // btnDeleteReservation
            // 
            btnDeleteReservation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteReservation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeleteReservation.Depth = 0;
            btnDeleteReservation.HighEmphasis = true;
            btnDeleteReservation.Icon = null;
            btnDeleteReservation.Location = new Point(1316, 705);
            btnDeleteReservation.Margin = new Padding(4, 6, 4, 6);
            btnDeleteReservation.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeleteReservation.Name = "btnDeleteReservation";
            btnDeleteReservation.NoAccentTextColor = Color.Empty;
            btnDeleteReservation.Size = new Size(73, 36);
            btnDeleteReservation.TabIndex = 12;
            btnDeleteReservation.Text = "Delete";
            btnDeleteReservation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeleteReservation.UseAccentColor = false;
            btnDeleteReservation.UseVisualStyleBackColor = true;
            btnDeleteReservation.Click += btnDeleteReservation_Click;
            // 
            // dtgViewAllReservations
            // 
            dtgViewAllReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgViewAllReservations.Location = new Point(27, 479);
            dtgViewAllReservations.Name = "dtgViewAllReservations";
            dtgViewAllReservations.RowTemplate.Height = 25;
            dtgViewAllReservations.Size = new Size(1282, 262);
            dtgViewAllReservations.TabIndex = 10;
            // 
            // cboAddReservationPeopleNum
            // 
            cboAddReservationPeopleNum.FormattingEnabled = true;
            cboAddReservationPeopleNum.Location = new Point(165, 99);
            cboAddReservationPeopleNum.Name = "cboAddReservationPeopleNum";
            cboAddReservationPeopleNum.Size = new Size(121, 23);
            cboAddReservationPeopleNum.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(42, 102);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 8;
            label12.Text = "People number";
            // 
            // lstAddReservationTreatment
            // 
            lstAddReservationTreatment.FormattingEnabled = true;
            lstAddReservationTreatment.ItemHeight = 15;
            lstAddReservationTreatment.Location = new Point(929, 24);
            lstAddReservationTreatment.Name = "lstAddReservationTreatment";
            lstAddReservationTreatment.Size = new Size(238, 409);
            lstAddReservationTreatment.TabIndex = 4;
            // 
            // lstAddReservationClient
            // 
            lstAddReservationClient.FormattingEnabled = true;
            lstAddReservationClient.ItemHeight = 15;
            lstAddReservationClient.Location = new Point(615, 24);
            lstAddReservationClient.Name = "lstAddReservationClient";
            lstAddReservationClient.Size = new Size(224, 409);
            lstAddReservationClient.TabIndex = 3;
            // 
            // lstAddResrvationRoomAvailable
            // 
            lstAddResrvationRoomAvailable.FormattingEnabled = true;
            lstAddResrvationRoomAvailable.ItemHeight = 15;
            lstAddResrvationRoomAvailable.Location = new Point(42, 187);
            lstAddResrvationRoomAvailable.Name = "lstAddResrvationRoomAvailable";
            lstAddResrvationRoomAvailable.Size = new Size(466, 244);
            lstAddResrvationRoomAvailable.TabIndex = 2;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnChangeDate);
            groupBox5.Controls.Add(btnAddReservation);
            groupBox5.Controls.Add(btnAddReservationDate);
            groupBox5.Controls.Add(dtpAddReservationCheckIn);
            groupBox5.Controls.Add(dtpAddReservationCheckOut);
            groupBox5.Location = new Point(27, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1289, 456);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Text = "Add Reservation";
            // 
            // btnChangeDate
            // 
            btnChangeDate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnChangeDate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnChangeDate.Depth = 0;
            btnChangeDate.HighEmphasis = true;
            btnChangeDate.Icon = null;
            btnChangeDate.Location = new Point(296, 139);
            btnChangeDate.Margin = new Padding(4, 6, 4, 6);
            btnChangeDate.MouseState = MaterialSkin.MouseState.HOVER;
            btnChangeDate.Name = "btnChangeDate";
            btnChangeDate.NoAccentTextColor = Color.Empty;
            btnChangeDate.Size = new Size(121, 36);
            btnChangeDate.TabIndex = 7;
            btnChangeDate.Text = "Change Date";
            btnChangeDate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnChangeDate.UseAccentColor = false;
            btnChangeDate.UseVisualStyleBackColor = true;
            btnChangeDate.Click += btnChangeDate_Click;
            // 
            // btnAddReservation
            // 
            btnAddReservation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddReservation.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddReservation.Depth = 0;
            btnAddReservation.HighEmphasis = true;
            btnAddReservation.Icon = null;
            btnAddReservation.Location = new Point(1218, 411);
            btnAddReservation.Margin = new Padding(4, 6, 4, 6);
            btnAddReservation.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddReservation.Name = "btnAddReservation";
            btnAddReservation.NoAccentTextColor = Color.Empty;
            btnAddReservation.Size = new Size(64, 36);
            btnAddReservation.TabIndex = 6;
            btnAddReservation.Text = "Book";
            btnAddReservation.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddReservation.UseAccentColor = false;
            btnAddReservation.UseVisualStyleBackColor = true;
            btnAddReservation.Click += btnAddReservation_Click;
            // 
            // btnAddReservationDate
            // 
            btnAddReservationDate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddReservationDate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddReservationDate.Depth = 0;
            btnAddReservationDate.HighEmphasis = true;
            btnAddReservationDate.Icon = null;
            btnAddReservationDate.Location = new Point(296, 88);
            btnAddReservationDate.Margin = new Padding(4, 6, 4, 6);
            btnAddReservationDate.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddReservationDate.Name = "btnAddReservationDate";
            btnAddReservationDate.NoAccentTextColor = Color.Empty;
            btnAddReservationDate.Size = new Size(185, 36);
            btnAddReservationDate.TabIndex = 5;
            btnAddReservationDate.Text = "Check availble room";
            btnAddReservationDate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddReservationDate.UseAccentColor = false;
            btnAddReservationDate.UseVisualStyleBackColor = true;
            btnAddReservationDate.Click += btnAddReservationDate_Click;
            // 
            // dtpAddReservationCheckIn
            // 
            dtpAddReservationCheckIn.Location = new Point(15, 45);
            dtpAddReservationCheckIn.Name = "dtpAddReservationCheckIn";
            dtpAddReservationCheckIn.Size = new Size(200, 23);
            dtpAddReservationCheckIn.TabIndex = 0;
            // 
            // dtpAddReservationCheckOut
            // 
            dtpAddReservationCheckOut.Location = new Point(281, 45);
            dtpAddReservationCheckOut.Name = "dtpAddReservationCheckOut";
            dtpAddReservationCheckOut.Size = new Size(200, 23);
            dtpAddReservationCheckOut.TabIndex = 1;
            // 
            // HOME
            // 
            HOME.Controls.Add(dtpHomeEnd);
            HOME.Controls.Add(dtgRoomsReservation);
            HOME.Controls.Add(dtpHomeStart);
            HOME.ImageKey = "home.png";
            HOME.Location = new Point(4, 31);
            HOME.Name = "HOME";
            HOME.Padding = new Padding(3);
            HOME.Size = new Size(1495, 765);
            HOME.TabIndex = 0;
            HOME.Text = "Home";
            HOME.UseVisualStyleBackColor = true;
            // 
            // dtpHomeEnd
            // 
            dtpHomeEnd.Location = new Point(281, 23);
            dtpHomeEnd.Name = "dtpHomeEnd";
            dtpHomeEnd.Size = new Size(200, 23);
            dtpHomeEnd.TabIndex = 2;
            dtpHomeEnd.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dtgRoomsReservation
            // 
            dtgRoomsReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRoomsReservation.Location = new Point(37, 70);
            dtgRoomsReservation.Name = "dtgRoomsReservation";
            dtgRoomsReservation.ReadOnly = true;
            dtgRoomsReservation.RowTemplate.Height = 25;
            dtgRoomsReservation.Size = new Size(1300, 677);
            dtgRoomsReservation.TabIndex = 0;
            // 
            // dtpHomeStart
            // 
            dtpHomeStart.Location = new Point(37, 23);
            dtpHomeStart.Name = "dtpHomeStart";
            dtpHomeStart.Size = new Size(200, 23);
            dtpHomeStart.TabIndex = 1;
            dtpHomeStart.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(HOME);
            materialTabControl1.Controls.Add(RESERVATION);
            materialTabControl1.Controls.Add(CLIENT);
            materialTabControl1.Controls.Add(ROOM);
            materialTabControl1.Controls.Add(SERVICE);
            materialTabControl1.Controls.Add(ROOM_TYPE);
            materialTabControl1.Controls.Add(TREATMENT);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1503, 800);
            materialTabControl1.TabIndex = 3;
            materialTabControl1.Selecting += HomeTabSelecting;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1509, 867);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "Form1";
            Text = "Hotel";
            Load += Form1_Load;
            TREATMENT.ResumeLayout(false);
            TREATMENT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgTreatment).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ROOM_TYPE.ResumeLayout(false);
            ROOM_TYPE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgRoomsType).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            SERVICE.ResumeLayout(false);
            SERVICE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgServices).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ROOM.ResumeLayout(false);
            ROOM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgAllRoom).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            CLIENT.ResumeLayout(false);
            CLIENT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgClients).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            RESERVATION.ResumeLayout(false);
            RESERVATION.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgViewAllReservations).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            HOME.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgRoomsReservation).EndInit();
            materialTabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private TabPage TREATMENT;
        private MaterialSkin.Controls.MaterialButton btnUpdateTreatment;
        private DataGridView dtgTreatment;
        private GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialButton btnAddTreatment;
        private MaterialSkin.Controls.MaterialTextBox2 txtAddTreatmentName;
        private Label label9;
        private MaterialSkin.Controls.MaterialTextBox2 txtAddTReatmentPrice;
        private TabPage ROOM_TYPE;
        private MaterialSkin.Controls.MaterialButton btnUpdateRoomType;
        private DataGridView dtgRoomsType;
        private GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton btnAddRoomType;
        private MaterialSkin.Controls.MaterialTextBox2 txtAddRoomTypeName;
        private MaterialSkin.Controls.MaterialTextBox2 txtAddRoomTypePrice;
        private TabPage SERVICE;
        private MaterialSkin.Controls.MaterialButton btnUpdateService;
        private DataGridView dtgServices;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btnAddService;
        private MaterialSkin.Controls.MaterialTextBox2 txtAddServiceName;
        private MaterialSkin.Controls.MaterialTextBox2 txtAddServicePrice;
        private TabPage ROOM;
        private DataGridView dtgAllRoom;
        private MaterialSkin.Controls.MaterialTextBox2 txtRoomNumber;
        private MaterialSkin.Controls.MaterialButton btnAddRoom;
        private CheckedListBox clstAddRoomServices;
        private ListBox lstAddRoomSelectType;
        private MaterialSkin.Controls.MaterialTextBox2 txtAddRoomMaxPeople;
        private TabPage CLIENT;
        private MaterialSkin.Controls.MaterialButton btnUpdateClients;
        private DataGridView dtgClients;
        private GroupBox groupBox1;
        private Label label2;
        private MaterialSkin.Controls.MaterialTextBox2 txtAddClientSuname;
        private MaterialSkin.Controls.MaterialButton btnAddClient;
        private Label label3;
        private MaterialSkin.Controls.MaterialTextBox2 txtAddClientName;
        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox2 txtAddClientMail;
        private TabPage RESERVATION;
        private DataGridView dtgViewAllReservations;
        private ComboBox cboAddReservationPeopleNum;
        private Label label12;
        private MaterialSkin.Controls.MaterialButton btnAddReservationDate;
        private ListBox lstAddReservationTreatment;
        private ListBox lstAddReservationClient;
        private ListBox lstAddResrvationRoomAvailable;
        private DateTimePicker dtpAddReservationCheckOut;
        private DateTimePicker dtpAddReservationCheckIn;
        private GroupBox groupBox5;
        private MaterialSkin.Controls.MaterialButton btnAddReservation;
        private TabPage HOME;
        private DateTimePicker dtpHomeEnd;
        private DataGridView dtgRoomsReservation;
        private DateTimePicker dtpHomeStart;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private Label label8;
        private Label label4;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label10;
        private Label label11;
        private Label label14;
        private Label label13;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private MaterialSkin.Controls.MaterialButton btnChangeDate;
        private MaterialSkin.Controls.MaterialButton btnDeleteReservation;
    }
}