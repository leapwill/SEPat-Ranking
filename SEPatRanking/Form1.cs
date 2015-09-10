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
            // TODO: This line of code loads data into the 'sEPat_TestDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.sEPat_TestDataSet.Students);
            this.comboBoxSearchSelector.SelectedItem = "LastName";

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

            OleDbConnection conn = new OleDbConnection();//Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SEPat_Test.accdb
            conn.ConnectionString = SEPatRanking.Properties.Settings.Default.SEPat_TestConnectionString;
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO Students (LastName,FirstName,GPA,ExtracurricularPoints,Attendance,IDNumber) VALUES (\'" + textBoxLastName.Text + "\',\'" + textBoxFirstName.Text + "\',\'" + textBoxGPA.Text + "\',\'" + textBoxExtracurricular.Text + "\',\'" + textBoxAttendance.Text + "\',\'" + textBoxID.Text + "\');", conn);
            //MessageBox.Show(cmd.CommandText.ToString());  //debug by showing SQL command before executing
            try
            {
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("New Student entry added!");
                //var dataSource = dataGridView1.DataSource;
                //dataGridView1.DataSource = null;
                /*dataGridView1.Update();
                dataGridView1.Refresh();
                dataGridView1.Parent.Refresh();*/
                //dataGridView1.DataSource = dataSource;
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
                if(ex.Message.Equals("Data type mismatch in criteria expression."))
                {
                    MessageBox.Show("You have entered incorrect data!", "Please make sure all typed data is of the correct type and format.");
                }
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void buttonViewDB_Click(object sender, EventArgs e)
        {
            ViewDatabaseActivity viewDBAct = new ViewDatabaseActivity();
            viewDBAct.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "" && comboBoxSearchSelector.Text != "")
            {
                studentsBindingSource2.Filter = comboBoxSearchSelector.Text + " LIKE \'*" + textBoxSearch.Text + "*\'";
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
    }
}
