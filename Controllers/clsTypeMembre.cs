using ADTMPDapk.Handlers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADTMPDapk.Models;
using Guna.UI2.WinForms;
namespace ADTMPDapk.Controllers
{
    class clsTypeMembre
    {
        // Creation de la classe de connexion
        Datalib datas = new Datalib();
        // Creation de l'objet de connexion SqlConnection
        static SqlConnection cnx;

        // Fonction pour afficher les types de membres dans un DataGrid View
        public void afficher_type_membre(DataGridView dtg)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_type_membre", cnx)
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

        // Fonction pour rechercher type membre
        public void rechercher_type_membres(string search_text, DataGridView dtg)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_type_membres", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("designation", SqlDbType.NVarChar)).Value = search_text;
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

        // Fonction pour rechercher l'id du type membre a partir de sa designation
        public void rechercher_id_par_designation(string txtsearch, DataGridView dtg)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("rechercher_id_par_designation", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("designation", SqlDbType.NVarChar)).Value = txtsearch;
               
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
        // Fonction pour verifier si la designation du tyepe membre existe deja
        public bool designation_existe(Type_membre type_Membre)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            bool check = false;
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("designation_existe", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("designation", SqlDbType.NVarChar)).Value = type_Membre.Designation;
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

        // Fonction pour enregistrer une salle
        public void enregistrer_type_membre(Type_membre type_Membre)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_type_membre", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                //bool check = designation_existe(type_Membre);
                //if (check != true)
                //{
                    cmd.Parameters.Add(new SqlParameter("id_type_membre", SqlDbType.NVarChar)).Value = type_Membre.Id_type_membre;
                    cmd.Parameters.Add(new SqlParameter("designation", SqlDbType.NVarChar)).Value = type_Membre.Designation;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Opération réussie!", "Effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show(type_Membre.designation + " existe deja!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
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

        // Fonction pour charger dans un combobox
        public void charger_listbox(Guna2ComboBox lst)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("charger_types_membres", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();
                var da = new SqlDataAdapter(cmd);
                var ds = new DataSet();
                da.Fill(ds, "type_membre");
                lst.DataSource = ds.Tables["type_membre"];
                lst.ValueMember = "id_type_membre";
                lst.DisplayMember = "designation";
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

        // Fonction pour supprimer type membre
        public void supprimer_type_membre(Type_membre type_Membre)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_type_membre", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_type_membre", SqlDbType.NVarChar)).Value = type_Membre.Id_type_membre;

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
