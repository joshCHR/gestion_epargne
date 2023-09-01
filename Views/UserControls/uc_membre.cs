using System;
using System.Windows.Forms;
using ADTMPDapk.Controllers;
using ADTMPDapk.Models;
using ADTMPDapk.Views.Forms;
using ADTMPDapk.Rapports;

namespace ADTMPDapk.Views.UserControls
{
    public partial class uc_membre : UserControl
    {
        clsMembre membre = new clsMembre();
        Membre membreModel = new Membre();
        frm_membre frm = new frm_membre();
        ToolTip ToolTip = new ToolTip();


        public uc_membre()
        {
            InitializeComponent();
            actualiser();
            ToolTip.SetToolTip(btnactualiser,"Actualiser");
            ToolTip.SetToolTip(btnAdd,"Ajouter un membre");
            ToolTip.SetToolTip(btnexcel, "Importer en excel");
            ToolTip.SetToolTip(btnprint, "Imprimer la liste de membre");
        }

     

        public void actualiser()
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

            }
            

        }

        private void dtg_membre_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            frm.txtmatricule.Text = dtg_membre.Rows[e.RowIndex].Cells[1].Value.ToString();
            frm.txtnom.Text = dtg_membre.Rows[e.RowIndex].Cells[2].Value.ToString();
            frm.txtpostnom.Text = dtg_membre.Rows[e.RowIndex].Cells[3].Value.ToString();
            frm.txtadresse.Text = dtg_membre.Rows[e.RowIndex].Cells[4].Value.ToString();
            frm.txtphone.Text = dtg_membre.Rows[e.RowIndex].Cells[5].Value.ToString();
            frm.cmbsexe.SelectedItem = dtg_membre.Rows[e.RowIndex].Cells[6].Value.ToString();
            frm.txtlieuNaiss.Text = dtg_membre.Rows[e.RowIndex].Cells[7].Value.ToString();
           // frm.txtdateNaiss.Text = dtg_membre.Rows[e.RowIndex].Cells[8].Value.ToString();
            //MessageBox.Show("" + dtg_membre.Rows[e.RowIndex].Cells[8].Value.ToString());
          
            frm.ShowDialog();
           
            actualiser();

        }

        private void uc_membre_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void dtg_membre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Confirmer la suppression", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    membreModel.matricule = dtg_membre.Rows[e.RowIndex].Cells[1].Value.ToString();
                    membre.supprimer_membre(membreModel);
                }
            }
            else
            {
                frm.labeltitre.Text= ("Modifier Membre");
                frm.txtmatricule.Text = dtg_membre.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.cmbtypeMembre.SelectedItem = dtg_membre.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.txtnom.Text = dtg_membre.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.txtpostnom.Text = dtg_membre.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.txtadresse.Text = dtg_membre.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.txtphone.Text = dtg_membre.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm.cmbsexe.SelectedItem = dtg_membre.Rows[e.RowIndex].Cells[7].Value.ToString();
                frm.txtlieuNaiss.Text = dtg_membre.Rows[e.RowIndex].Cells[8].Value.ToString();
                frm.txtdateNaiss.Value = DateTime.Parse(dtg_membre.Rows[e.RowIndex].Cells[9].Value.ToString());
                frm.ShowDialog();
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            var frm = new frm_listeMembre();
            frm.Show();
        }
    }
}

