using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelCost_ConsumptionCalculator
{
    public partial class Form1 : Form
    {

        Car carDBModel = new Car();
        User userDBModel = new User();
        Refuelling refuelDBModel = new Refuelling();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearFrm();
            PopulateGridViewUser();
            PopulateGridViewCar();
            FillDropdownUserList();
            FillDropdownCarList();
        }
        //section for adding refuelling

        private void FillDropdownUserList() {
            using (FuelCalcEntities db = new FuelCalcEntities()) {
                cbUser.DataSource = db.User.ToList<User>();
                cbUser.DisplayMember = "LastName";
                cbUser.ValueMember = "UserId";
            }
        }

        private void FillDropdownCarList()
        {
            using (FuelCalcEntities db = new FuelCalcEntities())
            {
                List<Car> cars = db.Car.ToList<Car>();
                var cbDict = new Dictionary<int, string>();
                foreach (var car in cars) {
                    cbDict.Add(car.CarId, 
                        car.CarMake.ToString() +
                        " " + car.CarModel.ToString() + 
                        " " + car.CarRegNr.ToString());
                }
                cbCar.DataSource = new BindingSource(cbDict, null);
                cbCar.DisplayMember = "Value";
                cbCar.ValueMember = "Key";
            }
        }
        //section refueling

        private void btnRefuellingCancel_Click(object sender, EventArgs e)
        {
            ClearFrm();
        }

        private void btnRefuellingSave_Click(object sender, EventArgs e)
        {
            refuelDBModel.Amount = Convert.ToDouble(txtAmount.Text.Trim());
            refuelDBModel.Cost = Convert.ToDouble(txtCost.Text.Trim());
            refuelDBModel.Mileage = Convert.ToDouble(txtMileage.Text.Trim());
            refuelDBModel.fk_CarId = Convert.ToInt32(cbCar.SelectedValue.ToString());
            refuelDBModel.fk_UserId = Convert.ToInt32(cbUser.SelectedValue.ToString());
            refuelDBModel.DateRefuel = dateTimeRefuel.Value;

            using (FuelCalcEntities db = new FuelCalcEntities()) {
                if (refuelDBModel.RefuelingId == 0) {
                    db.Refuelling.Add(refuelDBModel);
                }
                else {
                    db.Entry(refuelDBModel).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }
        }
        //section for adding users and cars
        //user section

        private void BtnUsrCancel_Click(object sender, EventArgs e)
        {
            ClearFrm();
        }

        private void BtnUserSave_Click(object sender, EventArgs e)
        {
            userDBModel.FirstName = txtFirstName.Text.Trim();
            userDBModel.LastName = txtLastName.Text.Trim();
            userDBModel.Email = txtEmail.Text.Trim();

            using (FuelCalcEntities db = new FuelCalcEntities()) {
                if (userDBModel.UserId == 0) {
                    db.User.Add(userDBModel);
                }
                else {
                    db.Entry(userDBModel).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }
            ClearFrm();
            PopulateGridViewUser();
            MessageBox.Show("Submitted successfully!");
        }

        void PopulateGridViewUser() {
            using (FuelCalcEntities db = new FuelCalcEntities()) {
                dataGridViewUser.DataSource = db.User.ToList<User>();
            }
        }

        private void DataGridViewUser_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewUser.CurrentCell.RowIndex != -1) {
                userDBModel.UserId = Convert.ToInt32(dataGridViewUser.CurrentRow.Cells["UserId"].Value);
                using (FuelCalcEntities db = new FuelCalcEntities()) {
                    userDBModel = db.User.Where(x => x.UserId == userDBModel.UserId).FirstOrDefault();
                    txtFirstName.Text = userDBModel.FirstName;
                    txtLastName.Text = userDBModel.LastName;
                    txtEmail.Text = userDBModel.Email;
                }
                btnUserDelete.Enabled = true;
                btnUserSave.Text = "Update";
            }
        }

        private void BtnUserDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?", "Car delete operation", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                using (FuelCalcEntities db = new FuelCalcEntities()) {
                    var entry = db.Entry(userDBModel);
                    if (entry.State == System.Data.Entity.EntityState.Detached) {
                        db.User.Attach(userDBModel);
                    }
                    db.User.Remove(userDBModel);
                    db.SaveChanges();
                    PopulateGridViewUser();
                    ClearFrm();
                    MessageBox.Show("Deleted successfully!");
                }
            }
        }

        //car section

        private void BtnCarCancel_Click(object sender, EventArgs e)
        {
            ClearFrm();
        }

        private void BtnCarSave_Click(object sender, EventArgs e)
        {
            carDBModel.CarMake = txtCarMake.Text.Trim();
            carDBModel.CarModel = txtCarModel.Text.Trim();
            carDBModel.CarRegNr = txtCarRegNr.Text.ToUpper().Replace(" ","").Trim();

            using (FuelCalcEntities db = new FuelCalcEntities()) {
                if (carDBModel.CarId == 0) { //table empty, adding row
                    db.Car.Add(carDBModel);

                }
                else { //update row
                    db.Entry(carDBModel).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
            }
            ClearFrm();
            PopulateGridViewCar();
            MessageBox.Show("Submitted successfully!");
        }

        void PopulateGridViewCar() {
            using (FuelCalcEntities db = new FuelCalcEntities()) {
                dataGridViewCar.DataSource = db.Car.ToList<Car>();
            }
        }

        private void DataGridViewCar_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewCar.CurrentCell.RowIndex != -1) {
                carDBModel.CarId = Convert.ToInt32(dataGridViewCar.CurrentRow.Cells["CarId"].Value);
                using (FuelCalcEntities db = new FuelCalcEntities()) {
                    carDBModel = db.Car.Where(x => x.CarId == carDBModel.CarId).FirstOrDefault();
                    txtCarMake.Text = carDBModel.CarMake;
                    txtCarModel.Text = carDBModel.CarModel;
                    txtCarRegNr.Text = carDBModel.CarRegNr;
                }
                btnCarDelete.Enabled = true;
                btnCarSave.Text = "Update";
            }
        }

        private void BtnCarDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record?", "Car delete operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (FuelCalcEntities db = new FuelCalcEntities())
                {
                    var entry = db.Entry(carDBModel);
                    if (entry.State == System.Data.Entity.EntityState.Detached) {
                        db.Car.Attach(carDBModel);
                    }
                    db.Car.Remove(carDBModel);
                    db.SaveChanges();
                    PopulateGridViewCar();
                    ClearFrm();
                    MessageBox.Show("Deleted successfully!");
                }
            }
        }
        //common methods

        void ClearFrm() {
            txtEmail.Text = txtFirstName.Text = txtLastName.Text = txtAmount.Text = txtCost.Text = txtMileage.Text = txtCarMake.Text = txtCarModel.Text = txtCarRegNr.Text = "";
            btnCarDelete.Enabled = false;
            btnUserDelete.Enabled = false;
            carDBModel.CarId = 0;
            userDBModel.UserId = 0;
            btnUserSave.Text = "Save";
            btnCarSave.Text = "Save";
        }

    }
}
