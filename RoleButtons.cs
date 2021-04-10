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
    public partial class RoleButtons : Form
    {
        public RoleButtons()
        {
            InitializeComponent();
        }

        public RoleButtons(int role)
        {
            InitializeComponent();
            textBox1.Text = role.ToString();
            switch (role)
            {
                case 1:
                    MessageBox.Show("Je dois t'ouvrir le formulaire Utilisateur");
                    buttonUtilisateur.Visible = true;
                    break;
                case 2:
                    MessageBox.Show("Je dois t'ouvrir le formulaire Admin");
                    buttonAdmin.Visible = true;
                    buttonUtilisateur.Visible = true;
                    break;
                case 0:
                default:
                    MessageBox.Show("Je dois t'ouvrir le formulaire Invite");
                    break;
            }
        }
        public RoleButtons(int role, int id, string nom , string prenom)
        {
            InitializeComponent();
            textBox1.Text = role.ToString();
            switch (role)
            {
                case 1:
                    MessageBox.Show("Je dois t'ouvrir le formulaire Utilisateur");
                    buttonUtilisateur.Visible = true;
                    break;
                case 2:
                    MessageBox.Show("Je dois t'ouvrir le formulaire Admin");
                    buttonAdmin.Visible = true;
                    buttonUtilisateur.Visible = true;
                    break;
                case 0:
                default:
                    MessageBox.Show("Je dois t'ouvrir le formulaire Invite");
                    break;
            }
        }

        private void buttonInvite_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cetait juste pour acceder au programme");
        }

        private void RoleButtons_Load(object sender, EventArgs e)
        {
           
        }
    }
}
