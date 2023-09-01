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
using ADTMPDapk.Views.Forms;

namespace ADTMPDapk
{
    public partial class dashboard : Form
    {
        ToolTip ToolTip = new ToolTip();
        public static string _en_ligne;
        public dashboard(string en_ligne)
        {
            InitializeComponent();
            ToolTip.SetToolTip(btnhomeretour, "Home");
            ToolTip.SetToolTip(btngrandure, "Grandir"); 
            ToolTip.SetToolTip(btnreduire, "Reduire");
            ToolTip.SetToolTip(btmfermer, "Fermer");
            ToolTip.SetToolTip(btndashboard, "Dashboard");
            ToolTip.SetToolTip(btnmembre, "Membre");
            ToolTip.SetToolTip(btnemprunt, "Emprunt");
            ToolTip.SetToolTip(btnepargne, "Epargne");
            ToolTip.SetToolTip(btnremboursement, "Remboursement");
            ToolTip.SetToolTip(btnsetting, "Setting");
            ToolTip.SetToolTip(btnparamettre, "Paramèttre");
            ToolTip.SetToolTip(btnrestitution, "Restitution");
            ToolTip.SetToolTip(btnSinup, "Se connecter");

            _en_ligne = en_ligne;

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
            labeltitre.Text = "EpargneSystem-dashboard";
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
            
            labeltitre.Text = "EpargneSystem-Membres";
            var fr = new uc_membre()
            {
                Size = panel_control.Size
            };
            fr.label1.Text = ("Membre");
            panel_control.Controls.Clear();
            panel_control.Controls.Add(fr);
            fr.Visible = false;
            bunifuTransition1.AnimationType = AnimationType.Custom;
            bunifuTransition1.ShowSync(fr);
            fr.Visible = true;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            labeltitre.Text = "EpargneSystem-Emprunt";
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
            labeltitre.Text = "EpargneSystem-Setting";
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
            labeltitre.Text = "EpargneSystem-Epargne";
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
            labeltitre.Text = "EpargneSystem-Remboursement";
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
            //labeltitre.Text = "EpargneSystem-Parametre";
            //var fr = new uc_paramettre()
            //{
            //    Size = panel_control.Size
            //};
            //panel_control.Controls.Clear();
            //panel_control.Controls.Add(fr);
            //fr.Visible = false;
            //bunifuTransition1.AnimationType = AnimationType.Custom;
            //bunifuTransition1.ShowSync(fr);
            //fr.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnrestitution_Click(object sender, EventArgs e)
        {
            labeltitre.Text = "EpargneSystem-Restitution";
            var fr = new uc_restitution()
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

        private void dashboard_Load(object sender, EventArgs e)
        {
            
        }

       

        private void btnSinup_Click(object sender, EventArgs e)
        {
            var frm = new frm_login();
            frm.ShowDialog();

        }

        private void btnreduire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
