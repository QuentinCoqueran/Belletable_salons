using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ppe1
{
    public class InfoUser
    {
        string _connexionString = "server = localhost; user id = root;database=cppe";
        private int _id;
        private int _role;
        private string _nom;
        private string _prenom;
        private string _password;

        public int Id
        {
            get => _id;
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
            }
        }
        public int Role
        {
            get => _role;
            set
            {
                if ((value > 0) && (value < 13))
                {
                    _role= value;
                }
            }
        }
        public string Nom
        {
            get => _nom;
            set
            {
                if(value is string)
                    _nom = value;
            }
        }
        public string Prenom
        {
            get => _prenom;
            set
            {
                if (value is string)
                    _prenom = value;
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (value is string)
                    _password = value;
            }
        }
        public string Save(string choix, string newNom, string newPrenom, string newPassword, int newRole, int hisId)
        {
            MySqlConnection conn = new MySqlConnection(_connexionString);
            string safePassword = SHA.petitsha(newPassword);
            if (choix == "modification")
            {
                try
                {
                    conn.Open();
                    string sql = "";
                    string sqlGetPassword = "SELECT password FROM `user` WHERE id =" + hisId;
                    string bddPassword = "";
                    MySqlCommand cmd1 = new MySqlCommand(sqlGetPassword, conn);
                    MySqlDataReader rdr = cmd1.ExecuteReader();//Curseur

                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            bddPassword = rdr.GetString(0);
                        }
                    
                            if (bddPassword == newPassword)
                        {
                            sql = "UPDATE `user` SET `nom`= \"" + newNom + "\",`prenom`=\"" + newPrenom + "\",`role`=" + newRole + " WHERE id =" + hisId;
                        }
                        else
                        {
                            sql = "UPDATE `user` SET `nom`= \"" + newNom + "\",`prenom`=\"" + newPrenom + "\",`password`=\"" + safePassword + "\",`role`=" + newRole + " WHERE id =" + hisId;
                        }
                        rdr.Close();
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        return "L'utilisateur " + newNom + " " + newPrenom + " à été modifié";
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                    return "erreur sql";
                }
            }
            else if (choix == "creation")
            {
                try
                {
                    conn.Open();
                    string sql1 = "SELECT * FROM user where `nom` = \"" + newNom + "\" and `prenom`=\"" + newPrenom + "\"";
                    MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                    MySqlDataReader rdr1 = cmd1.ExecuteReader();//Curseur

                    if (rdr1.HasRows)
                    {
                        rdr1.Close();
                        return "L'utilisateur existe déjà";
                    }
                    else
                    {
                        rdr1.Close();
                        string sql = "INSERT INTO user (nom, prenom, password, role) VALUES (\'" + newNom + "\',\'" + newPrenom + "\',\'" + safePassword + "\',\'" + newRole + "\')";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader rdr = cmd.ExecuteReader();//Curseur
                        rdr.Close();
                        return "L'utilisateur " + newNom + " " + newPrenom + " à été inscrit";
                    }


                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                    return "erreur sql";
                }
            }
            return "not edit and not add";
        }
    }
}
