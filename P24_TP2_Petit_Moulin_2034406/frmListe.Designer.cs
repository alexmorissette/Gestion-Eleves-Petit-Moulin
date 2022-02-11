
namespace P24_TP2_Petit_Moulin_2034406
{
    partial class frmListe
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
            this.lvEtudiants = new System.Windows.Forms.ListView();
            this.colNoID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodePermanent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSexe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateNaissance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAdresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVille = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodePostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTelephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIntra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFinal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTP1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTP2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitreListe = new System.Windows.Forms.Label();
            this.groupFiltre = new System.Windows.Forms.GroupBox();
            this.optListeMasculin = new System.Windows.Forms.RadioButton();
            this.optListeFeminin = new System.Windows.Forms.RadioButton();
            this.optAfficherTout = new System.Windows.Forms.RadioButton();
            this.optCoordonnees = new System.Windows.Forms.RadioButton();
            this.optNomsResultats = new System.Windows.Forms.RadioButton();
            this.groupStats = new System.Windows.Forms.GroupBox();
            this.groupMoyennes = new System.Windows.Forms.GroupBox();
            this.txtMoyGenerale = new System.Windows.Forms.Label();
            this.lblMoyGenerale = new System.Windows.Forms.Label();
            this.txtMoyTP2 = new System.Windows.Forms.Label();
            this.lblMoyTP2 = new System.Windows.Forms.Label();
            this.txtMoyTP1 = new System.Windows.Forms.Label();
            this.lblMoyTP1 = new System.Windows.Forms.Label();
            this.txtMoyFinal = new System.Windows.Forms.Label();
            this.lblMoyFinal = new System.Windows.Forms.Label();
            this.txtMoyIntra = new System.Windows.Forms.Label();
            this.lblMoyIntra = new System.Windows.Forms.Label();
            this.txtNbrEtudiants = new System.Windows.Forms.Label();
            this.lblNbrEtudiants = new System.Windows.Forms.Label();
            this.lblTri = new System.Windows.Forms.Label();
            this.prtDialog = new System.Windows.Forms.PrintDialog();
            this.cmdGestionForm = new System.Windows.Forms.Button();
            this.groupFiltre.SuspendLayout();
            this.groupStats.SuspendLayout();
            this.groupMoyennes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvEtudiants
            // 
            this.lvEtudiants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNoID,
            this.colCodePermanent,
            this.colPrenom,
            this.colNom,
            this.colSexe,
            this.colDateNaissance,
            this.colAdresse,
            this.colVille,
            this.colCodePostal,
            this.colTelephone,
            this.colIntra,
            this.colFinal,
            this.colTP1,
            this.colTP2});
            this.lvEtudiants.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEtudiants.FullRowSelect = true;
            this.lvEtudiants.GridLines = true;
            this.lvEtudiants.HideSelection = false;
            this.lvEtudiants.Location = new System.Drawing.Point(29, 84);
            this.lvEtudiants.Name = "lvEtudiants";
            this.lvEtudiants.Size = new System.Drawing.Size(1127, 404);
            this.lvEtudiants.TabIndex = 0;
            this.lvEtudiants.UseCompatibleStateImageBehavior = false;
            this.lvEtudiants.View = System.Windows.Forms.View.Details;
            this.lvEtudiants.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvEtudiants_ColumnClick);
            // 
            // colNoID
            // 
            this.colNoID.Text = "NoID";
            this.colNoID.Width = 200;
            // 
            // colCodePermanent
            // 
            this.colCodePermanent.Text = "Code Permanent";
            this.colCodePermanent.Width = 100;
            // 
            // colPrenom
            // 
            this.colPrenom.Text = "Prénom";
            this.colPrenom.Width = 150;
            // 
            // colNom
            // 
            this.colNom.Text = "Nom";
            // 
            // colSexe
            // 
            this.colSexe.Text = "Sexe";
            this.colSexe.Width = 157;
            // 
            // colDateNaissance
            // 
            this.colDateNaissance.Text = "Date de Naissance";
            this.colDateNaissance.Width = 200;
            // 
            // colAdresse
            // 
            this.colAdresse.Text = "Adresse";
            this.colAdresse.Width = 100;
            // 
            // colVille
            // 
            this.colVille.Text = "Ville";
            this.colVille.Width = 80;
            // 
            // colCodePostal
            // 
            this.colCodePostal.Text = "Code Postal";
            this.colCodePostal.Width = 100;
            // 
            // colTelephone
            // 
            this.colTelephone.Text = "Téléphone";
            // 
            // colIntra
            // 
            this.colIntra.Text = "Intra";
            // 
            // colFinal
            // 
            this.colFinal.Text = "Final";
            // 
            // colTP1
            // 
            this.colTP1.Text = "TP1";
            // 
            // colTP2
            // 
            this.colTP2.Text = "TP2";
            // 
            // lblTitreListe
            // 
            this.lblTitreListe.AutoSize = true;
            this.lblTitreListe.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreListe.Location = new System.Drawing.Point(25, 28);
            this.lblTitreListe.Name = "lblTitreListe";
            this.lblTitreListe.Size = new System.Drawing.Size(178, 22);
            this.lblTitreListe.TabIndex = 4;
            this.lblTitreListe.Text = "LISTE DES ÉTUDIANTS";
            // 
            // groupFiltre
            // 
            this.groupFiltre.Controls.Add(this.optListeMasculin);
            this.groupFiltre.Controls.Add(this.optListeFeminin);
            this.groupFiltre.Controls.Add(this.optAfficherTout);
            this.groupFiltre.Controls.Add(this.optCoordonnees);
            this.groupFiltre.Controls.Add(this.optNomsResultats);
            this.groupFiltre.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupFiltre.Location = new System.Drawing.Point(29, 509);
            this.groupFiltre.Name = "groupFiltre";
            this.groupFiltre.Size = new System.Drawing.Size(561, 128);
            this.groupFiltre.TabIndex = 5;
            this.groupFiltre.TabStop = false;
            this.groupFiltre.Text = "FILTRES";
            // 
            // optListeMasculin
            // 
            this.optListeMasculin.AutoSize = true;
            this.optListeMasculin.Location = new System.Drawing.Point(300, 60);
            this.optListeMasculin.Name = "optListeMasculin";
            this.optListeMasculin.Size = new System.Drawing.Size(220, 26);
            this.optListeMasculin.TabIndex = 4;
            this.optListeMasculin.TabStop = true;
            this.optListeMasculin.Text = "Sexe masculin seulement";
            this.optListeMasculin.UseVisualStyleBackColor = true;
            this.optListeMasculin.Enter += new System.EventHandler(this.AfficherMasculin);
            // 
            // optListeFeminin
            // 
            this.optListeFeminin.AutoSize = true;
            this.optListeFeminin.Location = new System.Drawing.Point(300, 28);
            this.optListeFeminin.Name = "optListeFeminin";
            this.optListeFeminin.Size = new System.Drawing.Size(210, 26);
            this.optListeFeminin.TabIndex = 3;
            this.optListeFeminin.TabStop = true;
            this.optListeFeminin.Text = "Sexe féminin seulement";
            this.optListeFeminin.UseVisualStyleBackColor = true;
            this.optListeFeminin.Enter += new System.EventHandler(this.AfficherFeminin);
            // 
            // optAfficherTout
            // 
            this.optAfficherTout.AutoSize = true;
            this.optAfficherTout.Checked = true;
            this.optAfficherTout.Location = new System.Drawing.Point(6, 28);
            this.optAfficherTout.Name = "optAfficherTout";
            this.optAfficherTout.Size = new System.Drawing.Size(144, 26);
            this.optAfficherTout.TabIndex = 2;
            this.optAfficherTout.TabStop = true;
            this.optAfficherTout.Text = "Tous les détails";
            this.optAfficherTout.UseVisualStyleBackColor = true;
            this.optAfficherTout.Enter += new System.EventHandler(this.AfficherEtudiants);
            // 
            // optCoordonnees
            // 
            this.optCoordonnees.AutoSize = true;
            this.optCoordonnees.Location = new System.Drawing.Point(6, 84);
            this.optCoordonnees.Name = "optCoordonnees";
            this.optCoordonnees.Size = new System.Drawing.Size(215, 26);
            this.optCoordonnees.TabIndex = 1;
            this.optCoordonnees.TabStop = true;
            this.optCoordonnees.Text = "Coordonnées seulement";
            this.optCoordonnees.UseVisualStyleBackColor = true;
            this.optCoordonnees.Enter += new System.EventHandler(this.AfficherCoordonnees);
            // 
            // optNomsResultats
            // 
            this.optNomsResultats.AutoSize = true;
            this.optNomsResultats.Location = new System.Drawing.Point(6, 55);
            this.optNomsResultats.Name = "optNomsResultats";
            this.optNomsResultats.Size = new System.Drawing.Size(182, 26);
            this.optNomsResultats.TabIndex = 0;
            this.optNomsResultats.Text = "Résultats seulement";
            this.optNomsResultats.UseVisualStyleBackColor = true;
            this.optNomsResultats.Enter += new System.EventHandler(this.AfficherResultats);
            // 
            // groupStats
            // 
            this.groupStats.Controls.Add(this.groupMoyennes);
            this.groupStats.Controls.Add(this.txtNbrEtudiants);
            this.groupStats.Controls.Add(this.lblNbrEtudiants);
            this.groupStats.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupStats.Location = new System.Drawing.Point(624, 509);
            this.groupStats.Name = "groupStats";
            this.groupStats.Size = new System.Drawing.Size(532, 166);
            this.groupStats.TabIndex = 6;
            this.groupStats.TabStop = false;
            this.groupStats.Text = "STATISTIQUES";
            // 
            // groupMoyennes
            // 
            this.groupMoyennes.Controls.Add(this.txtMoyGenerale);
            this.groupMoyennes.Controls.Add(this.lblMoyGenerale);
            this.groupMoyennes.Controls.Add(this.txtMoyTP2);
            this.groupMoyennes.Controls.Add(this.lblMoyTP2);
            this.groupMoyennes.Controls.Add(this.txtMoyTP1);
            this.groupMoyennes.Controls.Add(this.lblMoyTP1);
            this.groupMoyennes.Controls.Add(this.txtMoyFinal);
            this.groupMoyennes.Controls.Add(this.lblMoyFinal);
            this.groupMoyennes.Controls.Add(this.txtMoyIntra);
            this.groupMoyennes.Controls.Add(this.lblMoyIntra);
            this.groupMoyennes.Location = new System.Drawing.Point(216, 25);
            this.groupMoyennes.Name = "groupMoyennes";
            this.groupMoyennes.Size = new System.Drawing.Size(300, 135);
            this.groupMoyennes.TabIndex = 6;
            this.groupMoyennes.TabStop = false;
            this.groupMoyennes.Text = "Moyennes du groupe";
            // 
            // txtMoyGenerale
            // 
            this.txtMoyGenerale.Location = new System.Drawing.Point(184, 98);
            this.txtMoyGenerale.Name = "txtMoyGenerale";
            this.txtMoyGenerale.Size = new System.Drawing.Size(78, 20);
            this.txtMoyGenerale.TabIndex = 13;
            this.txtMoyGenerale.Text = "54";
            // 
            // lblMoyGenerale
            // 
            this.lblMoyGenerale.AutoSize = true;
            this.lblMoyGenerale.Location = new System.Drawing.Point(18, 98);
            this.lblMoyGenerale.Name = "lblMoyGenerale";
            this.lblMoyGenerale.Size = new System.Drawing.Size(160, 22);
            this.lblMoyGenerale.TabIndex = 12;
            this.lblMoyGenerale.Text = "Moyenne générale :";
            // 
            // txtMoyTP2
            // 
            this.txtMoyTP2.Location = new System.Drawing.Point(215, 61);
            this.txtMoyTP2.Name = "txtMoyTP2";
            this.txtMoyTP2.Size = new System.Drawing.Size(79, 20);
            this.txtMoyTP2.TabIndex = 11;
            this.txtMoyTP2.Text = "54";
            // 
            // lblMoyTP2
            // 
            this.lblMoyTP2.AutoSize = true;
            this.lblMoyTP2.Location = new System.Drawing.Point(159, 62);
            this.lblMoyTP2.Name = "lblMoyTP2";
            this.lblMoyTP2.Size = new System.Drawing.Size(50, 22);
            this.lblMoyTP2.TabIndex = 10;
            this.lblMoyTP2.Text = "TP 2 :";
            // 
            // txtMoyTP1
            // 
            this.txtMoyTP1.Location = new System.Drawing.Point(215, 32);
            this.txtMoyTP1.Name = "txtMoyTP1";
            this.txtMoyTP1.Size = new System.Drawing.Size(79, 20);
            this.txtMoyTP1.TabIndex = 9;
            this.txtMoyTP1.Text = "54";
            // 
            // lblMoyTP1
            // 
            this.lblMoyTP1.AutoSize = true;
            this.lblMoyTP1.Location = new System.Drawing.Point(159, 32);
            this.lblMoyTP1.Name = "lblMoyTP1";
            this.lblMoyTP1.Size = new System.Drawing.Size(50, 22);
            this.lblMoyTP1.TabIndex = 8;
            this.lblMoyTP1.Text = "TP 1 :";
            // 
            // txtMoyFinal
            // 
            this.txtMoyFinal.Location = new System.Drawing.Point(79, 62);
            this.txtMoyFinal.Name = "txtMoyFinal";
            this.txtMoyFinal.Size = new System.Drawing.Size(74, 20);
            this.txtMoyFinal.TabIndex = 7;
            this.txtMoyFinal.Text = "54";
            // 
            // lblMoyFinal
            // 
            this.lblMoyFinal.AutoSize = true;
            this.lblMoyFinal.Location = new System.Drawing.Point(18, 61);
            this.lblMoyFinal.Name = "lblMoyFinal";
            this.lblMoyFinal.Size = new System.Drawing.Size(54, 22);
            this.lblMoyFinal.TabIndex = 6;
            this.lblMoyFinal.Text = "Final :";
            // 
            // txtMoyIntra
            // 
            this.txtMoyIntra.Location = new System.Drawing.Point(79, 33);
            this.txtMoyIntra.Name = "txtMoyIntra";
            this.txtMoyIntra.Size = new System.Drawing.Size(74, 20);
            this.txtMoyIntra.TabIndex = 5;
            this.txtMoyIntra.Text = "54";
            // 
            // lblMoyIntra
            // 
            this.lblMoyIntra.AutoSize = true;
            this.lblMoyIntra.Location = new System.Drawing.Point(18, 32);
            this.lblMoyIntra.Name = "lblMoyIntra";
            this.lblMoyIntra.Size = new System.Drawing.Size(55, 22);
            this.lblMoyIntra.TabIndex = 4;
            this.lblMoyIntra.Text = "Intra :";
            // 
            // txtNbrEtudiants
            // 
            this.txtNbrEtudiants.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbrEtudiants.Location = new System.Drawing.Point(43, 75);
            this.txtNbrEtudiants.Name = "txtNbrEtudiants";
            this.txtNbrEtudiants.Size = new System.Drawing.Size(94, 36);
            this.txtNbrEtudiants.TabIndex = 1;
            this.txtNbrEtudiants.Text = "54";
            this.txtNbrEtudiants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNbrEtudiants
            // 
            this.lblNbrEtudiants.AutoSize = true;
            this.lblNbrEtudiants.Location = new System.Drawing.Point(7, 35);
            this.lblNbrEtudiants.Name = "lblNbrEtudiants";
            this.lblNbrEtudiants.Size = new System.Drawing.Size(172, 22);
            this.lblNbrEtudiants.TabIndex = 0;
            this.lblNbrEtudiants.Text = "Nombre d\'étudiants :";
            // 
            // lblTri
            // 
            this.lblTri.AutoSize = true;
            this.lblTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTri.Location = new System.Drawing.Point(31, 61);
            this.lblTri.Name = "lblTri";
            this.lblTri.Size = new System.Drawing.Size(310, 16);
            this.lblTri.TabIndex = 7;
            this.lblTri.Text = "Cliquez sur le nom d\'une colonne pour en faire le tri.";
            // 
            // prtDialog
            // 
            this.prtDialog.UseEXDialog = true;
            // 
            // cmdGestionForm
            // 
            this.cmdGestionForm.Location = new System.Drawing.Point(971, 28);
            this.cmdGestionForm.Name = "cmdGestionForm";
            this.cmdGestionForm.Size = new System.Drawing.Size(185, 36);
            this.cmdGestionForm.TabIndex = 8;
            this.cmdGestionForm.Text = "Gestion des étudiants";
            this.cmdGestionForm.UseVisualStyleBackColor = true;
            this.cmdGestionForm.Click += new System.EventHandler(this.cmdGestionForm_Click);
            // 
            // frmListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.cmdGestionForm);
            this.Controls.Add(this.lblTri);
            this.Controls.Add(this.groupStats);
            this.Controls.Add(this.groupFiltre);
            this.Controls.Add(this.lblTitreListe);
            this.Controls.Add(this.lvEtudiants);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListe";
            this.Text = "Liste des étudiants";
            this.Activated += new System.EventHandler(this.AfficherEtudiants);
            this.Load += new System.EventHandler(this.frmListe_Load);
            this.groupFiltre.ResumeLayout(false);
            this.groupFiltre.PerformLayout();
            this.groupStats.ResumeLayout(false);
            this.groupStats.PerformLayout();
            this.groupMoyennes.ResumeLayout(false);
            this.groupMoyennes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvEtudiants;
        private System.Windows.Forms.ColumnHeader colNoID;
        private System.Windows.Forms.ColumnHeader colCodePermanent;
        private System.Windows.Forms.ColumnHeader colPrenom;
        private System.Windows.Forms.ColumnHeader colNom;
        private System.Windows.Forms.ColumnHeader colSexe;
        private System.Windows.Forms.ColumnHeader colDateNaissance;
        private System.Windows.Forms.ColumnHeader colAdresse;
        private System.Windows.Forms.ColumnHeader colVille;
        private System.Windows.Forms.ColumnHeader colCodePostal;
        private System.Windows.Forms.ColumnHeader colTelephone;
        private System.Windows.Forms.ColumnHeader colIntra;
        private System.Windows.Forms.ColumnHeader colFinal;
        private System.Windows.Forms.ColumnHeader colTP1;
        private System.Windows.Forms.ColumnHeader colTP2;
        private System.Windows.Forms.Label lblTitreListe;
        private System.Windows.Forms.GroupBox groupFiltre;
        private System.Windows.Forms.RadioButton optAfficherTout;
        private System.Windows.Forms.RadioButton optCoordonnees;
        private System.Windows.Forms.RadioButton optNomsResultats;
        private System.Windows.Forms.GroupBox groupStats;
        private System.Windows.Forms.Label lblNbrEtudiants;
        private System.Windows.Forms.Label txtNbrEtudiants;
        private System.Windows.Forms.GroupBox groupMoyennes;
        private System.Windows.Forms.Label txtMoyIntra;
        private System.Windows.Forms.Label lblMoyIntra;
        private System.Windows.Forms.Label txtMoyGenerale;
        private System.Windows.Forms.Label lblMoyGenerale;
        private System.Windows.Forms.Label txtMoyTP2;
        private System.Windows.Forms.Label lblMoyTP2;
        private System.Windows.Forms.Label txtMoyTP1;
        private System.Windows.Forms.Label lblMoyTP1;
        private System.Windows.Forms.Label txtMoyFinal;
        private System.Windows.Forms.Label lblMoyFinal;
        private System.Windows.Forms.RadioButton optListeMasculin;
        private System.Windows.Forms.RadioButton optListeFeminin;
        private System.Windows.Forms.Label lblTri;
        private System.Windows.Forms.PrintDialog prtDialog;
        private System.Windows.Forms.Button cmdGestionForm;
    }
}