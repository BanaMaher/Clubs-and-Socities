namespace testing
{
    partial class report_activities
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
            this.dgvforReportActivities = new System.Windows.Forms.DataGridView();
            this.ClubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActvityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Achievments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvforReportActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvforReportActivities
            // 
            this.dgvforReportActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvforReportActivities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClubName,
            this.ActvityName,
            this.ActivityDate,
            this.ActivityDescription,
            this.Achievments});
            this.dgvforReportActivities.Location = new System.Drawing.Point(40, 108);
            this.dgvforReportActivities.Name = "dgvforReportActivities";
            this.dgvforReportActivities.RowHeadersWidth = 51;
            this.dgvforReportActivities.RowTemplate.Height = 24;
            this.dgvforReportActivities.Size = new System.Drawing.Size(667, 270);
            this.dgvforReportActivities.TabIndex = 0;
            // 
            // ClubName
            // 
            this.ClubName.HeaderText = "Club Name";
            this.ClubName.MinimumWidth = 6;
            this.ClubName.Name = "ClubName";
            this.ClubName.Width = 125;
            // 
            // ActvityName
            // 
            this.ActvityName.HeaderText = "Activity Name";
            this.ActvityName.MinimumWidth = 6;
            this.ActvityName.Name = "ActvityName";
            this.ActvityName.Width = 125;
            // 
            // ActivityDate
            // 
            this.ActivityDate.HeaderText = "Activity Name";
            this.ActivityDate.MinimumWidth = 6;
            this.ActivityDate.Name = "ActivityDate";
            this.ActivityDate.Width = 125;
            // 
            // ActivityDescription
            // 
            this.ActivityDescription.HeaderText = "Activity Description";
            this.ActivityDescription.MinimumWidth = 6;
            this.ActivityDescription.Name = "ActivityDescription";
            this.ActivityDescription.Width = 125;
            // 
            // Achievments
            // 
            this.Achievments.HeaderText = "Achievments";
            this.Achievments.MinimumWidth = 6;
            this.Achievments.Name = "Achievments";
            this.Achievments.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Report for activities held";
            // 
            // report_activities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvforReportActivities);
            this.Name = "report_activities";
            this.Text = "report_activities";
            ((System.ComponentModel.ISupportInitialize)(this.dgvforReportActivities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvforReportActivities;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClubName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActvityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Achievments;
        private System.Windows.Forms.Label label1;
    }
}