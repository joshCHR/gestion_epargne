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
    class clsRestituer
    {
        // Creation de la classe de connexion
        Datalib datas = new Datalib();

        // Creation de l'objet de connexion SqlConnection
        static SqlConnection cnx;

        // Fonction pour afficher les restitutions dans un DataGrid View
        public void Afficher_restitutin(DataGridView dtg)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("Afficher_restitutin", cnx)
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

        // Fonction pour rechercher restitution
        public void rechercher_restituer(string search_text, DataGridView dtg)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_restituer", cnx)
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

        // Fonction pour enregistrer une restitution
        public void enregistrer_restituer(Resititution resititution)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_restituer", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add(new SqlParameter("ref_pret", SqlDbType.Int)).Value = resititution.Ref_pret;
                cmd.Parameters.Add(new SqlParameter("reste_a_payer", SqlDbType.Money)).Value = resititution.Rest_apayer;
                cmd.Parameters.Add(new SqlParameter("date_rest", SqlDbType.Date)).Value = resititution.Date_rest;
                cmd.Parameters.Add(new SqlParameter("interets", SqlDbType.Money)).Value = resititution.Interets;
                cmd.Parameters.Add(new SqlParameter("ref_rembourser", SqlDbType.Int)).Value = resititution.Ref_rembourser;

                cmd.ExecuteNonQuery();
                    MessageBox.Show("Opération réussie!", "Effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Fonction pour modifier une restitution
        public void modifier_restituer(Resititution resititution)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("modifier_restituer", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add(new SqlParameter("id_restituer", SqlDbType.Int)).Value = resititution.Id_restituer;
                cmd.Parameters.Add(new SqlParameter("ref_pret", SqlDbType.Int)).Value = resititution.Ref_pret;
                cmd.Parameters.Add(new SqlParameter("reste_a_payer", SqlDbType.Money)).Value = resititution.Rest_apayer;
                cmd.Parameters.Add(new SqlParameter("date_rest", SqlDbType.Date)).Value = resititution.Date_rest;
                cmd.Parameters.Add(new SqlParameter("interets", SqlDbType.Money)).Value = resititution.Interets;
                cmd.Parameters.Add(new SqlParameter("ref_rembourser", SqlDbType.Int)).Value = resititution.Ref_rembourser;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Opération réussie!", "Effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        // Fonction pour supprimer une salle
        public void supprimer_restituer(Resititution resititution)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_restituer", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_type_membre", SqlDbType.NVarChar)).Value = resititution.Id_restituer;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Opération réussie!", "Effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
