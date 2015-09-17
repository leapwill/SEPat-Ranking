namespace SEPatRanking
{
    partial class ViewDatabaseActivity
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
            this.sEPat_TestDataSet = new SEPatRanking.SEPat_TestDataSet();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extracurricularPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new SEPatRanking.SEPat_TestDataSetTableAdapters.StudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sEPat_TestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sEPat_TestDataSet
            // 
            this.sEPat_TestDataSet.DataSetName = "SEPat_TestDataSet";
            this.sEPat_TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.IDNumber,
            this.gPADataGridViewTextBoxColumn,
            this.extracurricularPointsDataGridViewTextBoxColumn,
            this.attendanceDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.studentsBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(784, 362);
            this.dataGridView.TabIndex = 0;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // IDNumber
            // 
            this.IDNumber.DataPropertyName = "IDNumber";
            this.IDNumber.HeaderText = "IDNumber";
            this.IDNumber.Name = "IDNumber";
            // 
            // gPADataGridViewTextBoxColumn
            // 
            this.gPADataGridViewTextBoxColumn.DataPropertyName = "GPA";
            this.gPADataGridViewTextBoxColumn.HeaderText = "GPA";
            this.gPADataGridViewTextBoxColumn.Name = "gPADataGridViewTextBoxColumn";
            // 
            // extracurricularPointsDataGridViewTextBoxColumn
            // 
            this.extracurricularPointsDataGridViewTextBoxColumn.DataPropertyName = "ExtracurricularPoints";
            this.extracurricularPointsDataGridViewTextBoxColumn.HeaderText = "ExtracurricularPoints";
            this.extracurricularPointsDataGridViewTextBoxColumn.Name = "extracurricularPointsDataGridViewTextBoxColumn";
            // 
            // attendanceDataGridViewTextBoxColumn
            // 
            this.attendanceDataGridViewTextBoxColumn.DataPropertyName = "Attendance";
            this.attendanceDataGridViewTextBoxColumn.HeaderText = "Attendance";
            this.attendanceDataGridViewTextBoxColumn.Name = "attendanceDataGridViewTextBoxColumn";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.sEPat_TestDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // ViewDatabaseActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.dataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 200);
            this.Name = "ViewDatabaseActivity";
            this.Text = "View the Database";
            this.Load += new System.EventHandler(this.ViewDatabaseActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sEPat_TestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SEPat_TestDataSet sEPat_TestDataSet;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private SEPat_TestDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extracurricularPointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDataGridViewTextBoxColumn;
    }
}