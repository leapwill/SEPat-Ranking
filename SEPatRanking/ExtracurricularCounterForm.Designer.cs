namespace SEPatRanking
{
    partial class ExtracurricularHelpActivity
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBoxNHS = new System.Windows.Forms.CheckBox();
            this.checkBoxDance = new System.Windows.Forms.CheckBox();
            this.checkBoxSports = new System.Windows.Forms.CheckBox();
            this.checkBoxFineArts = new System.Windows.Forms.CheckBox();
            this.checkBoxBand = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonExtracurricularCountApply = new System.Windows.Forms.Button();
            this.numericUpDownOtherClubs = new System.Windows.Forms.NumericUpDown();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOtherClubs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.numericUpDownOtherClubs);
            this.panel4.Controls.Add(this.checkBoxNHS);
            this.panel4.Controls.Add(this.checkBoxDance);
            this.panel4.Controls.Add(this.checkBoxSports);
            this.panel4.Controls.Add(this.checkBoxFineArts);
            this.panel4.Controls.Add(this.checkBoxBand);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 107);
            this.panel4.TabIndex = 5;
            // 
            // checkBoxNHS
            // 
            this.checkBoxNHS.AutoSize = true;
            this.checkBoxNHS.Location = new System.Drawing.Point(4, 50);
            this.checkBoxNHS.Name = "checkBoxNHS";
            this.checkBoxNHS.Size = new System.Drawing.Size(147, 17);
            this.checkBoxNHS.TabIndex = 8;
            this.checkBoxNHS.Text = "NHS/NFHS/MAO/NTHS";
            this.checkBoxNHS.UseVisualStyleBackColor = true;
            // 
            // checkBoxDance
            // 
            this.checkBoxDance.AutoSize = true;
            this.checkBoxDance.Location = new System.Drawing.Point(90, 27);
            this.checkBoxDance.Name = "checkBoxDance";
            this.checkBoxDance.Size = new System.Drawing.Size(140, 17);
            this.checkBoxDance.TabIndex = 7;
            this.checkBoxDance.Text = "Dance/Cheer/Troyanns";
            this.checkBoxDance.UseVisualStyleBackColor = true;
            // 
            // checkBoxSports
            // 
            this.checkBoxSports.AutoSize = true;
            this.checkBoxSports.Location = new System.Drawing.Point(4, 27);
            this.checkBoxSports.Name = "checkBoxSports";
            this.checkBoxSports.Size = new System.Drawing.Size(56, 17);
            this.checkBoxSports.TabIndex = 6;
            this.checkBoxSports.Text = "Sports";
            this.checkBoxSports.UseVisualStyleBackColor = true;
            // 
            // checkBoxFineArts
            // 
            this.checkBoxFineArts.AutoSize = true;
            this.checkBoxFineArts.Location = new System.Drawing.Point(90, 4);
            this.checkBoxFineArts.Name = "checkBoxFineArts";
            this.checkBoxFineArts.Size = new System.Drawing.Size(96, 17);
            this.checkBoxFineArts.TabIndex = 5;
            this.checkBoxFineArts.Text = "Other Fine Arts";
            this.checkBoxFineArts.UseVisualStyleBackColor = true;
            // 
            // checkBoxBand
            // 
            this.checkBoxBand.AutoSize = true;
            this.checkBoxBand.Location = new System.Drawing.Point(4, 4);
            this.checkBoxBand.Name = "checkBoxBand";
            this.checkBoxBand.Size = new System.Drawing.Size(51, 17);
            this.checkBoxBand.TabIndex = 4;
            this.checkBoxBand.Text = "Band";
            this.checkBoxBand.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Number of other clubs:";
            // 
            // buttonExtracurricularCountApply
            // 
            this.buttonExtracurricularCountApply.Location = new System.Drawing.Point(13, 126);
            this.buttonExtracurricularCountApply.Name = "buttonExtracurricularCountApply";
            this.buttonExtracurricularCountApply.Size = new System.Drawing.Size(75, 23);
            this.buttonExtracurricularCountApply.TabIndex = 6;
            this.buttonExtracurricularCountApply.Text = "Count";
            this.buttonExtracurricularCountApply.UseVisualStyleBackColor = true;
            this.buttonExtracurricularCountApply.Click += new System.EventHandler(this.buttonExtracurricularCountApply_Click);
            // 
            // numericUpDownOtherClubs
            // 
            this.numericUpDownOtherClubs.Location = new System.Drawing.Point(123, 75);
            this.numericUpDownOtherClubs.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownOtherClubs.Name = "numericUpDownOtherClubs";
            this.numericUpDownOtherClubs.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownOtherClubs.TabIndex = 9;
            // 
            // ExtracurricularHelpActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 159);
            this.Controls.Add(this.buttonExtracurricularCountApply);
            this.Controls.Add(this.panel4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtracurricularHelpActivity";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "How to Count Extracurriculars";
            this.TopMost = true;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOtherClubs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonExtracurricularCountApply;
        private System.Windows.Forms.CheckBox checkBoxNHS;
        private System.Windows.Forms.CheckBox checkBoxDance;
        private System.Windows.Forms.CheckBox checkBoxSports;
        private System.Windows.Forms.CheckBox checkBoxFineArts;
        private System.Windows.Forms.CheckBox checkBoxBand;
        private System.Windows.Forms.NumericUpDown numericUpDownOtherClubs;
    }
}