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

            Program.character.LastName = this.LastNameTextBox.Text;//passes the title to the order form  
            Program.character.FirstName = this.FirstNameTextBox.Text;//passes the category to the order form
            Program.character.Strength = this.StrengthTextBox.Text;//passes the cost to the order form
            Program.character.Dexterity = this.DexterityTextBox.Text;
            Program.character.Constitution = this.ConstitutionTextBox.Text;
            Program.character.Intelligence = this.IntelligenceTextBox.Text;
            Program.character.Wisdom = this.WisdomTextBox.Text;
            Program.character.Charisma = this.CharismaTextBox.Text;
            Program.character.Race = this.raceTextBox.Text;

            
            

        }
    }
}
