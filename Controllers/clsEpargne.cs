using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADTMPDapk.Handlers;
using ADTMPDapk.Models;
namespace ADTMPDapk.Controllers
{
    class clsEpargne
    {
        Datalib datas = new Datalib();
        static SqlConnection cnx;

        public void afficher_epargne(DataGridView dtg)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_epargne", cnx)
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

        public void rechercher_epargne(string search_text, DataGridView dtg)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recherche_epargne", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("search", SqlDbType.NVarChar)).Value = search_text;
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

        public void enregistrer_epargne(Epargne epargne)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_epargne", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("idEpargne", SqlDbType.NVarChar)).Value = epargne.IdEpargne;
                cmd.Parameters.Add(new SqlParameter("matriculeMembre", SqlDbType.NVarChar)).Value = epargne.MatriculeMembre;
                cmd.Parameters.Add(new SqlParameter("idUser", SqlDbType.NVarChar)).Value = epargne.IdUser;
                cmd.Parameters.Add(new SqlParameter("numeroEpargne", SqlDbType.NVarChar)).Value = epargne.NumeroEpargne;
                cmd.Parameters.Add(new SqlParameter("designationEpargne", SqlDbType.NVarChar)).Value = epargne.DesignationEpargne;
                cmd.Parameters.Add(new SqlParameter("libeleCompte", SqlDbType.NVarChar)).Value = epargne.LibeleCompte;
                cmd.Parameters.Add(new SqlParameter("montantEpargne", SqlDbType.Money)).Value = epargne.MontantEpargne;
                cmd.Parameters.Add(new SqlParameter("dateVersement", SqlDbType.Date)).Value = epargne.DateVersement;
                

                cmd.ExecuteNonQuery();
                MessageBox.Show("Opration reussie!", "Enregistrements", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void supprimer_document(Epargne epargne)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_epargne", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("idEpargne", SqlDbType.NVarChar)).Value = epargne.IdEpargne;

                cmd.ExecuteNonQuery();
               
                MessageBox.Show("Suppression avec succès!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

