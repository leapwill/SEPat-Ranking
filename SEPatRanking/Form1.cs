﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sEPat_TestDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.sEPat_TestDataSet.Students);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            //http://www.w3schools.com/sql/sql_quickref.asp
            //http://stackoverflow.com/questions/19275557/c-sharp-inserting-data-from-a-form-into-an-access-database

            //https://msdn.microsoft.com/en-us/library/system.data.oledb.oledbdataadapter%28v=vs.110%29.aspx

            OleDbConnection conn = new OleDbConnection(global::SEPatRanking.Properties.Settings.Default.SEPat_TestConnectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Students (Last Name, First Name, GPA, Extracurricular Points, Attendace) VALUES (" + textBoxLastName.Text + ", " + textBoxFirstName.Text + ", " + textBoxGPA.Text + ", " + textBoxExtracurricular.Text + ", " + textBoxAttendance.Text + ")", conn);
            dataGridView1.Refresh();
        }
    }
}
