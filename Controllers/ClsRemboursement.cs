using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ADTMPDapk.Handlers;
using ADTMPDapk.Models;

namespace ADTMPDapk.Controllers
{
    class clsRemboursement
    {

        Datalib datas = new Datalib();
        static SqlConnection cnx;

        public void afficher_remboursement(DataGridView dtg)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_remboursement", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Souhaitez vous lire le message d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_remboursement(string search_text, DataGridView dtg)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_remboursement", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("search  ", SqlDbType.NVarChar)).Value = search_text;
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception exct)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Souhaitez vous lire le message d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(exct.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }

        public void enregistrer_remboursement(Remboursement remboursement)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_remboursement", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_remb", SqlDbType.Int)).Value = remboursement.Id_remb;
                cmd.Parameters.Add(new SqlParameter("id_pret", SqlDbType.Int)).Value = remboursement.IdPret;
                cmd.Parameters.Add(new SqlParameter("dateRemb", SqlDbType.Date)).Value = remboursement.Date;
                cmd.Parameters.Add(new SqlParameter("montantRemb", SqlDbType.Money)).Value = remboursement.MontantRemb;
                cmd.Parameters.Add(new SqlParameter("id_user", SqlDbType.NVarChar)).Value = remboursement.Id_user;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Opération reussie!", "Remboursement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_remboursement(Remboursement remboursement)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_remboursement", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_remb ", SqlDbType.NVarChar)).Value = remboursement.Id_remb;

                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Supprimé avec succès!", "Supprimé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception tdf)
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous voir le code d'erreur?", "Erreurs ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(tdf.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }

    }
}
