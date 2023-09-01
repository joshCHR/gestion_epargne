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
    class clsUser
    {
        Datalib datas = new Datalib();
        static SqlConnection cnx;
        public void afficher_user(DataGridView dtg)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_user", cnx)
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

        // Fonction pour rechecher les utilisateurs
        public void rechercher_user(string search_text, DataGridView dtg)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_user", cnx)
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

        // Fonction pour enregistrer les utilisateurs
        public void enregistrer_user(User user)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_user", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_user", SqlDbType.NVarChar)).Value = user.Id_user;
                cmd.Parameters.Add(new SqlParameter("nom", SqlDbType.NVarChar)).Value = user.Nom;
                cmd.Parameters.Add(new SqlParameter("postnom", SqlDbType.NVarChar)).Value = user.Postnom;
                cmd.Parameters.Add(new SqlParameter("poste", SqlDbType.NVarChar)).Value = user.Poste;
                cmd.Parameters.Add(new SqlParameter("levels", SqlDbType.NVarChar)).Value = user.Levels;
                cmd.Parameters.Add(new SqlParameter("statut", SqlDbType.NVarChar)).Value = user.Statut;
             
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
        // Fonction pour se connecter
        public bool se_connecter(User user)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            bool check = false;
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("se_connecter", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_user", SqlDbType.NVarChar)).Value = user.Id_user;
                cmd.Parameters.Add(new SqlParameter("user_password", SqlDbType.NVarChar)).Value = user.Password;
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
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
            return check;
        }
        // Fonction pour verifier si le username existe deja

        public bool user_exist(User user)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            bool check = false;
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("user_exist", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_user", SqlDbType.NVarChar)).Value = user.Id_user;
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
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
            return check;
        }

        // Fonction pour verifier si le nom et le postnom existe deja
        public bool names_exist(User user)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            bool check = false;
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("names_exist", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("nom", SqlDbType.NVarChar)).Value = user.Nom;
                cmd.Parameters.Add(new SqlParameter("postnom", SqlDbType.NVarChar)).Value = user.Postnom;
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
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
            return check;
        }
        // Fonction pour supprimer l'utilisateur
        public void supprimer_user(User user)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_user", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_user", SqlDbType.NVarChar)).Value = user.Id_user;

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
        // Fonction pour verifier si le poste possede deja une affectation
        public bool user_affected(User user)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            bool check = false;
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("user_affected", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_user", SqlDbType.NVarChar)).Value = user.Id_user;
                cmd.Parameters.Add(new SqlParameter("poste", SqlDbType.NVarChar)).Value = user.Poste;
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
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
            return check;
        }
        // Fonction pour trouver les noms du user de son username
        public string rechercher_noms_user_par_id(string search_text)
        {
            string noms = "";
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_noms_user_par_id", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_user", SqlDbType.NVarChar)).Value = search_text;

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    noms = result.ToString();
                }
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
            return noms;
        }

        // Fonction pour trouver le level du user
        public string select_level(string search_text)
        {
            string noms = "";
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("select_level", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_user", SqlDbType.NVarChar)).Value = search_text;

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    noms = result.ToString();
                }
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
            return noms;
        }


    }
}
