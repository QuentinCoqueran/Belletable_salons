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

namespace ppe1
{
    public partial class Remarques : Form
    {
        public Remarques()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _connexionString = "server = localhost; user id = root;database=cppe";
            string type_remarque = "";
            string localDateString = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            MySqlConnection conn = new MySqlConnection(_connexionString);
            InfoUser infoUser = new InfoUser();
            conn.Open();
            if (dysfonctionnement.Checked)
            {
                type_remarque = "Dysfonctionnement";
            }
            else if (evolution.Checked)
            {
                type_remarque = "Souhait d'évolution";
            }
            string sql = "INSERT into remarques (type_remarque, date_creation, commentaire, utilisateur) VALUES(\'" + type_remarque + "\', \'" + localDateString + "\', \'" + commentaire.Text + "\', \'" + infoUser.Nom + "\')";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
        }
    }
}