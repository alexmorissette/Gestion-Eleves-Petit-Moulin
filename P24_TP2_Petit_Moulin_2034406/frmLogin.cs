/*
 * IDENTIFICATION
 * Titre: Formulaire de connexion
 * 
 * Description: Ce programme affiche un formulaire qui demande à l'utilisateur d'entrer
 * ses informations de connexion afin d'accéder à la MDI.
 * 
 * Éventuellement, il va falloir créer un fichier Utilisateurs.dta pour stocker les enregistrements et créer un formulaire pour la gestion
 * de ces utilisateurs.
 * 
 * Fait par : Alex Morissette
 * Le 27 avril 2021
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
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Procédure qui permet à l'utilisateur d'accéder à la MDI si les informations de connexion saisies sont correctes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdConnecter_Click(object sender, EventArgs e)
        {
            try
            {

                // Vérifier si la fenetre est déjà ouverte
                for (int i = 0; i < this.MdiChildren.Length; i++)
                {
                    if (this.MdiChildren[i].Text == "Connexion")
                    {
                        // Le formulaire gestion est déjà ouvert
                        this.MdiChildren[i].Activate();
                        return; // Pour sortir 
                    }
                }

                int nbrUsers = 1; // 
                string[,] userConnect = new string[nbrUsers, 2];
                userConnect[0,0] = "ADMIN";
                userConnect[0,1] = "ADMIN";

                if (txtUtilisateur.Text == "")
                {
                    err1.SetError(txtUtilisateur, "Entrez le nom d'utilisateur");
                    txtUtilisateur.Focus();
                    return;
                }
                if (mskMotdepasse.Text == "")
                {
                    err1.SetError(mskMotdepasse, "Entrez le mot de passe");
                    mskMotdepasse.Focus();
                    return;
                }
                else
                {
                    if (txtUtilisateur.Text.ToUpper() == userConnect[0,0] && mskMotdepasse.Text.ToUpper() == userConnect[0,1])
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Utilisateur ou mot de passe invalide!", "Connexion impossible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        err1.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                       
        }

        /// <summary>
        /// Procédure qui permet de vider le formulaire des notifications d'erreurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void err1Clear(object sender, KeyPressEventArgs e)
        {
            err1.Clear();
        }

        /// <summary>
        /// Procédure qui permet de quitter le programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
