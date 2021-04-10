namespace ppe1
{
    partial class RoleButtons
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
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonUtilisateur = new System.Windows.Forms.Button();
            this.buttonInvite = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(44, 43);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(100, 28);
            this.buttonAdmin.TabIndex = 0;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Visible = false;
            // 
            // buttonUtilisateur
            // 
            this.buttonUtilisateur.Location = new System.Drawing.Point(181, 43);
            this.buttonUtilisateur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUtilisateur.Name = "buttonUtilisateur";
            this.buttonUtilisateur.Size = new System.Drawing.Size(100, 28);
            this.buttonUtilisateur.TabIndex = 1;
            this.buttonUtilisateur.Text = "Utilisateur";
            this.buttonUtilisateur.UseVisualStyleBackColor = true;
            this.buttonUtilisateur.Visible = false;
            // 
            // buttonInvite
            // 
            this.buttonInvite.Location = new System.Drawing.Point(311, 43);
            this.buttonInvite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInvite.Name = "buttonInvite";
            this.buttonInvite.Size = new System.Drawing.Size(100, 28);
            this.buttonInvite.TabIndex = 2;
            this.buttonInvite.Text = "Invité";
            this.buttonInvite.UseVisualStyleBackColor = true;
            this.buttonInvite.Click += new System.EventHandler(this.buttonInvite_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 114);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 3;
            // 
            // RoleButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(469, 173);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonInvite);
            this.Controls.Add(this.buttonUtilisateur);
            this.Controls.Add(this.buttonAdmin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RoleButtons";
            this.Text = "Vos Boutons";
            this.Load += new System.EventHandler(this.RoleButtons_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonUtilisateur;
        private System.Windows.Forms.Button buttonInvite;
        private System.Windows.Forms.TextBox textBox1;
    }
}