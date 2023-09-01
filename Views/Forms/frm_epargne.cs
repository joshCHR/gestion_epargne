using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADTMPDapk.Models;
using ADTMPDapk.Controllers;
using System.Data.SqlTypes;
namespace ADTMPDapk
{
    public partial class frm_epargne : Form
    {
        Epargne epargne = new Epargne();
        clsEpargne controller = new clsEpargne();
        clsMembre clsMembre = new clsMembre();
        ToolTip tool = new ToolTip();

        public int unique_id = 0;
        clsUser clsUser = new clsUser();
        public string _enligne = dashboard._en_ligne;
        public frm_epargne()
        {
            InitializeComponent();
            tool.SetToolTip(btnactualiser, "Actualiser");
            tool.SetToolTip(btnaddref, "Faire la reference a un membre");
            tool.SetToolTip(btmfermer, "Fermer");
            txtperception.Text = clsUser.rechercher_noms_user_par_id(_enligne);
            txtperception.Enabled = false;

            clsMembre.charger_listbox(cmbmembre);
        }
        public void enregistrement()
        {
            if(txtdesignation.Text !="" && txtlibelle.Text!= ""&&
                txtnemeroEpargne.Text!= "" && txtperception.Text !="" && txtversement.Text != "")
            {
                epargne.IdEpargne = unique_id;
                epargne.DesignationEpargne = txtdesignation.Text;
                epargne.DateVersement = txtdateNaiss.Value.Date;
                epargne.IdUser = _enligne;
                epargne.LibeleCompte = txtlibelle.Text;
                epargne.MatriculeMembre = cmbmembre.SelectedValue.ToString();
                epargne.MontantEpargne = SqlMoney.Parse(txtversement.Text);
                epargne.NumeroEpargne = txtnemeroEpargne.Text;

                controller.enregistrer_epargne(epargne);
            }
            else
            {
                MessageBox.Show("Tous les champs sont requis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            enregistrement();
            refresh();
        }

        private void btmfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaddref_Click(object sender, EventArgs e)
        {
            var fr = new frm_membre();
            fr.ShowDialog();
        }

        private void cmbmembre_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsMembre.charger_listbox(cmbmembre);
        }
        private void refresh()
        {
            txtdateNaiss.Text = "";
            txtdesignation.Text = "";
            txtlibelle.Text = "";
            txtnemeroEpargne.Text = "";
            txtperception.Text = "";
            txtversement.Text = "";
        }
        private void btnactualiser_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
