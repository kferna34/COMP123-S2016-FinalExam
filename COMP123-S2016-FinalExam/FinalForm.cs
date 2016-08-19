using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace COMP123_S2016_FinalExam
{
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Character listInfo { get; set; }
        private void FinalForm_Load(object sender, EventArgs e)
        {
            Character Informations = new Character();

            Informations.listInfo = this;

            listInfo.LastName = this.LastNameTextBox.Text;//passes the title to the order form  
            listInfo.FirstName = this.FirstNameTextBox.Text;//passes the category to the order form
            listInfo.Strength = this.StrengthTextBox.Text;//passes the cost to the order form
            listInfo.Dexterity = this.DexterityTextBox.Text;
            listInfo.Constitution = this.ConstitutionTextBox.Text;
            listInfo.Intelligence = this.IntelligenceTextBox.Text;
            listInfo.Wisdom = this.WisdomTextBox.Text;
            listInfo.Charisma = this.CharismaTextBox.Text;
            listInfo.Race = this.raceTextBox.Text;
            
            
            this.Hide();
        }
    }
}
