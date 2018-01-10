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
    public partial class FrmCalculateCost : Form
    {
        public FrmCalculateCost()
        {
            InitializeComponent();
        }

        private void FrmCalculateCost_Load(object sender, EventArgs e)
        {
            //Add carpets to the carpet combobox
            foreach (Carpet ct in FrmMain.carpets)
            {
                cmbCarpet.Items.Add(ct.Name);
            }

            //Add rooms to the room combobox
            for (int i = 0; i < FrmMain.rooms.Count; i++)
            {
                Room rm = new Room();
                rm = (Room) FrmMain.rooms[i];

                cmbRoom.Items.Add(rm.Name);
            }

        }

        private void btnDisplayCost_Click(object sender, EventArgs e)
        {
            btnBack.Visible = true;
            Carpet selectedCt = new Carpet();
            Room selectedRm = new Room();
            int carpetNum,
                roomNum;
            double totalCost;

            //Figure out which carpet and room is selected
            carpetNum = cmbCarpet.SelectedIndex;
            roomNum = cmbRoom.SelectedIndex;

            //Find the correct carpet and room in thier respective lists
            selectedCt = (Carpet) FrmMain.carpets[carpetNum];
            selectedRm = (Room)FrmMain.rooms[roomNum];

            totalCost = selectedRm.CalculateArea() * selectedCt.Price;
            //Display out in rich textbox
            rtbOutput.Text = selectedCt.ToString() + "\n" +
                selectedRm.ToString() +
                "\nTotal Cost: " + totalCost.ToString("C");

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }
    }
}
