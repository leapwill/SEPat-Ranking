/*
    SEPatRanking
    Copyright (C) 2015 Newman Smith Science and Engineering Pathway

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    The GNU GPL is available to read at <http://www.gnu.org/licenses/>.
*/

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
