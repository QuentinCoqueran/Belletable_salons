using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

namespace ppe1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CreatePDF.generatePDF();

            InfoUser infoUser = new InfoUser();
            Login MonFormLogin = new Login(infoUser);
            MonFormLogin.ShowDialog();
            if (MonFormLogin.DialogResult == DialogResult.OK)
            {
               /* int niveauUtilisateur = MonFormLogin.niveauUtilisateur;
                int idUtilisateur = MonFormLogin.idUtilisateur;
                string nomUtilisateur = MonFormLogin.nomUtilisateur;
                string prenomUtilisateur = MonFormLogin.prenomUtilisateur;*/
                logSql(infoUser.Role, infoUser.Id, infoUser.Nom, infoUser.Prenom, "connection");
                MonFormLogin.Close();
                switch (infoUser.Role)
                {
                    case 1:
                        //MessageBox.Show("Tu est un Utilisateur");
                        Application.Run(new FormUtilisateur(infoUser));
                        break;
                    case 2:
                        //MessageBox.Show("Tu est un Admin");
                        Application.Run(new FormAdmin(infoUser));
                        break;
                    case 0:
                    default:
                        //MessageBox.Show("Tu est un Invite");
                        Application.Run(new FormInvite(infoUser));
                        break;
                }
                logSql(infoUser.Role, infoUser.Id, infoUser.Nom, infoUser.Prenom, "deconnection");
            }
            else
                MonFormLogin.Close();
            MessageBox.Show("Au revoir");
        }

        static private void logSql(int niveauUtilisateur, int idUtilisateur, string nomUtilisateur, string prenomUtilisateur, string connectionDeconnection)
        {
            //DateTime localDate = DateTime.Now; //il est pas au bon format
            string localDateString = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            string _connexionString = "server=192.168.16.210;user id=root;database=belletable_salons_quentin";
            MySqlConnection conn = new MySqlConnection(_connexionString);
            conn.Open();
            if (connectionDeconnection == "connection")
            {
                try
                {
                    string sql = "INSERT INTO `log`(`id`, `nom`, `prenom`, `role`, `datedebut`) VALUES (" + idUtilisateur + ",\'" + nomUtilisateur + "\' ,\'" + prenomUtilisateur + "\' ,\'" + niveauUtilisateur + "\' ,\'" + localDateString + "\')"; //faut que le format sois en 2021/01/25 22:31:07
                    //MessageBox.Show(sql);
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (connectionDeconnection == "deconnection")
            {
                try
                {
                    string sql = "UPDATE `log` SET `datefin` = \'" + localDateString + "\' WHERE `idlog` = (SELECT MAX(`idlog`)) and datefin is NULL"; //faut que le format sois en 2021/01/25 22:31:07
                    //MessageBox.Show(sql);
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            
        }

    }
}
