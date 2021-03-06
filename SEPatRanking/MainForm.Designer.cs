﻿namespace SEPatRanking
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtracurricularPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sEPat_DataSet = new SEPatRanking.SEPat_DataSet();
            this.buttonApply = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSearchNewWindow = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSearchSelector = new System.Windows.Forms.ComboBox();
            this.buttonSearchReset = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxServiceHours = new System.Windows.Forms.TextBox();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.labelGrade = new System.Windows.Forms.Label();
            this.buttonAttendancePlusOne = new System.Windows.Forms.Button();
            this.buttonExtracurricularHelp = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAttendance = new System.Windows.Forms.TextBox();
            this.textBoxExtracurricular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGPA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelGPA = new System.Windows.Forms.Label();
            this.textBoxIDNumber = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAddNew = new System.Windows.Forms.Label();
            this.buttonEditDB = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonMultiSelectAttendance = new System.Windows.Forms.Button();
            this.buttonCalculateScores = new System.Windows.Forms.Button();
            this.buttonIncrementGrade = new System.Windows.Forms.Button();
            this.studentsTableAdapter = new SEPatRanking.SEPat_DataSetTableAdapters.StudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEPat_DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.Score,
            this.LastName,
            this.FirstName,
            this.IDNumber,
            this.Grade,
            this.ServiceHours,
            this.GPA,
            this.ExtracurricularPoints,
            this.Attendance});
            this.dataGridView1.DataSource = this.studentsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(8, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(764, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Score
            // 
            this.Score.DataPropertyName = "Score";
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 45;
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
            this.FirstName.ReadOnly = true;
            // 
            // IDNumber
            // 
            this.IDNumber.DataPropertyName = "IDNumber";
            this.IDNumber.HeaderText = "IDNumber";
            this.IDNumber.Name = "IDNumber";
            this.IDNumber.ReadOnly = true;
            this.IDNumber.Width = 60;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Grade";
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Width = 40;
            // 
            // ServiceHours
            // 
            this.ServiceHours.DataPropertyName = "ServiceHours";
            this.ServiceHours.HeaderText = "ServiceHours";
            this.ServiceHours.Name = "ServiceHours";
            this.ServiceHours.ReadOnly = true;
            this.ServiceHours.Width = 80;
            // 
            // GPA
            // 
            this.GPA.DataPropertyName = "GPA";
            this.GPA.HeaderText = "GPA";
            this.GPA.Name = "GPA";
            this.GPA.ReadOnly = true;
            this.GPA.Width = 60;
            // 
            // ExtracurricularPoints
            // 
            this.ExtracurricularPoints.DataPropertyName = "ExtracurricularPoints";
            this.ExtracurricularPoints.HeaderText = "ExtracurricularPoints";
            this.ExtracurricularPoints.Name = "ExtracurricularPoints";
            this.ExtracurricularPoints.ReadOnly = true;
            // 
            // Attendance
            // 
            this.Attendance.DataPropertyName = "Attendance";
            this.Attendance.HeaderText = "Attendance";
            this.Attendance.Name = "Attendance";
            this.Attendance.ReadOnly = true;
            this.Attendance.Width = 65;
            // 
            // studentsBindingSource2
            // 
            this.studentsBindingSource2.DataMember = "Students";
            this.studentsBindingSource2.DataSource = this.sEPat_DataSet;
            // 
            // sEPat_DataSet
            // 
            this.sEPat_DataSet.DataSetName = "SEPat_DataSet";
            this.sEPat_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(633, 119);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(122, 23);
            this.buttonApply.TabIndex = 11;
            this.buttonApply.Text = "Add/Update Student";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonSearchNewWindow);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.comboBoxSearchSelector);
            this.panel1.Controls.Add(this.buttonSearchReset);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 61);
            this.panel1.TabIndex = 0;
            // 
            // buttonSearchNewWindow
            // 
            this.buttonSearchNewWindow.Location = new System.Drawing.Point(680, 3);
            this.buttonSearchNewWindow.Name = "buttonSearchNewWindow";
            this.buttonSearchNewWindow.Size = new System.Drawing.Size(75, 52);
            this.buttonSearchNewWindow.TabIndex = 15;
            this.buttonSearchNewWindow.Text = "New Window";
            this.buttonSearchNewWindow.UseVisualStyleBackColor = true;
            this.buttonSearchNewWindow.Click += new System.EventHandler(this.buttonSearchNewWindow_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Category";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(133, 24);
            this.textBoxSearch.MaxLength = 6;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // comboBoxSearchSelector
            // 
            this.comboBoxSearchSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchSelector.FormattingEnabled = true;
            this.comboBoxSearchSelector.Items.AddRange(new object[] {
            "LastName",
            "FirstName",
            "IDNumber"});
            this.comboBoxSearchSelector.Location = new System.Drawing.Point(6, 24);
            this.comboBoxSearchSelector.Name = "comboBoxSearchSelector";
            this.comboBoxSearchSelector.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchSelector.TabIndex = 1;
            this.comboBoxSearchSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonSearchReset
            // 
            this.buttonSearchReset.Location = new System.Drawing.Point(599, 32);
            this.buttonSearchReset.Name = "buttonSearchReset";
            this.buttonSearchReset.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchReset.TabIndex = 4;
            this.buttonSearchReset.Text = "Reset";
            this.buttonSearchReset.UseVisualStyleBackColor = true;
            this.buttonSearchReset.Click += new System.EventHandler(this.buttonSearchReset_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(599, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxServiceHours);
            this.panel2.Controls.Add(this.comboBoxGrade);
            this.panel2.Controls.Add(this.labelGrade);
            this.panel2.Controls.Add(this.buttonAttendancePlusOne);
            this.panel2.Controls.Add(this.buttonExtracurricularHelp);
            this.panel2.Controls.Add(this.textBoxLastName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxAttendance);
            this.panel2.Controls.Add(this.textBoxExtracurricular);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxGPA);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.labelGPA);
            this.panel2.Controls.Add(this.textBoxIDNumber);
            this.panel2.Controls.Add(this.buttonApply);
            this.panel2.Controls.Add(this.textBoxFirstName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 147);
            this.panel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Service Hours";
            // 
            // textBoxServiceHours
            // 
            this.textBoxServiceHours.Location = new System.Drawing.Point(84, 94);
            this.textBoxServiceHours.MaxLength = 2;
            this.textBoxServiceHours.Name = "textBoxServiceHours";
            this.textBoxServiceHours.Size = new System.Drawing.Size(74, 20);
            this.textBoxServiceHours.TabIndex = 17;
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxGrade.Location = new System.Drawing.Point(307, 16);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(35, 21);
            this.comboBoxGrade.TabIndex = 16;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(306, 0);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(36, 13);
            this.labelGrade.TabIndex = 15;
            this.labelGrade.Text = "Grade";
            // 
            // buttonAttendancePlusOne
            // 
            this.buttonAttendancePlusOne.Location = new System.Drawing.Point(147, 52);
            this.buttonAttendancePlusOne.Name = "buttonAttendancePlusOne";
            this.buttonAttendancePlusOne.Size = new System.Drawing.Size(30, 23);
            this.buttonAttendancePlusOne.TabIndex = 13;
            this.buttonAttendancePlusOne.Text = "+1";
            this.buttonAttendancePlusOne.UseVisualStyleBackColor = true;
            this.buttonAttendancePlusOne.Click += new System.EventHandler(this.buttonAttendancePlusOne_Click);
            // 
            // buttonExtracurricularHelp
            // 
            this.buttonExtracurricularHelp.Location = new System.Drawing.Point(6, 117);
            this.buttonExtracurricularHelp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExtracurricularHelp.Name = "buttonExtracurricularHelp";
            this.buttonExtracurricularHelp.Size = new System.Drawing.Size(61, 20);
            this.buttonExtracurricularHelp.TabIndex = 12;
            this.buttonExtracurricularHelp.Text = "Counter";
            this.buttonExtracurricularHelp.UseVisualStyleBackColor = true;
            this.buttonExtracurricularHelp.Click += new System.EventHandler(this.buttonExtracurricularHelp_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(6, 16);
            this.textBoxLastName.MaxLength = 63;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(112, 20);
            this.textBoxLastName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Attendance";
            // 
            // textBoxAttendance
            // 
            this.textBoxAttendance.Location = new System.Drawing.Point(70, 55);
            this.textBoxAttendance.MaxLength = 6;
            this.textBoxAttendance.Name = "textBoxAttendance";
            this.textBoxAttendance.Size = new System.Drawing.Size(71, 20);
            this.textBoxAttendance.TabIndex = 9;
            // 
            // textBoxExtracurricular
            // 
            this.textBoxExtracurricular.Location = new System.Drawing.Point(6, 94);
            this.textBoxExtracurricular.MaxLength = 2;
            this.textBoxExtracurricular.Name = "textBoxExtracurricular";
            this.textBoxExtracurricular.Size = new System.Drawing.Size(71, 20);
            this.textBoxExtracurricular.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extracurricular";
            // 
            // textBoxGPA
            // 
            this.textBoxGPA.Location = new System.Drawing.Point(6, 55);
            this.textBoxGPA.MaxLength = 6;
            this.textBoxGPA.Name = "textBoxGPA";
            this.textBoxGPA.Size = new System.Drawing.Size(58, 20);
            this.textBoxGPA.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Number";
            // 
            // labelGPA
            // 
            this.labelGPA.AutoSize = true;
            this.labelGPA.Location = new System.Drawing.Point(3, 39);
            this.labelGPA.Name = "labelGPA";
            this.labelGPA.Size = new System.Drawing.Size(29, 13);
            this.labelGPA.TabIndex = 0;
            this.labelGPA.Text = "GPA";
            // 
            // textBoxIDNumber
            // 
            this.textBoxIDNumber.Location = new System.Drawing.Point(242, 16);
            this.textBoxIDNumber.MaxLength = 6;
            this.textBoxIDNumber.Name = "textBoxIDNumber";
            this.textBoxIDNumber.Size = new System.Drawing.Size(58, 20);
            this.textBoxIDNumber.TabIndex = 7;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(124, 16);
            this.textBoxFirstName.MaxLength = 63;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(112, 20);
            this.textBoxFirstName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name";
            // 
            // labelAddNew
            // 
            this.labelAddNew.AutoSize = true;
            this.labelAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAddNew.Location = new System.Drawing.Point(13, 86);
            this.labelAddNew.Name = "labelAddNew";
            this.labelAddNew.Size = new System.Drawing.Size(64, 17);
            this.labelAddNew.TabIndex = 0;
            this.labelAddNew.Text = "Add New";
            // 
            // buttonEditDB
            // 
            this.buttonEditDB.Enabled = false;
            this.buttonEditDB.Location = new System.Drawing.Point(661, 259);
            this.buttonEditDB.Name = "buttonEditDB";
            this.buttonEditDB.Size = new System.Drawing.Size(111, 23);
            this.buttonEditDB.TabIndex = 12;
            this.buttonEditDB.Text = "Edit Database";
            this.buttonEditDB.UseVisualStyleBackColor = true;
            this.buttonEditDB.Click += new System.EventHandler(this.buttonViewDB_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(12, 259);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 14;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonMultiSelectAttendance
            // 
            this.buttonMultiSelectAttendance.Location = new System.Drawing.Point(517, 259);
            this.buttonMultiSelectAttendance.Name = "buttonMultiSelectAttendance";
            this.buttonMultiSelectAttendance.Size = new System.Drawing.Size(138, 23);
            this.buttonMultiSelectAttendance.TabIndex = 15;
            this.buttonMultiSelectAttendance.Text = "Multi-Select Attendance";
            this.buttonMultiSelectAttendance.UseVisualStyleBackColor = true;
            this.buttonMultiSelectAttendance.Click += new System.EventHandler(this.buttonMultiSelectAttendance_Click);
            // 
            // buttonCalculateScores
            // 
            this.buttonCalculateScores.Location = new System.Drawing.Point(94, 259);
            this.buttonCalculateScores.Name = "buttonCalculateScores";
            this.buttonCalculateScores.Size = new System.Drawing.Size(97, 23);
            this.buttonCalculateScores.TabIndex = 16;
            this.buttonCalculateScores.Text = "Calculate Scores";
            this.buttonCalculateScores.UseVisualStyleBackColor = true;
            this.buttonCalculateScores.Click += new System.EventHandler(this.buttonCalculateScores_Click);
            // 
            // buttonIncrementGrade
            // 
            this.buttonIncrementGrade.Location = new System.Drawing.Point(386, 259);
            this.buttonIncrementGrade.Name = "buttonIncrementGrade";
            this.buttonIncrementGrade.Size = new System.Drawing.Size(125, 23);
            this.buttonIncrementGrade.TabIndex = 17;
            this.buttonIncrementGrade.Text = "Increment Grade Level";
            this.buttonIncrementGrade.UseVisualStyleBackColor = true;
            this.buttonIncrementGrade.Click += new System.EventHandler(this.buttonIncrementGrade_Click);
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.buttonIncrementGrade);
            this.Controls.Add(this.buttonCalculateScores);
            this.Controls.Add(this.buttonMultiSelectAttendance);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonEditDB);
            this.Controls.Add(this.labelAddNew);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Science and Engineering Pathway Student Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEPat_DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SEPat_DataSet sEPat_DataSet;
        private SEPat_DataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAddNew;
        private System.Windows.Forms.Label labelGPA;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxIDNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAttendance;
        private System.Windows.Forms.TextBox textBoxExtracurricular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGPA;
        private System.Windows.Forms.BindingSource studentsBindingSource2;
        private System.Windows.Forms.Button buttonEditDB;
        private System.Windows.Forms.Button buttonSearchReset;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSearchSelector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonExtracurricularHelp;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonAttendancePlusOne;
        private System.Windows.Forms.Button buttonSearchNewWindow;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Button buttonMultiSelectAttendance;
        private System.Windows.Forms.Button buttonCalculateScores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxServiceHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtracurricularPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendance;
        private System.Windows.Forms.Button buttonIncrementGrade;
    }
}

