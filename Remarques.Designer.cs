
namespace ppe1
{
    partial class Remarques
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
            this.commentaire = new System.Windows.Forms.RichTextBox();
            this.dysfonctionnement = new System.Windows.Forms.RadioButton();
            this.evolution = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // commentaire
            // 
            this.commentaire.Location = new System.Drawing.Point(15, 30);
            this.commentaire.Name = "commentaire";
            this.commentaire.Size = new System.Drawing.Size(460, 133);
            this.commentaire.TabIndex = 0;
            this.commentaire.Text = "";
            // 
            // dysfonctionnement
            // 
            this.dysfonctionnement.AutoSize = true;
            this.dysfonctionnement.Location = new System.Drawing.Point(29, 36);
            this.dysfonctionnement.Name = "dysfonctionnement";
            this.dysfonctionnement.Size = new System.Drawing.Size(150, 21);
            this.dysfonctionnement.TabIndex = 3;
            this.dysfonctionnement.TabStop = true;
            this.dysfonctionnement.Text = "Dysfonctionnement";
            this.dysfonctionnement.UseVisualStyleBackColor = true;
            // 
            // evolution
            // 
            this.evolution.AutoSize = true;
            this.evolution.Location = new System.Drawing.Point(204, 36);
            this.evolution.Name = "evolution";
            this.evolution.Size = new System.Drawing.Size(149, 21);
            this.evolution.TabIndex = 4;
            this.evolution.TabStop = true;
            this.evolution.Text = "Souhait d\'évolution";
            this.evolution.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.evolution);
            this.groupBox1.Controls.Add(this.dysfonctionnement);
            this.groupBox1.Location = new System.Drawing.Point(105, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 84);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type de remarque";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.commentaire);
            this.groupBox2.Location = new System.Drawing.Point(90, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 190);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Votre remarque :";
            // 
            // Remarques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Remarques";
            this.Text = "Remarques";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox commentaire;
        private System.Windows.Forms.RadioButton dysfonctionnement;
        private System.Windows.Forms.RadioButton evolution;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}