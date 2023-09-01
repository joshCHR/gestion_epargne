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
    public partial class frm_login : Form
    {
        clsUser clsUser = new clsUser();
        User user = new User();
        public frm_login()
        {
            InitializeComponent();
        }
        public void se_connecter()
        {
            bool check = false;
            if(txtusername.Text!="" && txtpasswer.Text != "")
            {
                user.Id_user = txtusername.Text.Trim();
                user.Password = txtpasswer.Text.Trim();

                check = clsUser.se_connecter(user);
                if (check == true)
                {
                    this.Hide();

                    var frm = new dashboard(txtusername.Text);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Identifiants invalides");
                }
            }
            else
            {
                MessageBox.Show("Tous les champs sont requis!");
            }
        }
        private void lblcomptecreer_Click(object sender, EventArgs e)
        {

        }


        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            se_connecter(); 
        }

        private void lblcomptecreer_Click_1(object sender, EventArgs e)
        {
            var frm = new frm_user();
            frm.ShowDialog();
        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
