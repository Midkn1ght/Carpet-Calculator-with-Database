namespace CarpetCalculatorAdvanced
{
    partial class FrmMain
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
            this.btnAddCarpet = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnCalculateCost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCarpet
            // 
            this.btnAddCarpet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCarpet.Location = new System.Drawing.Point(12, 12);
            this.btnAddCarpet.Name = "btnAddCarpet";
            this.btnAddCarpet.Size = new System.Drawing.Size(260, 95);
            this.btnAddCarpet.TabIndex = 0;
            this.btnAddCarpet.Text = "Add a Carpet";
            this.btnAddCarpet.UseVisualStyleBackColor = true;
            this.btnAddCarpet.Click += new System.EventHandler(this.btnAddCarpet_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.Location = new System.Drawing.Point(12, 113);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(260, 95);
            this.btnAddRoom.TabIndex = 1;
            this.btnAddRoom.Text = "Add a Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnCalculateCost
            // 
            this.btnCalculateCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateCost.Location = new System.Drawing.Point(12, 214);
            this.btnCalculateCost.Name = "btnCalculateCost";
            this.btnCalculateCost.Size = new System.Drawing.Size(260, 95);
            this.btnCalculateCost.TabIndex = 2;
            this.btnCalculateCost.Text = "Calculate Cost";
            this.btnCalculateCost.UseVisualStyleBackColor = true;
            this.btnCalculateCost.Click += new System.EventHandler(this.btnCalculateCost_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 320);
            this.Controls.Add(this.btnCalculateCost);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.btnAddCarpet);
            this.Name = "FrmMain";
            this.Text = "Carpet Calculatior Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCarpet;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnCalculateCost;
    }
}

