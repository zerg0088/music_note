using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tempWindow
{
    public partial class introForm : Form
    {
        private int delayCount = 50;
        private int count = 0;
        private Boolean isLoad = false;
        private Form pform;
        public introForm(Form p)
        {
            InitializeComponent();
            pform = p;
            this.Opacity = 0;
        }

        private void showTimer_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.05;
            if (this.Opacity == 1)
            {
                isLoad = true;
            }
            if (isLoad)
            {
                if (delayCount == count)
                {
                    showTimer.Stop();
                    showTimer.Enabled = false;
                   
                    this.Close();
                    pform.Opacity = 1;
                }
                count++;
            }
        }
    }
}
