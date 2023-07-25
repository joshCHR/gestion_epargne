using System;
using System.Windows.Forms;
using ADTMPDapk.Backend.Controllers;
using ADTMPDapk.Models;
using ADTMPDapk.Views.Forms;



namespace ADTMPDapk.Views.UserControls
{
    public partial class uc_membre : UserControl
    {
        clsMembre membre = new clsMembre();
        Membre membreModel = new Membre();
        frm_membre frm = new frm_membre();



        public uc_membre()
        {
            InitializeComponent();
            actualiser();  
        }

     

        private void actualiser()
        {
            membre.affiche_membre(dtg_membre);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            var frm = new frm_membre();
            frm.ShowDialog();
        }
       

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            actualiser();
        }
        private void recherche()
        {
            membre.recherche_membre_parnom(txtsearch.Text, dtg_membre);
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            recherche();
        }
        private void dtg_membre_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                if (MessageBox.Show("Voulez-vous supprimer cette information? ", "Supprimer",  MessageBoxButtons.OK) == DialogResult.Yes);
            
                membreModel.matricule = dtg_membre.Rows[e.RowIndex].Cells[1].Value.ToString();
                membre.supprimer_membre(membreModel);
                actualiser();
            }


            else
            {
                frm.txtmatricule.Text = dtg_membre.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.txtnom.Text = dtg_membre.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.txtpostnom.Text = dtg_membre.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.txtadresse.Text = dtg_membre.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.txtphone.Text = dtg_membre.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.cmbsexe.SelectedItem = dtg_membre.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm.txtlieuNaiss.Text = dtg_membre.Rows[e.RowIndex].Cells[7].Value.ToString();
                frm.txtdateNaiss.Text = dtg_membre.Rows[e.RowIndex].Cells[8].Value.ToString();
               
                frm.ShowDialog();
            }

        }
    }
}

