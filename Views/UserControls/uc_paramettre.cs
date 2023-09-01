using System;
using System.Windows.Forms;
using ADTMPDapk.Views.Forms;
using ADTMPDapk.Controllers;
using ADTMPDapk.Models;

namespace ADTMPDapk.Views.UserControls
{
    public partial class uc_paramettre : UserControl
    {
        clsTypeMembre clsTypeMembre = new clsTypeMembre();
        clsAdhesion clsAdhesion = new clsAdhesion();
        clsUser clsUser = new clsUser();

        Type_membre type_Membre = new Type_membre();
        Adhesion adhesion = new Adhesion();
        User user = new User();
        ToolTip tool = new ToolTip();

        public string level;
        public string _enligne = dashboard._en_ligne;
        //private object clsUser;

        public uc_paramettre()
        {
            InitializeComponent();
            tool.SetToolTip(btnactualiser, "Actualiser");
            tool.SetToolTip(btnAdd, "Ajouter le type de membre");
            actualiser();
            afficher_adhesion();
            afficher_user();
            // Affectation du level
            level = clsUser.select_level(_enligne);
            restrictions(level);
        }
        public void actualiser()
        {

            clsTypeMembre.afficher_type_membre(dtg_typeMembre);
        }
        public void afficher_adhesion()
        {
            clsAdhesion.afficher_adhesion(dtgvAdhesion);
        }

        private void btnhomeretour_Click(object sender, EventArgs e)
        {

        }

        private void uc_paramettre_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnadhesion_Click(object sender, EventArgs e)
        {
            var adhesion = new frm_adhesion();
            adhesion.ShowDialog();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {

        }

        private void dtgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Confirmer la suppression", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    user.Id_user = dtgv_users.CurrentRow.Cells[1].Value.ToString();
                    clsUser.supprimer_user(user);
                }
            }
            else
            {
                string statut = dtgv_users.CurrentRow.Cells[6].Value.ToString();
                var fr = new frm_user();
                fr.txtmatricule.Text = dtgv_users.CurrentRow.Cells[1].Value.ToString();
                fr.txtnom.Text = dtgv_users.CurrentRow.Cells[2].Value.ToString();
                fr.txtpostnom.Text = dtgv_users.CurrentRow.Cells[3].Value.ToString();
                fr.txtposte.Text = dtgv_users.CurrentRow.Cells[4].Value.ToString();
                fr.cmbniveau.SelectedItem = dtgv_users.CurrentRow.Cells[5].Value.ToString();
                if (statut == "on")
                {
                    fr.checkStatut.Text = "On";
                    fr.checkStatut.Checked = true;
                }
                else if (statut == "off")
                {
                    fr.checkStatut.Text = "Off";
                    fr.checkStatut.Checked = false;
                }
                fr.is_update = true;
                fr.ShowDialog();
            }
        }
    }
    }

