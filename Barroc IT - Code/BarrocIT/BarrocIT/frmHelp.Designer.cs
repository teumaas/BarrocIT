namespace BarrocIT
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.txtHandleiding = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtHandleiding
            // 
            this.txtHandleiding.BackColor = System.Drawing.SystemColors.Window;
            this.txtHandleiding.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHandleiding.Location = new System.Drawing.Point(1, 1);
            this.txtHandleiding.Name = "txtHandleiding";
            this.txtHandleiding.ReadOnly = true;
            this.txtHandleiding.Size = new System.Drawing.Size(682, 559);
            this.txtHandleiding.TabIndex = 0;
            this.txtHandleiding.Text = "\n";
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.txtHandleiding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barroc IT - Help";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHelp_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtHandleiding;
    }
}