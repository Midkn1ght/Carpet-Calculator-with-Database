namespace CarpetCalculatorAdvanced
{
    partial class FrmAddRoom
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.grpLength = new System.Windows.Forms.GroupBox();
            this.txtLengthIn = new System.Windows.Forms.TextBox();
            this.lblLengthIn = new System.Windows.Forms.Label();
            this.txtLengthFt = new System.Windows.Forms.TextBox();
            this.lblLengthFt = new System.Windows.Forms.Label();
            this.grpWidth = new System.Windows.Forms.GroupBox();
            this.txtWidthIn = new System.Windows.Forms.TextBox();
            this.txtWidthFt = new System.Windows.Forms.TextBox();
            this.lblWidthIn = new System.Windows.Forms.Label();
            this.lblWidthFt = new System.Windows.Forms.Label();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpLength.SuspendLayout();
            this.grpWidth.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Room Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(131, 49);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 3;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(42, 53);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(79, 13);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Room Location";
            // 
            // grpLength
            // 
            this.grpLength.Controls.Add(this.txtLengthIn);
            this.grpLength.Controls.Add(this.lblLengthIn);
            this.grpLength.Controls.Add(this.txtLengthFt);
            this.grpLength.Controls.Add(this.lblLengthFt);
            this.grpLength.Location = new System.Drawing.Point(12, 102);
            this.grpLength.Name = "grpLength";
            this.grpLength.Size = new System.Drawing.Size(125, 117);
            this.grpLength.TabIndex = 4;
            this.grpLength.TabStop = false;
            this.grpLength.Text = "Length";
            // 
            // txtLengthIn
            // 
            this.txtLengthIn.Location = new System.Drawing.Point(69, 72);
            this.txtLengthIn.Name = "txtLengthIn";
            this.txtLengthIn.Size = new System.Drawing.Size(34, 20);
            this.txtLengthIn.TabIndex = 3;
            // 
            // lblLengthIn
            // 
            this.lblLengthIn.AutoSize = true;
            this.lblLengthIn.Location = new System.Drawing.Point(7, 73);
            this.lblLengthIn.Name = "lblLengthIn";
            this.lblLengthIn.Size = new System.Drawing.Size(39, 13);
            this.lblLengthIn.TabIndex = 2;
            this.lblLengthIn.Text = "Inches";
            // 
            // txtLengthFt
            // 
            this.txtLengthFt.Location = new System.Drawing.Point(69, 30);
            this.txtLengthFt.Name = "txtLengthFt";
            this.txtLengthFt.Size = new System.Drawing.Size(34, 20);
            this.txtLengthFt.TabIndex = 1;
            // 
            // lblLengthFt
            // 
            this.lblLengthFt.AutoSize = true;
            this.lblLengthFt.Location = new System.Drawing.Point(7, 31);
            this.lblLengthFt.Name = "lblLengthFt";
            this.lblLengthFt.Size = new System.Drawing.Size(28, 13);
            this.lblLengthFt.TabIndex = 0;
            this.lblLengthFt.Text = "Feet";
            // 
            // grpWidth
            // 
            this.grpWidth.Controls.Add(this.txtWidthIn);
            this.grpWidth.Controls.Add(this.txtWidthFt);
            this.grpWidth.Controls.Add(this.lblWidthIn);
            this.grpWidth.Controls.Add(this.lblWidthFt);
            this.grpWidth.Location = new System.Drawing.Point(147, 102);
            this.grpWidth.Name = "grpWidth";
            this.grpWidth.Size = new System.Drawing.Size(125, 117);
            this.grpWidth.TabIndex = 5;
            this.grpWidth.TabStop = false;
            this.grpWidth.Text = "Width";
            // 
            // txtWidthIn
            // 
            this.txtWidthIn.Location = new System.Drawing.Point(76, 73);
            this.txtWidthIn.Name = "txtWidthIn";
            this.txtWidthIn.Size = new System.Drawing.Size(34, 20);
            this.txtWidthIn.TabIndex = 9;
            // 
            // txtWidthFt
            // 
            this.txtWidthFt.Location = new System.Drawing.Point(76, 31);
            this.txtWidthFt.Name = "txtWidthFt";
            this.txtWidthFt.Size = new System.Drawing.Size(34, 20);
            this.txtWidthFt.TabIndex = 7;
            // 
            // lblWidthIn
            // 
            this.lblWidthIn.AutoSize = true;
            this.lblWidthIn.Location = new System.Drawing.Point(14, 74);
            this.lblWidthIn.Name = "lblWidthIn";
            this.lblWidthIn.Size = new System.Drawing.Size(39, 13);
            this.lblWidthIn.TabIndex = 8;
            this.lblWidthIn.Text = "Inches";
            // 
            // lblWidthFt
            // 
            this.lblWidthFt.AutoSize = true;
            this.lblWidthFt.Location = new System.Drawing.Point(14, 32);
            this.lblWidthFt.Name = "lblWidthFt";
            this.lblWidthFt.Size = new System.Drawing.Size(28, 13);
            this.lblWidthFt.TabIndex = 6;
            this.lblWidthFt.Text = "Feet";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(12, 226);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(103, 54);
            this.btnAddRoom.TabIndex = 6;
            this.btnAddRoom.Text = "Add a Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(169, 226);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 54);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back to Main";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmAddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 292);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.grpWidth);
            this.Controls.Add(this.grpLength);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "FrmAddRoom";
            this.Text = "Add a Room";
            this.grpLength.ResumeLayout(false);
            this.grpLength.PerformLayout();
            this.grpWidth.ResumeLayout(false);
            this.grpWidth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.GroupBox grpLength;
        private System.Windows.Forms.TextBox txtLengthIn;
        private System.Windows.Forms.Label lblLengthIn;
        private System.Windows.Forms.TextBox txtLengthFt;
        private System.Windows.Forms.Label lblLengthFt;
        private System.Windows.Forms.GroupBox grpWidth;
        private System.Windows.Forms.TextBox txtWidthIn;
        private System.Windows.Forms.TextBox txtWidthFt;
        private System.Windows.Forms.Label lblWidthIn;
        private System.Windows.Forms.Label lblWidthFt;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnBack;
    }
}