using System;
using System.Windows.Forms;
using ADTMPDapk.Models;
using ADTMPDapk.Views.Forms;
using ADTMPDapk.Controllers;
using ADTMPDapk.Models;
using Guna.UI2.WinForms;
using ADTMPDapk.Views.Forms;

namespace ADTMPDapk
{
    public partial class frm_membre : Form
    {
        clsMembre membre = new clsMembre();
        clsTypeMembre typeMembre = new clsTypeMembre();
        Membre modelMembre = new Membre();
        Membre membreModel = new Membre();

        ToolTip tool = new ToolTip();


        public int id = 0;
        
     public frm_membre()
        {
            InitializeComponent();
            tool.SetToolTip(btnactualiser,"Atualiser");
            tool.SetToolTip(btmfermer,"Fermer");
            typeMembre.charger_listbox(cmbtypeMembre);
            
        }
        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

                  }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmatricule_Click(object sender, EventArgs e)
        {
            lbl_matricule.Visible = true;
        }
           
        private void ajout()
        {
            if(txtmatricule.Text !="" && txtadresse.Text!="" && 
                txtlieuNaiss.Text !="" && txtnom.Text!="" && 
                txtphone.Text !="" && txtpostnom.Text != "")
            {
                membreModel.matricule = txtmatricule.Text;
                membreModel.nom = txtnom.Text;
                membreModel.postnom = txtpostnom.Text;
                membreModel.adresse = txtadresse.Text;
                membreModel.phone = txtphone.Text;
                membreModel.sexe = cmbsexe.SelectedItem.ToString();
                membreModel.lieuNaiss = txtlieuNaiss.Text;
                membreModel.dateNaiss = txtdateNaiss.Value.Date;
                // membreModel.photo = pictureBox1;
                membreModel.ref_type = cmbtypeMembre.SelectedValue.ToString();
                membre.enregistrer_mambre(membreModel);


            }
            else
            {
                MessageBox.Show("Tous les champs sont requis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            ajout();
            Actualiser();
            Refresh();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //membre.modifier_mambre(membreModel);
            //var frm = new frm_login();
            //frm.Show();
        }
        private  void Actualiser()
        {
            txtmatricule.Text="";
            txtnom.Text = "";
            txtpostnom.Text = "";
            txtphone.Text = "";
            txtadresse.Text = "";
            txtdateNaiss.Text = "";
           
        }

        private void btnAddTypeMembre_Click(object sender, EventArgs e)
        {
            var frm = new frm_typemembre();
            frm.ShowDialog();

        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            Actualiser();
        }
    }
}
