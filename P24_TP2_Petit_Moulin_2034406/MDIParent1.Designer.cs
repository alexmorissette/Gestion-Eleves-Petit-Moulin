
namespace P24_TP2_Petit_Moulin_2034406
{
    partial class frmMDI
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGestionEtu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAide = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuApropos = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gestionDesÉtudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeEtStatistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.ctxtMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuAide});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(1419, 24);
            this.mnuPrincipal.TabIndex = 2;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGestionEtu,
            this.mnuListe,
            this.mnuSep1,
            this.mnuQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuGestionEtu
            // 
            this.mnuGestionEtu.Name = "mnuGestionEtu";
            this.mnuGestionEtu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.mnuGestionEtu.Size = new System.Drawing.Size(225, 22);
            this.mnuGestionEtu.Text = "&Gestion des étudiants";
            this.mnuGestionEtu.Click += new System.EventHandler(this.mnuGestionEtu_Click);
            // 
            // mnuListe
            // 
            this.mnuListe.Name = "mnuListe";
            this.mnuListe.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.mnuListe.Size = new System.Drawing.Size(225, 22);
            this.mnuListe.Text = "&Liste et statistiques";
            this.mnuListe.Click += new System.EventHandler(this.mnuListe_Click);
            // 
            // mnuSep1
            // 
            this.mnuSep1.Name = "mnuSep1";
            this.mnuSep1.Size = new System.Drawing.Size(222, 6);
            // 
            // mnuQuitter
            // 
            this.mnuQuitter.Name = "mnuQuitter";
            this.mnuQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuQuitter.Size = new System.Drawing.Size(225, 22);
            this.mnuQuitter.Text = "&Quitter";
            this.mnuQuitter.Click += new System.EventHandler(this.mnuQuitter_Click);
            // 
            // mnuAide
            // 
            this.mnuAide.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuApropos});
            this.mnuAide.Name = "mnuAide";
            this.mnuAide.Size = new System.Drawing.Size(43, 20);
            this.mnuAide.Text = "Aide";
            // 
            // mnuApropos
            // 
            this.mnuApropos.Name = "mnuApropos";
            this.mnuApropos.Size = new System.Drawing.Size(180, 22);
            this.mnuApropos.Text = "À propos";
            this.mnuApropos.Click += new System.EventHandler(this.mnuApropos_Click);
            // 
            // ctxtMenu
            // 
            this.ctxtMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesÉtudiantsToolStripMenuItem,
            this.listeEtStatistiquesToolStripMenuItem});
            this.ctxtMenu.Name = "ctxtMenu";
            this.ctxtMenu.Size = new System.Drawing.Size(188, 48);
            this.ctxtMenu.Text = "Menu";
            // 
            // gestionDesÉtudiantsToolStripMenuItem
            // 
            this.gestionDesÉtudiantsToolStripMenuItem.Name = "gestionDesÉtudiantsToolStripMenuItem";
            this.gestionDesÉtudiantsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gestionDesÉtudiantsToolStripMenuItem.Text = "Gestion des étudiants";
            this.gestionDesÉtudiantsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesÉtudiantsToolStripMenuItem_Click);
            // 
            // listeEtStatistiquesToolStripMenuItem
            // 
            this.listeEtStatistiquesToolStripMenuItem.Name = "listeEtStatistiquesToolStripMenuItem";
            this.listeEtStatistiquesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.listeEtStatistiquesToolStripMenuItem.Text = "Liste et statistiques";
            this.listeEtStatistiquesToolStripMenuItem.Click += new System.EventHandler(this.listeEtStatistiquesToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 790);
            this.ContextMenuStrip = this.ctxtMenu;
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.Name = "frmMDI";
            this.Text = "Gestion - École du Petit Moulin";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ctxtMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuGestionEtu;
        private System.Windows.Forms.ToolStripMenuItem mnuListe;
        private System.Windows.Forms.ToolStripSeparator mnuSep1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuAide;
        private System.Windows.Forms.ToolStripMenuItem mnuApropos;
        private System.Windows.Forms.ContextMenuStrip ctxtMenu;
        private System.Windows.Forms.ToolStripMenuItem gestionDesÉtudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeEtStatistiquesToolStripMenuItem;
    }
}



