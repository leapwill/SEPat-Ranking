﻿/*
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
using System.Threading;

namespace SEPatRanking
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this.sEPat_DataSet.Students);
            dataGridView1.Sort(dataGridView1.Columns["Score"], ListSortDirection.Descending);
            this.comboBoxSearchSelector.SelectedItem = "LastName";
            this.comboBoxGrade.SelectedItem = "9";
            this.toolTip1.SetToolTip(this.buttonMultiSelectAttendance, "Ctrl+Click to select then click to +1 attendance");
            this.toolTip1.SetToolTip(this.labelGPA, "Weighted");
            this.toolTip1.SetToolTip(this.buttonIncrementGrade, "Add one to grade and remove graduated seniors");
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            try //attempt to add a new student
            {
                studentsTableAdapter.Insert(double.Parse(textBoxGPA.Text), textBoxFirstName.Text, textBoxLastName.Text, textBoxIDNumber.Text, comboBoxGrade.Text, 0, short.Parse(textBoxAttendance.Text), short.Parse(textBoxExtracurricular.Text), short.Parse(textBoxServiceHours.Text));
                MessageBox.Show("New Student entry added!");
            }
            catch (FormatException ex) //if it fails because of invalid data in a field (eg letters in a number field)
            {
                MessageBox.Show("You have entered the wrong type of data, try again!\n" + ex.ToString());
            }
            catch //if it fails because there is a duplicate IDNumber, edit the student instead
            {
                studentsTableAdapter.UpdateQuery(textBoxLastName.Text, textBoxFirstName.Text, decimal.Parse(textBoxGPA.Text), short.Parse(textBoxExtracurricular.Text), short.Parse(textBoxAttendance.Text), comboBoxGrade.Text, short.Parse(textBoxServiceHours.Text), 0, textBoxIDNumber.Text);
            }
            this.studentsTableAdapter.Fill(this.sEPat_DataSet.Students);
        }

        private void executeOleDbNonQuery(OleDbCommand cmd)
        { //Executes a NonQuery with specified command
            
            studentsTableAdapter.Connection.Open();
            cmd.Connection = studentsTableAdapter.Connection;
            //MessageBox.Show(cmd.CommandText.ToString());  //debug by showing SQL command before executing
            try
            {
                cmd.ExecuteNonQuery();
                textBoxLastName.Clear();
                textBoxFirstName.Clear();
                textBoxIDNumber.Clear();
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
            }
            studentsTableAdapter.Connection.Close();
        }

        private void buttonViewDB_Click(object sender, EventArgs e)
        { //Opens a new window with only a dataGridView, but this one can be double clicked to edit
            ViewDatabaseActivity viewDBAct = new ViewDatabaseActivity();
            viewDBAct.ShowDialog();
            this.studentsTableAdapter.Fill(this.sEPat_DataSet.Students);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        { //limits entries shown in dataGridView to only those that fit the search parameters in the given column
            if (textBoxSearch.Text != "" && comboBoxSearchSelector.Text != "")
            {
                studentsBindingSource2.Filter = comboBoxSearchSelector.Text + " like \'*" + textBoxSearch.Text + "*\'";
                studentsTableAdapter.Fill(sEPat_DataSet.Students);
            }
            else { }
        }

        private void buttonSearchReset_Click(object sender, EventArgs e)
        { //empties search box and refills dataGridView
            studentsBindingSource2.RemoveFilter();
            studentsTableAdapter.Fill(sEPat_DataSet.Students);
            textBoxSearch.Clear();
        }

        private void buttonSearchNewWindow_Click(object sender, EventArgs e)
        { //opens new window (editable dataGridView) with a filter
            if (textBoxSearch.Text != "" && comboBoxSearchSelector.Text != "")
            {
                string filter = comboBoxSearchSelector.Text + " like \'*" + textBoxSearch.Text + "*\'";
                ViewDatabaseActivity viewFilteredDBAct = new ViewDatabaseActivity(filter);
                viewFilteredDBAct.ShowDialog();
            }
            else { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { //clear the Search text box when the dropdown selector changes category for convenience
            textBoxSearch.Clear();
        }

        private void buttonExtracurricularHelp_Click(object sender, EventArgs e)
        { //opens ExtraCurricularCounterForm to aid the user through properly counting all the extracurriculars
            ExtracurricularHelpActivity extraHelpAct = new ExtracurricularHelpActivity();
            extraHelpAct.ShowDialog();
            textBoxExtracurricular.Text = extraHelpAct.getExtracurricularPoints().ToString();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        { //shows the AboutBox for version, author, and license information
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void buttonAttendancePlusOne_Click(object sender, EventArgs e)
        { //simple increments the Attendance text box value by one
            if (textBoxAttendance.Text != "")
            {
                textBoxAttendance.Text = (Int32.Parse(textBoxAttendance.Text) + 1).ToString();
            }
            else { }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        { //when a cell is double-clicked, fill the text boxes with that student's information so it may be edited
            if(dataGridView1.SelectedRows.Count == 1)
            {
                textBoxLastName.Text = dataGridView1.SelectedRows[0].Cells["LastName"].Value.ToString();
                textBoxFirstName.Text = dataGridView1.SelectedRows[0].Cells["FirstName"].Value.ToString();
                textBoxIDNumber.Text = dataGridView1.SelectedRows[0].Cells["IDNumber"].Value.ToString();
                textBoxGPA.Text = dataGridView1.SelectedRows[0].Cells["GPA"].Value.ToString();
                textBoxAttendance.Text = dataGridView1.SelectedRows[0].Cells["Attendance"].Value.ToString();
                textBoxExtracurricular.Text = dataGridView1.SelectedRows[0].Cells["ExtracurricularPoints"].Value.ToString();
                comboBoxGrade.SelectedItem = dataGridView1.SelectedRows[0].Cells["Grade"].Value.ToString();
                textBoxServiceHours.Text = dataGridView1.SelectedRows[0].Cells["ServiceHours"].Value.ToString();
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
        { //go through all selected rows (Ctrl+Click) and get the unique IDNumber to add 1 to the Attendance value
            for(int i = 0; i < dataGridView1.SelectedRows.Count; i += 1)
            {
                string idToChange = dataGridView1.SelectedRows[i].Cells["IDNumber"].Value.ToString();
                int newAttendance = int.Parse(dataGridView1.SelectedRows[i].Cells["Attendance"].Value.ToString()) + 1;
                studentsTableAdapter.UpdateQueryAttendance(short.Parse(newAttendance.ToString()), idToChange);
            }
            this.studentsTableAdapter.Fill(this.sEPat_DataSet.Students);
        }

        private void buttonCalculateScores_Click(object sender, EventArgs e)
        { //reset scores, find percentiles, and calculate new scores
            CalculatingForm calculatingForm = new CalculatingForm();
            Thread calculatingFormThread = new Thread(new ThreadStart(calculatingForm.Run));
            calculatingFormThread.Start(); //show a marquee bar to hold the user over becuase calculations are long

            int numOfStudents = sEPat_DataSet.Tables["Students"].Rows.Count;
            //first clear all old scores so nothing is double counted
            foreach (DataRow row in sEPat_DataSet.Tables["Students"].Rows)
            {
                studentsTableAdapter.UpdateQueryScore(0, row["IDNumber"].ToString());
            }

            //creates a sortable list of all students
            //sort and calc percentiles
            string[] scoringColumns = { "Attendance", "ExtracurricularPoints", "GPA", "ServiceHours" };
            for (int i = 0; i < scoringColumns.Length; i++)
            { //for each column to be scored, create and sort a DataView for each column contributing to the socre
                DataTable SEPat_DataTable = sEPat_DataSet.Tables["Students"];
                DataView SEPat_DataView = new DataView(SEPat_DataTable);
                SEPat_DataView.Sort = scoringColumns[i];

                for (int percentile = 40; percentile < 100; percentile += 10)
                { //for each percentile level that allots points, add a point
                    //use nearest rank method to calc the rank of a percentile
                    int rank = int.Parse(Math.Ceiling((percentile / 100.0) * numOfStudents).ToString());
                    DataTable sortedTable = SEPat_DataView.ToTable();
                    for (int j = rank; j < numOfStudents; j++)
                    {
                        //get the ID of the student at this rank, get the old score from that IDNumber, and then put the old score +1 directly into the database
                        string IDNumberOfCurrentStudent = sortedTable.Rows[j]["IDNumber"].ToString();
                        int oldScore = int.Parse(studentsTableAdapter.GetScore(IDNumberOfCurrentStudent).ToString());
                        studentsTableAdapter.UpdateQueryScore(decimal.Parse(oldScore.ToString()) + 1, IDNumberOfCurrentStudent);
                    }
                }
            }

            calculatingFormThread.Abort();
            this.studentsTableAdapter.Fill(this.sEPat_DataSet.Students);
        }

        private void buttonIncrementGrade_Click(object sender, EventArgs e)
        { //backs up database, then delete seniors and increments grades
            System.IO.File.Copy("SEPat_.accdb", "database.backup", true);
            DataTable tempTable = (new DataView(sEPat_DataSet.Tables["Students"])).ToTable();
            foreach(DataRow row in tempTable.Rows)
            {
                string IDNumberOfCurrentStudent = row["IDNumber"].ToString();
                int oldGrade = int.Parse(studentsTableAdapter.GetGrade(IDNumberOfCurrentStudent).ToString());
                if(oldGrade == 12)
                {
                    studentsTableAdapter.DeleteQuery(IDNumberOfCurrentStudent);
                }
                else
                {
                    studentsTableAdapter.UpdateQueryGrade((oldGrade + 1).ToString(), IDNumberOfCurrentStudent);
                }
            }
            this.studentsTableAdapter.Fill(this.sEPat_DataSet.Students);
        }

    }
}
