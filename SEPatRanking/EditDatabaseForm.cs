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

namespace SEPatRanking
{
    public partial class ViewDatabaseActivity : System.Windows.Forms.Form
    {

        public ViewDatabaseActivity()
        {
            InitializeComponent();
        }

        public ViewDatabaseActivity(string str)
        {
            InitializeComponent();
            studentsBindingSource.Filter = str;
            studentsTableAdapter.Fill(sEPat_TestDataSet.Students);
        }

        private void ViewDatabaseActivity_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sEPat_TestDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.sEPat_TestDataSet.Students);

        }
    }
}
