namespace SEPatRanking
{
    partial class MainActivity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtracurricularPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonApply = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAttendance = new System.Windows.Forms.TextBox();
            this.textBoxExtracurricular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGPA = new System.Windows.Forms.TextBox();
            this.labelGPA = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAddNew = new System.Windows.Forms.Label();
            this.buttonViewDB = new System.Windows.Forms.Button();
            this.gPADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sEPat_TestDataSet = new SEPatRanking.SEPat_TestDataSet();
            this.studentsTableAdapter = new SEPatRanking.SEPat_TestDataSetTableAdapters.StudentsTableAdapter();
            this.buttonSearchReset = new System.Windows.Forms.Button();
            this.comboBoxSearchSelector = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEPat_TestDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.FirstName,
            this.gPADataGridViewTextBoxColumn,
            this.ExtracurricularPoints,
            this.attendanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(8, 400);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // ExtracurricularPoints
            // 
            this.ExtracurricularPoints.DataPropertyName = "ExtracurricularPoints";
            this.ExtracurricularPoints.HeaderText = "ExtracurricularPoints";
            this.ExtracurricularPoints.Name = "ExtracurricularPoints";
            this.ExtracurricularPoints.ReadOnly = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(680, 19);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 3;
            this.buttonApply.Text = "Add Student";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.comboBoxSearchSelector);
            this.panel1.Controls.Add(this.buttonSearchReset);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 61);
            this.panel1.TabIndex = 7;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(680, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxAttendance);
            this.panel2.Controls.Add(this.textBoxExtracurricular);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxGPA);
            this.panel2.Controls.Add(this.labelGPA);
            this.panel2.Controls.Add(this.textBoxLastName);
            this.panel2.Controls.Add(this.buttonApply);
            this.panel2.Controls.Add(this.textBoxFirstName);
            this.panel2.Controls.Add(this.textBoxID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 118);
            this.panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Attendance";
            // 
            // textBoxAttendance
            // 
            this.textBoxAttendance.Location = new System.Drawing.Point(447, 22);
            this.textBoxAttendance.MaxLength = 6;
            this.textBoxAttendance.Name = "textBoxAttendance";
            this.textBoxAttendance.Size = new System.Drawing.Size(71, 20);
            this.textBoxAttendance.TabIndex = 20;
            // 
            // textBoxExtracurricular
            // 
            this.textBoxExtracurricular.Location = new System.Drawing.Point(370, 22);
            this.textBoxExtracurricular.MaxLength = 6;
            this.textBoxExtracurricular.Name = "textBoxExtracurricular";
            this.textBoxExtracurricular.Size = new System.Drawing.Size(71, 20);
            this.textBoxExtracurricular.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Extracurricular";
            // 
            // textBoxGPA
            // 
            this.textBoxGPA.Location = new System.Drawing.Point(306, 22);
            this.textBoxGPA.MaxLength = 6;
            this.textBoxGPA.Name = "textBoxGPA";
            this.textBoxGPA.Size = new System.Drawing.Size(58, 20);
            this.textBoxGPA.TabIndex = 17;
            // 
            // labelGPA
            // 
            this.labelGPA.AutoSize = true;
            this.labelGPA.Location = new System.Drawing.Point(306, 6);
            this.labelGPA.Name = "labelGPA";
            this.labelGPA.Size = new System.Drawing.Size(29, 13);
            this.labelGPA.TabIndex = 16;
            this.labelGPA.Text = "GPA";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(70, 22);
            this.textBoxLastName.MaxLength = 63;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(112, 20);
            this.textBoxLastName.TabIndex = 15;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(188, 22);
            this.textBoxFirstName.MaxLength = 63;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(112, 20);
            this.textBoxFirstName.TabIndex = 14;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(6, 22);
            this.textBoxID.MaxLength = 6;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(58, 20);
            this.textBoxID.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "First Name";
            // 
            // labelAddNew
            // 
            this.labelAddNew.AutoSize = true;
            this.labelAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAddNew.Location = new System.Drawing.Point(13, 86);
            this.labelAddNew.Name = "labelAddNew";
            this.labelAddNew.Size = new System.Drawing.Size(64, 17);
            this.labelAddNew.TabIndex = 4;
            this.labelAddNew.Text = "Add New";
            // 
            // buttonViewDB
            // 
            this.buttonViewDB.Location = new System.Drawing.Point(657, 371);
            this.buttonViewDB.Name = "buttonViewDB";
            this.buttonViewDB.Size = new System.Drawing.Size(111, 23);
            this.buttonViewDB.TabIndex = 9;
            this.buttonViewDB.Text = "View Database";
            this.buttonViewDB.UseVisualStyleBackColor = true;
            this.buttonViewDB.Click += new System.EventHandler(this.buttonViewDB_Click);
            // 
            // gPADataGridViewTextBoxColumn
            // 
            this.gPADataGridViewTextBoxColumn.DataPropertyName = "GPA";
            this.gPADataGridViewTextBoxColumn.HeaderText = "GPA";
            this.gPADataGridViewTextBoxColumn.Name = "gPADataGridViewTextBoxColumn";
            this.gPADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attendanceDataGridViewTextBoxColumn
            // 
            this.attendanceDataGridViewTextBoxColumn.DataPropertyName = "Attendance";
            this.attendanceDataGridViewTextBoxColumn.HeaderText = "Attendance";
            this.attendanceDataGridViewTextBoxColumn.Name = "attendanceDataGridViewTextBoxColumn";
            this.attendanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentsBindingSource2
            // 
            this.studentsBindingSource2.DataMember = "Students";
            this.studentsBindingSource2.DataSource = this.sEPat_TestDataSet;
            // 
            // sEPat_TestDataSet
            // 
            this.sEPat_TestDataSet.DataSetName = "SEPat_TestDataSet";
            this.sEPat_TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSearchReset
            // 
            this.buttonSearchReset.Location = new System.Drawing.Point(680, 32);
            this.buttonSearchReset.Name = "buttonSearchReset";
            this.buttonSearchReset.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchReset.TabIndex = 10;
            this.buttonSearchReset.Text = "Reset";
            this.buttonSearchReset.UseVisualStyleBackColor = true;
            this.buttonSearchReset.Click += new System.EventHandler(this.buttonSearchReset_Click);
            // 
            // comboBoxSearchSelector
            // 
            this.comboBoxSearchSelector.FormattingEnabled = true;
            this.comboBoxSearchSelector.Items.AddRange(new object[] {
            "LastName",
            "FirstName",
            "IDNumber"});
            this.comboBoxSearchSelector.Location = new System.Drawing.Point(6, 24);
            this.comboBoxSearchSelector.Name = "comboBoxSearchSelector";
            this.comboBoxSearchSelector.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchSelector.TabIndex = 11;
            this.comboBoxSearchSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(133, 24);
            this.textBoxSearch.MaxLength = 31;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Query";
            // 
            // MainActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.buttonViewDB);
            this.Controls.Add(this.labelAddNew);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainActivity";
            this.Text = "Science and Engineering Pathway Student Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEPat_TestDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SEPat_TestDataSet sEPat_TestDataSet;
        private SEPat_TestDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAddNew;
        private System.Windows.Forms.Label labelGPA;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extracurricularPointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAttendance;
        private System.Windows.Forms.TextBox textBoxExtracurricular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtracurricularPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentsBindingSource2;
        private System.Windows.Forms.Button buttonViewDB;
        private System.Windows.Forms.Button buttonSearchReset;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSearchSelector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

