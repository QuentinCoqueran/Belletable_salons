namespace ppe1
{
    partial class ChangeUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNom = new System.Windows.Forms.Label();
            this.buttonMAJ = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.dgUser = new System.Windows.Forms.DataGridView();
            this.rbUtilisateur = new System.Windows.Forms.RadioButton();
            this.rbInvite = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.buttonChangeMdp = new System.Windows.Forms.Button();
            this.tbChangeMdp = new System.Windows.Forms.TextBox();
            this.aide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(88, 15);
            this.labelNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(45, 17);
            this.labelNom.TabIndex = 15;
            this.labelNom.Text = "Nom :";
            // 
            // buttonMAJ
            // 
            this.buttonMAJ.Location = new System.Drawing.Point(311, 114);
            this.buttonMAJ.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMAJ.Name = "buttonMAJ";
            this.buttonMAJ.Size = new System.Drawing.Size(109, 28);
            this.buttonMAJ.TabIndex = 14;
            this.buttonMAJ.Text = "Mettre à jour";
            this.buttonMAJ.UseVisualStyleBackColor = true;
            this.buttonMAJ.Click += new System.EventHandler(this.buttonMAJ_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(156, 15);
            this.tbNom.Margin = new System.Windows.Forms.Padding(4);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(263, 22);
            this.tbNom.TabIndex = 12;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(69, 64);
            this.labelPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(65, 17);
            this.labelPrenom.TabIndex = 18;
            this.labelPrenom.Text = "Prenom :";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(156, 64);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(263, 22);
            this.tbPrenom.TabIndex = 17;
            // 
            // dgUser
            // 
            this.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUser.Location = new System.Drawing.Point(16, 245);
            this.dgUser.Margin = new System.Windows.Forms.Padding(4);
            this.dgUser.Name = "dgUser";
            this.dgUser.RowHeadersWidth = 51;
            this.dgUser.Size = new System.Drawing.Size(1035, 294);
            this.dgUser.TabIndex = 19;
            // 
            // rbUtilisateur
            // 
            this.rbUtilisateur.AutoSize = true;
            this.rbUtilisateur.Location = new System.Drawing.Point(231, 172);
            this.rbUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.rbUtilisateur.Name = "rbUtilisateur";
            this.rbUtilisateur.Size = new System.Drawing.Size(92, 21);
            this.rbUtilisateur.TabIndex = 20;
            this.rbUtilisateur.Text = "Utilisateur";
            this.rbUtilisateur.UseVisualStyleBackColor = true;
            // 
            // rbInvite
            // 
            this.rbInvite.AutoSize = true;
            this.rbInvite.Location = new System.Drawing.Point(352, 172);
            this.rbInvite.Margin = new System.Windows.Forms.Padding(4);
            this.rbInvite.Name = "rbInvite";
            this.rbInvite.Size = new System.Drawing.Size(62, 21);
            this.rbInvite.TabIndex = 21;
            this.rbInvite.Text = "Invite";
            this.rbInvite.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(125, 172);
            this.rbAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(68, 21);
            this.rbAdmin.TabIndex = 22;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonChangeMdp
            // 
            this.buttonChangeMdp.Location = new System.Drawing.Point(509, 65);
            this.buttonChangeMdp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChangeMdp.Name = "buttonChangeMdp";
            this.buttonChangeMdp.Size = new System.Drawing.Size(175, 28);
            this.buttonChangeMdp.TabIndex = 23;
            this.buttonChangeMdp.Text = "Modifier le mdp";
            this.buttonChangeMdp.UseVisualStyleBackColor = true;
            this.buttonChangeMdp.Click += new System.EventHandler(this.buttonChangeMdp_Click);
            // 
            // tbChangeMdp
            // 
            this.tbChangeMdp.Location = new System.Drawing.Point(692, 65);
            this.tbChangeMdp.Margin = new System.Windows.Forms.Padding(4);
            this.tbChangeMdp.Name = "tbChangeMdp";
            this.tbChangeMdp.Size = new System.Drawing.Size(263, 22);
            this.tbChangeMdp.TabIndex = 24;
            this.tbChangeMdp.Visible = false;
            // 
            // aide
            // 
            this.aide.Location = new System.Drawing.Point(707, 155);
            this.aide.Name = "aide";
            this.aide.Size = new System.Drawing.Size(81, 29);
            this.aide.TabIndex = 29;
            this.aide.Text = "Aide ";
            this.aide.UseVisualStyleBackColor = true;
            this.aide.Click += new System.EventHandler(this.aide_Click);
            // 
            // ChangeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.aide);
            this.Controls.Add(this.tbChangeMdp);
            this.Controls.Add(this.buttonChangeMdp);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.rbInvite);
            this.Controls.Add(this.rbUtilisateur);
            this.Controls.Add(this.dgUser);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.buttonMAJ);
            this.Controls.Add(this.tbNom);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangeUser";
            this.Text = "Modification d\'un utilisateur";
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Button buttonMAJ;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.DataGridView dgUser;
        private System.Windows.Forms.RadioButton rbUtilisateur;
        private System.Windows.Forms.RadioButton rbInvite;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.Button buttonChangeMdp;
        private System.Windows.Forms.TextBox tbChangeMdp;
        private System.Windows.Forms.Button aide;
    }
}