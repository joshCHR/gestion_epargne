using System;
using System.Windows.Forms;
using ADTMPDapk.Models;
using ADTMPDapk.Views.Forms;
using ADTMPDapk.Controllers;

namespace ADTMPDapk.Views.UserControls
{
    public partial class uc_setting : UserControl
        
    {
        clsTypeMembre clsTypeMembre = new clsTypeMembre();
        clsAdhesion clsAdhesion = new clsAdhesion();
        clsUser clsUser = new clsUser();
        clsEtat_financier etatFin = new clsEtat_financier();

        Type_membre type_Membre = new Type_membre();
        Adhesion adhesion = new Adhesion();
        User user = new User();
        ToolTip tool = new ToolTip();

        public string level;
        public string _enligne = dashboard._en_ligne;
        public uc_setting()
        {
            InitializeComponent();
            tool.SetToolTip(btnactualisertype,"Actualiser");
            tool.SetToolTip(btnAddTypeMembre, "Ajouter le type de membre");
            actualiser();
            afficher_adhesion();
            afficher_user();
            Actualiser();
            // Affectation du level
            level = clsUser.select_level(_enligne);
            restrictions(level);
        }
        public void restrictions(string txt)
        {
            if(txt != "0")
            {
                dtgvAdhesion.Visible = false;
                txtsearchadhesion.Visible = false;
                btnactualiseradhesion.Visible = false;
                btnAddAdhesion.Visible = false;
                panUsers.Visible = false;
            }
        }
        public void actualiser()
        {
            
            clsTypeMembre.afficher_type_membre(dtg_typeMembre);
        }
        public void afficher_adhesion()
        {
            clsAdhesion.afficher_adhesion(dtgvAdhesion);
        }
        public void afficher_user()
        {
            clsUser.afficher_user(dtgv_users);
        }
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var frm = new frm_typemembre();
            frm.ShowDialog();
        }

        private void Actualiser()
        {
            etatFin.etat_financier(dtg_etatFin);
        }

        private void uc_setting_Load(object sender, System.EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btnactualiser_Click(object sender, System.EventArgs e)
        {
            actualiser();
        }

        private void txtsearchtype_TextChanged(object sender, EventArgs e)
        {
            clsTypeMembre.rechercher_type_membres(txtsearchtype.Text, dtg_typeMembre);
        }

        private void dtg_typeMembre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Confimer la suppression!!!", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialogResult == DialogResult.Yes)
                {
                    type_Membre.Id_type_membre = dtg_typeMembre.CurrentRow.Cells[1].Value.ToString();
                    clsTypeMembre.supprimer_type_membre(type_Membre);
                    actualiser();
                }
            }
            else
            {
                var frm = new frm_typemembre();
                frm.txtid.Text = dtg_typeMembre.CurrentRow.Cells[1].Value.ToString();
                frm.txtdesignation.Text = dtg_typeMembre.CurrentRow.Cells[2].Value.ToString();
                frm.ShowDialog();
            }
        }

        private void btnAddAdhesion_Click(object sender, EventArgs e)
        {
            var fr = new frm_adhesion();
            fr.ShowDialog();
        }

        private void btnactualiseradhesion_Click(object sender, EventArgs e)
        {
            afficher_adhesion();
        }

        private void txtsearchadhesion_TextChanged(object sender, EventArgs e)
        {
            clsAdhesion.rechercher_epargne(txtsearchadhesion.Text, dtgvAdhesion);
        }

        private void dtgvAdhesion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Confirmer la suppression", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    adhesion.IdAhesion = Int32.Parse(dtgvAdhesion.CurrentRow.Cells[1].Value.ToString());
                    clsAdhesion.supprimer_adhesion(adhesion);
                }
            }
            else
            {
                var fr = new frm_adhesion();
                fr.unique_id = Int32.Parse(dtgvAdhesion.CurrentRow.Cells[1].Value.ToString());
                fr.cmbmembre1.SelectedItem = dtgvAdhesion.CurrentRow.Cells[2].Value.ToString();
                fr.txtdateversement.Text = dtgvAdhesion.CurrentRow.Cells[3].Value.ToString();
                fr.txtversement.Text = dtgvAdhesion.CurrentRow.Cells[4].Value.ToString();
                fr.txtsecteur.Text = dtgvAdhesion.CurrentRow.Cells[5].Value.ToString();
                fr.ShowDialog();
                

            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var fr = new frm_user();
            fr.ShowDialog();
        }

        private void btnRefreshUser_Click(object sender, EventArgs e)
        {
            afficher_user();
        }

        private void txtsearchuser_TextChanged(object sender, EventArgs e)
        {
            clsUser.rechercher_user(txtsearchuser.Text, dtgv_users);
        }

        private void dtgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
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
                if(statut == "on")
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
