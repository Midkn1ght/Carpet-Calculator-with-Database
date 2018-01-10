using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CarpetCalculatorAdvanced
{
    public partial class FrmMain : Form
    {
        public static ArrayList carpets = new ArrayList();
        public static ArrayList rooms = new ArrayList();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAddCarpet_Click(object sender, EventArgs e)
        {
            //Create an instance of the carpet form
            FrmAddCarpet carpetForm = new FrmAddCarpet();
            //show that form on the screen
            carpetForm.Show();
                   

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            //Create an instance of the room form
            FrmAddRoom roomForm = new FrmAddRoom();
            //show the form on the screen
            roomForm.Show();
        }

        private void btnCalculateCost_Click(object sender, EventArgs e)
        {
            //Create an object of the calculate cost button
            FrmCalculateCost costForm = new FrmCalculateCost();
            //Show form on screen
            costForm.Show();
        }
    }
}
