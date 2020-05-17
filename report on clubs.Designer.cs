namespace testing
{
    partial class report_on_clubs
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
            this.dgvReportForClub = new System.Windows.Forms.DataGridView();
            this.ClubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEstablished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClubDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presidentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportForClub)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReportForClub
            // 
            this.dgvReportForClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportForClub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClubName,
            this.DateEstablished,
            this.ClubDescription,
            this.presidentName});
            this.dgvReportForClub.Location = new System.Drawing.Point(81, 121);
            this.dgvReportForClub.Name = "dgvReportForClub";
            this.dgvReportForClub.RowHeadersWidth = 51;
            this.dgvReportForClub.RowTemplate.Height = 24;
            this.dgvReportForClub.Size = new System.Drawing.Size(552, 273);
            this.dgvReportForClub.TabIndex = 0;
            // 
            // ClubName
            // 
            this.ClubName.HeaderText = "Club Name";
            this.ClubName.MinimumWidth = 6;
            this.ClubName.Name = "ClubName";
            this.ClubName.Width = 125;
            // 
            // DateEstablished
            // 
            this.DateEstablished.HeaderText = "Date Established";
            this.DateEstablished.MinimumWidth = 6;
            this.DateEstablished.Name = "DateEstablished";
            this.DateEstablished.Width = 125;
            // 
            // ClubDescription
            // 
            this.ClubDescription.HeaderText = "Club Description";
            this.ClubDescription.MinimumWidth = 6;
            this.ClubDescription.Name = "ClubDescription";
            this.ClubDescription.Width = 125;
            // 
            // presidentName
            // 
            this.presidentName.HeaderText = "President\'s Name";
            this.presidentName.MinimumWidth = 6;
            this.presidentName.Name = "presidentName";
            this.presidentName.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Report on club";
            // 
            // report_on_clubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReportForClub);
            this.Name = "report_on_clubs";
            this.Text = "report_on_clubs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportForClub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReportForClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClubName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEstablished;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClubDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn presidentName;
        private System.Windows.Forms.Label label1;
    }
}