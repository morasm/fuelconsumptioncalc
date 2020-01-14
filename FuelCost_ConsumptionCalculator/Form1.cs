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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearFrm();
            PopulateGridViewCar();
        }

        //usr section

        private void BtnUsrCancel_Click(object sender, EventArgs e)
        {
            ClearFrm();
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
                    db.SaveChanges();
                }
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
            txtEmail.Text = txtFirstName.Text = txtLastName.Text = txtAmount.Text = txtCarMake.Text = txtCarModel.Text = txtCarRegNr.Text = "";
            btnCarDelete.Enabled = false;
            btnUserDelete.Enabled = false;
            btnUserSave.Text = "Save";
            btnCarSave.Text = "Save";
        }


    }
}
