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

namespace ADTMPDapk
{
    public partial class frm_remboursement : Form
    {
        Remboursement remboursement = new Remboursement();
        clsRemboursement controller = new clsRemboursement();
        clsPret clsPret = new clsPret();

        public int unique_id = 0;
        clsUser clsUser = new clsUser();
        public string _enligne = dashboard._en_ligne;
        public void enregistrement()
        {
            if(txtmontant.Text !="" && txtperception.Text != "")
            {
                remboursement.Id_remb = unique_id;
                remboursement.Date = daterembousement.Value.Date;
                remboursement.IdPret = cmbmembre.SelectedValue.ToString();
                remboursement.MontantRemb = SqlMoney.Parse(txtmontant.Text);
                remboursement.Id_user = _enligne;

                controller.enregistrer_remboursement(remboursement);
            }
            else
            {
                MessageBox.Show("Tous les champs sont requis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public frm_remboursement()
        {
            InitializeComponent();
            txtperception.Text = clsUser.rechercher_noms_user_par_id(_enligne);
            txtperception.Enabled = false;
            clsPret.charger_listbox(cmbmembre);
        }

        private void btmfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            enregistrement();
        }
    }
}
