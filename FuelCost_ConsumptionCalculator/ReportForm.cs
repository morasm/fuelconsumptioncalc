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
    public partial class ReportForm: Form
    {

        TravelService ts = new TravelService();
        RefuellingService rs = new RefuellingService();

        private int monthNumber;

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            
            monthNumber = MainForm.MonthReport;
                
            String trDescr = "Monthly report of business travels:\r\n";
            String refDescr = "\r\nMonthly report of refuellings:\r\n";

            List<Travel> travels = ts.GetAllByMonth(monthNumber);
            foreach (Travel tr in travels) {
                trDescr += tr.DateTravel.ToShortDateString() + " " + tr.User.FirstName + " " + tr.User.LastName + " " + tr.TravelPurpose + "\r\n";
                    }

            List<Refuelling> refuellings = rs.GetAllByMonth(monthNumber);
            foreach (Refuelling refuelling in refuellings) {
                refDescr += refuelling.DateRefuel.ToShortDateString() + " " + refuelling.Car.CarRegNr + " " + " " + refuelling.Cost.ToString() + "zł \r\n";
            }
            txtReport.Text = trDescr + "\r\n" + refDescr;
        }

        private void BtnCloseReport_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }


    }
}
