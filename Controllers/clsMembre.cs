using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ADTMPDapk.Handlers;
using ADTMPDapk.Models;

namespace ADTMPDapk.Backend.Controllers
{
    class clsMembre
    {
        Datalib datas = new Datalib();
        static SqlConnection cnx;
        Membre membre = new Membre();

        //Notification_Center 
        //notify = new Notification_Center();

        /*------------------- Display Detail Paiement Function -----------------------------*/
        public void affiche_membre(DataGridView dtg)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("affiche_membre", cnx)
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
        /*------------------- End Display Detail Paiement Function -----------------------------*/

             /*------------------- Search membre Function -----------------------------------------*/
        public void recherche_membre_parnom(string txtsearch, DataGridView dtg)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recherche_membre_parnom", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("nom", SqlDbType.NVarChar)).Value = txtsearch;
                cmd.Parameters.Add(new SqlParameter("matricule", SqlDbType.NVarChar)).Value = txtsearch;
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
        /*------------------- End Search By Numero Paiement Function ---------------------------------*/

        /*------------------- Add Entrepot Function -------------------------------------------------*/
        public void enregistrer_mambre(Membre membre)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("enregistrer_mambre", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@matricule", SqlDbType.NVarChar)).Value = membre.matricule;
                cmd.Parameters.Add(new SqlParameter("@nom", SqlDbType.NVarChar)).Value = membre.nom;
                cmd.Parameters.Add(new SqlParameter("@postnom", SqlDbType.NVarChar)).Value = membre.postnom;
                cmd.Parameters.Add(new SqlParameter("@adresse", SqlDbType.NVarChar)).Value = membre.adresse;
                cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.NVarChar)).Value = membre.phone;  
                cmd.Parameters.Add(new SqlParameter("@sexe", SqlDbType.NVarChar)).Value = membre.sexe;
                cmd.Parameters.Add(new SqlParameter("@lieuNaiss", SqlDbType.NVarChar)).Value = membre.lieuNaiss;
               // cmd.Parameters.Add(new SqlParameter("dateNaiss", SqlDbType.DateTime)).Value = membre.dateNaiss;
                cmd.Parameters.Add(new SqlParameter("@dateNaiss", SqlDbType.DateTime)).Value = membre.dateNaiss;
           ;
                //cmd.Parameters.Add(new SqlParameter("photo", SqlDbType.Image)).Value = membre.photo;

                cmd.ExecuteNonQuery();
              /*notify.notifier("Article ajouté!");*/ // Class does not exit yet
                MessageBox.Show("Membre ajouté!", "Enregistrements", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /*------------------- End Add Detail Paiement Function ---------------------------------------*/

        ///*------------------- Delete Entrepot Function -----------------------------------------------*/
        public void supprimer_membre(Membre membre)
        {
            cnx = new SqlConnection(datas.GetInstance().ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("supprimer_membre", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@matricule", SqlDbType.NVarChar)).Value = membre.matricule;
             

                cmd.ExecuteNonQuery();
                ////notify.notifier("Enregistrement avec succès!"); // Class does not extit yet
                MessageBox.Show("Supprimé avec succès!", "Enregistrements", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        /*------------------- End Delete Detail Paiement Function -----------------------------------*/
    }
}
