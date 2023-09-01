using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADTMPDapk.Controllers;
using ADTMPDapk.Models;
using System.Data.SqlTypes;
using ADTMPDapk.Views.UserControls;

namespace ADTMPDapk.Views.Forms
{
    public partial class frm_adhesion : Form
    {
        Adhesion adhesion = new Adhesion();
        clsAdhesion controller = new clsAdhesion();
        clsMembre membre = new clsMembre();
        uc_setting UserAdherer = new uc_setting();
        public int unique_id = 0;
        clsUser clsUser = new clsUser();
        public string _enligne = dashboard._en_ligne;
        public frm_adhesion()
        {
            InitializeComponent();
            membre.charger_listbox(cmbmembre1);
            txtpercepteur.Text = clsUser.rechercher_noms_user_par_id(_enligne);
            txtpercepteur.Enabled = false;
        }
        public void enregistrement()
        {
            if(txtdateversement.Text !="" && txtpercepteur.Text !="" && 
                txtsecteur.Text !="" && txtversement.Text != "")
            {
                adhesion.IdAhesion = unique_id;
                adhesion.MatriculeMembre = cmbmembre1.SelectedValue.ToString();
                adhesion.MontantAdhesion = SqlMoney.Parse(txtversement.Text);
                adhesion.MotifAdhesion = txtsecteur.Text;
                adhesion.StatutAdhesion = _enligne;
                adhesion.DateAdhesion = txtdateversement.Value.Date;
                if (unique_id == 0)
                {
                    controller.enregistrer_adhesion(adhesion);
                }
                else
                {
                    controller.modifier_adhesion(adhesion);
                }
                
            }
            else
            {
                MessageBox.Show("Tous les champs sont requis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            enregistrement();
            UserAdherer.actualiser();

        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            txtdateversement.Text = "";
            txtpercepteur.Text = "";
            txtsecteur.Text = "";
            
        }
    }
}
