using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppe1
{
    public partial class FormInvite : Form
    {
        int niveau;
        int id;
        string nom; 
        string prenom;
        InfoUser infoUser;
        public FormInvite()
        {
            InitializeComponent();
        }
        public FormInvite(int niveauUtilisateur, int idUtilisateur, string nomUtilisateur, string prenomUtilisateur, InfoUser infoUserr)
        {
            InitializeComponent();
            niveau = niveauUtilisateur;
            id = idUtilisateur;
            nom = nomUtilisateur;
            prenom = prenomUtilisateur;
            infoUser = infoUserr;
        }
        public FormInvite(InfoUser infoUserr)
        {
            InitializeComponent();
            infoUser = infoUserr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bonjour " + infoUser.Nom + " " + infoUser.Prenom + "\nVous êtes un : Invite\nVotre ID est : " + infoUser.Id);
        }

        private void aide_Click(object sender, EventArgs e)
        {
            Remarques maremarque = new Remarques();
            maremarque.ShowDialog();
        }
    }
}
