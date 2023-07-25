using System;

using System.Windows.Forms;
using ADTMPDapk.Backend.Controllers;
using ADTMPDapk.Models;


namespace ADTMPDapk
{
    public partial class frm_membre : Form
    {
        clsMembre membre = new clsMembre();
        Membre membreModel = new Membre();
        
     public frm_membre()
        {
            InitializeComponent();
            
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
            membreModel.matricule = txtmatricule.Text;
            membreModel.nom = txtnom.Text;
            membreModel.postnom = txtpostnom.Text;
            membreModel.adresse = txtadresse.Text;
            membreModel.phone = txtphone.Text;
            membreModel.sexe = cmbsexe.SelectedItem.ToString();
            membreModel.lieuNaiss = txtlieuNaiss.Text;
            membreModel.dateNaiss = txtdateNaiss.Value;
            
            //membreModel.photo = pictureBox1.Image;
            membre.enregistrer_mambre(membreModel);
        }
        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            ajout();
            Refresh();
            
        }
    }
}
