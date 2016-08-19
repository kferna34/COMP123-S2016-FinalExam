using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace COMP123_S2016_FinalExam
{
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            
            InitializeComponent();
            
        }
        
        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm NavToAbilityGen = new AbilityGeneratorForm();//sends the user to the stream form 
            NavToAbilityGen.Show();
            this.Hide();
        }
    }
}
