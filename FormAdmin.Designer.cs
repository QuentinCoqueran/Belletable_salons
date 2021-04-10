namespace ppe1
{
    partial class FormAdmin
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
            this.dtLog = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPages = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtUser = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgEchec = new System.Windows.Forms.DataGridView();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.aide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtLog)).BeginInit();
            this.tabPages.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtUser)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEchec)).BeginInit();
            this.SuspendLayout();
            // 
            // dtLog
            // 
            this.dtLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLog.Location = new System.Drawing.Point(0, 0);
            this.dtLog.Margin = new System.Windows.Forms.Padding(4);
            this.dtLog.Name = "dtLog";
            this.dtLog.RowHeadersWidth = 51;
            this.dtLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtLog.Size = new System.Drawing.Size(1033, 385);
            this.dtLog.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Vos informations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.tabPage3);
            this.tabPages.Controls.Add(this.tabPage1);
            this.tabPages.Controls.Add(this.tabPage2);
            this.tabPages.Location = new System.Drawing.Point(88, 51);
            this.tabPages.Margin = new System.Windows.Forms.Padding(4);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(768, 412);
            this.tabPages.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dtUser);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(760, 383);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "User";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtUser
            // 
            this.dtUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUser.Location = new System.Drawing.Point(1, 0);
            this.dtUser.Margin = new System.Windows.Forms.Padding(4);
            this.dtUser.Name = "dtUser";
            this.dtUser.RowHeadersWidth = 51;
            this.dtUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtUser.Size = new System.Drawing.Size(761, 380);
            this.dtUser.TabIndex = 1;
            this.dtUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtUser_CellDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(760, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Logs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgEchec);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(760, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Echec";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgEchec
            // 
            this.dgEchec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEchec.Location = new System.Drawing.Point(0, 0);
            this.dgEchec.Margin = new System.Windows.Forms.Padding(4);
            this.dgEchec.Name = "dgEchec";
            this.dgEchec.RowHeadersWidth = 51;
            this.dgEchec.Size = new System.Drawing.Size(959, 363);
            this.dgEchec.TabIndex = 3;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(555, 15);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(165, 28);
            this.buttonAddUser.TabIndex = 3;
            this.buttonAddUser.Text = "Ajouter un utilisateur";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // aide
            // 
            this.aide.Location = new System.Drawing.Point(88, 12);
            this.aide.Name = "aide";
            this.aide.Size = new System.Drawing.Size(81, 29);
            this.aide.TabIndex = 30;
            this.aide.Text = "Aide ";
            this.aide.UseVisualStyleBackColor = true;
            this.aide.Click += new System.EventHandler(this.aide_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(910, 478);
            this.Controls.Add(this.aide);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.tabPages);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAdmin";
            this.Text = "Panel Administrateur";
            ((System.ComponentModel.ISupportInitialize)(this.dtLog)).EndInit();
            this.tabPages.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtUser)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEchec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgEchec;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dtUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button aide;
    }
}