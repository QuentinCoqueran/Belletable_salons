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
    public partial class FormAdmin : Form
    {
        string _connexionString = "server = localhost; user id = root;database=cppe";
       /* int role;
        int id;
        string nom;
        string prenom;*/
        InfoUser infoUser;
        public FormAdmin()
        {
            InitializeComponent();
        }
        /*public FormAdmin(int niveauUtilisateur, int idUtilisateur, string nomUtilisateur, string prenomUtilisateur, InfoUser infoUserr)
        {
            InitializeComponent();
            role = niveauUtilisateur;
            id = idUtilisateur;
            nom = nomUtilisateur;
            prenom = prenomUtilisateur;
            infoUser = infoUserr;
            this.dtLog.ColumnCount = 6;
            dtLog.Columns[4].Width = 150;
            dtLog.Columns[5].Width = 150;
            dtLog.Columns[0].Name = "IDLog";
            dtLog.Columns[1].Name = "ID";
            dtLog.Columns[2].Name = "Nom";
            dtLog.Columns[3].Name = "Prenom";
            dtLog.Columns[4].Name = "Role";
            dtLog.Columns[5].Name = "DateDebut";
            dtLog.Columns[6].Name = "DateFin";
            checkLog();
            checkEchec();
        }*/
        public FormAdmin(InfoUser infoUserr)
        {
            InitializeComponent();
            infoUser = infoUserr;
            //dataGridLog
            this.dtLog.ColumnCount = 6;
            dtLog.Columns[4].Width = 150;
            dtLog.Columns[5].Width = 150;
            dtLog.Columns[0].Name = "IDLog";
            dtLog.Columns[1].Name = "Role";
            dtLog.Columns[2].Name = "Nom";
            dtLog.Columns[3].Name = "Prenom";
            dtLog.Columns[4].Name = "DateDebut";
            dtLog.Columns[5].Name = "DateFin";

            //dataGridFailConnection
            this.dgEchec.ColumnCount = 3;
            dgEchec.Columns[2].Width = 150;
            dgEchec.Columns[0].Name = "IDechec";
            dgEchec.Columns[1].Name = "Nom";
            dgEchec.Columns[2].Name = "Date";

            checkUser();
            checkLog();
            checkEchec();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bonjour " + infoUser.Nom + " " + infoUser.Prenom + "\nVous êtes un : Admin\nVotre ID est : " + infoUser.Id);
        }

        private void checkUser()
        {
            MySqlConnection conn = new MySqlConnection(_connexionString);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM user ORDER BY role DESC";
                var ListConnexion = new List<InfoUser>();
                ListConnexion = conn.Query<InfoUser>(sql).ToList();
                dtUser.DataSource = ListConnexion;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void checkLog()
        {
            MySqlConnection conn = new MySqlConnection(_connexionString);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM log ORDER BY datedebut DESC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();//Curseur

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        dtLog.Rows.Add(rdr[0], rdr[4], rdr[2], rdr[3], rdr[5], rdr[6]);
                    }
                }
                else
                {
                    MessageBox.Show("Les logs sont vides");
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void checkEchec()
        {
            MySqlConnection conn = new MySqlConnection(_connexionString);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM echec ORDER BY date DESC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();//Curseur

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        dgEchec.Rows.Add(rdr[0], rdr[1], rdr[3]);
                    }
                }
                else
                {
                    MessageBox.Show("Les logs d'echec sont vides");
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dtUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          //  string nom = dtLog.CurrentRow.Cells[2].Value.ToString();
           
            foreach (DataGridViewRow row in dtUser.SelectedRows)
            {
                InfoUser clickedUser = row.DataBoundItem as InfoUser;
                ChangeUser changeUser = new ChangeUser(clickedUser);
                changeUser.ShowDialog();
                checkUser();
            }
            
            
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
            checkUser();
        }

        private void aide_Click(object sender, EventArgs e)
        {
            Remarques maremarque = new Remarques();
            maremarque.ShowDialog();
        }
    }
}
