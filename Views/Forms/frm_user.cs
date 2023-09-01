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

namespace ADTMPDapk.Views.Forms
{
    public partial class frm_user : Form
    {
        clsUser controller = new clsUser();
        User model = new User();

        public bool is_update;
        public frm_user()
        {
            InitializeComponent();
        }

        private void btmfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbsexe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            enregistrer_user();
        }
        public void enregistrer_user()
        {
            if(txtmatricule.Text !="" && txtnom.Text != "" && txtposte.Text !="" && txtpostnom.Text !="")
            {
                model.Id_user = txtmatricule.Text.Trim();
                if (cmbniveau.SelectedItem.ToString() == "1")
                {
                    model.Levels = "1";
                }else if(cmbniveau.SelectedItem.ToString() == "2")
                {
                    model.Levels = "2";
                }else if(cmbniveau.SelectedItem.ToString() == "3")
                {
                    model.Levels = "3";
                }
   
                model.Levels = cmbniveau.SelectedItem.ToString();
                model.Nom = txtnom.Text.Trim();
                model.Postnom = txtpostnom.Text.Trim();
                model.Poste = txtposte.Text.Trim();

                if(checkStatut.Checked == true)
                {
                    checkStatut.Text = "On";
                    model.Statut = "on";
                }
                else
                {
                    model.Statut = "off";
                }
                

                bool check_user_already_exist = controller.user_exist(model);
                bool check_names_already_exist = controller.names_exist(model);
                bool check_poste = controller.user_affected(model);

                // Verifier si c'est l'ajout ou la modification

                if (is_update != true) {
                    // Check if the names already exist
                    if (check_names_already_exist != true)
                    {
                        // Check if an other user is not affected to she service
                        if (check_poste != true)
                        {
                            // Check if the username already exist
                            if (check_user_already_exist != true)
                            {
                                controller.enregistrer_user(model);
                            }
                            else
                            {
                                MessageBox.Show("Le nom d'utilisateur " + txtmatricule.Text + " existe deja", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Le poste " + txtposte.Text + " en occupation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le nom et postnom " + txtnom.Text + " " + txtpostnom.Text + " existent deja", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                   controller.enregistrer_user(model);
                }
                
            }
            else
            {
                MessageBox.Show("Tous les champs sont requis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkStatut_Click(object sender, EventArgs e)
        {
            if(checkStatut.Text == "On")
            {
                checkStatut.Text = "Off";
            }
            else
            {
                checkStatut.Text = "On";
            }
                
          
        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm = new frm_login();
            frm.ShowDialog();
        }
    }
}
