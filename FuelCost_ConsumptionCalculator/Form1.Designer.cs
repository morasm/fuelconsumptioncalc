namespace FuelCost_ConsumptionCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRefuelling = new System.Windows.Forms.TabPage();
            this.lblDateOfRefuelling = new System.Windows.Forms.Label();
            this.btnRefuellingCancel = new System.Windows.Forms.Button();
            this.labelMileage = new System.Windows.Forms.Label();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.labelCostRefuel = new System.Windows.Forms.Label();
            this.cbCar = new System.Windows.Forms.ComboBox();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.dateTimeRefuel = new System.Windows.Forms.DateTimePicker();
            this.labelUserRefuel = new System.Windows.Forms.Label();
            this.labelCarRefuel = new System.Windows.Forms.Label();
            this.btnRefuellingSave = new System.Windows.Forms.Button();
            this.labelAmountRefuel = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.tabPageTravel = new System.Windows.Forms.TabPage();
            this.labelTravelTargetMileage = new System.Windows.Forms.Label();
            this.txtTravelTargetMileage = new System.Windows.Forms.TextBox();
            this.labelTravelStartMileage = new System.Windows.Forms.Label();
            this.txtTravelStartMileage = new System.Windows.Forms.TextBox();
            this.labelDateTravel = new System.Windows.Forms.Label();
            this.btnCancelTravel = new System.Windows.Forms.Button();
            this.labelTravelPurpose = new System.Windows.Forms.Label();
            this.txtTravelPurpose = new System.Windows.Forms.TextBox();
            this.txtTravelTarget = new System.Windows.Forms.TextBox();
            this.labelTravelTarget = new System.Windows.Forms.Label();
            this.cbCarTravel = new System.Windows.Forms.ComboBox();
            this.cbUserTravel = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTravel = new System.Windows.Forms.DateTimePicker();
            this.labelUserTravel = new System.Windows.Forms.Label();
            this.labelCarTravel = new System.Windows.Forms.Label();
            this.btnSaveTravel = new System.Windows.Forms.Button();
            this.labelTravelStart = new System.Windows.Forms.Label();
            this.txtTravelStart = new System.Windows.Forms.TextBox();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.labelUserDB = new System.Windows.Forms.Label();
            this.labelCarsDB = new System.Windows.Forms.Label();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCar = new System.Windows.Forms.DataGridView();
            this.CarID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarMake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarRegNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCarCancel = new System.Windows.Forms.Button();
            this.txtCarRegNr = new System.Windows.Forms.TextBox();
            this.btnCarDelete = new System.Windows.Forms.Button();
            this.labelCarRegNr = new System.Windows.Forms.Label();
            this.btnCarSave = new System.Windows.Forms.Button();
            this.labelCarModel = new System.Windows.Forms.Label();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.labelCarMake = new System.Windows.Forms.Label();
            this.txtCarMake = new System.Windows.Forms.TextBox();
            this.btnUsrCancel = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.labelUserConf = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelCarConf = new System.Windows.Forms.Label();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.labelLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageRefuelling.SuspendLayout();
            this.tabPageTravel.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRefuelling);
            this.tabControl1.Controls.Add(this.tabPageTravel);
            this.tabControl1.Controls.Add(this.tabPageConfig);
            this.tabControl1.Controls.Add(this.tabPageReports);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 417);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageRefuelling
            // 
            this.tabPageRefuelling.Controls.Add(this.lblDateOfRefuelling);
            this.tabPageRefuelling.Controls.Add(this.btnRefuellingCancel);
            this.tabPageRefuelling.Controls.Add(this.labelMileage);
            this.tabPageRefuelling.Controls.Add(this.txtMileage);
            this.tabPageRefuelling.Controls.Add(this.txtCost);
            this.tabPageRefuelling.Controls.Add(this.labelCostRefuel);
            this.tabPageRefuelling.Controls.Add(this.cbCar);
            this.tabPageRefuelling.Controls.Add(this.cbUser);
            this.tabPageRefuelling.Controls.Add(this.dateTimeRefuel);
            this.tabPageRefuelling.Controls.Add(this.labelUserRefuel);
            this.tabPageRefuelling.Controls.Add(this.labelCarRefuel);
            this.tabPageRefuelling.Controls.Add(this.btnRefuellingSave);
            this.tabPageRefuelling.Controls.Add(this.labelAmountRefuel);
            this.tabPageRefuelling.Controls.Add(this.txtAmount);
            this.tabPageRefuelling.Location = new System.Drawing.Point(4, 22);
            this.tabPageRefuelling.Name = "tabPageRefuelling";
            this.tabPageRefuelling.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRefuelling.Size = new System.Drawing.Size(752, 391);
            this.tabPageRefuelling.TabIndex = 0;
            this.tabPageRefuelling.Text = "Add refuelling";
            this.tabPageRefuelling.UseVisualStyleBackColor = true;
            // 
            // lblDateOfRefuelling
            // 
            this.lblDateOfRefuelling.AutoSize = true;
            this.lblDateOfRefuelling.Location = new System.Drawing.Point(24, 159);
            this.lblDateOfRefuelling.Name = "lblDateOfRefuelling";
            this.lblDateOfRefuelling.Size = new System.Drawing.Size(30, 13);
            this.lblDateOfRefuelling.TabIndex = 26;
            this.lblDateOfRefuelling.Text = "Date";
            // 
            // btnRefuellingCancel
            // 
            this.btnRefuellingCancel.Location = new System.Drawing.Point(108, 179);
            this.btnRefuellingCancel.Name = "btnRefuellingCancel";
            this.btnRefuellingCancel.Size = new System.Drawing.Size(75, 23);
            this.btnRefuellingCancel.TabIndex = 25;
            this.btnRefuellingCancel.Text = "Cancel";
            this.btnRefuellingCancel.UseVisualStyleBackColor = true;
            this.btnRefuellingCancel.Click += new System.EventHandler(this.BtnRefuellingCancel_Click);
            // 
            // labelMileage
            // 
            this.labelMileage.AutoSize = true;
            this.labelMileage.Location = new System.Drawing.Point(24, 130);
            this.labelMileage.Name = "labelMileage";
            this.labelMileage.Size = new System.Drawing.Size(44, 13);
            this.labelMileage.TabIndex = 14;
            this.labelMileage.Text = "Mileage";
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(105, 127);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(100, 20);
            this.txtMileage.TabIndex = 13;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(105, 101);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 12;
            // 
            // labelCostRefuel
            // 
            this.labelCostRefuel.AutoSize = true;
            this.labelCostRefuel.Location = new System.Drawing.Point(24, 104);
            this.labelCostRefuel.Name = "labelCostRefuel";
            this.labelCostRefuel.Size = new System.Drawing.Size(28, 13);
            this.labelCostRefuel.TabIndex = 11;
            this.labelCostRefuel.Text = "Cost";
            // 
            // cbCar
            // 
            this.cbCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCar.FormattingEnabled = true;
            this.cbCar.Location = new System.Drawing.Point(105, 45);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(200, 21);
            this.cbCar.TabIndex = 10;
            // 
            // cbUser
            // 
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(105, 19);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(200, 21);
            this.cbUser.TabIndex = 9;
            // 
            // dateTimeRefuel
            // 
            this.dateTimeRefuel.CustomFormat = "yyyy-MM-dd";
            this.dateTimeRefuel.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeRefuel.Location = new System.Drawing.Point(105, 153);
            this.dateTimeRefuel.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimeRefuel.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTimeRefuel.Name = "dateTimeRefuel";
            this.dateTimeRefuel.Size = new System.Drawing.Size(100, 20);
            this.dateTimeRefuel.TabIndex = 8;
            // 
            // labelUserRefuel
            // 
            this.labelUserRefuel.AutoSize = true;
            this.labelUserRefuel.Location = new System.Drawing.Point(24, 27);
            this.labelUserRefuel.Name = "labelUserRefuel";
            this.labelUserRefuel.Size = new System.Drawing.Size(29, 13);
            this.labelUserRefuel.TabIndex = 6;
            this.labelUserRefuel.Text = "User";
            // 
            // labelCarRefuel
            // 
            this.labelCarRefuel.AutoSize = true;
            this.labelCarRefuel.Location = new System.Drawing.Point(24, 53);
            this.labelCarRefuel.Name = "labelCarRefuel";
            this.labelCarRefuel.Size = new System.Drawing.Size(23, 13);
            this.labelCarRefuel.TabIndex = 5;
            this.labelCarRefuel.Text = "Car";
            // 
            // btnRefuellingSave
            // 
            this.btnRefuellingSave.Location = new System.Drawing.Point(27, 179);
            this.btnRefuellingSave.Name = "btnRefuellingSave";
            this.btnRefuellingSave.Size = new System.Drawing.Size(75, 23);
            this.btnRefuellingSave.TabIndex = 4;
            this.btnRefuellingSave.Text = "Save";
            this.btnRefuellingSave.UseVisualStyleBackColor = true;
            this.btnRefuellingSave.Click += new System.EventHandler(this.BtnRefuellingSave_Click);
            // 
            // labelAmountRefuel
            // 
            this.labelAmountRefuel.AutoSize = true;
            this.labelAmountRefuel.Location = new System.Drawing.Point(24, 78);
            this.labelAmountRefuel.Name = "labelAmountRefuel";
            this.labelAmountRefuel.Size = new System.Drawing.Size(75, 13);
            this.labelAmountRefuel.TabIndex = 3;
            this.labelAmountRefuel.Text = "Amount of fuel";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(105, 75);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // tabPageTravel
            // 
            this.tabPageTravel.Controls.Add(this.labelTravelTargetMileage);
            this.tabPageTravel.Controls.Add(this.txtTravelTargetMileage);
            this.tabPageTravel.Controls.Add(this.labelTravelStartMileage);
            this.tabPageTravel.Controls.Add(this.txtTravelStartMileage);
            this.tabPageTravel.Controls.Add(this.labelDateTravel);
            this.tabPageTravel.Controls.Add(this.btnCancelTravel);
            this.tabPageTravel.Controls.Add(this.labelTravelPurpose);
            this.tabPageTravel.Controls.Add(this.txtTravelPurpose);
            this.tabPageTravel.Controls.Add(this.txtTravelTarget);
            this.tabPageTravel.Controls.Add(this.labelTravelTarget);
            this.tabPageTravel.Controls.Add(this.cbCarTravel);
            this.tabPageTravel.Controls.Add(this.cbUserTravel);
            this.tabPageTravel.Controls.Add(this.dateTimePickerTravel);
            this.tabPageTravel.Controls.Add(this.labelUserTravel);
            this.tabPageTravel.Controls.Add(this.labelCarTravel);
            this.tabPageTravel.Controls.Add(this.btnSaveTravel);
            this.tabPageTravel.Controls.Add(this.labelTravelStart);
            this.tabPageTravel.Controls.Add(this.txtTravelStart);
            this.tabPageTravel.Location = new System.Drawing.Point(4, 22);
            this.tabPageTravel.Name = "tabPageTravel";
            this.tabPageTravel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTravel.Size = new System.Drawing.Size(752, 391);
            this.tabPageTravel.TabIndex = 3;
            this.tabPageTravel.Text = "Add travel";
            this.tabPageTravel.UseVisualStyleBackColor = true;
            // 
            // labelTravelTargetMileage
            // 
            this.labelTravelTargetMileage.AutoSize = true;
            this.labelTravelTargetMileage.Location = new System.Drawing.Point(31, 236);
            this.labelTravelTargetMileage.Name = "labelTravelTargetMileage";
            this.labelTravelTargetMileage.Size = new System.Drawing.Size(65, 13);
            this.labelTravelTargetMileage.TabIndex = 44;
            this.labelTravelTargetMileage.Text = "Mileage end";
            // 
            // txtTravelTargetMileage
            // 
            this.txtTravelTargetMileage.Location = new System.Drawing.Point(112, 233);
            this.txtTravelTargetMileage.Name = "txtTravelTargetMileage";
            this.txtTravelTargetMileage.Size = new System.Drawing.Size(100, 20);
            this.txtTravelTargetMileage.TabIndex = 43;
            // 
            // labelTravelStartMileage
            // 
            this.labelTravelStartMileage.AutoSize = true;
            this.labelTravelStartMileage.Location = new System.Drawing.Point(31, 210);
            this.labelTravelStartMileage.Name = "labelTravelStartMileage";
            this.labelTravelStartMileage.Size = new System.Drawing.Size(67, 13);
            this.labelTravelStartMileage.TabIndex = 42;
            this.labelTravelStartMileage.Text = "Mileage start";
            // 
            // txtTravelStartMileage
            // 
            this.txtTravelStartMileage.Location = new System.Drawing.Point(112, 207);
            this.txtTravelStartMileage.Name = "txtTravelStartMileage";
            this.txtTravelStartMileage.Size = new System.Drawing.Size(100, 20);
            this.txtTravelStartMileage.TabIndex = 41;
            // 
            // labelDateTravel
            // 
            this.labelDateTravel.AutoSize = true;
            this.labelDateTravel.Location = new System.Drawing.Point(34, 267);
            this.labelDateTravel.Name = "labelDateTravel";
            this.labelDateTravel.Size = new System.Drawing.Size(30, 13);
            this.labelDateTravel.TabIndex = 40;
            this.labelDateTravel.Text = "Date";
            // 
            // btnCancelTravel
            // 
            this.btnCancelTravel.Location = new System.Drawing.Point(115, 297);
            this.btnCancelTravel.Name = "btnCancelTravel";
            this.btnCancelTravel.Size = new System.Drawing.Size(75, 23);
            this.btnCancelTravel.TabIndex = 39;
            this.btnCancelTravel.Text = "Cancel";
            this.btnCancelTravel.UseVisualStyleBackColor = true;
            this.btnCancelTravel.Click += new System.EventHandler(this.BtnCancelTravel_Click);
            // 
            // labelTravelPurpose
            // 
            this.labelTravelPurpose.AutoSize = true;
            this.labelTravelPurpose.Location = new System.Drawing.Point(31, 130);
            this.labelTravelPurpose.Name = "labelTravelPurpose";
            this.labelTravelPurpose.Size = new System.Drawing.Size(46, 13);
            this.labelTravelPurpose.TabIndex = 38;
            this.labelTravelPurpose.Text = "Purpose";
            // 
            // txtTravelPurpose
            // 
            this.txtTravelPurpose.Location = new System.Drawing.Point(112, 127);
            this.txtTravelPurpose.Multiline = true;
            this.txtTravelPurpose.Name = "txtTravelPurpose";
            this.txtTravelPurpose.Size = new System.Drawing.Size(200, 74);
            this.txtTravelPurpose.TabIndex = 37;
            // 
            // txtTravelTarget
            // 
            this.txtTravelTarget.Location = new System.Drawing.Point(112, 101);
            this.txtTravelTarget.Name = "txtTravelTarget";
            this.txtTravelTarget.Size = new System.Drawing.Size(200, 20);
            this.txtTravelTarget.TabIndex = 36;
            // 
            // labelTravelTarget
            // 
            this.labelTravelTarget.AutoSize = true;
            this.labelTravelTarget.Location = new System.Drawing.Point(31, 104);
            this.labelTravelTarget.Name = "labelTravelTarget";
            this.labelTravelTarget.Size = new System.Drawing.Size(20, 13);
            this.labelTravelTarget.TabIndex = 35;
            this.labelTravelTarget.Text = "To";
            // 
            // cbCarTravel
            // 
            this.cbCarTravel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarTravel.FormattingEnabled = true;
            this.cbCarTravel.Location = new System.Drawing.Point(112, 45);
            this.cbCarTravel.Name = "cbCarTravel";
            this.cbCarTravel.Size = new System.Drawing.Size(200, 21);
            this.cbCarTravel.TabIndex = 34;
            // 
            // cbUserTravel
            // 
            this.cbUserTravel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserTravel.FormattingEnabled = true;
            this.cbUserTravel.Location = new System.Drawing.Point(112, 19);
            this.cbUserTravel.Name = "cbUserTravel";
            this.cbUserTravel.Size = new System.Drawing.Size(200, 21);
            this.cbUserTravel.TabIndex = 33;
            // 
            // dateTimePickerTravel
            // 
            this.dateTimePickerTravel.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerTravel.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTravel.Location = new System.Drawing.Point(115, 261);
            this.dateTimePickerTravel.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerTravel.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerTravel.Name = "dateTimePickerTravel";
            this.dateTimePickerTravel.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerTravel.TabIndex = 32;
            // 
            // labelUserTravel
            // 
            this.labelUserTravel.AutoSize = true;
            this.labelUserTravel.Location = new System.Drawing.Point(31, 27);
            this.labelUserTravel.Name = "labelUserTravel";
            this.labelUserTravel.Size = new System.Drawing.Size(29, 13);
            this.labelUserTravel.TabIndex = 31;
            this.labelUserTravel.Text = "User";
            // 
            // labelCarTravel
            // 
            this.labelCarTravel.AutoSize = true;
            this.labelCarTravel.Location = new System.Drawing.Point(31, 53);
            this.labelCarTravel.Name = "labelCarTravel";
            this.labelCarTravel.Size = new System.Drawing.Size(23, 13);
            this.labelCarTravel.TabIndex = 30;
            this.labelCarTravel.Text = "Car";
            // 
            // btnSaveTravel
            // 
            this.btnSaveTravel.Location = new System.Drawing.Point(34, 297);
            this.btnSaveTravel.Name = "btnSaveTravel";
            this.btnSaveTravel.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTravel.TabIndex = 29;
            this.btnSaveTravel.Text = "Save";
            this.btnSaveTravel.UseVisualStyleBackColor = true;
            this.btnSaveTravel.Click += new System.EventHandler(this.BtnSaveTravel_Click);
            // 
            // labelTravelStart
            // 
            this.labelTravelStart.AutoSize = true;
            this.labelTravelStart.Location = new System.Drawing.Point(31, 78);
            this.labelTravelStart.Name = "labelTravelStart";
            this.labelTravelStart.Size = new System.Drawing.Size(30, 13);
            this.labelTravelStart.TabIndex = 28;
            this.labelTravelStart.Text = "From";
            // 
            // txtTravelStart
            // 
            this.txtTravelStart.Location = new System.Drawing.Point(112, 75);
            this.txtTravelStart.Name = "txtTravelStart";
            this.txtTravelStart.Size = new System.Drawing.Size(200, 20);
            this.txtTravelStart.TabIndex = 27;
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Controls.Add(this.labelUserDB);
            this.tabPageConfig.Controls.Add(this.labelCarsDB);
            this.tabPageConfig.Controls.Add(this.dataGridViewUser);
            this.tabPageConfig.Controls.Add(this.dataGridViewCar);
            this.tabPageConfig.Controls.Add(this.btnCarCancel);
            this.tabPageConfig.Controls.Add(this.txtCarRegNr);
            this.tabPageConfig.Controls.Add(this.btnCarDelete);
            this.tabPageConfig.Controls.Add(this.labelCarRegNr);
            this.tabPageConfig.Controls.Add(this.btnCarSave);
            this.tabPageConfig.Controls.Add(this.labelCarModel);
            this.tabPageConfig.Controls.Add(this.txtCarModel);
            this.tabPageConfig.Controls.Add(this.labelCarMake);
            this.tabPageConfig.Controls.Add(this.txtCarMake);
            this.tabPageConfig.Controls.Add(this.btnUsrCancel);
            this.tabPageConfig.Controls.Add(this.txtEmail);
            this.tabPageConfig.Controls.Add(this.btnUserDelete);
            this.tabPageConfig.Controls.Add(this.labelUserConf);
            this.tabPageConfig.Controls.Add(this.labelEmail);
            this.tabPageConfig.Controls.Add(this.labelCarConf);
            this.tabPageConfig.Controls.Add(this.btnUserSave);
            this.tabPageConfig.Controls.Add(this.labelLastName);
            this.tabPageConfig.Controls.Add(this.txtLastName);
            this.tabPageConfig.Controls.Add(this.labelFirstName);
            this.tabPageConfig.Controls.Add(this.txtFirstName);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfig.Size = new System.Drawing.Size(752, 391);
            this.tabPageConfig.TabIndex = 1;
            this.tabPageConfig.Text = "Configuration";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // labelUserDB
            // 
            this.labelUserDB.AutoSize = true;
            this.labelUserDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserDB.Location = new System.Drawing.Point(466, 13);
            this.labelUserDB.Name = "labelUserDB";
            this.labelUserDB.Size = new System.Drawing.Size(94, 17);
            this.labelUserDB.TabIndex = 28;
            this.labelUserDB.Text = "Users in DB";
            // 
            // labelCarsDB
            // 
            this.labelCarsDB.AutoSize = true;
            this.labelCarsDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCarsDB.Location = new System.Drawing.Point(466, 199);
            this.labelCarsDB.Name = "labelCarsDB";
            this.labelCarsDB.Size = new System.Drawing.Size(77, 17);
            this.labelCarsDB.TabIndex = 27;
            this.labelCarsDB.Text = "Car in DB";
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.FirstName,
            this.LastName,
            this.Email});
            this.dataGridViewUser.Location = new System.Drawing.Point(308, 33);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.Size = new System.Drawing.Size(438, 128);
            this.dataGridViewUser.TabIndex = 26;
            this.dataGridViewUser.DoubleClick += new System.EventHandler(this.DataGridViewUser_DoubleClick);
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // dataGridViewCar
            // 
            this.dataGridViewCar.AllowUserToDeleteRows = false;
            this.dataGridViewCar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarID,
            this.CarMake,
            this.CarModel,
            this.CarRegNr});
            this.dataGridViewCar.Location = new System.Drawing.Point(308, 219);
            this.dataGridViewCar.Name = "dataGridViewCar";
            this.dataGridViewCar.ReadOnly = true;
            this.dataGridViewCar.Size = new System.Drawing.Size(438, 128);
            this.dataGridViewCar.TabIndex = 25;
            this.dataGridViewCar.DoubleClick += new System.EventHandler(this.DataGridViewCar_DoubleClick);
            // 
            // CarID
            // 
            this.CarID.DataPropertyName = "CarId";
            this.CarID.HeaderText = "CarID";
            this.CarID.Name = "CarID";
            this.CarID.ReadOnly = true;
            this.CarID.Visible = false;
            // 
            // CarMake
            // 
            this.CarMake.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarMake.DataPropertyName = "CarMake";
            this.CarMake.FillWeight = 50F;
            this.CarMake.HeaderText = "Car make";
            this.CarMake.Name = "CarMake";
            this.CarMake.ReadOnly = true;
            // 
            // CarModel
            // 
            this.CarModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CarModel.DataPropertyName = "CarModel";
            this.CarModel.FillWeight = 50F;
            this.CarModel.HeaderText = "Car model";
            this.CarModel.Name = "CarModel";
            this.CarModel.ReadOnly = true;
            // 
            // CarRegNr
            // 
            this.CarRegNr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CarRegNr.DataPropertyName = "CarRegNr";
            this.CarRegNr.HeaderText = "Reg. number";
            this.CarRegNr.Name = "CarRegNr";
            this.CarRegNr.ReadOnly = true;
            this.CarRegNr.Width = 93;
            // 
            // btnCarCancel
            // 
            this.btnCarCancel.Location = new System.Drawing.Point(185, 324);
            this.btnCarCancel.Name = "btnCarCancel";
            this.btnCarCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCarCancel.TabIndex = 24;
            this.btnCarCancel.Text = "Cancel";
            this.btnCarCancel.UseVisualStyleBackColor = true;
            this.btnCarCancel.Click += new System.EventHandler(this.BtnCarCancel_Click);
            // 
            // txtCarRegNr
            // 
            this.txtCarRegNr.Location = new System.Drawing.Point(101, 264);
            this.txtCarRegNr.Name = "txtCarRegNr";
            this.txtCarRegNr.Size = new System.Drawing.Size(100, 20);
            this.txtCarRegNr.TabIndex = 23;
            // 
            // btnCarDelete
            // 
            this.btnCarDelete.Location = new System.Drawing.Point(104, 324);
            this.btnCarDelete.Name = "btnCarDelete";
            this.btnCarDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCarDelete.TabIndex = 22;
            this.btnCarDelete.Text = "Delete";
            this.btnCarDelete.UseVisualStyleBackColor = true;
            this.btnCarDelete.Click += new System.EventHandler(this.BtnCarDelete_Click);
            // 
            // labelCarRegNr
            // 
            this.labelCarRegNr.AutoSize = true;
            this.labelCarRegNr.Location = new System.Drawing.Point(20, 267);
            this.labelCarRegNr.Name = "labelCarRegNr";
            this.labelCarRegNr.Size = new System.Drawing.Size(38, 13);
            this.labelCarRegNr.TabIndex = 20;
            this.labelCarRegNr.Text = "RegNr";
            // 
            // btnCarSave
            // 
            this.btnCarSave.Location = new System.Drawing.Point(23, 324);
            this.btnCarSave.Name = "btnCarSave";
            this.btnCarSave.Size = new System.Drawing.Size(75, 23);
            this.btnCarSave.TabIndex = 19;
            this.btnCarSave.Text = "Save";
            this.btnCarSave.UseVisualStyleBackColor = true;
            this.btnCarSave.Click += new System.EventHandler(this.BtnCarSave_Click);
            // 
            // labelCarModel
            // 
            this.labelCarModel.AutoSize = true;
            this.labelCarModel.Location = new System.Drawing.Point(20, 245);
            this.labelCarModel.Name = "labelCarModel";
            this.labelCarModel.Size = new System.Drawing.Size(36, 13);
            this.labelCarModel.TabIndex = 18;
            this.labelCarModel.Text = "Model";
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(101, 242);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(100, 20);
            this.txtCarModel.TabIndex = 17;
            // 
            // labelCarMake
            // 
            this.labelCarMake.AutoSize = true;
            this.labelCarMake.Location = new System.Drawing.Point(20, 222);
            this.labelCarMake.Name = "labelCarMake";
            this.labelCarMake.Size = new System.Drawing.Size(34, 13);
            this.labelCarMake.TabIndex = 16;
            this.labelCarMake.Text = "Make";
            // 
            // txtCarMake
            // 
            this.txtCarMake.Location = new System.Drawing.Point(101, 219);
            this.txtCarMake.Name = "txtCarMake";
            this.txtCarMake.Size = new System.Drawing.Size(100, 20);
            this.txtCarMake.TabIndex = 15;
            // 
            // btnUsrCancel
            // 
            this.btnUsrCancel.Location = new System.Drawing.Point(185, 138);
            this.btnUsrCancel.Name = "btnUsrCancel";
            this.btnUsrCancel.Size = new System.Drawing.Size(75, 23);
            this.btnUsrCancel.TabIndex = 14;
            this.btnUsrCancel.Text = "Cancel";
            this.btnUsrCancel.UseVisualStyleBackColor = true;
            this.btnUsrCancel.Click += new System.EventHandler(this.BtnUsrCancel_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(101, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Location = new System.Drawing.Point(104, 138);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(75, 23);
            this.btnUserDelete.TabIndex = 12;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.BtnUserDelete_Click);
            // 
            // labelUserConf
            // 
            this.labelUserConf.AutoSize = true;
            this.labelUserConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserConf.Location = new System.Drawing.Point(20, 13);
            this.labelUserConf.Name = "labelUserConf";
            this.labelUserConf.Size = new System.Drawing.Size(142, 17);
            this.labelUserConf.TabIndex = 11;
            this.labelUserConf.Text = "User configuration";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(20, 81);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(72, 13);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email address";
            // 
            // labelCarConf
            // 
            this.labelCarConf.AutoSize = true;
            this.labelCarConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCarConf.Location = new System.Drawing.Point(20, 199);
            this.labelCarConf.Name = "labelCarConf";
            this.labelCarConf.Size = new System.Drawing.Size(133, 17);
            this.labelCarConf.TabIndex = 9;
            this.labelCarConf.Text = "Car configuration";
            // 
            // btnUserSave
            // 
            this.btnUserSave.Location = new System.Drawing.Point(23, 138);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(75, 23);
            this.btnUserSave.TabIndex = 8;
            this.btnUserSave.Text = "Save";
            this.btnUserSave.UseVisualStyleBackColor = true;
            this.btnUserSave.Click += new System.EventHandler(this.BtnUserSave_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(20, 59);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "Last name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(101, 56);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(20, 36);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(55, 13);
            this.labelFirstName.TabIndex = 5;
            this.labelFirstName.Text = "First name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(101, 33);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // tabPageReports
            // 
            this.tabPageReports.Location = new System.Drawing.Point(4, 22);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Size = new System.Drawing.Size(752, 391);
            this.tabPageReports.TabIndex = 2;
            this.tabPageReports.Text = "Reports";
            this.tabPageReports.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Fuel cost & consumption calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRefuelling.ResumeLayout(false);
            this.tabPageRefuelling.PerformLayout();
            this.tabPageTravel.ResumeLayout(false);
            this.tabPageTravel.PerformLayout();
            this.tabPageConfig.ResumeLayout(false);
            this.tabPageConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRefuelling;
        private System.Windows.Forms.Label labelAmountRefuel;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.TabPage tabPageReports;
        private System.Windows.Forms.Button btnRefuellingSave;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dateTimeRefuel;
        private System.Windows.Forms.Label labelUserRefuel;
        private System.Windows.Forms.Label labelCarRefuel;
        private System.Windows.Forms.Button btnCarCancel;
        private System.Windows.Forms.TextBox txtCarRegNr;
        private System.Windows.Forms.Button btnCarDelete;
        private System.Windows.Forms.Label labelCarRegNr;
        private System.Windows.Forms.Button btnCarSave;
        private System.Windows.Forms.Label labelCarModel;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.Label labelCarMake;
        private System.Windows.Forms.TextBox txtCarMake;
        private System.Windows.Forms.Button btnUsrCancel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Label labelUserConf;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelCarConf;
        private System.Windows.Forms.Label labelUserDB;
        private System.Windows.Forms.Label labelCarsDB;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.DataGridView dataGridViewCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarMake;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarRegNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.ComboBox cbCar;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label labelCostRefuel;
        private System.Windows.Forms.Label labelMileage;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.Button btnRefuellingCancel;
        private System.Windows.Forms.Label lblDateOfRefuelling;
        private System.Windows.Forms.TabPage tabPageTravel;
        private System.Windows.Forms.Label labelTravelTargetMileage;
        private System.Windows.Forms.TextBox txtTravelTargetMileage;
        private System.Windows.Forms.Label labelTravelStartMileage;
        private System.Windows.Forms.TextBox txtTravelStartMileage;
        private System.Windows.Forms.Label labelDateTravel;
        private System.Windows.Forms.Button btnCancelTravel;
        private System.Windows.Forms.Label labelTravelPurpose;
        private System.Windows.Forms.TextBox txtTravelPurpose;
        private System.Windows.Forms.TextBox txtTravelTarget;
        private System.Windows.Forms.Label labelTravelTarget;
        private System.Windows.Forms.ComboBox cbCarTravel;
        private System.Windows.Forms.ComboBox cbUserTravel;
        private System.Windows.Forms.DateTimePicker dateTimePickerTravel;
        private System.Windows.Forms.Label labelUserTravel;
        private System.Windows.Forms.Label labelCarTravel;
        private System.Windows.Forms.Button btnSaveTravel;
        private System.Windows.Forms.Label labelTravelStart;
        private System.Windows.Forms.TextBox txtTravelStart;
    }
}

