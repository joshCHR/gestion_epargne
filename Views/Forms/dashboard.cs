using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADTMPDapk.Views.UserControls;
using BunifuAnimatorNS;


namespace ADTMPDapk
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngrandure_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btngestion_Click(object sender, EventArgs e)
        {
        //    if (panelmenu.Width == 40)
        //    {
           
                 // panelMenu1.Visible = true;
        //        panelmenu.Width = 95;
        //        panelAnimation.ShowSync(panelmenu);
        //    }
        //    else
        //    {
        //        panelmenu.Visible = false;
        //        panelmenu.Width = 40;
        //        panelAnimation.ShowSync(panelmenu);
        //    }
        }

        private void btnhomeretour_Click(object sender, EventArgs e)
        {
        //    if (panelMenu1.Width == 52)
        //       {

        //         panelMenu1.Visible = true;
        //        panelMenu1.Width = 300;
        //        panel_control.Width = 1000;
        //        panelAnimation.ShowSync(panelMenu1);
        //    }
        //    else
        //    {
        //        panelMenu1.Visible = false;
        //        panelMenu1.Width = 52;
        //        panelAnimation.ShowSync(panelMenu1);
        //    }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            labeltitre.Text = "dashboard";
            var fr = new uc_dashoard()
            {
                Size = panel_control.Size
            };
            panel_control.Controls.Clear();
            panel_control.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = AnimationType.Custom;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void btnmembre_Click(object sender, EventArgs e)
        {
            labeltitre.Text = "Membres";
            var fr = new uc_membre()
            {
                Size = panel_control.Size
            };
            panel_control.Controls.Clear();
            panel_control.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = AnimationType.Custom;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            labeltitre.Text = "Emprunt";
            var fr = new uc_emprunt()
            {
                Size = panel_control.Size
            };
            panel_control.Controls.Clear();
            panel_control.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = AnimationType.Custom;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            labeltitre.Text = "Setting";
            var fr = new uc_setting()
            {
                Size = panel_control.Size
            };
            panel_control.Controls.Clear();
            panel_control.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = AnimationType.Custom;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void btnepargne_Click(object sender, EventArgs e)
        {
            labeltitre.Text = "Epargne";
            var fr = new uc_epargne()
            {
                Size = panel_control.Size
            };
            panel_control.Controls.Clear();
            panel_control.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = AnimationType.Custom;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void btnremboursement_Click(object sender, EventArgs e)
        {
            labeltitre.Text = "Remboursement";
            var fr = new uc_remboursement()
            {
                Size = panel_control.Size
            };
            panel_control.Controls.Clear();
            panel_control.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = AnimationType.Custom;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void btnparamettre_Click(object sender, EventArgs e)
        {
            labeltitre.Text = "Parametre";
            var fr = new uc_paramettre()
            {
                Size = panel_control.Size
            };
            panel_control.Controls.Clear();
            panel_control.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = AnimationType.Custom;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }
    }
}
