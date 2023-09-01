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
using ADTMPDapk.Views.Forms;
namespace ADTMPDapk.Views.UserControls
{
 
    public partial class uc_emprunt : UserControl
    {
        clsPret clsPret = new clsPret();
        Pret pret = new Pret();
        ToolTip tool = new ToolTip();
        public uc_emprunt()
        {
            InitializeComponent();
            tool.SetToolTip(btnactualiser, "Actualiser");
            tool.SetToolTip(btnAdd, "Nouveau pret");
            tool.SetToolTip(btnexcel, "Emporter en excel");
            tool.SetToolTip(btnprint, "Imprimer les prets");
            afficher_pret();
        }
        public void afficher_pret()
        {
            clsPret.afficher_pret(dtg_emprunt);
        }
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var pret = new frm_emprunt();
            pret.ShowDialog();
        }

        private void uc_emprunt_Load(object sender, System.EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, System.EventArgs e)
        {

        }

        private void dtg_emprunt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Confirmer la suppression", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    pret.Id_pret = int.Parse(dtg_emprunt.Rows[e.RowIndex].Cells[1].Value.ToString());
                    clsPret.supprimer_pret(pret);
                }
            }
            else
            {
                var fr = new frm_emprunt();
                fr.unique_id = int.Parse(dtg_emprunt.Rows[e.RowIndex].Cells[1].Value.ToString());
                fr.cmbmembre.SelectedItem = dtg_emprunt.Rows[e.RowIndex].Cells[2].Value.ToString();
                fr.txtsecteur.Text = dtg_emprunt.Rows[e.RowIndex].Cells[3].Value.ToString();
                fr.txtversement.Text = dtg_emprunt.Rows[e.RowIndex].Cells[4].Value.ToString();
                fr.txtdateversement.Value = DateTime.Parse(dtg_emprunt.Rows[e.RowIndex].Cells[5].Value.ToString());
                fr.ShowDialog();

            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            clsPret.rechercher_pret(txtsearch.Text, dtg_emprunt);
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            afficher_pret();
        }
    }
}
