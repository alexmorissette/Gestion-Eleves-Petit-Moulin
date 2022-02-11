/*
 * IDENTIFICATION
 * Titre: Liste des étudiants inscrits
 * 
 * Description: Ce programme permet d'afficher une liste contenant les informations des étudiants inscrits 
 * à partir du formulaire "Gestion des étudiants". 
 * 
 * Il affiche également les statistiques:
 * - Le nombre d'étudiant inscrits
 * - La moyenne de chaque étudiant 
 * - Les moyennes du groupe pour chaque évaluation
 * - La moyenne générale du groupe. 
 * 
 * De plus, l'utilisateur peut sélectionner des options d'affichage afin de filtrer le contenu de la liste 
 * et trier les colonnes de manière ascendante ou descendante.
 * 
 * Fait par : Alex Morissette
 * Le 20 avril 2021
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
using System.IO;
using System.Collections;

namespace P24_TP2_Petit_Moulin_2034406
{
    public partial class frmListe : Form
    {
        private ListViewColumnSorter lvwColumnSorter; // Pour le tri des colonnes

        public frmListe()
        {
            InitializeComponent();

            // Création d'une instance d'un ListView pour trier les colonnes et faire son assignation au contrôle ListView
            lvwColumnSorter = new ListViewColumnSorter();
            this.lvEtudiants.ListViewItemSorter = lvwColumnSorter;
        }

        /// <summary>
        /// Procédure qui appelle la procédure AfficherEtudiants() au démarrage du formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmListe_Load(object sender, EventArgs e)
        {
            AfficherEtudiants();
        }

        /// <summary>
        /// Procédure qui permet d'afficher tous les enregistrements des étudiants dans la ListView, calcule les moyennes et affiche les moyennes.
        /// </summary>
        private void AfficherEtudiants()
        {
            try
            {
                // Vider la liste
                lvEtudiants.Clear(); // Ou .Items pour juste les items

                // Faire les en-têtes des colonnes (additionner le total des largeurs de colonnes pour définir la largeur du listview
                lvEtudiants.Columns.Add("NoID", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Code permanent", 150, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Prénom", 180, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Nom", 180, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Sexe", 50, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Date de naissance", 150, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Adresse", 220, HorizontalAlignment.Left);
                lvEtudiants.Columns.Add("Ville", 180, HorizontalAlignment.Left);
                lvEtudiants.Columns.Add("Code Postal", 100, HorizontalAlignment.Left);
                lvEtudiants.Columns.Add("Téléphone", 180, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Intra", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Final", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("TP1", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("TP2", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Moyenne", 100, HorizontalAlignment.Center);

                // Ouvrir le fichier des étudiants
                FileStream fs = new FileStream(frmGestionEtudiants.NomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                BinaryReader br = new BinaryReader(fs);

                // Pour lire et ajouter les informations d'un étudiants
                string[] etudiants = new string[15]; // 15 éléments : NoID, Prenom, Nom, Code permanent....

                // Pour ajouter un item au ListView
                ListViewItem itm;

                // Pour calculer les moyennes

                float sommeIntra = 0;
                float sommeFinal = 0;
                float sommeTP1 = 0;
                float sommeTP2 = 0;
                float sommeGenerale = 0;

                for (; ; )
                {
                    if (br.PeekChar() == -1) break;
                    etudiants[0] = br.ReadString().Trim(); // NoID de l'étudiant
                    etudiants[1] = br.ReadString().Trim(); // Code Permanent
                    etudiants[2] = br.ReadString().Trim(); // Prenom
                    etudiants[3] = br.ReadString().Trim(); // nom
                    etudiants[4] = br.ReadChar().ToString(); // Sexe
                    etudiants[5] = br.ReadString(); // Date naissance
                    etudiants[6] = br.ReadString().Trim(); // Adresse
                    etudiants[7] = br.ReadString().Trim(); // Ville
                    etudiants[8] = br.ReadString(); // Code Postal
                    etudiants[9] = br.ReadString(); // Telephone
                    etudiants[10] = br.ReadSingle().ToString(); // Intra
                    etudiants[11] = br.ReadSingle().ToString(); // Final
                    etudiants[12] = br.ReadSingle().ToString(); // TP1
                    etudiants[13] = br.ReadSingle().ToString(); // TP2
                

                    // Calculer et afficher la moyenne de chaque étudiant
                    float moyEtu = 0;
                    moyEtu = (float.Parse(etudiants[10]) * 0.4f) +
                        (float.Parse(etudiants[11]) * 0.4f)  + 
                        (float.Parse(etudiants[12]) * 0.1f) + 
                        (float.Parse(etudiants[13]) * 0.1f);
                    etudiants[14] = moyEtu.ToString();

                    // Ajouter l'item au ListView
                    itm = new ListViewItem(etudiants); // Ajout des info de l'étudiant ci-dessus au ListViewItem
                    lvEtudiants.Items.Add(itm); // Ajout l'étudiant (item) au ListView


                    // Additionner les notes pour la moyenne du groupe
                    sommeIntra = sommeIntra + float.Parse(etudiants[10]);
                    sommeFinal = sommeFinal + float.Parse(etudiants[11]);
                    sommeTP1 = sommeTP1 + float.Parse(etudiants[12]);
                    sommeTP2 = sommeTP2 + float.Parse(etudiants[13]);
                    sommeGenerale = (sommeIntra * 0.4f) + (sommeFinal * 0.4f) + (sommeTP1 * 0.1f) + (sommeTP2 * 0.1f);

                }
                // Fermer les fichiers
                br.Close();
                fs.Close();

                // Calculer et afficher la moyenne de l'étudiant

                // Calculer et Afficher les moyennes du groupe
                txtMoyIntra.Text = (sommeIntra / (float)lvEtudiants.Items.Count).ToString("##.00") + " %";
                txtMoyFinal.Text = (sommeFinal / (float)lvEtudiants.Items.Count).ToString("##.00") + " %";
                txtMoyTP1.Text = (sommeTP1 / (float)lvEtudiants.Items.Count).ToString("##.00") + " %";
                txtMoyTP2.Text = (sommeTP2 / (float)lvEtudiants.Items.Count).ToString("##.00") + " %";
                txtMoyGenerale.Text = (sommeGenerale / (float)lvEtudiants.Items.Count).ToString("##.00") + " %";

                // Afficher le nombre d'étudiants
                txtNbrEtudiants.Text = lvEtudiants.Items.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        /// <summary>
        /// Procédure qui appelle la procédure AfficherEtudiants() pour l'option Afficher tous
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherEtudiants(object sender, EventArgs e)
        {
            AfficherEtudiants();
        }

        /// <summary>
        /// Procédure qui permet d'afficher seulement les résulats dans le ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherResultats(object sender, EventArgs e)
        {
            try
            {
                // Vider la liste
                lvEtudiants.Clear(); // Ou .Items pour juste les items

                // Faire les en-têtes des colonnes (additionner le total des largeurs de colonnes pour définir la largeur du listview
                lvEtudiants.Columns.Add("NoID", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Prénom", 180, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Nom", 180, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Intra", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Final", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("TP1", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("TP2", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Moyenne", 100, HorizontalAlignment.Center);


                // Ouvrir le fichier des étudiants
                FileStream fs = new FileStream(frmGestionEtudiants.NomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                BinaryReader br = new BinaryReader(fs);

                // Pour lire et ajouter les informations d'un étudiants
                string[] etudiants = new string[8]; // 8 éléments : NoID, Prenom, Nom, Intra, Final, TP1, TP2, Moyenne

                // Pour ajouter un item au ListView
                ListViewItem itm;

                for (; ; )
                {
                    if (br.PeekChar() == -1) break;
                    etudiants[0] = br.ReadString().Trim(); // NoID de l'étudiant
                    br.ReadString().Trim(); // Code Permanent
                    etudiants[1] = br.ReadString().Trim(); // Prenom
                    etudiants[2] = br.ReadString().Trim(); // nom
                    br.ReadChar().ToString(); // Sexe
                    br.ReadString(); // Date naissance
                    br.ReadString().Trim(); // Adresse
                    br.ReadString().Trim(); // Ville
                    br.ReadString(); // Code Postal
                    br.ReadString(); // Telephone
                    etudiants[3] = br.ReadSingle().ToString(); // Intra
                    etudiants[4] = br.ReadSingle().ToString(); // Final
                    etudiants[5] = br.ReadSingle().ToString(); // TP1
                    etudiants[6] = br.ReadSingle().ToString(); // TP2

                    // Calculer et afficher la moyenne de chaque étudiant
                    float moyEtu = 0;
                    moyEtu = (float.Parse(etudiants[3]) * 0.4f) +
                        (float.Parse(etudiants[4]) * 0.4f) +
                        (float.Parse(etudiants[5]) * 0.1f) +
                        (float.Parse(etudiants[6]) * 0.1f);
                    etudiants[7] = moyEtu.ToString();

                    // Ajouter l'item au ListView
                    itm = new ListViewItem(etudiants); // Ajout des info de l'étudiant ci-dessus au ListViewItem
                    lvEtudiants.Items.Add(itm); // Ajout l'étudiant (item) au ListView
                }
                // Fermer les fichiers
                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /// <summary>
        /// Procédure qui permet d'afficher seulement les coordonnées des étudiants au ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherCoordonnees(object sender, EventArgs e)
        {
            try
            {
                // Vider la liste
                lvEtudiants.Clear(); // Ou .Items pour juste les items

                // Faire les en-têtes des colonnes (additionner le total des largeurs de colonnes pour définir la largeur du listview
                lvEtudiants.Columns.Add("NoID", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Prénom", 180, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Nom", 180, HorizontalAlignment.Center); ;
                lvEtudiants.Columns.Add("Adresse", 220, HorizontalAlignment.Left);
                lvEtudiants.Columns.Add("Ville", 180, HorizontalAlignment.Left);
                lvEtudiants.Columns.Add("Code Postal", 100, HorizontalAlignment.Left);
                lvEtudiants.Columns.Add("Téléphone", 180, HorizontalAlignment.Center);

                // Ouvrir le fichier des étudiants
                FileStream fs = new FileStream(frmGestionEtudiants.NomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                BinaryReader br = new BinaryReader(fs);

                // Pour lire et ajouter les informations d'un étudiants
                string[] etudiants = new string[7]; // 7 éléments : NoID, Prenom, Nom, adresse, ville, code postal, telephone

                // Pour ajouter un item au ListView
                ListViewItem itm;

                for (; ; )
                {
                    if (br.PeekChar() == -1) break;
                    etudiants[0] = br.ReadString().Trim(); // NoID de l'étudiant
                    br.ReadString().Trim(); // Code Permanent
                    etudiants[1] = br.ReadString().Trim(); // Prenom
                    etudiants[2] = br.ReadString().Trim(); // nom
                    br.ReadChar().ToString(); // Sexe
                    br.ReadString(); // Date naissance
                    etudiants[3] = br.ReadString().Trim(); // Adresse
                    etudiants[4] = br.ReadString().Trim(); // Ville
                    etudiants[5] = br.ReadString(); // Code Postal
                    etudiants[6] = br.ReadString(); // Telephone
                    br.ReadSingle().ToString(); // Intra
                    br.ReadSingle().ToString(); // Final
                    br.ReadSingle().ToString(); // TP1
                    br.ReadSingle().ToString(); // TP2



                    // Ajouter l'item au ListView
                    itm = new ListViewItem(etudiants); // Ajout des info de l'étudiant ci-dessus au ListViewItem
                    lvEtudiants.Items.Add(itm); // Ajout l'étudiant (item) au ListView

                }
                // Fermer les fichiers
                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /// <summary>
        /// Procédure qui permet d'afficher seulement les édutiants de sexe féminin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherFeminin(object sender, EventArgs e)
        {
            try
            {
                // Vider la liste
                lvEtudiants.Clear(); // Ou .Items pour juste les items

                // Faire les en-têtes des colonnes (additionner le total des largeurs de colonnes pour définir la largeur du listview
                lvEtudiants.Columns.Add("NoID", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Code permanent", 150, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Prénom", 180, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Nom", 180, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Sexe", 50, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Date de naissance", 150, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Adresse", 220, HorizontalAlignment.Left);
                lvEtudiants.Columns.Add("Ville", 180, HorizontalAlignment.Left);
                lvEtudiants.Columns.Add("Code Postal", 100, HorizontalAlignment.Left);
                lvEtudiants.Columns.Add("Téléphone", 180, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Intra", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Final", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("TP1", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("TP2", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Moyenne", 100, HorizontalAlignment.Center);

                // Ouvrir le fichier des étudiants
                FileStream fs = new FileStream(frmGestionEtudiants.NomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                BinaryReader br = new BinaryReader(fs);

                // Pour lire et ajouter les informations d'un étudiants
                string[] etudiants = new string[15]; // 15 éléments : NoID, Prenom, Nom, Code permanent....

                // Pour ajouter un item au ListView
                ListViewItem itm;

                for (; ; )
                {
                    if (br.PeekChar() == -1) break;
                    etudiants[0] = br.ReadString().Trim(); // NoID de l'étudiant
                    etudiants[1] = br.ReadString().Trim(); // Code Permanent
                    etudiants[2] = br.ReadString().Trim(); // Prenom
                    etudiants[3] = br.ReadString().Trim(); // nom
                    etudiants[4] = br.ReadChar().ToString(); // Sexe
                    etudiants[5] = br.ReadString(); // Date naissance
                    etudiants[6] = br.ReadString().Trim(); // Adresse
                    etudiants[7] = br.ReadString().Trim(); // Ville
                    etudiants[8] = br.ReadString(); // Code Postal
                    etudiants[9] = br.ReadString(); // Telephone
                    etudiants[10] = br.ReadSingle().ToString(); // Intra
                    etudiants[11] = br.ReadSingle().ToString(); // Final
                    etudiants[12] = br.ReadSingle().ToString(); // TP1
                    etudiants[13] = br.ReadSingle().ToString(); // TP2

                    // Ajouter l'item au ListView
                    if (etudiants[4] == "F")
                    {
                        itm = new ListViewItem(etudiants); // Ajout des info de l'étudiant ci-dessus au ListViewItem
                        lvEtudiants.Items.Add(itm); // Ajout l'étudiant (item) au ListView
                    }

                }
                // Fermer les fichiers
                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /// <summary>
        /// Procédure qui permet d'afficher seulement les édutiants de sexe masculin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficherMasculin(object sender, EventArgs e)
        {
            try
            {
                // Vider la liste
                lvEtudiants.Clear(); // Ou .Items pour juste les items

                // Faire les en-têtes des colonnes (additionner le total des largeurs de colonnes pour définir la largeur du listview
                lvEtudiants.Columns.Add("NoID", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Code permanent", 150, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Prénom", 180, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Nom", 180, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Sexe", 50, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Date de naissance", 150, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Adresse", 220, HorizontalAlignment.Left);
                lvEtudiants.Columns.Add("Ville", 180, HorizontalAlignment.Left);
                lvEtudiants.Columns.Add("Code Postal", 100, HorizontalAlignment.Left);
                lvEtudiants.Columns.Add("Téléphone", 180, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Intra", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Final", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("TP1", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("TP2", 70, HorizontalAlignment.Center);
                lvEtudiants.Columns.Add("Moyenne", 100, HorizontalAlignment.Center);

                // Ouvrir le fichier des étudiants
                FileStream fs = new FileStream(frmGestionEtudiants.NomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                BinaryReader br = new BinaryReader(fs);

                // Pour lire et ajouter les informations d'un étudiants
                string[] etudiants = new string[15]; // 14 éléments : NoID, Prenom, Nom, Code permanent....

                // Pour ajouter un item au ListView
                ListViewItem itm;

                for (; ; )
                {
                    if (br.PeekChar() == -1) break;
                    etudiants[0] = br.ReadString().Trim(); // NoID de l'étudiant
                    etudiants[1] = br.ReadString().Trim(); // Code Permanent
                    etudiants[2] = br.ReadString().Trim(); // Prenom
                    etudiants[3] = br.ReadString().Trim(); // nom
                    etudiants[4] = br.ReadChar().ToString(); // Sexe
                    etudiants[5] = br.ReadString(); // Date naissance
                    etudiants[6] = br.ReadString().Trim(); // Adresse
                    etudiants[7] = br.ReadString().Trim(); // Ville
                    etudiants[8] = br.ReadString(); // Code Postal
                    etudiants[9] = br.ReadString(); // Telephone
                    etudiants[10] = br.ReadSingle().ToString(); // Intra
                    etudiants[11] = br.ReadSingle().ToString(); // Final
                    etudiants[12] = br.ReadSingle().ToString(); // TP1
                    etudiants[13] = br.ReadSingle().ToString(); // TP2

                    // Ajouter l'item au ListView
                    if (etudiants[4] == "M")
                    {
                        itm = new ListViewItem(etudiants); // Ajout des info de l'étudiant ci-dessus au ListViewItem
                        lvEtudiants.Items.Add(itm); // Ajout l'étudiant (item) au ListView
                    }

                }
                // Fermer les fichiers
                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /// <summary>
        /// Procédure qui permet de trier la colonne (ascendant ou descendant) sur laquelle clique l'utilisateur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvEtudiants_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            try
            {
                // Déterminer si la colonne cliquée a déjà été triée
                if (e.Column == lvwColumnSorter.SortColumn)
                {
                    // Inverser le tri pour cette colonne
                    if (lvwColumnSorter.Order == SortOrder.Ascending)
                    {
                        lvwColumnSorter.Order = SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorter.Order = SortOrder.Ascending;
                    }
                }
                else
                {
                    // Assigner le no de la colonne à trier, défaut: ascendant
                    lvwColumnSorter.SortColumn = e.Column;
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }

                // Trier avec les options spécifiées
                this.lvEtudiants.Sort();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        /// <summary>
        /// Procédure qui permet d'activer ou de mettre en focus le formulaire Gestion des étudiants.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdGestionForm_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier si la fenetre est déjà ouverte
                for (int i = 0; i < frmMDI.ActiveForm.MdiChildren.Length; i++)
                {
                    if (frmMDI.ActiveForm.MdiChildren[i].Text == "Gestion des étudiants")
                    {
                        // Le formulaire gestion est déjà ouvert
                        frmMDI.ActiveForm.MdiChildren[i].Activate();
                        return; // Pour sortir 
                    }
                }

                frmGestionEtudiants frm = new frmGestionEtudiants();
                frm.MdiParent = frmMDI.ActiveForm;
                frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
