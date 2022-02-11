/*
 * IDENTIFICATION
 * Titre: Formulaire MDI d'accueil
 * 
 * Description: Ce programme affiche une fenêtre MDI et un menu qui permet d'accéder
 * aux différents formulaires.
 * 
 * Fait par : Alex Morissette
 * Le 12 avril 2021
 * Modifié le : 2 mai 2021
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P24_TP2_Petit_Moulin_2034406
{
    public partial class frmMDI : Form
    {
        //private int childFormNumber = 0;

        public frmMDI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Procédure qui permet d'afficher le formulaire de Gestion des étudiants.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuGestionEtu_Click(object sender, EventArgs e)
        {
            // Vérifier si la fenetre est déjà ouverte
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Text == "Gestion des étudiants")
                {
                    // Le formulaire gestion est déjà ouvert
                    this.MdiChildren[i].Activate();
                    return; // Pour sortir 
                }
            }

            frmGestionEtudiants frm = new frmGestionEtudiants();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Procédure qui permet de quitter le programme. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuQuitter_Click(object sender, EventArgs e)
        {
            DialogResult rep;

            // Demander une confirmation
            rep = MessageBox.Show("Voulez-vous vraiment quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rep == DialogResult.Yes)
                Application.Exit();
        }

        /// <summary>
        ///^Procédure qui permet d'afficher la fenêtre "À propos"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuApropos_Click(object sender, EventArgs e)
        {
            frmApropos frm = new frmApropos();
            frm.ShowDialog(); // fenêtre Modale
        }

        /// <summary>
        /// Procédure qui permet d'afficher le formulaire "Liste des étudiants".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuListe_Click(object sender, EventArgs e)
        {
            
            // Vérifier si la fenetre est déjà ouverte
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Text == "Liste des étudiants")
                {
                    // Le formulaire gestion est déjà ouvert
                    this.MdiChildren[i].Activate();
                    return; // Pour sortir 
                }
            }

            frmListe frm = new frmListe();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Procédure qui, au démarrage du programme, afficher le formulaire de connexion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMDI_Load(object sender, EventArgs e)
        {

            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        /// <summary>
        /// Procédure qui permet d'afficher la liste des étudiants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listeEtStatistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Vérifier si la fenetre est déjà ouverte
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Text == "Liste des étudiants")
                {
                    // Le formulaire gestion est déjà ouvert
                    this.MdiChildren[i].Activate();
                    return; // Pour sortir 
                }
            }

            frmListe frm = new frmListe();
            frm.MdiParent = this;
            frm.Show();
        }

        /// <summary>
        /// Procédure qui permet d'afficher le formulaire Gestion des étudiants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gestionDesÉtudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Vérifier si la fenetre est déjà ouverte
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (this.MdiChildren[i].Text == "Gestion des étudiants")
                {
                    // Le formulaire gestion est déjà ouvert
                    this.MdiChildren[i].Activate();
                    return; // Pour sortir 
                }
            }

            frmGestionEtudiants frm = new frmGestionEtudiants();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}