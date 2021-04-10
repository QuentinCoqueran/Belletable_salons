using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

namespace ppe1
{
    public partial class Login : Form
    {
        string _connexionString = "server = localhost; user id = root;database=cppe";
        public int idUtilisateur = 0;
        public string nomUtilisateur = "";
        public string prenomUtilisateur = "";
        public int niveauUtilisateur = 0;
        int i = 0;
        InfoUser infoUser;

        public Login()
        {
            InitializeComponent();
        }

        public Login(InfoUser infoUserr)
        {
            InitializeComponent();
            this.infoUser = infoUserr;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(_connexionString);
            try
            {
                conn.Open();
                string safePassword = SHA.petitsha(tbPassword.Text);
                string sql = "SELECT * FROM user where nom = \'" + tbNom.Text + "\' and password = \'" + safePassword + "\'";
                //string sql = "SELECT * FROM user where nom = @theName and password = @thePassword";
               /* var ParametresRequetes = new DynamicParameters();
                ParametresRequetes.Add("theName", tbNom.Text);
                ParametresRequetes.Add("thePassword", safePassword);
                var ListConnexion = new List<InfoUser>();
                ListConnexion = conn.Query<InfoUser>(sql, ParametresRequetes).ToList();*/
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();//Curseur

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        MessageBox.Show("Bonjour " + rdr[1] + " " + rdr[2] + "\nRôle : " +rdr[4]);
                    }
                    
                    this.niveauUtilisateur = Convert.ToInt32(rdr[4]);
                    this.idUtilisateur = Convert.ToInt32(rdr[0]);
                    this.nomUtilisateur = rdr[1].ToString();
                    this.prenomUtilisateur = rdr[2].ToString();
                    infoUser.Role = Convert.ToInt32(rdr[4]);
                    infoUser.Id = Convert.ToInt32(rdr[0]);
                    infoUser.Nom = rdr[1].ToString();
                    infoUser.Prenom = rdr[2].ToString();
                    infoUser.Password = safePassword;

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (i == 2)
                    {
                        rdr.Close();
                        string localDateString = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                        sql = "INSERT INTO `echec`(`nom`, `password`, `date`) VALUES (\'" + tbNom.Text + "\',\'" + tbPassword.Text +"\' ,\'" + localDateString + "\')"; //faut que le format sois en 2021/01/25 22:31:07
                        MessageBox.Show(sql);
                        cmd = conn.CreateCommand();
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("3 tentatives échoué, fermeture de l'application");
                        this.DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        MessageBox.Show("Authentification échoué\nAccés refusé\nTentative n° " + (i + 1));
                        i++;
                    }
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbNomtbPrenom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
                e.Handled = true;
            }
        }
    }
}
