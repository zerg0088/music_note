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
    public partial class Form1 : Form
    {
        private Boolean isTabOpen = false;
        private Boolean isTabClose = false;
        private noteManager notemanage;
        private int preTabIndex = -1;
        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0;

            introForm intro = new introForm(this);
            intro.Show();

            button_play.SendToBack();
            button_stop.SendToBack();

            loading_panel.Visible = false;

            notemanage = new noteManager(this);
        }

        private void convert_Click(object sender, EventArgs e)
        {
            if (loading_panel.Visible)
                loading_panel.Visible = false;
            else
                loading_panel.Visible = true;
        }

        /*private void tabsUp_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl page = sender as TabControl;
            if (page.SelectedIndex == 0)
            {
                tabControlInit();
                tabControlOpen();
            }
            else if (page.SelectedIndex == 1)
            {
                tabControlInit();
                tabControlOpen();
            }
            
        }*/
        private void tabControlInit()
        {
            tabsUp.Height = 26;
        }
        private void tabControlOpen()
        {
            isTabOpen = true;
            tabOpenTimer.Enabled = true;
            tabOpenTimer.Start();
        }

        private void tabOpenTimer_Tick(object sender, EventArgs e)
        {
            if (isTabOpen)
            {
                if (tabsUp.Height >= 160)
                {
                    tabOpenTimer.Enabled = false;
                    tabOpenTimer.Stop();
                    isTabOpen = false;
                    return;
                }
                tabsUp.Height += 12;
            }
            if (isTabClose)
            {
                if (tabsUp.Height <= 24)
                {
                    tabOpenTimer.Enabled = false;
                    tabOpenTimer.Stop();
                    isTabClose = false;
                    return;
                }
                tabsUp.Height -= 12;
            }
            
        }

        private void seletMenu(int index)
        {
            //TabControl page = sender as TabControl;
            if (preTabIndex == index)
            {
                isTabClose = true;
                tabOpenTimer.Enabled = true;
                tabOpenTimer.Start();
            }
            else
            {
                tabControlInit();
                tabControlOpen();
            }
            preTabIndex = index;
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            tabsUp.SelectedIndex = 0;
            seletMenu(0);
        }

        private void button_inst_Click(object sender, EventArgs e)
        {
            tabsUp.SelectedIndex = 1;
            seletMenu(1);
        }

        private void button_note_Click(object sender, EventArgs e)
        {
            tabsUp.SelectedIndex = 2;
            seletMenu(2);
        }

        private void button_sign_Click(object sender, EventArgs e)
        {
            tabsUp.SelectedIndex = 3;
            seletMenu(3);
        }
    }
}
