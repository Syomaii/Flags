using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PhilippinesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PhilippinesRadioButton.Checked)
            {
                picBoxDisplay.Image = Image.FromFile(@"PhilippineFlag.png");
                CountryNameLabel.Text = "Philippines";
            }
        }

        private void ColombiaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ColombiaRadioButton.Checked == true)
            {
                picBoxDisplay.Image = Image.FromFile(@"ColombiaFlag.png");
                CountryNameLabel.Text = "Colombia";
            }
        }

        private void USARadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (USARadioButton.Checked == true)
            {
                picBoxDisplay.Image = Image.FromFile(@"USAFlag.png");
                CountryNameLabel.Text = "USA";
            }
        }

        private void FranceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            if (FranceRadioButton.Checked == true)
            {
                picBoxDisplay.Image = Image.FromFile(@"FranceFlag.png");
                CountryNameLabel.Text = "France";
            }
        }

        private void TitleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TitleCheckBox.Checked == true)
                FlagViewerLabel.Visible = true;
            else
                FlagViewerLabel.Visible = false;
        }

        private void CountryNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CountryNameCheckBox.Checked == true)
                CountryNameLabel.Visible = true;
            else
                CountryNameLabel.Visible = false;
        }

        private void ProgrammerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ProgrammerCheckBox.Checked == true )
            {
                ProgrammerLabel.Visible = true;
                ProgrammerLabel.Text = "Jose Roger Perez";
            }    
            else
                ProgrammerLabel.Visible = false;
        }

        private void picBoxDisplay_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void CountryNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProgrammerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
