/*
 * IDENTIFICATION
 * Titre: Programme de gestion des étudiants
 * 
 * Description: Ce programme permet à l'utilisateur d'inscrire un étudiant, 
 * modifier son inscription (Adresse, Ville, Code postal, Téléphone et Notes seulement)
 * et de supprimer une inscription. Le programme permet également la naviguation entre 
 * les inscriptions et la recherche d'inscription selon des critères de recherche spécifiques.
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
using System.IO; // pour les fichiers et répertoires
using System.Collections; // Pour les ArrayList

namespace P24_TP2_Petit_Moulin_2034406
{
    public partial class frmGestionEtudiants : Form
    {

        public frmGestionEtudiants()
        {
            InitializeComponent();  
        }

        int pos = -1; // Indique la position ou nous sommes dans le fichier
        public const int LongueurEnr = 194; // Longueur de l'enregistrement    
        int nbrEtudiants = 0; // Indique le nombre de membres contenu dans le fichier
        public const string NomFichier = "Eleves.dta"; // Indique le nom du fichier
        Action actionCourante = Action.Aucune; // indique l’action nous allons faire sur le fichier

        ArrayList tabNoID = new ArrayList();
        

        public enum Action
        {
            Inscrire,
            Modification,
            Aucune
        }
        
        /// <summary>
        /// Procedure au démarrage du formulaire qui détermine le nombre d'étudiants inscrits,
        /// affiche les en-têtes des colonnes de la recherche et récupère le premier étudiant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGestionEtudiants_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(NomFichier, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
                nbrEtudiants = (int)fs.Length / LongueurEnr;
                fs.Close();

                // Faire les en-têtes des colonnes du tableau des résultats de recherche
                lvResultats.Columns.Add("Code permanent", 100, HorizontalAlignment.Center);
                lvResultats.Columns.Add("Prénom", 120, HorizontalAlignment.Center);
                lvResultats.Columns.Add("Nom", 120, HorizontalAlignment.Center);

                if (nbrEtudiants > 0)
                {
                    Debarrer(groupNavigation, cmdModifierEtu, cmdSupprimerEtu);

                    pos = 0;
                    RecupererEtudiant(pos);
                }
                else
                {
                    Barrer(groupNavigation, cmdModifierEtu, cmdSupprimerEtu, groupRecherche);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        /// <summary>
        /// Procédure qui inscrit un étudiant dans le fichier NomFichier. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdInscrireEtu_Click(object sender, EventArgs e)
        {
            RemplirTabNoID();
            
            // BarrerDebarrer(true);
            ViderEcran();
            Barrer(cmdInscrireEtu, cmdModifierEtu, cmdSupprimerEtu, groupNavigation, groupRecherche, txtCodePermEtu, groupSexeEtu);
            Debarrer(groupInfoEtudiant, groupResultatsEtudiant, cmdOK, cmdAnnuler, txtPrenomEtu, txtNomEtu, groupSexeEtu, dtpDateNaissanceEtu);
            lblNoteSelectSexe.Visible = true;

            ViderRecherche();
            txtPrenomEtu.Focus();

            AjusterDate();

            // Afficher le texte de l'action en cours
            actionCourante = Action.Inscrire;
            lblMode.Text = "*** Mode Inscription ***";
        }

        /// <summary>
        /// Procédure qui ajuste le champ de la date à aujourd'hui moins 4 ans
        /// </summary>
        private void AjusterDate()
        {
            // Mettre la date à aujourd'hui moins 4 ans pour aider l'utilisateur à choisir la date plus rapidement
            DateTime dn = DateTime.Now;
            string dnFormat;
            dnFormat = dn.AddYears(-4).ToString();
            dtpDateNaissanceEtu.Text = dnFormat;
        }

        /// <summary>
        /// Procédure qui rempli le ArrayList des NoID
        /// </summary>
        private void RemplirTabNoID()
        {
            pos = 0;
            tabNoID.Clear();
            // Mettre les NoIDEtu dans tabNoID pour faire la validation
            for (int i = 0; i < nbrEtudiants; i++)
            {
                tabNoID.Add(RecupererEtudiant(pos));
                pos++;
            }
            pos--; // Revenir d'une position car pos++ dans le for juste avant.
        }

        /// <summary>
        /// Procédure qui débarre les contrôles désirés (boutons et autres)
        /// </summary>
        /// <param name="c"></param>
        private void Debarrer(params Control[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                c[i].Enabled = true;
            }
        }

        /// <summary>
        /// Procédure qui barre les contrôles désirés
        /// </summary>
        /// <param name="c"></param>
        private void Barrer(params Control[] c)
        {
            foreach (Control ctr in c)
            {
                ctr.Enabled = false;
            }
        }

        /// <summary>
        /// Procédure qui vide de son contenu les champs et remet à 0 les numerics.
        /// </summary>
        private void ViderEcran()
        {
            
            txtNoIDEtu.Clear();
            txtCodePermEtu.Clear();
            txtNomEtu.Clear();
            txtPrenomEtu.Clear();
            OptionFeminin.Checked = false;
            OptionMasculin.Checked = false;
            dtpDateNaissanceEtu.Value = DateTime.Now;
            txtAdresseEtu.Clear();
            txtVilleEtu.Clear();
            mskCodePostalEtu.Clear();
            mskTelephoneEtu.Clear();
            numNoteIntra.Value = 0;
            numNoteFinal.Value = 0;
            numNoteTP1.Value = 0;
            numNoteTP2.Value = 0;
        }

        /// <summary>
        /// Procédure qui permet de modifier le contenu des champs disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdModifierEtu_Click(object sender, EventArgs e) // Cliquer sur OK ou Annuler, pas sur Inscrire (générer erreur message si clique sur inscrire)
        {
            //BarrerDebarrer(true);
            Barrer(groupNavigation, cmdInscrireEtu, cmdSupprimerEtu, cmdModifierEtu, groupRecherche, txtCodePermEtu, txtNomEtu, txtPrenomEtu, groupSexeEtu, dtpDateNaissanceEtu);
            Debarrer(groupInfoEtudiant, groupResultatsEtudiant, cmdOK, cmdAnnuler);
            actionCourante = Action.Modification;

            txtAdresseEtu.Focus();
            lblMode.Text = "*** Mode modification ***";
        }

        /// <summary>
        /// Procédure qui demande à l'utilisateur une cnfirmation avant la suppression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSupprimerEtu_Click(object sender, EventArgs e)
        {
            //DialogResult rep; // Pour récupérer la réponse du user

            if (MessageBox.Show("Voulez-vous supprimer cet étudiant ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                SupprimerEtudiant();
            }
        }

        /// <summary>
        /// Procédure  qui permet de supprimer un étudiant du fichier NomFichier
        /// </summary>
        private void SupprimerEtudiant()
        {
            string nomFichierTemp = "Eleves.tmp";
            // Ouvrir 2 fichiers, le fichier source original et le fichier de destruction (corbeille)
            FileStream fsSource = new FileStream(NomFichier, FileMode.Open, FileAccess.Read, FileShare.None);
            BinaryReader br = new BinaryReader(fsSource);
            FileStream fsDest = new FileStream(nomFichierTemp, FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryWriter bw = new BinaryWriter(fsDest);

            // Boucle de lecture
            string NoIDEtu,
                CodePermanentEtu,
                PrenomEtu,
                NomEtu,
                DateNaissanceEtu,
                AdresseEtu,
                VilleEtu,
                CodePostalEtu,
                TelephoneEtu;
            char SexeEtu;
            float NoteIntra,
                NoteFinal,
                NoteTP1,
                NoteTP2;

            for (int i = 0; i < nbrEtudiants; i++)
            {
                NoIDEtu = br.ReadString();
                CodePermanentEtu = br.ReadString();
                PrenomEtu = br.ReadString();
                NomEtu = br.ReadString();
                SexeEtu = br.ReadChar();
                DateNaissanceEtu = br.ReadString();
                AdresseEtu = br.ReadString();
                VilleEtu = br.ReadString();
                CodePostalEtu = br.ReadString();
                TelephoneEtu = br.ReadString();
                NoteIntra = br.ReadSingle();
                NoteFinal = br.ReadSingle();
                NoteTP1 = br.ReadSingle();
                NoteTP2 = br.ReadSingle();

                // Tester si c'est celui qu'on ne veut pas supprimer
                if (NoIDEtu.Trim() != txtNoIDEtu.Text.Trim())
                {
                    // Transférer l'étudiant dans le fichier temporaire pour le conserver
                    bw.Write(NoIDEtu);
                    bw.Write(CodePermanentEtu);
                    bw.Write(PrenomEtu);
                    bw.Write(NomEtu);
                    bw.Write(SexeEtu);
                    bw.Write(DateNaissanceEtu);
                    bw.Write(AdresseEtu);
                    bw.Write(VilleEtu);
                    bw.Write(CodePostalEtu);
                    bw.Write(TelephoneEtu);
                    bw.Write(NoteIntra);
                    bw.Write(NoteFinal);
                    bw.Write(NoteTP1);
                    bw.Write(NoteTP2);
                }
            }
            // On ferme le fichier
            bw.Close();
            fsSource.Close();
            bw.Close();
            fsDest.Close();

            // On détruit le fichier source
            File.Delete(NomFichier);
            // Déplace le fichier destination en fichier source - Renommage
            File.Move(nomFichierTemp, NomFichier);

            // Confirmer la destruction
            nbrEtudiants--;
            MessageBox.Show("*** Étudiant " + txtPrenomEtu.Text.Trim() + " " + txtNomEtu.Text.Trim() + " a été supprimé avec succès. ***");

            if (nbrEtudiants > 0)
            {
                // Se positionner et récupérer le premier étudiant
                pos = 0;
                RecupererEtudiant(pos);
            }
            else
            {
                pos = -1;
                ViderEcran();
                Barrer(groupInfoEtudiant, groupNavigation, cmdOK, cmdAnnuler, cmdModifierEtu, cmdSupprimerEtu, groupRecherche);
                lblMode.Text = "";
            }
        }

        /// <summary>
        /// Procédure qui permet d'appeler les procédures d'inscription, de modification de l'enregistrement, de validation du code permanent et d'affectation du NoID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOK_Click(object sender, EventArgs e)
        {
            try
            {
                
                // Valider si l'écran est bien rempli
                if (ValiderEcran() == false)
                    return;
                // Valider le code permanent
                if (ValiderCP() == false)
                    return;
                // Si bien rempli, on ajoute l'info... mais c'est possible qu'on modifie les infos un jour...
                if (actionCourante == Action.Inscrire)
                {

                    //Attribuer le no unique pour chaque étudiant. 
                    GenererNoID();

                    InscrireOuModifierEtudiant();

                    lblValidationCP.Text = "";

                    MessageBox.Show("*** Étudiant inscrit avec succès ! ***", "Inscription");
                    nbrEtudiants++;
                    pos = nbrEtudiants - 1;
                    lblMode.Text = "*** Étudiant " + (pos + 1) + " de " + nbrEtudiants + " ***";
                }
                else
                {
                    //ModifierEtudiant();
                    InscrireOuModifierEtudiant();
                    MessageBox.Show("*** Étudiant modifié avec succès ! ***", "Modification");
                }
                cmdAnnuler.PerformClick(); // PerformClick simule le clic du bouton cmdAnnuler, si les infos ne sont pas valides.

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Procédure qui génère le numéro d'identification unique de l'étudiant
        /// </summary>
        private void GenererNoID()
        {

            try
            {
                string tempID = ""; // Pour stocker le NoID complet
                string tempIDNom = ""; // Pour stocker la partie du nom du NoID
                int nbrX; // Pour stocker le nombre de X à placer pour compléter le nom.

                // Pour les 3 premières lettre - compléter avec des X si moins de 3 lettres
                if (txtNomEtu.Text.Length < 3)
                {
                    nbrX = 3 - txtNomEtu.Text.Length; // Déterminer le nombre de X à mettre dans le Nom
                    tempID = txtNomEtu.Text.Substring(0, txtNomEtu.Text.Length).ToUpper(); // Stocker les 1 ou 2 lettres pour le nom 
                    for (int i = 0; i < nbrX; i++) // Boucler pour insérer les X dans la partie nom
                    {
                        tempIDNom = tempID + "X";
                        tempID = tempIDNom;
                    }
                }
                // Si le nom est plus de 2 lettres
                if (txtNomEtu.Text.Length >= 3) 
                {
                    tempIDNom = txtNomEtu.Text.Substring(0, 3).ToUpper(); // Si nom est OK, on assigne

                    if(txtNomEtu.Text.Substring(0, txtNomEtu.Text.Length).Contains("St-")) // Si le nom inscrit est exemple: St-Jacques, enlève le '-' 
                                                                                            // et remplace les 3 premiers caractères par "SAI".
                        tempIDNom = "SAI";

                    if(txtNomEtu.Text.Substring(1, 1).Contains("'")) // Si le nom est par exemple O'Donnell, on enlève l'apostrophe et réassigne le nom
                    {
                        tempID = txtNomEtu.Text.Substring(0, txtNomEtu.Text.Length).ToUpper();
                        tempID = tempID.Remove(1, 1);
                        tempIDNom = tempID.Substring(0, 3);
                    }
                }

                // Plus la première lettre du prénom
                tempID = tempIDNom + txtPrenomEtu.Text.Substring(0, 1).ToUpper();

                // Ajouter le caractère séquentiel
                char charSeq = (char)48; // ASCII : 0(48).... A(65)
                do
                {
                    // Vérifier si le no NoID existe déjà
                    if (tabNoID.Contains(tempID + charSeq.ToString()) == true)
                    {
                        if (charSeq == (char)57) // char 57 = 9
                        {
                            charSeq = (char)65; // char 65 = A
                        }
                        else charSeq++; // Si 0 est attribué, on incrémente à 1...
                        if (charSeq == (char)91) // char 91 = Z... On arrive au bout des possibilités pour le NoID, on informe l'utilisateur de supprimer un enregistrement.
                            MessageBox.Show("Impossible d'attribuer un numéro d'identification à l'étudiant. " +
                                "\n\n Veuillez supprimer un étudiant qui n'est plus inscrit à l'école.", "Action requise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNoIDEtu.Text = tempID + charSeq.ToString(); // On assigne si on n'est pas au bout
                    }
                    else // Si le NoID n'existe pas encore, on l'assigne
                    {
                        txtNoIDEtu.Text = tempID + charSeq.ToString();
                    }

                } while (tabNoID.Contains(tempID + charSeq.ToString()) == true); // On boucle tant que le NoID ainsi composé existe

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Fonction qui valide les entrées de chacun des champs du formulaire
        /// </summary>
        /// <returns>Vrai si le contenu de tous les champs est valide.</returns>
        private bool ValiderEcran()
        {
            err1.Clear(); // Efface les messages d'erreur
            bool valide = true;

            // Vérifier si chaque champ est OK
            if (txtCodePermEtu.Text.Trim() == "" || txtCodePermEtu.Text.Length != 12)
            {
                valide = false;
                err1.SetError(txtCodePermEtu, "Code permanent non valide");
                //MessageBox.Show("Vous devez compléter le code permanent.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (txtPrenomEtu.Text.Trim() == "")
            {
                valide = false;
                err1.SetError(txtPrenomEtu, "Prénom obligatoire");
            }
            if (txtNomEtu.Text.Trim() == "")
            {
                valide = false;
                err1.SetError(txtNomEtu, "Nom obligatoire");
            }

            if (OptionMasculin.Checked == false && OptionFeminin.Checked == false)
            {
                valide = false;
                err1.SetError(groupSexeEtu, "Sélection du sexe obligatoire");
            }
            if (txtAdresseEtu.Text.Trim() == "")
            {
                valide = false;
                err1.SetError(txtAdresseEtu, "Adresse obligatoire (no civique et rue");
            }
            if (txtVilleEtu.Text.Trim() == "")
            {
                valide = false;
                err1.SetError(txtVilleEtu, "Ville obligatoire");
            }
            if (mskCodePostalEtu.MaskFull == false)
            {
                valide = false;
                err1.SetError(mskCodePostalEtu, "Code postal obligatoire");
            }
            if (mskTelephoneEtu.MaskFull == false)
            {
                valide = false;
                err1.SetError(mskTelephoneEtu, "Téléphone obligatoire");
            }
            return valide;
        }

        /// <summary>
        /// Procédure qui permet d'annuler l'action en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            try
            {
                err1.Clear();
            
                actionCourante = Action.Aucune;
                lblMode.Text = "";
                lblValidationCP.Text = "";

                if (nbrEtudiants > 0)
                {
                    Barrer(cmdOK, cmdAnnuler, groupInfoEtudiant, groupResultatsEtudiant);
                    Debarrer(cmdInscrireEtu, cmdModifierEtu, groupNavigation, cmdSupprimerEtu, groupRecherche);
                    RecupererEtudiant(pos);
                }
                else
                {
                    ViderEcran();
                    Barrer(cmdOK, cmdAnnuler, cmdSupprimerEtu, cmdModifierEtu, groupNavigation, groupInfoEtudiant, groupResultatsEtudiant);
                    Debarrer(cmdInscrireEtu);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);             
            }    
        }

        /// <summary>
        /// Procédure qui permet d'inscrire un enregistrement au fichier des élèves .dta
        /// </summary>
        private void InscrireOuModifierEtudiant()
        {
            try
            {
                // ouvrir le FileStream
                FileStream fs;
                // 1.5 - Se positionner au bon endroit dans le fichier
                if (actionCourante == Action.Inscrire)
                {
                    fs = new FileStream(NomFichier, FileMode.Append, FileAccess.Write, FileShare.None);
                }
                else
                {
                    fs = new FileStream(NomFichier, FileMode.Open, FileAccess.Write, FileShare.None);
                    // Établir le bon positionnement
                    fs.Seek(pos * LongueurEnr, SeekOrigin.Begin);
                }
                BinaryWriter bw = new BinaryWriter(fs);

                DateTime dateNaiss;
                string NoIDEtu,
                    CodePermEtu,
                    PrenomEtu,
                    NomEtu,
                    DateNaissanceEtu,
                    AdresseEtu,
                    VilleEtu,
                    CodePostalEtu,
                    TelephoneEtu;
                char SexeEtu;
                float NoteIntra,
                    NoteFinal,
                    NoteTP1,
                    NoteTP2;

                
                NoIDEtu = txtNoIDEtu.Text.PadRight(5); // 6 octets
                if (actionCourante == Action.Inscrire)
                    tabNoID.Add(NoIDEtu);
                CodePermEtu = txtCodePermEtu.Text.PadRight(12); // 13 octets : total 19 octets
                PrenomEtu = txtPrenomEtu.Text.PadRight(30); // 31 octets : 50 octets
                NomEtu = txtNomEtu.Text.PadRight(30); // 31 octets : 81 octets
                if (OptionFeminin.Checked == true)
                    SexeEtu = 'F';
                else 
                    SexeEtu = 'M'; // 1 octet : 82 octets
                dateNaiss = dtpDateNaissanceEtu.Value;
                DateNaissanceEtu = dateNaiss.ToShortDateString(); // 11 octets : 93 octets
                AdresseEtu = txtAdresseEtu.Text.PadRight(30); // 31 octets : 124 octets
                VilleEtu = txtVilleEtu.Text.PadRight(30); // 31 octets : 155 octets
                CodePostalEtu = mskCodePostalEtu.Text; // 8 octets : 163 octets
                TelephoneEtu = mskTelephoneEtu.Text; // 15 octets : 178 octets
                NoteIntra = (float)numNoteIntra.Value; // 4 oct 
                NoteFinal = (float)numNoteFinal.Value; // 4 oct
                NoteTP1 = (float)numNoteTP1.Value; // 4 oct
                NoteTP2 = (float)numNoteTP2.Value; // 4 oct : 194 octets

                // On écrit dans le fichier
                bw.Write(NoIDEtu);
                bw.Write(CodePermEtu);
                bw.Write(PrenomEtu);
                bw.Write(NomEtu);
                bw.Write(SexeEtu);
                bw.Write(DateNaissanceEtu);
                bw.Write(AdresseEtu);
                bw.Write(VilleEtu);
                bw.Write(CodePostalEtu);
                bw.Write(TelephoneEtu);
                bw.Write(NoteIntra);
                bw.Write(NoteFinal);
                bw.Write(NoteTP1);
                bw.Write(NoteTP2);

                // On ferme le fichier
                bw.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Procédure qui affiche les informations du premier étudiant inscrit au fichier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPremier_Click(object sender, EventArgs e)
        {
            pos = 0;
            RecupererEtudiant(pos);
        }

        /// <summary>
        /// Procédure qui affiche les informations de l'étudiant précédent celui qui est présentement affiché
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPrecedent_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos--;
                RecupererEtudiant(pos);
            }
        }

        /// <summary>
        /// Procédure qui affiche les informations de l'étudiant suivant celui qui est présentement affiché
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSuivant_Click(object sender, EventArgs e)
        {
            if (pos < nbrEtudiants - 1)
            {
                pos++;
                RecupererEtudiant(pos);
            }
        }

        /// <summary>
        /// Procédure qui affiche les informations du dernier étudiant inscrit au fichier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDernier_Click(object sender, EventArgs e)
        {
            pos = nbrEtudiants - 1;
            RecupererEtudiant(pos);
        }
        
        /// <summary>
        /// Fonction qui récupère les informations d'un étudiant selon la position spécifiée en paramètre.
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Le NoID de l'étudiant</returns>
        private string RecupererEtudiant(int p)
        {
            try
            {
                FileStream fs = new FileStream(NomFichier, FileMode.Open, FileAccess.Read, FileShare.None);
                BinaryReader br = new BinaryReader(fs);
                fs.Seek(p * LongueurEnr, SeekOrigin.Begin); // On se positionne sur le bon étudiant

                txtNoIDEtu.Text = br.ReadString();
                txtCodePermEtu.Text = br.ReadString();
                txtPrenomEtu.Text = br.ReadString().Trim(); // Trim() permet d'enlever les espaces avant et après
                txtNomEtu.Text = br.ReadString().Trim();
                char sexe;
                sexe = br.ReadChar();
                if (sexe == 'F')
                    OptionFeminin.Checked = true;
                else 
                    OptionMasculin.Checked = true;
                dtpDateNaissanceEtu.Text = br.ReadString();
                txtAdresseEtu.Text = br.ReadString().Trim(); 
                txtVilleEtu.Text = br.ReadString().Trim();
                mskCodePostalEtu.Text = br.ReadString();
                mskTelephoneEtu.Text = br.ReadString();
                numNoteIntra.Value = (decimal)br.ReadSingle(); 
                numNoteFinal.Value = (decimal)br.ReadSingle(); 
                numNoteTP1.Value = (decimal)br.ReadSingle(); 
                numNoteTP2.Value = (decimal)br.ReadSingle(); 

                br.Close();
                fs.Close();
                lblMode.Text = "*** Étudiant " + (p + 1).ToString() + " de "+ nbrEtudiants.ToString() + " ***";
                lblNoteSelectSexe.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return txtNoIDEtu.Text;
        }

        /// <summary>
        /// Procédure qui valide chaque caractère entré dans le champ (pour le prénom, le nom et la ville)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Touche du clavier qui est appuyée</param>
        private void ValiderChaine(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == ' ' || e.KeyChar == '-' || char.IsLetter(e.KeyChar) == true || e.KeyChar == (char)39 || e.KeyChar == (char)8)
            {
                return;
            }
            else
            {
                // On ne veut pas le caractère
                e.Handled = true;
                e.KeyChar = ('\0');
            }
        }

        /// <summary>
        /// Procédure qui valide chaque caractère saisi dans le champ (pour adresse)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Touche du clavier qui est appuyée</param>
        private void ValiderChaineAdresse(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ' || e.KeyChar == '-' || char.IsLetterOrDigit(e.KeyChar) == true || e.KeyChar == (char)8 || e.KeyChar == (char)39 || e.KeyChar == '.')
            {
                return;
            }
            else
            {
                // On ne veut pas le caractère
                e.Handled = true;
                e.KeyChar = ('\0');
            }
        }

        /// <summary>
        /// Procédure qui génère automatiquement la première partie du code permanent associée au nom, prénom et à la date de naissance. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenererCodePerm(object sender, EventArgs e)
        {
            GenererCodePerm();
        }

        /// <summary>
        /// Procédure qui génère automatiquement la première partie du code permanent associée au nom, prénom et à la date de naissance. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenererCodePerm()
        {
            try
            {
                // Mettre la date en format court : AAAA-MM-JJ
                string dnFormat;
                DateTime dateN = dtpDateNaissanceEtu.Value;
                dnFormat = dateN.ToShortDateString();

                int nbrX;
                string tempCP = "";
                string tempCPNom = "";

                // Vider le champ du code
                txtCodePermEtu.Clear();
                // ReadOnly à false, pour pouvoir le modifier
                txtCodePermEtu.ReadOnly = false;

                // Valider le prénom et le nom avant de les utiliser pour composer le code permanent
                if (ValiderPrenomNom() == false)
                    return;

                // Pour les 3 premières lettre - compléter avec des X si moins de 3 lettres
                if (txtNomEtu.Text.Length < 3)
                {
                    nbrX = 3 - txtNomEtu.Text.Length;
                    tempCP = txtNomEtu.Text.Substring(0, txtNomEtu.Text.Length);
                    for (int i = 0; i < nbrX; i++)
                    {
                        tempCPNom = tempCP + "X";
                        tempCP = tempCPNom;
                    }
                }
                // Si le nom est de 3 lettres et plus...
                if (txtNomEtu.Text.Length >= 3)
                {
                    tempCPNom = txtNomEtu.Text.Substring(0, 3).ToUpper(); // Si nom OK et plus de 2 lettres

                    if (txtNomEtu.Text.Substring(0, 3).Contains("St-")) // Si le nom inscrit est exemple: St-Jacques, enlève le '-' et remplace les caractères t et - par a et i.
                    {
                        tempCPNom = "SAI";
                    }
                    if (txtNomEtu.Text.Substring(1, 1).Contains("'")) // Si le nom inscrit est exemple: O'Donnell, on elève le "'"
                    {
                        tempCP = txtNomEtu.Text.Substring(0, txtNomEtu.Text.Length).ToUpper();
                        tempCP = tempCP.Remove(1, 1);
                        tempCPNom = tempCP.Substring(0, 3);
                    }
                    // Autres exceptions à gérer ??? ==============================================================
                }

                // Plus la première lettre du prénom
                tempCP = tempCPNom.ToUpper() + txtPrenomEtu.Text.Substring(0, 1).ToUpper();

                // Additionner les chiffres à la date de naissance selon les normes du gouvernement
                if (int.Parse(dnFormat.Substring(0, 4)) > 1999)
                {
                    if (OptionFeminin.Checked == true)
                        txtCodePermEtu.Text = tempCP
                       + (int.Parse(dnFormat.Substring(8, 2)) + 62).ToString()
                       + (int.Parse(dnFormat.Substring(5, 2)) + 50).ToString()
                       + dnFormat.Substring(2, 2);
                    else
                        txtCodePermEtu.Text = (tempCP + (int.Parse(dnFormat.Substring(8, 2)) + 62)
                        + dnFormat.Substring(5, 2)
                        + dnFormat.Substring(2, 2)).ToString();
                }
                else if (OptionFeminin.Checked == true)
                    txtCodePermEtu.Text = tempCP
                        + dnFormat.Substring(8, 2)
                        + (int.Parse(dnFormat.Substring(5, 2)) + 50).ToString()
                        + dnFormat.Substring(2, 2);
                else txtCodePermEtu.Text = (tempCP + dnFormat.Substring(8, 2)
                        + dnFormat.Substring(5, 2) + dnFormat.Substring(2, 2)).ToString();

                Debarrer(txtCodePermEtu);

                if (txtCodePermEtu.Enabled == true)
                    lblValidationCP.Text = "Entrez les 2 caractères uniques."; // S'affiche s'il manque les 2 caractères qui rendent le code unique.

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            return ;
        }
        /// <summary>
        /// Fonction qui permet de valider si le champ n'est pas vide et s'il ne commence pas par un caractère spécial.
        /// </summary>
        /// <returns>Vrai si le contenu du champ est valide. Faux si invalide</returns>
        private bool ValiderPrenomNom()
        {
            
            bool valide = true;
            err1.Clear();
            // PRENOM ============================
            if (txtPrenomEtu.Text == "" ||
                    txtPrenomEtu.Text.StartsWith(" ") == true ||
                    txtPrenomEtu.Text.StartsWith("-") == true ||
                    txtPrenomEtu.Text.StartsWith("'") == true)
            {
                // Pour s'assurer que le code permanent sera généré le programme
                OptionFeminin.Checked = false;
                OptionMasculin.Checked = false;
                    
                MessageBox.Show("Le premier caractère du PRÉNOM entré est invalide. \r\n" +
                    "Vous devez entrer au moins une lettre pour le prénom. \r\n" +
                    "AUCUN ACCENT.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                valide = false;
                txtPrenomEtu.Focus();
            }

            // NOM ===============================
            if (txtNomEtu.Text == "" ||
                txtNomEtu.Text.StartsWith(" ") == true ||
                txtNomEtu.Text.StartsWith("-") == true ||
                txtNomEtu.Text.StartsWith("'") == true)
            {
                OptionFeminin.Checked = false;
                OptionMasculin.Checked = false;

                MessageBox.Show("Le premier caractère du NOM entré est invalide. \r\n " +
                    "Vous devez entrer au moins une lettre pour le nom. \r\n" +
                    "AUCUN ACCENT.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                valide = false;
                txtNomEtu.Focus();
            }
            return valide;
        }

        /// <summary>
        /// Fonction qui permet de valider le code permanent avant de l'inscrire au fichier
        /// </summary>
        /// <returns>VRAI si le code est valide et unique</returns>
        private bool ValiderCP()
        {
            bool valide = true;
            try
            {
                if(actionCourante == Action.Inscrire)
                {
                    string AvaliderCP = txtCodePermEtu.Text;
                    ArrayList tabCP = new ArrayList();
                    pos = 0; // Retourne au début du fichier pour pouvoir récupérer le code permanent de tous les étudiants inscrits.
                    string tempCP = txtCodePermEtu.Text;

                    // Mettre les code perm dans tabCP pour faire la validation et la comparaison
                    for (int i = 0; i < nbrEtudiants; i++)
                    {
                        tabCP.Add(RecupererEtudiantCP(pos));
                        pos++;

                        // Aussitôt que la boucle détecte le même CP que celui saisit,
                        // on enlève les 2 caractères uniques et retourne sur le champ de CP pour refaire la saisie.
                        if (tabCP.Contains(AvaliderCP) == true)
                        {
                            MessageBox.Show("Le code permanent est déjà attribué à un autre étudiant. Vérifier la date de naissance, le sexe de l'étudiant ou les 2 derniers caractères du code.", "Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCodePermEtu.Text = tempCP.Remove(10, 2);
                            txtCodePermEtu.ReadOnly = false;
                            valide = false;
                            pos = 0;
                            break;
                        }
                        else
                        {
                            // Si le CP est unique, on assigne
                            txtCodePermEtu.Text = tempCP; 
                            valide = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return valide;
        }

        /// <summary>
        /// Procédure qui permet de rechercher et d'afficher dans la liste ce qui est saisit dans le champ de recherche.
        /// </summary>
        /// <param name="p"></param>
        private void Rechercher(int p)
        {
            try
            {
                // Vider la liste
                lvResultats.Clear(); // Ou .Items pour juste les items

                // Faire les en-têtes des colonnes du tableau des résultats de recherche
                lvResultats.Columns.Add("Code permanent", 100, HorizontalAlignment.Center);
                lvResultats.Columns.Add("Prénom", 120, HorizontalAlignment.Center);
                lvResultats.Columns.Add("Nom", 120, HorizontalAlignment.Center);

                FileStream fs = new FileStream(NomFichier, FileMode.Open, FileAccess.Read, FileShare.None);
                BinaryReader br = new BinaryReader(fs);
                //fs.Seek(p * LongueurEnr, SeekOrigin.Begin); // On se positionne sur le bon membre

                string[] resultats = new string[3]; // Pour stocker les 3 éléments: Code Perm, Nom, Prénom

                // Pour ajouter un item au ListView
                ListViewItem itm;

                p = 0;
                for (; ; )
                {
                    if (br.PeekChar() == -1) break;
                    br.ReadString().Trim(); // NoID de l'étudiant
                    resultats[0] = br.ReadString().Trim().ToUpper(); // Code Permanent
                    resultats[1] = br.ReadString().Trim().ToUpper(); // Prenom
                    resultats[2] = br.ReadString().Trim().ToUpper(); // nom
                    br.ReadChar().ToString(); // Sexe
                    br.ReadString(); // Date naissance
                    br.ReadString().Trim(); // Adresse
                    br.ReadString().Trim(); // Ville
                    br.ReadString(); // Code Postal
                    br.ReadString(); // Telephone
                    br.ReadSingle().ToString(); // Intra
                    br.ReadSingle().ToString(); // Final
                    br.ReadSingle().ToString(); // TP1
                    br.ReadSingle().ToString(); // TP2

                    // Recherche par code permanent
                    if(optParCodePerm.Checked == true)
                    {
                        if (txtRecherche.Text == "")
                        {
                            ViderRecherche();
                        }
                        
                        else if (resultats[0].Contains(txtRecherche.Text.ToUpper()))
                        {
                            // Ajouter l'item au ListView
                            itm = new ListViewItem(resultats); // Ajout des info de l'étudiant ci-dessus au ListViewItem
                            lvResultats.Items.Add(itm); // Ajout l'étudiant (item) au ListView
                            lblQteResultat.Text = lvResultats.Items.Count.ToString(); // Afficher le nombre d'étudiants correspondant à la requête

                        }
                    }

                    //Recherche par Prénom
                    if (optParPrenom.Checked == true)
                    {
                        
                        if (txtRecherche.Text == "")
                        {
                            ViderRecherche();
                        }

                        else if (resultats[1].Contains(txtRecherche.Text.ToUpper()))
                        {
                            // Ajouter l'item au ListView
                            itm = new ListViewItem(resultats); // Ajout des info de l'étudiant ci-dessus au ListViewItem
                            lvResultats.Items.Add(itm); // Ajout l'étudiant (item) au ListView
                            lblQteResultat.Text = lvResultats.Items.Count.ToString(); // Afficher le nombre d'étudiants correspondant à la requête

                        }
                    }

                    //Recherche par Nom
                    if (optParNom.Checked == true)
                    {
                        if (txtRecherche.Text == "")
                        {
                            ViderRecherche();
                        }

                        else if (resultats[2].Contains(txtRecherche.Text.ToUpper()))
                        {
                            // Ajouter l'item au ListView
                            itm = new ListViewItem(resultats); // Ajout des info de l'étudiant ci-dessus au ListViewItem
                            lvResultats.Items.Add(itm); // Ajout l'étudiant (item) au ListView
                            lblQteResultat.Text = lvResultats.Items.Count.ToString(); // Afficher le nombre d'étudiants correspondant à la requête
                        }
                    }
                }
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Procédure qui permet de vider le champ de recherche et la liste
        /// </summary>
        private void ViderRecherche()
        {
            txtRecherche.Clear();
            lvResultats.Items.Clear();
            lblQteResultat.Text = "0";
        }

        /// <summary>
        /// Procédure qui permet de vider le champ de recherche et la liste quand on change de filtre de recherche.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViderRecherche(object sender, EventArgs e)
        {
            ViderRecherche();  
        }

        /// <summary>
        /// Procédure qui permet de relancer la procédure Rechercher() à chaque fois que le texte saisit dans le champ de recherche change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            Rechercher(pos);
        }

        /// <summary>
        /// Procédure qui permet de récupérer  l'enregistrement de l'étudiant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdRechSelectEtu_Click(object sender, EventArgs e)
        {
            try
            {
                pos = 0;
                ArrayList cp = new ArrayList();
            
                // Mettre les Code permanent dans cp pour faire la comparaison avec l'item sélectionné dans la liste
                for (int i = 0; i < nbrEtudiants; i++)
                {
                    cp.Add(RecupererEtudiantCP(pos));
                    pos++;
                }
                // Assigner la sélection à txtCP pour la comparaison
                string txtCP = lvResultats.SelectedItems[0].Text;

                pos = 0; // Partir du premier étudiant
                // Comparer le code perm de l'item sélectionné avec les codes perm stockés dans l'ArrayList CP 
                for (int i = 0; i < nbrEtudiants; i++)
                {
                    if (cp[i].ToString().Contains(txtCP)) // Si le code perm est trouvé, on récupère l'étudiant et l'affiche.
                    {
                        RecupererEtudiant(pos);
                        pos = 0;
                        break;
                    }
                    pos++; // Pour revenir sur l'étudiant en cours
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Fonction qui permet de récupérer l'enregistrement d'un étudiant
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Le code permanent de l'étudiant récupéré</returns>
        private string RecupererEtudiantCP(int p)
        {
            try
            {
                FileStream fs = new FileStream(NomFichier, FileMode.Open, FileAccess.Read, FileShare.None);
                BinaryReader br = new BinaryReader(fs);
                fs.Seek(p * LongueurEnr, SeekOrigin.Begin); // On se positionne sur le bon étudiant

                br.ReadString();
                txtCodePermEtu.Text = br.ReadString().Trim();
                br.ReadString().Trim(); // Trim() permet d'enlever les espaces avant et après
                br.ReadString().Trim();
                br.ReadChar();
                br.ReadString();
                br.ReadString().Trim();
                br.ReadString().Trim();
                br.ReadString();
                br.ReadString();
                br.ReadSingle();
                br.ReadSingle();
                br.ReadSingle();
                br.ReadSingle();

                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return txtCodePermEtu.Text.ToUpper();
        }

        /// <summary>
        /// Procédure qui demande à l'utilisateur de vérifier si la partie généré et la partie saisit manuellement du code permanent sont bonnes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCodePermEtu_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCodePermEtu.Text.Length == 12)
            {
                err1.Clear();
                DialogResult rep;
                rep = MessageBox.Show("Êtes-vous certain que les 2 derniers caractères du code permanent sont bons?", "Vérification",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si c'est bon, on gèle le champ en ReadOnly
                if (rep == DialogResult.Yes)
                {
                    // Si l'utilisateur a entré le Code perm manuellement, on le regénère et ajoute les 2 caractères uniques saisis pour être sûr.
                    string deuxDernCharCP = txtCodePermEtu.Text.Substring(10, 2);
                    GenererCodePerm();
                    txtCodePermEtu.Text = txtCodePermEtu.Text + deuxDernCharCP.ToUpper();
                    txtCodePermEtu.ReadOnly = true;
                    lblValidationCP.Text = "";
                    txtAdresseEtu.Focus();
                }
                // Si c'est pas bon, on regénère le code
                else if(rep == DialogResult.No)
                {
                    txtCodePermEtu.ReadOnly = false;
                    GenererCodePerm();
                    //txtCodePermEtu.Text = txtCodePermEtu.Text.Remove(10, 2);
                }
            }
        }

        /// <summary>
        /// Procédure qui permet d'avertir l'utilisateur de resélectionner le sexe de l'étudiant s'il a modifié la date de naissance 
        /// après avoir déjà sélectionné le sexe une première fois.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpDateNaissanceEtu_ValueChanged(object sender, EventArgs e)
        {
            if(actionCourante == Action.Inscrire && (OptionFeminin.Checked == true || OptionMasculin.Checked == true))
            {
                txtCodePermEtu.Clear();
                OptionFeminin.Checked = false;
                OptionMasculin.Checked = false;
                MessageBox.Show("Veuillez vérifier la date de naissance et resélectionner le sexe de l'étudiant pour regénérer son code permanent.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        /// <summary>
        /// Procédure qui permet d'ouvrir ou de mettre en focus le formulaire Liste des étudiants
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdListeForm_Click(object sender, EventArgs e)
        {
            // Vérifier si la fenetre est déjà ouverte
            for (int i = 0; i < frmMDI.ActiveForm.MdiChildren.Length; i++)
            {
                if (frmMDI.ActiveForm.MdiChildren[i].Text == "Liste des étudiants")
                {
                    // Le formulaire gestion est déjà ouvert
                    frmMDI.ActiveForm.MdiChildren[i].Activate();
                    return; // Pour sortir 
                }
            }

            frmListe frm = new frmListe();
            frm.MdiParent = frmMDI.ActiveForm;
            frm.Show();
        }

        /// <summary>
        /// Procédure qui permet d'éviter d'effacer la partie générée du code permanent.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCodePermEtu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtCodePermEtu.Text.Length >= 10)
            {
                if (char.IsLetterOrDigit(e.KeyChar) == true)
                {
                    return;
                }
                else
                {
                    // On ne veut pas le caractère
                    e.Handled = true;
                    e.KeyChar = ('\0');
                }
            }
        }
    }
}
