
namespace P24_TP2_Petit_Moulin_2034406
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.lblNomUtilisateur = new System.Windows.Forms.Label();
            this.txtUtilisateur = new System.Windows.Forms.TextBox();
            this.groupConnexion = new System.Windows.Forms.GroupBox();
            this.mskMotdepasse = new System.Windows.Forms.MaskedTextBox();
            this.cmdConnecter = new System.Windows.Forms.Button();
            this.lblMotdepasse = new System.Windows.Forms.Label();
            this.err1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.groupConnexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomUtilisateur
            // 
            this.lblNomUtilisateur.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUtilisateur.Location = new System.Drawing.Point(21, 28);
            this.lblNomUtilisateur.Name = "lblNomUtilisateur";
            this.lblNomUtilisateur.Size = new System.Drawing.Size(119, 23);
            this.lblNomUtilisateur.TabIndex = 0;
            this.lblNomUtilisateur.Text = "Utilisateur :";
            // 
            // txtUtilisateur
            // 
            this.txtUtilisateur.Location = new System.Drawing.Point(146, 25);
            this.txtUtilisateur.Name = "txtUtilisateur";
            this.txtUtilisateur.Size = new System.Drawing.Size(308, 26);
            this.txtUtilisateur.TabIndex = 1;
            this.txtUtilisateur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.err1Clear);
            // 
            // groupConnexion
            // 
            this.groupConnexion.Controls.Add(this.cmdQuitter);
            this.groupConnexion.Controls.Add(this.mskMotdepasse);
            this.groupConnexion.Controls.Add(this.cmdConnecter);
            this.groupConnexion.Controls.Add(this.lblMotdepasse);
            this.groupConnexion.Controls.Add(this.lblNomUtilisateur);
            this.groupConnexion.Controls.Add(this.txtUtilisateur);
            this.groupConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupConnexion.Location = new System.Drawing.Point(12, 37);
            this.groupConnexion.Name = "groupConnexion";
            this.groupConnexion.Size = new System.Drawing.Size(513, 175);
            this.groupConnexion.TabIndex = 2;
            this.groupConnexion.TabStop = false;
            this.groupConnexion.Text = "Connexion";
            // 
            // mskMotdepasse
            // 
            this.mskMotdepasse.Location = new System.Drawing.Point(146, 63);
            this.mskMotdepasse.Name = "mskMotdepasse";
            this.mskMotdepasse.PasswordChar = '*';
            this.mskMotdepasse.Size = new System.Drawing.Size(308, 26);
            this.mskMotdepasse.TabIndex = 2;
            // 
            // cmdConnecter
            // 
            this.cmdConnecter.Location = new System.Drawing.Point(146, 105);
            this.cmdConnecter.Name = "cmdConnecter";
            this.cmdConnecter.Size = new System.Drawing.Size(137, 37);
            this.cmdConnecter.TabIndex = 3;
            this.cmdConnecter.Text = "Se connecter";
            this.cmdConnecter.UseVisualStyleBackColor = true;
            this.cmdConnecter.Click += new System.EventHandler(this.cmdConnecter_Click);
            // 
            // lblMotdepasse
            // 
            this.lblMotdepasse.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotdepasse.Location = new System.Drawing.Point(21, 66);
            this.lblMotdepasse.Name = "lblMotdepasse";
            this.lblMotdepasse.Size = new System.Drawing.Size(119, 23);
            this.lblMotdepasse.TabIndex = 2;
            this.lblMotdepasse.Text = "Mot de passe :";
            // 
            // err1
            // 
            this.err1.ContainerControl = this;
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdQuitter.Location = new System.Drawing.Point(318, 105);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(136, 37);
            this.cmdQuitter.TabIndex = 4;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.cmdConnecter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(553, 249);
            this.ControlBox = false;
            this.Controls.Add(this.groupConnexion);
            this.Name = "frmLogin";
            this.Text = "Connexion";
            this.groupConnexion.ResumeLayout(false);
            this.groupConnexion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNomUtilisateur;
        private System.Windows.Forms.TextBox txtUtilisateur;
        private System.Windows.Forms.GroupBox groupConnexion;
        private System.Windows.Forms.Label lblMotdepasse;
        private System.Windows.Forms.Button cmdConnecter;
        private System.Windows.Forms.ErrorProvider err1;
        private System.Windows.Forms.MaskedTextBox mskMotdepasse;
        private System.Windows.Forms.Button cmdQuitter;
    }
}