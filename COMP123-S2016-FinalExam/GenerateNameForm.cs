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
            //showing the logo
            Thread LogoScreen = new Thread(new ThreadStart(SplashForm));
            LogoScreen.Start();
            Thread.Sleep(1000);
            InitializeComponent();
            LogoScreen.Abort();// close the logo
        }
        public void SplashForm()
        {
            Application.Run(new SplashForm());
        }

    }
}
