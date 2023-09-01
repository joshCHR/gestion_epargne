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
using ADTMPDapk.Rapports;

namespace ADTMPDapk.Views.UserControls
{
    public partial class uc_remboursement : UserControl
    {
        clsRemboursement clsRemboursement = new clsRemboursement();
        Remboursement remboursement = new Remboursement();
        ToolTip ToolTip = new ToolTip();
        public uc_remboursement()
        {
            InitializeComponent();
            ToolTip.SetToolTip(btnAdd, "Nouveau enregistrement");          
            ToolTip.SetToolTip(btnAdd, "Actualiser");
            ToolTip.SetToolTip(btnprint, "Imprimer le remboursement");
            ToolTip.SetToolTip(btnexcel, "Importer en excel");
            afficher_remboursement();
        }
        public void afficher_remboursement()
        {
            clsRemboursement.afficher_remboursement(dtg_remboursement);
        }
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var reboursermrnt = new frm_remboursement();
            reboursermrnt.ShowDialog();
        }

        private void uc_remboursement_Load(object sender, System.EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            afficher_remboursement();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            clsRemboursement.rechercher_remboursement(txtsearch.Text, dtg_remboursement);
        }

        private void dtg_remboursement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                DialogResult rs = new DialogResult();
                rs = MessageBox.Show("Confirmer la supression", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(rs == DialogResult.Yes)
                {
                    remboursement.Id_remb = int.Parse(dtg_remboursement.Rows[e.RowIndex].Cells[1].Value.ToString());
                    clsRemboursement.supprimer_remboursement(remboursement);
                }
            }
            else
            {
                var fr = new frm_remboursement();
                fr.unique_id = int.Parse(dtg_remboursement.Rows[e.RowIndex].Cells[1].Value.ToString());
                fr.cmbmembre.SelectedItem = dtg_remboursement.Rows[e.RowIndex].Cells[2].Value.ToString();
                fr.daterembousement.Value = DateTime.Parse(dtg_remboursement.Rows[e.RowIndex].Cells[3].Value.ToString());
                fr.txtmontant.Text = dtg_remboursement.Rows[e.RowIndex].Cells[4].Value.ToString();
                fr.ShowDialog();
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
         
        }

        private void journalierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Show();
        }

        private void planRemboursementToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var form = new Form1();
            form.ShowDialog();
        }
    }
}
