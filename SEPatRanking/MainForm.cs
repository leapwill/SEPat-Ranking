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
using System.Data.OleDb;

namespace SEPatRanking
{
    public partial class MainActivity : System.Windows.Forms.Form
    {
        public MainActivity()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.sEPat_TestDataSet.Students);
            this.comboBoxSearchSelector.SelectedItem = "LastName";
            this.toolTip1.SetToolTip(this.buttonMultiSelectAttendance, "Ctrl+Click to select then click to +1 attendance");
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            //http://www.w3schools.com/sql/sql_quickref.asp
            //http://stackoverflow.com/questions/19275557/c-sharp-inserting-data-from-a-form-into-an-access-database
            //https://msdn.microsoft.com/en-us/library/system.data.oledb.oledbdataadapter%28v=vs.110%29.aspx

            //WTJTODO: Check if student already exists in DB and edit entry (instead of add) if true

            //start of checkForDupe
            bool duplicate = false;
            studentsBindingSource2.RemoveFilter();
            
                if (studentsBindingSource2.Contains(textBoxID.Text))
                {
                    duplicate = true;
                }
                else { }
            

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = SEPatRanking.Properties.Settings.Default.SEPat_TestConnectionString;
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;

            if (duplicate) //edit the currently entered student because it already exists with other information
            {
                //"UPDATE Students\nSET "+ column + "\'=" + newValue + "\'\nWHERE IDNumber=\'" + textBoxID.Text + "\';";
                if (textBoxAttendance.Text != "")
                {
                    cmd.CommandText = "UPDATE Students\nSET " + "Attendance" + "\'=" + textBoxAttendance.Text + "\'\nWHERE IDNumber=\'" + textBoxID.Text + "\';";
                    executeOleDbNonQuery(conn, cmd);
                }
            }
            else //add a new student (because the ID number doesn't already exist)
            {
                //this uses an OleDb (SQL interface between C# and Access) but it'd probably be better to put it
                //in the bindingSource or tableAdapter than directly into the Access file
                cmd.CommandText = "INSERT INTO Students (LastName,FirstName,GPA,ExtracurricularPoints,Attendance,IDNumber) VALUES (\'" + textBoxLastName.Text + "\',\'" + textBoxFirstName.Text + "\',\'" + textBoxGPA.Text + "\',\'" + textBoxExtracurricular.Text + "\',\'" + textBoxAttendance.Text + "\',\'" + textBoxID.Text + "\');";
                executeOleDbNonQuery(conn, cmd);
                //MessageBox.Show(cmd.CommandText.ToString());  //debug by showing SQL command before executing
                
            }

        }

        public void executeOleDbNonQuery(OleDbConnection conn, OleDbCommand cmd)
        {
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Student entry added!");
                conn.Close();
                studentsTableAdapter.Fill(sEPat_TestDataSet.Students);
                textBoxLastName.Clear();
                textBoxFirstName.Clear();
                textBoxID.Clear();
                textBoxGPA.Clear();
                textBoxExtracurricular.Clear();
                textBoxAttendance.Clear();
            }
            catch (OleDbException ex)
            {
                if (ex.Message.Equals("Data type mismatch in criteria expression."))
                {
                    MessageBox.Show("Please make sure all typed data is of the correct type and format.", "You have entered incorrect data!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
        }

        private void buttonViewDB_Click(object sender, EventArgs e)
        {
            ViewDatabaseActivity viewDBAct = new ViewDatabaseActivity();
            viewDBAct.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //WTJTODO: search on Enter key
            if (textBoxSearch.Text != "" && comboBoxSearchSelector.Text != "")
            {
                studentsBindingSource2.Filter = comboBoxSearchSelector.Text + " like \'*" + textBoxSearch.Text + "*\'";
                studentsTableAdapter.Fill(sEPat_TestDataSet.Students);
            }
            else { }
        }

        private void buttonSearchReset_Click(object sender, EventArgs e)
        {
            studentsBindingSource2.RemoveFilter();
            studentsTableAdapter.Fill(sEPat_TestDataSet.Students);
            textBoxSearch.Clear();
        }

        private void buttonSearchNewWindow_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "" && comboBoxSearchSelector.Text != "")
            {
                string filter = comboBoxSearchSelector.Text + " like \'*" + textBoxSearch.Text + "*\'";
                ViewDatabaseActivity viewFilteredDBAct = new ViewDatabaseActivity(filter);
                viewFilteredDBAct.ShowDialog();
            }
            else { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        private void buttonExtracurricularHelp_Click(object sender, EventArgs e)
        {
            ExtracurricularHelpActivity extraHelpAct = new ExtracurricularHelpActivity();
            extraHelpAct.ShowDialog();
            textBoxExtracurricular.Text = extraHelpAct.getExtracurricularPoints().ToString();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void buttonAttendancePlusOne_Click(object sender, EventArgs e)
        {
            if (textBoxAttendance.Text != "")
            {
                textBoxAttendance.Text = (Int32.Parse(textBoxAttendance.Text) + 1).ToString();
            }
            else { }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //http://stackoverflow.com/questions/11260843/getting-data-from-selected-datagridview-row-and-which-event
            //http://stackoverflow.com/questions/5746319/get-cell-contents-of-a-selected-row-in-a-datagridview

            if(dataGridView1.SelectedRows.Count == 1)
            {
                textBoxLastName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBoxFirstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBoxID.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBoxGPA.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBoxExtracurricular.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBoxAttendance.Text = Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            else { }
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        { //use Enter key to click search button if there is search text or click reset button if search is blank
            if(e.KeyChar == (char)13)
            {
                if (textBoxSearch.Text == "") buttonSearchReset_Click(sender, e);
                else buttonSearch_Click(sender, e);
            }
        }

        private void buttonMultiSelectAttendance_Click(object sender, EventArgs e)
        {
            //WTJTODO: 
            for(int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.SelectedRows[i].Cells["Attendance"].Value = Int32.Parse(dataGridView1.SelectedRows[i].Cells["Attendance"].Value.ToString()) += 1;
            }
        }
    }
}
