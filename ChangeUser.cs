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
    public partial class ChangeUser : Form
    {
        string _connexionString = "server = localhost; user id = root;database=cppe";
        InfoUser infoUser;
        public ChangeUser()
        {
            InitializeComponent();
        }
        /*public ChangeUser(string nom, string prenom, int role)
        {
            InitializeComponent();
            tbNom.Text = nom;
            tbPrenom.Text = prenom;
            switch (role)
            {
                case 0:
                    rbInvite.Checked = true;
                    break;
                case 1:
                    rbUtilisateur.Checked = true;
                    break;
                case 2:
                    rbAdmin.Checked = true;
                    break;
            }

        }*/

        public ChangeUser(InfoUser infoUserr) //peut etre interressant a utiliser, mais faut voir si infoUser
        {
            InitializeComponent();
            infoUser = infoUserr;
            tbNom.Text = infoUser.Nom;
            tbPrenom.Text = infoUser.Prenom;
            tbChangeMdp.Text = infoUser.Password;
            switch (infoUser.Role)
            {
                case 0:
                    rbInvite.Checked = true;
                    break;
                case 1:
                    rbUtilisateur.Checked = true;
                    break;
                case 2:
                    rbAdmin.Checked = true;
                    break;
            }
            //tableau des logs du user
            this.dgUser.ColumnCount = 6;
            dgUser.Columns[4].Width = 150;
            dgUser.Columns[5].Width = 150;
            dgUser.Columns[0].Name = "IDLog";
            dgUser.Columns[1].Name = "Role";
            dgUser.Columns[2].Name = "Nom";
            dgUser.Columns[3].Name = "Prenom";
            dgUser.Columns[4].Name = "DateDebut";
            dgUser.Columns[5].Name = "DateFin";
            checkLogUser();
        }

        private void checkLogUser()
        {
            MySqlConnection conn = new MySqlConnection(_connexionString);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM log WHERE id = " + infoUser.Id + " ORDER BY datedebut DESC";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();//Curseur

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        dgUser.Rows.Add(rdr[0], rdr[4], rdr[2], rdr[3], rdr[5], rdr[6]);
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

        private void buttonChangeMdp_Click(object sender, EventArgs e)
        {
            tbChangeMdp.Visible = true;
        }

        private void buttonMAJ_Click(object sender, EventArgs e)
        {
            int rbSelected = 0;
            if (rbAdmin.Checked == true)
                rbSelected = 2;
            if (rbUtilisateur.Checked == true)
                rbSelected = 1;
            if (rbInvite.Checked == true)
                rbSelected = 0;
            MessageBox.Show(infoUser.Save("modification", tbNom.Text, tbPrenom.Text, tbChangeMdp.Text, rbSelected, infoUser.Id));
            this.DialogResult = DialogResult.OK;
        }

        private void aide_Click(object sender, EventArgs e)
        {
            Remarques maremarque = new Remarques();
            maremarque.ShowDialog();
        }
    }
}
