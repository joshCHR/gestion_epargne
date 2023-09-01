using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Windows.Forms;
using ADTMPDapk.Models;
using ADTMPDapk.Controllers;

namespace ADTMPDapk
{
    public partial class frm_emprunt : Form
    {
        Pret pret = new Pret();
        clsPret controller = new clsPret();
        clsMembre membre = new clsMembre();
        public int unique_id = 0;

        clsUser clsUser = new clsUser();
        public string _enligne = dashboard._en_ligne;
        ToolTip tool = new ToolTip();
        public frm_emprunt()
        {
            InitializeComponent();
            tool.SetToolTip(btnactualiser, "Actualiser");
            tool.SetToolTip(btnfermer, "Fermer");
            txtpercepteur.Text = clsUser.rechercher_noms_user_par_id(_enligne);
            txtpercepteur.Enabled = false;

            membre.charger_listbox(cmbmembre);
        }
        public void enregistrement()
        {
            if (txtdateversement.Text != "" && txtpercepteur.Text != "" &&
                txtsecteur.Text != "" && txtversement.Text != "")
            {
                pret.Id_pret = unique_id;
                pret.Date_pret = txtdateversement.Value.Date;
                pret.Secteur = txtsecteur.Text;
                pret.User = _enligne;
                pret.Membre = cmbmembre.SelectedValue.ToString();
                pret.Versement = SqlMoney.Parse(txtversement.Text);
          
                controller.enregistrer_pret(pret);
            }
            else
            {
                MessageBox.Show("Tous les champs sont requis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtdateNaiss_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnfermer_Click(object sender, EventArgs e)
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
            membre.charger_listbox(cmbmembre);
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            enregistrement();
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            txtdateversement.Text = "";
            txtpercepteur.Text = "";
            txtsecteur.Text = "";
            txtversement.Text = "";
        }
    }
}
