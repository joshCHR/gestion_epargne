using ADTMPDapk.Controllers;
using ADTMPDapk.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADTMPDapk.Views.UserControls;



namespace ADTMPDapk
{
    public partial class frm_typemembre : Form
    {
        
        public frm_typemembre()
        {
            InitializeComponent();
        }

        private void txtdesignation_TextChanged(object sender, EventArgs e)
        {

        }

        private void labellieuNaiss_Click(object sender, EventArgs e)
        {

        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            add_type_membre();
        }
        public void add_type_membre()
        {
            uc_setting uc_Setting = new uc_setting();
            Type_membre type = new Type_membre();
            clsTypeMembre typeMembre = new clsTypeMembre();
            if (txtdesignation.Text !="" && txtdesignation.Text != "")
            {
                type.Id_type_membre = txtid.Text;
                type.Designation = txtdesignation.Text;
                typeMembre.enregistrer_type_membre(type);

                
            }
            else
            {
                MessageBox.Show("Tous les champs sont requis!!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            uc_Setting.actualiser();

        }
    }
}
