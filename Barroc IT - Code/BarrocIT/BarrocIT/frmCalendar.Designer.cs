namespace BarrocIT
{
    partial class frmCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalendar));
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.listBoxMeetings = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(7, 6);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 0;
            this.Calendar.TabStop = false;
            // 
            // listBoxMeetings
            // 
            this.listBoxMeetings.FormattingEnabled = true;
            this.listBoxMeetings.Items.AddRange(new object[] {
            "Placeholder meeting 00-00-0000",
            "Placeholder meeting 00-00-0000",
            "Placeholder meeting 00-00-0000",
            "Placeholder meeting 00-00-0000"});
            this.listBoxMeetings.Location = new System.Drawing.Point(190, 6);
            this.listBoxMeetings.Name = "listBoxMeetings";
            this.listBoxMeetings.Size = new System.Drawing.Size(171, 160);
            this.listBoxMeetings.TabIndex = 0;
            this.listBoxMeetings.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Image = global::BarrocIT.Properties.Resources.Edit;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.Location = new System.Drawing.Point(190, 175);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 25);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.TabStop = false;
            this.btnSelect.Text = "Select";
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::BarrocIT.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(281, 175);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 208);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.listBoxMeetings);
            this.Controls.Add(this.Calendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barroc IT - Calendar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.ListBox listBoxMeetings;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
    }
}