namespace CarpetCalculatorAdvanced
{
    partial class FrmAddCarpet
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
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.lblQuality = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddCarpet = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Carpet Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtQuality
            // 
            this.txtQuality.Location = new System.Drawing.Point(129, 65);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(100, 20);
            this.txtQuality.TabIndex = 3;
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Location = new System.Drawing.Point(32, 69);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(73, 13);
            this.lblQuality.TabIndex = 2;
            this.lblQuality.Text = "Carpet Quality";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(129, 101);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(32, 105);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(65, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Carpet Price";
            // 
            // btnAddCarpet
            // 
            this.btnAddCarpet.Location = new System.Drawing.Point(35, 157);
            this.btnAddCarpet.Name = "btnAddCarpet";
            this.btnAddCarpet.Size = new System.Drawing.Size(86, 39);
            this.btnAddCarpet.TabIndex = 6;
            this.btnAddCarpet.Text = "Add a Carpet";
            this.btnAddCarpet.UseVisualStyleBackColor = true;
            this.btnAddCarpet.Click += new System.EventHandler(this.btnAddCarpet_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(143, 157);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 39);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back to Main";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmAddCarpet
            // 
            this.AcceptButton = this.btnAddCarpet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 224);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddCarpet);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtQuality);
            this.Controls.Add(this.lblQuality);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "FrmAddCarpet";
            this.Text = "Add a Carpet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtQuality;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddCarpet;
        private System.Windows.Forms.Button btnBack;
    }
}