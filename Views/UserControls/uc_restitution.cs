using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADTMPDapk.Controllers;
using ADTMPDapk.Rapports;

namespace ADTMPDapk.Views.UserControls
{
   
    public partial class uc_restitution : UserControl
    {
        clsRestituer clsRes = new clsRestituer();
        ToolTip ToolTip = new ToolTip(); 
        public uc_restitution()
        {
            InitializeComponent();
            ToolTip.SetToolTip(btnactualiser, "Actualiser");
            ToolTip.SetToolTip(btnAdd, "Ajouter un membre");
            ToolTip.SetToolTip(btnexcel, "Importer en excel");
            ToolTip.SetToolTip(btnprint, "Imprimer la liste de membre");
            actualiser();
        }

        private void uc_restitution_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        public void actualiser()
        {
            clsRes.Afficher_restitutin(dtg_restitution);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtg_restitution_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            clsRes.Afficher_restitutin(dtg_restitution);
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            var frm = new frm_Rapport_restitution();
            frm.Show();
        }
    }
}
