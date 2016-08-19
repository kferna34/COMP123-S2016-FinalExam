﻿using System;
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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LogoTimer.Enabled = false;
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
                LogoTimer.Stop();
            GenerateNameForm generateNameForm = new GenerateNameForm();
            generateNameForm.Show();
            this.Hide();
            
        }

       
    }
}
