namespace CarpetCalculatorAdvanced
{
    partial class FrmCalculateCost
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
            this.lblCarpet = new System.Windows.Forms.Label();
            this.cmbCarpet = new System.Windows.Forms.ComboBox();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.btnDisplayCost = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblCarpet
            // 
            this.lblCarpet.AutoSize = true;
            this.lblCarpet.Location = new System.Drawing.Point(30, 32);
            this.lblCarpet.Name = "lblCarpet";
            this.lblCarpet.Size = new System.Drawing.Size(77, 13);
            this.lblCarpet.TabIndex = 0;
            this.lblCarpet.Text = "Choose Carpet";
            // 
            // cmbCarpet
            // 
            this.cmbCarpet.FormattingEnabled = true;
            this.cmbCarpet.Location = new System.Drawing.Point(134, 28);
            this.cmbCarpet.Name = "cmbCarpet";
            this.cmbCarpet.Size = new System.Drawing.Size(121, 21);
            this.cmbCarpet.TabIndex = 1;
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(134, 65);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(121, 21);
            this.cmbRoom.TabIndex = 3;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(30, 69);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(74, 13);
            this.lblRoom.TabIndex = 2;
            this.lblRoom.Text = "Choose Room";
            // 
            // btnDisplayCost
            // 
            this.btnDisplayCost.Location = new System.Drawing.Point(9, 104);
            this.btnDisplayCost.Name = "btnDisplayCost";
            this.btnDisplayCost.Size = new System.Drawing.Size(122, 47);
            this.btnDisplayCost.TabIndex = 4;
            this.btnDisplayCost.Text = "Display Cost";
            this.btnDisplayCost.UseVisualStyleBackColor = true;
            this.btnDisplayCost.Click += new System.EventHandler(this.btnDisplayCost_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(152, 104);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 47);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back to Main";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(9, 158);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(263, 119);
            this.rtbOutput.TabIndex = 6;
            this.rtbOutput.Text = "";
            // 
            // FrmCalculateCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 289);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDisplayCost);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.cmbCarpet);
            this.Controls.Add(this.lblCarpet);
            this.Name = "FrmCalculateCost";
            this.Text = "Calculate Cost";
            this.Load += new System.EventHandler(this.FrmCalculateCost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarpet;
        private System.Windows.Forms.ComboBox cmbCarpet;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Button btnDisplayCost;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}