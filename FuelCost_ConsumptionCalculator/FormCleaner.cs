using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelCost_ConsumptionCalculator
{
    class FormCleaner
    {
        public FormCleaner() { }

        public void ClearForm(TabControl tc)
        {
            foreach (TabPage tab in tc.TabPages)
            {
                foreach (Control ctrl in tab.Controls)
                    if (ctrl is TextBox)
                    {
                        ctrl.Text = "";
                    }
            }
        }
    }
}
