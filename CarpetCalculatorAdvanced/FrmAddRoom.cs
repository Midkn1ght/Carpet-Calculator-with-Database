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
    public partial class FrmAddRoom : Form
    {
        public FrmAddRoom()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            int lFt,
                lIn,
                wFt,
                wIn;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                //Display Error message
                MessageBox.Show("Room Name empty! Please re-enter");
                //Clear textbox
                txtName.Clear();
                //Focus on text box
                txtName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                //Display Error message
                MessageBox.Show("Room Location empty! Please re-enter");
                //Clear textbox
                txtLocation.Clear();
                //Focus on text box
                txtLocation.Focus();
            }
            else if (int.TryParse(txtLengthFt.Text, out lFt) == false)
            {
                //Display Error message
                MessageBox.Show("Room length in feet invalid! Please re-enter");
                //Clear textbox
                txtLengthFt.Clear();
                //Focus on text box
                txtLengthFt.Focus();
            }
            else if (int.TryParse(txtLengthIn.Text, out lIn) == false)
            {
                //Display Error message
                MessageBox.Show("Room length in feet invalid! Please re-enter");
                //Clear textbox
                txtLengthIn.Clear();
                //Focus on text box
                txtLengthIn.Focus();
            }
            else if (int.TryParse(txtWidthFt.Text, out wFt) == false)
            {
                //Display Error message
                MessageBox.Show("Room length in feet invalid! Please re-enter");
                //Clear textbox
                txtWidthFt.Clear();
                //Focus on text box
                txtWidthFt.Focus();
            }
            else if (int.TryParse(txtWidthIn.Text, out wIn) == false)
            {
                //Display Error message
                MessageBox.Show("Room length in feet invalid! Please re-enter");
                //Clear textbox
                txtWidthIn.Clear();
                //Focus on text box
                txtWidthIn.Focus();
            }
            else
            {
                //All validation passed, store information in a Room object
                Room myRoom = new Room();
                //Add information from the form to the object
                myRoom.Name = txtName.Text;
                myRoom.Location = txtLocation.Text;
                myRoom.LengthFt = lFt;
                myRoom.LengthIn = lIn;
                myRoom.WidthFt = wFt;
                myRoom.WidthIn = wIn;

                //Add room to the list of rooms
                FrmMain.rooms.Add(myRoom);
                //Display message to inform room has been added
                MessageBox.Show("Room Added!");
                //Reset all text boxes
                txtName.Clear();
                txtLocation.Clear();
                txtLengthFt.Clear();
                txtLengthIn.Clear();
                txtWidthFt.Clear();
                txtWidthIn.Clear();
                //Set the focus to the name textbox
                txtName.Focus();



            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Closes this form
            this.Close();
        }
    }
}
