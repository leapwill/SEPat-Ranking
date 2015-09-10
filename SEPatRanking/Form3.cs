using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SEPatRanking
{
    public partial class ExtracurricularHelpActivity : System.Windows.Forms.Form
    {
        public ExtracurricularHelpActivity()
        {
            InitializeComponent();
        }

        int count = 0;

        private void buttonExtracurricularCountApply_Click(object sender, EventArgs e)
        {
            if (checkBoxBand.Checked) count += 3;
            if (checkBoxSports.Checked) count += 3;
            if (checkBoxFineArts.Checked) count += 2;
            if (checkBoxDance.Checked) count += 2;
            if (checkBoxNHS.Checked) count += 2;
            count += (int)numericUpDownOtherClubs.Value;
            this.Close();
        }

        public int getExtracurricularPoints()
        {
            return count;
        }
    }
}
