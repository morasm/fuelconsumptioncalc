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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimeRefuel = new System.Windows.Forms.DateTimePicker();
            this.labelUserRefuel = new System.Windows.Forms.Label();
            this.labelCarRefuel = new System.Windows.Forms.Label();
            this.btnRefuellingSave = new System.Windows.Forms.Button();
            this.labelAmountRefuel = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.cbCar = new System.Windows.Forms.ComboBox();
            this.labelCostRefuel = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.labelMileage = new System.Windows.Forms.Label();
            this.btnRefuellingCancel = new System.Windows.Forms.Button();
            this.lblDateOfRefuelling = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 417);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblDateOfRefuelling);
            this.tabPage1.Controls.Add(this.btnRefuellingCancel);
            this.tabPage1.Controls.Add(this.labelMileage);
            this.tabPage1.Controls.Add(this.txtMileage);
            this.tabPage1.Controls.Add(this.txtCost);
            this.tabPage1.Controls.Add(this.labelCostRefuel);
            this.tabPage1.Controls.Add(this.cbCar);
            this.tabPage1.Controls.Add(this.cbUser);
            this.tabPage1.Controls.Add(this.dateTimeRefuel);
            this.tabPage1.Controls.Add(this.labelUserRefuel);
            this.tabPage1.Controls.Add(this.labelCarRefuel);
            this.tabPage1.Controls.Add(this.btnRefuellingSave);
            this.tabPage1.Controls.Add(this.labelAmountRefuel);
            this.tabPage1.Controls.Add(this.txtAmount);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add refuelling";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.btnRefuellingSave.Click += new System.EventHandler(this.btnRefuellingSave_Click);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelUserDB);
            this.tabPage2.Controls.Add(this.labelCarsDB);
            this.tabPage2.Controls.Add(this.dataGridViewUser);
            this.tabPage2.Controls.Add(this.dataGridViewCar);
            this.tabPage2.Controls.Add(this.btnCarCancel);
            this.tabPage2.Controls.Add(this.txtCarRegNr);
            this.tabPage2.Controls.Add(this.btnCarDelete);
            this.tabPage2.Controls.Add(this.labelCarRegNr);
            this.tabPage2.Controls.Add(this.btnCarSave);
            this.tabPage2.Controls.Add(this.labelCarModel);
            this.tabPage2.Controls.Add(this.txtCarModel);
            this.tabPage2.Controls.Add(this.labelCarMake);
            this.tabPage2.Controls.Add(this.txtCarMake);
            this.tabPage2.Controls.Add(this.btnUsrCancel);
            this.tabPage2.Controls.Add(this.txtEmail);
            this.tabPage2.Controls.Add(this.btnUserDelete);
            this.tabPage2.Controls.Add(this.labelUserConf);
            this.tabPage2.Controls.Add(this.labelEmail);
            this.tabPage2.Controls.Add(this.labelCarConf);
            this.tabPage2.Controls.Add(this.btnUserSave);
            this.tabPage2.Controls.Add(this.labelLastName);
            this.tabPage2.Controls.Add(this.txtLastName);
            this.tabPage2.Controls.Add(this.labelFirstName);
            this.tabPage2.Controls.Add(this.txtFirstName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(752, 391);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reports";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // cbCar
            // 
            this.cbCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCar.FormattingEnabled = true;
            this.cbCar.Location = new System.Drawing.Point(105, 45);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(200, 21);
            this.cbCar.TabIndex = 10;
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
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(105, 101);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 12;
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(105, 127);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(100, 20);
            this.txtMileage.TabIndex = 13;
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
            // btnRefuellingCancel
            // 
            this.btnRefuellingCancel.Location = new System.Drawing.Point(108, 179);
            this.btnRefuellingCancel.Name = "btnRefuellingCancel";
            this.btnRefuellingCancel.Size = new System.Drawing.Size(75, 23);
            this.btnRefuellingCancel.TabIndex = 25;
            this.btnRefuellingCancel.Text = "Cancel";
            this.btnRefuellingCancel.UseVisualStyleBackColor = true;
            this.btnRefuellingCancel.Click += new System.EventHandler(this.btnRefuellingCancel_Click);
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelAmountRefuel;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
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
    }
}

