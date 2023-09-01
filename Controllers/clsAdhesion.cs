using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADTMPDapk.Models;
using ADTMPDapk.Handlers;
using System.Windows.Forms;

namespace ADTMPDapk.Controllers
{
    class clsAdhesion
    {
        Datalib datas = new Datalib();
        static SqlConnection cnx;
       
        public void afficher_adhesion(DataGridView dtg)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_adhesion", cnx)
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
                var cmd = new SqlCommand("rechercher_adhesion", cnx)
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

        public void enregistrer_adhesion(Adhesion adhesion)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_adhesion", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("matriculeMembre", SqlDbType.NVarChar)).Value = adhesion.MatriculeMembre;
                cmd.Parameters.Add(new SqlParameter("dateAhesion", SqlDbType.DateTime)).Value = adhesion.DateAdhesion;
                cmd.Parameters.Add(new SqlParameter("montantAdhesion", SqlDbType.Money)).Value = adhesion.MontantAdhesion;
                cmd.Parameters.Add(new SqlParameter("motifAhesion", SqlDbType.NVarChar)).Value = adhesion.MotifAdhesion;
                cmd.Parameters.Add(new SqlParameter("statutAdhesion", SqlDbType.NVarChar)).Value = adhesion.StatutAdhesion;
           

                cmd.ExecuteNonQuery();
               
                MessageBox.Show("Operation reussie!", "Enregistrements", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void modifier_adhesion(Adhesion adhesion)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("modifier_adhesion", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("idAhesion", SqlDbType.NVarChar)).Value = adhesion.IdAhesion;
                cmd.Parameters.Add(new SqlParameter("matriculeMembre", SqlDbType.NVarChar)).Value = adhesion.MatriculeMembre;
                cmd.Parameters.Add(new SqlParameter("dateAhesion", SqlDbType.DateTime)).Value = adhesion.DateAdhesion;
                cmd.Parameters.Add(new SqlParameter("montantAdhesion", SqlDbType.Money)).Value = adhesion.MontantAdhesion;
                cmd.Parameters.Add(new SqlParameter("motifAhesion", SqlDbType.NVarChar)).Value = adhesion.MotifAdhesion;
                cmd.Parameters.Add(new SqlParameter("statutAdhesion", SqlDbType.NVarChar)).Value = adhesion.StatutAdhesion;


                cmd.ExecuteNonQuery();
             
                MessageBox.Show("Modification reussie!", "Enregistrements", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void supprimer_adhesion(Adhesion adhesion)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_adhesion", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("idAhesion", SqlDbType.Int)).Value = adhesion.IdAhesion;

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

