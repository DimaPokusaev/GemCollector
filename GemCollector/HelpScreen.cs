using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GemCollector
{
    public partial class HelpScreen : UserControl
    {
        public HelpScreen()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(180);
            SelectScreen.menuClick.Play();
            SelectScreen gs = new SelectScreen();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            f.Controls.Add(gs);
        }
    }
}
