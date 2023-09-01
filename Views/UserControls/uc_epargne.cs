using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADTMPDapk.Views.Forms;
using ADTMPDapk.Controllers;
using ADTMPDapk.Models;
using ADTMPDapk.Rapports.frm_rapport;

namespace ADTMPDapk.Views.UserControls
{
    public partial class uc_epargne : UserControl
    {
        clsEpargne clsEpargne = new clsEpargne();
        Epargne epargne = new Epargne();
        

        ToolTip tool = new ToolTip();
        public uc_epargne()
        {
            InitializeComponent();
            tool.SetToolTip(btnactualiser, "Actualiser");
            tool.SetToolTip(btnAdd, "Ajouter epargne");
            tool.SetToolTip(btnexcel, "Emporter en excel");
            tool.SetToolTip(btnprint, "Imprimer la liste pour epargne");
            affihcer_epargne();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var epargne = new frm_epargne();
            epargne.ShowDialog();
        }
        public void affihcer_epargne()
        {
            clsEpargne.afficher_epargne(dtg_epargne);
        }
        private void uc_epargne_Load(object sender, System.EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btnactualiser_Click(object sender, System.EventArgs e)
        {
            affihcer_epargne();
        }

        private void txtsearch_TextChanged(object sender, System.EventArgs e)
        {
            clsEpargne.rechercher_epargne(txtsearch.Text, dtg_epargne);
        }

        private void dtg_epargne_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Confirmer la suppression!", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dr == DialogResult.Yes)
                {
                    epargne.IdEpargne = int.Parse(dtg_epargne.Rows[e.RowIndex].Cells[1].Value.ToString());
                    clsEpargne.supprimer_document(epargne);
                }
            }
            else
            {
                var fr = new frm_epargne();
                fr.unique_id = int.Parse(dtg_epargne.Rows[e.RowIndex].Cells[1].Value.ToString());
                fr.cmbmembre.SelectedItem = dtg_epargne.Rows[e.RowIndex].Cells[2].Value.ToString();
                fr.txtnemeroEpargne.Text = dtg_epargne.Rows[e.RowIndex].Cells[4].Value.ToString();
                fr.txtdesignation.Text = dtg_epargne.Rows[e.RowIndex].Cells[5].Value.ToString();
                fr.txtlibelle.Text = dtg_epargne.Rows[e.RowIndex].Cells[6].Value.ToString();
                fr.txtversement.Text = dtg_epargne.Rows[e.RowIndex].Cells[7].Value.ToString();
                fr.txtdateNaiss.Value = DateTime.Parse(dtg_epargne.Rows[e.RowIndex].Cells[8].Value.ToString());
                fr.ShowDialog();
            }
        }

        private void btnRecu_Click(object sender, EventArgs e)
        {
            var frm = new frm_bonEntrer();
            frm.Show();

        }
    }
}
