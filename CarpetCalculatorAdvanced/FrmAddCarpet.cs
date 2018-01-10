using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarpetCalculatorAdvanced
{
    public partial class FrmAddCarpet : Form
    {
        public FrmAddCarpet()
        {
            InitializeComponent();
        }

        private void btnAddCarpet_Click(object sender, EventArgs e)
        {
            double price;
            //Check if textbox is empty or has a white spaces
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                //Display Error message
                MessageBox.Show("Carpet Name empty! Please re-enter");
                //Clear textbox
                txtName.Clear();
                //Focus on text box
                txtName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtQuality.Text))
            {
                //Display Error message
                MessageBox.Show("Carpet Quality empty! Please re-enter");
                //Clear textbox
                txtQuality.Clear();
                //Focus on text box
                txtQuality.Focus();
            }
            else if (double.TryParse(txtPrice.Text, out price) == false)
            {
                //Display Error message
                MessageBox.Show("Carpet Price invalid! Please re-enter");
                //Clear textbox
                txtPrice.Clear();
                //Focus on text box
                txtPrice.Focus();
            }
            else
            {
                //All data validation has passed - add carpet to the list
                //Create temp carpet object
                Carpet myCarpet = new Carpet();
                //Add information from the form to the carpet object
                myCarpet.Name = txtName.Text;
                myCarpet.Quality = txtQuality.Text;
                myCarpet.Price = price;

                //Add object to list of carpets - arraylist in Main form
                FrmMain.carpets.Add(myCarpet);
                //let the user know carpet is added
                MessageBox.Show("Carpet Added!");
                //Clear textboxes to allow user to add a new carpet
                txtName.Clear();
                txtPrice.Clear();
                txtQuality.Clear();
                //Set focus on name textbox
                txtName.Focus();



            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
