
namespace P24_TP2_Petit_Moulin_2034406
{
    partial class frmGestionEtudiants
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
            this.groupInfoEtudiant = new System.Windows.Forms.GroupBox();
            this.lblNoteSelectSexe = new System.Windows.Forms.Label();
            this.lblValidationCP = new System.Windows.Forms.Label();
            this.txtCodePermEtu = new System.Windows.Forms.TextBox();
            this.txtNoIDEtu = new System.Windows.Forms.TextBox();
            this.mskCodePostalEtu = new System.Windows.Forms.MaskedTextBox();
            this.dtpDateNaissanceEtu = new System.Windows.Forms.DateTimePicker();
            this.mskTelephoneEtu = new System.Windows.Forms.MaskedTextBox();
            this.txtVilleEtu = new System.Windows.Forms.TextBox();
            this.txtAdresseEtu = new System.Windows.Forms.TextBox();
            this.txtNomEtu = new System.Windows.Forms.TextBox();
            this.txtPrenomEtu = new System.Windows.Forms.TextBox();
            this.lblDateNaissanceEtu = new System.Windows.Forms.Label();
            this.lblTelephoneEtu = new System.Windows.Forms.Label();
            this.lblCodePostalEtu = new System.Windows.Forms.Label();
            this.lblVilleEtu = new System.Windows.Forms.Label();
            this.lblAdresseEtu = new System.Windows.Forms.Label();
            this.groupSexeEtu = new System.Windows.Forms.GroupBox();
            this.OptionFeminin = new System.Windows.Forms.RadioButton();
            this.OptionMasculin = new System.Windows.Forms.RadioButton();
            this.lblCodePermanent = new System.Windows.Forms.Label();
            this.lblNomEtu = new System.Windows.Forms.Label();
            this.lblPrenomEtu = new System.Windows.Forms.Label();
            this.lblNoIdentificationEtu = new System.Windows.Forms.Label();
            this.groupResultatsEtudiant = new System.Windows.Forms.GroupBox();
            this.numNoteTP2 = new System.Windows.Forms.NumericUpDown();
            this.numNoteTP1 = new System.Windows.Forms.NumericUpDown();
            this.numNoteFinal = new System.Windows.Forms.NumericUpDown();
            this.numNoteIntra = new System.Windows.Forms.NumericUpDown();
            this.lblNoteTP2 = new System.Windows.Forms.Label();
            this.lblNoteTP1 = new System.Windows.Forms.Label();
            this.lblNoteFinal = new System.Windows.Forms.Label();
            this.lblNoteIntra = new System.Windows.Forms.Label();
            this.cmdInscrireEtu = new System.Windows.Forms.Button();
            this.cmdModifierEtu = new System.Windows.Forms.Button();
            this.cmdSupprimerEtu = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.groupNavigation = new System.Windows.Forms.GroupBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.cmdDernier = new System.Windows.Forms.Button();
            this.cmdSuivant = new System.Windows.Forms.Button();
            this.cmdPrecedent = new System.Windows.Forms.Button();
            this.cmdPremier = new System.Windows.Forms.Button();
            this.err1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.groupRecherche = new System.Windows.Forms.GroupBox();
            this.lblNoteDClick = new System.Windows.Forms.Label();
            this.cmdRechSelectEtu = new System.Windows.Forms.Button();
            this.lvResultats = new System.Windows.Forms.ListView();
            this.lblQteResultat = new System.Windows.Forms.Label();
            this.lblNbrResultats = new System.Windows.Forms.Label();
            this.groupFiltres = new System.Windows.Forms.GroupBox();
            this.optParCodePerm = new System.Windows.Forms.RadioButton();
            this.optParNom = new System.Windows.Forms.RadioButton();
            this.optParPrenom = new System.Windows.Forms.RadioButton();
            this.cmdListeForm = new System.Windows.Forms.Button();
            this.groupInfoEtudiant.SuspendLayout();
            this.groupSexeEtu.SuspendLayout();
            this.groupResultatsEtudiant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNoteTP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoteTP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoteFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoteIntra)).BeginInit();
            this.groupNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            this.groupRecherche.SuspendLayout();
            this.groupFiltres.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInfoEtudiant
            // 
            this.groupInfoEtudiant.Controls.Add(this.lblNoteSelectSexe);
            this.groupInfoEtudiant.Controls.Add(this.lblValidationCP);
            this.groupInfoEtudiant.Controls.Add(this.txtCodePermEtu);
            this.groupInfoEtudiant.Controls.Add(this.txtNoIDEtu);
            this.groupInfoEtudiant.Controls.Add(this.mskCodePostalEtu);
            this.groupInfoEtudiant.Controls.Add(this.dtpDateNaissanceEtu);
            this.groupInfoEtudiant.Controls.Add(this.mskTelephoneEtu);
            this.groupInfoEtudiant.Controls.Add(this.txtVilleEtu);
            this.groupInfoEtudiant.Controls.Add(this.txtAdresseEtu);
            this.groupInfoEtudiant.Controls.Add(this.txtNomEtu);
            this.groupInfoEtudiant.Controls.Add(this.txtPrenomEtu);
            this.groupInfoEtudiant.Controls.Add(this.lblDateNaissanceEtu);
            this.groupInfoEtudiant.Controls.Add(this.lblTelephoneEtu);
            this.groupInfoEtudiant.Controls.Add(this.lblCodePostalEtu);
            this.groupInfoEtudiant.Controls.Add(this.lblVilleEtu);
            this.groupInfoEtudiant.Controls.Add(this.lblAdresseEtu);
            this.groupInfoEtudiant.Controls.Add(this.groupSexeEtu);
            this.groupInfoEtudiant.Controls.Add(this.lblCodePermanent);
            this.groupInfoEtudiant.Controls.Add(this.lblNomEtu);
            this.groupInfoEtudiant.Controls.Add(this.lblPrenomEtu);
            this.groupInfoEtudiant.Controls.Add(this.lblNoIdentificationEtu);
            this.groupInfoEtudiant.Enabled = false;
            this.groupInfoEtudiant.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInfoEtudiant.Location = new System.Drawing.Point(12, 12);
            this.groupInfoEtudiant.Name = "groupInfoEtudiant";
            this.groupInfoEtudiant.Size = new System.Drawing.Size(576, 495);
            this.groupInfoEtudiant.TabIndex = 0;
            this.groupInfoEtudiant.TabStop = false;
            this.groupInfoEtudiant.Text = "Étudiant";
            // 
            // lblNoteSelectSexe
            // 
            this.lblNoteSelectSexe.AutoSize = true;
            this.lblNoteSelectSexe.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoteSelectSexe.Location = new System.Drawing.Point(216, 219);
            this.lblNoteSelectSexe.Name = "lblNoteSelectSexe";
            this.lblNoteSelectSexe.Size = new System.Drawing.Size(323, 15);
            this.lblNoteSelectSexe.TabIndex = 26;
            this.lblNoteSelectSexe.Text = "Sélectionnez le sexe après avoir modifié la date de naissance.";
            // 
            // lblValidationCP
            // 
            this.lblValidationCP.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidationCP.Location = new System.Drawing.Point(378, 289);
            this.lblValidationCP.Name = "lblValidationCP";
            this.lblValidationCP.Size = new System.Drawing.Size(192, 28);
            this.lblValidationCP.TabIndex = 25;
            // 
            // txtCodePermEtu
            // 
            this.txtCodePermEtu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodePermEtu.Location = new System.Drawing.Point(216, 289);
            this.txtCodePermEtu.MaxLength = 12;
            this.txtCodePermEtu.Name = "txtCodePermEtu";
            this.txtCodePermEtu.Size = new System.Drawing.Size(155, 29);
            this.txtCodePermEtu.TabIndex = 5;
            this.txtCodePermEtu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodePermEtu_KeyPress);
            this.txtCodePermEtu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodePermEtu_KeyUp);
            // 
            // txtNoIDEtu
            // 
            this.txtNoIDEtu.Enabled = false;
            this.txtNoIDEtu.Location = new System.Drawing.Point(216, 43);
            this.txtNoIDEtu.MaxLength = 5;
            this.txtNoIDEtu.Name = "txtNoIDEtu";
            this.txtNoIDEtu.Size = new System.Drawing.Size(115, 29);
            this.txtNoIDEtu.TabIndex = 24;
            // 
            // mskCodePostalEtu
            // 
            this.mskCodePostalEtu.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mskCodePostalEtu.Location = new System.Drawing.Point(216, 401);
            this.mskCodePostalEtu.Mask = ">L0L 0L0";
            this.mskCodePostalEtu.Name = "mskCodePostalEtu";
            this.mskCodePostalEtu.Size = new System.Drawing.Size(140, 29);
            this.mskCodePostalEtu.TabIndex = 8;
            // 
            // dtpDateNaissanceEtu
            // 
            this.dtpDateNaissanceEtu.Location = new System.Drawing.Point(216, 183);
            this.dtpDateNaissanceEtu.MinDate = new System.DateTime(1989, 1, 1, 0, 0, 0, 0);
            this.dtpDateNaissanceEtu.Name = "dtpDateNaissanceEtu";
            this.dtpDateNaissanceEtu.Size = new System.Drawing.Size(194, 29);
            this.dtpDateNaissanceEtu.TabIndex = 4;
            this.dtpDateNaissanceEtu.Value = new System.DateTime(2021, 4, 13, 0, 0, 0, 0);
            this.dtpDateNaissanceEtu.ValueChanged += new System.EventHandler(this.dtpDateNaissanceEtu_ValueChanged);
            // 
            // mskTelephoneEtu
            // 
            this.mskTelephoneEtu.Location = new System.Drawing.Point(216, 435);
            this.mskTelephoneEtu.Mask = "(999) 000-0000";
            this.mskTelephoneEtu.Name = "mskTelephoneEtu";
            this.mskTelephoneEtu.Size = new System.Drawing.Size(140, 29);
            this.mskTelephoneEtu.TabIndex = 9;
            // 
            // txtVilleEtu
            // 
            this.txtVilleEtu.Location = new System.Drawing.Point(216, 364);
            this.txtVilleEtu.MaxLength = 30;
            this.txtVilleEtu.Name = "txtVilleEtu";
            this.txtVilleEtu.Size = new System.Drawing.Size(280, 29);
            this.txtVilleEtu.TabIndex = 7;
            this.txtVilleEtu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValiderChaine);
            // 
            // txtAdresseEtu
            // 
            this.txtAdresseEtu.Location = new System.Drawing.Point(216, 328);
            this.txtAdresseEtu.MaxLength = 30;
            this.txtAdresseEtu.Name = "txtAdresseEtu";
            this.txtAdresseEtu.Size = new System.Drawing.Size(280, 29);
            this.txtAdresseEtu.TabIndex = 6;
            this.txtAdresseEtu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValiderChaineAdresse);
            // 
            // txtNomEtu
            // 
            this.txtNomEtu.Location = new System.Drawing.Point(216, 115);
            this.txtNomEtu.MaxLength = 30;
            this.txtNomEtu.Name = "txtNomEtu";
            this.txtNomEtu.Size = new System.Drawing.Size(280, 29);
            this.txtNomEtu.TabIndex = 2;
            this.txtNomEtu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValiderChaine);
            // 
            // txtPrenomEtu
            // 
            this.txtPrenomEtu.Location = new System.Drawing.Point(216, 80);
            this.txtPrenomEtu.MaxLength = 30;
            this.txtPrenomEtu.Name = "txtPrenomEtu";
            this.txtPrenomEtu.Size = new System.Drawing.Size(280, 29);
            this.txtPrenomEtu.TabIndex = 1;
            this.txtPrenomEtu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValiderChaine);
            // 
            // lblDateNaissanceEtu
            // 
            this.lblDateNaissanceEtu.Location = new System.Drawing.Point(212, 152);
            this.lblDateNaissanceEtu.Name = "lblDateNaissanceEtu";
            this.lblDateNaissanceEtu.Size = new System.Drawing.Size(180, 28);
            this.lblDateNaissanceEtu.TabIndex = 9;
            this.lblDateNaissanceEtu.Text = "Date de naissance :";
            this.lblDateNaissanceEtu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelephoneEtu
            // 
            this.lblTelephoneEtu.Location = new System.Drawing.Point(6, 436);
            this.lblTelephoneEtu.Name = "lblTelephoneEtu";
            this.lblTelephoneEtu.Size = new System.Drawing.Size(180, 28);
            this.lblTelephoneEtu.TabIndex = 8;
            this.lblTelephoneEtu.Text = "Téléphone : ";
            this.lblTelephoneEtu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCodePostalEtu
            // 
            this.lblCodePostalEtu.Location = new System.Drawing.Point(6, 401);
            this.lblCodePostalEtu.Name = "lblCodePostalEtu";
            this.lblCodePostalEtu.Size = new System.Drawing.Size(180, 28);
            this.lblCodePostalEtu.TabIndex = 7;
            this.lblCodePostalEtu.Text = "Code Postal : ";
            this.lblCodePostalEtu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVilleEtu
            // 
            this.lblVilleEtu.Location = new System.Drawing.Point(6, 365);
            this.lblVilleEtu.Name = "lblVilleEtu";
            this.lblVilleEtu.Size = new System.Drawing.Size(180, 28);
            this.lblVilleEtu.TabIndex = 6;
            this.lblVilleEtu.Text = "Ville : ";
            this.lblVilleEtu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAdresseEtu
            // 
            this.lblAdresseEtu.Location = new System.Drawing.Point(6, 329);
            this.lblAdresseEtu.Name = "lblAdresseEtu";
            this.lblAdresseEtu.Size = new System.Drawing.Size(180, 28);
            this.lblAdresseEtu.TabIndex = 5;
            this.lblAdresseEtu.Text = "Adresse : ";
            this.lblAdresseEtu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupSexeEtu
            // 
            this.groupSexeEtu.Controls.Add(this.OptionFeminin);
            this.groupSexeEtu.Controls.Add(this.OptionMasculin);
            this.groupSexeEtu.Location = new System.Drawing.Point(6, 152);
            this.groupSexeEtu.Name = "groupSexeEtu";
            this.groupSexeEtu.Size = new System.Drawing.Size(180, 103);
            this.groupSexeEtu.TabIndex = 3;
            this.groupSexeEtu.TabStop = false;
            this.groupSexeEtu.Text = "Sexe : ";
            // 
            // OptionFeminin
            // 
            this.OptionFeminin.AutoSize = true;
            this.OptionFeminin.Location = new System.Drawing.Point(6, 60);
            this.OptionFeminin.Name = "OptionFeminin";
            this.OptionFeminin.Size = new System.Drawing.Size(95, 26);
            this.OptionFeminin.TabIndex = 1;
            this.OptionFeminin.Tag = "F";
            this.OptionFeminin.Text = "Féminin";
            this.OptionFeminin.UseVisualStyleBackColor = true;
            this.OptionFeminin.Click += new System.EventHandler(this.GenererCodePerm);
            // 
            // OptionMasculin
            // 
            this.OptionMasculin.AutoSize = true;
            this.OptionMasculin.Location = new System.Drawing.Point(6, 28);
            this.OptionMasculin.Name = "OptionMasculin";
            this.OptionMasculin.Size = new System.Drawing.Size(103, 26);
            this.OptionMasculin.TabIndex = 0;
            this.OptionMasculin.Tag = "M";
            this.OptionMasculin.Text = "Masculin";
            this.OptionMasculin.UseVisualStyleBackColor = true;
            this.OptionMasculin.Click += new System.EventHandler(this.GenererCodePerm);
            // 
            // lblCodePermanent
            // 
            this.lblCodePermanent.Location = new System.Drawing.Point(6, 289);
            this.lblCodePermanent.Name = "lblCodePermanent";
            this.lblCodePermanent.Size = new System.Drawing.Size(180, 28);
            this.lblCodePermanent.TabIndex = 3;
            this.lblCodePermanent.Text = "Code permanent : ";
            this.lblCodePermanent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNomEtu
            // 
            this.lblNomEtu.Location = new System.Drawing.Point(6, 116);
            this.lblNomEtu.Name = "lblNomEtu";
            this.lblNomEtu.Size = new System.Drawing.Size(180, 28);
            this.lblNomEtu.TabIndex = 2;
            this.lblNomEtu.Text = "Nom : ";
            this.lblNomEtu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrenomEtu
            // 
            this.lblPrenomEtu.Location = new System.Drawing.Point(6, 78);
            this.lblPrenomEtu.Name = "lblPrenomEtu";
            this.lblPrenomEtu.Size = new System.Drawing.Size(180, 28);
            this.lblPrenomEtu.TabIndex = 1;
            this.lblPrenomEtu.Text = "Prénom : ";
            this.lblPrenomEtu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNoIdentificationEtu
            // 
            this.lblNoIdentificationEtu.Location = new System.Drawing.Point(6, 44);
            this.lblNoIdentificationEtu.Name = "lblNoIdentificationEtu";
            this.lblNoIdentificationEtu.Size = new System.Drawing.Size(180, 28);
            this.lblNoIdentificationEtu.TabIndex = 0;
            this.lblNoIdentificationEtu.Text = "No d\'identification : ";
            this.lblNoIdentificationEtu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupResultatsEtudiant
            // 
            this.groupResultatsEtudiant.Controls.Add(this.numNoteTP2);
            this.groupResultatsEtudiant.Controls.Add(this.numNoteTP1);
            this.groupResultatsEtudiant.Controls.Add(this.numNoteFinal);
            this.groupResultatsEtudiant.Controls.Add(this.numNoteIntra);
            this.groupResultatsEtudiant.Controls.Add(this.lblNoteTP2);
            this.groupResultatsEtudiant.Controls.Add(this.lblNoteTP1);
            this.groupResultatsEtudiant.Controls.Add(this.lblNoteFinal);
            this.groupResultatsEtudiant.Controls.Add(this.lblNoteIntra);
            this.groupResultatsEtudiant.Enabled = false;
            this.groupResultatsEtudiant.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupResultatsEtudiant.Location = new System.Drawing.Point(594, 12);
            this.groupResultatsEtudiant.Name = "groupResultatsEtudiant";
            this.groupResultatsEtudiant.Size = new System.Drawing.Size(392, 128);
            this.groupResultatsEtudiant.TabIndex = 1;
            this.groupResultatsEtudiant.TabStop = false;
            this.groupResultatsEtudiant.Text = "Résultats";
            // 
            // numNoteTP2
            // 
            this.numNoteTP2.DecimalPlaces = 1;
            this.numNoteTP2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numNoteTP2.Location = new System.Drawing.Point(283, 75);
            this.numNoteTP2.Name = "numNoteTP2";
            this.numNoteTP2.Size = new System.Drawing.Size(76, 29);
            this.numNoteTP2.TabIndex = 13;
            // 
            // numNoteTP1
            // 
            this.numNoteTP1.DecimalPlaces = 1;
            this.numNoteTP1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numNoteTP1.Location = new System.Drawing.Point(283, 44);
            this.numNoteTP1.Name = "numNoteTP1";
            this.numNoteTP1.Size = new System.Drawing.Size(76, 29);
            this.numNoteTP1.TabIndex = 12;
            // 
            // numNoteFinal
            // 
            this.numNoteFinal.DecimalPlaces = 1;
            this.numNoteFinal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numNoteFinal.Location = new System.Drawing.Point(107, 76);
            this.numNoteFinal.Name = "numNoteFinal";
            this.numNoteFinal.Size = new System.Drawing.Size(76, 29);
            this.numNoteFinal.TabIndex = 11;
            // 
            // numNoteIntra
            // 
            this.numNoteIntra.DecimalPlaces = 1;
            this.numNoteIntra.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numNoteIntra.Location = new System.Drawing.Point(107, 43);
            this.numNoteIntra.Name = "numNoteIntra";
            this.numNoteIntra.Size = new System.Drawing.Size(76, 29);
            this.numNoteIntra.TabIndex = 10;
            // 
            // lblNoteTP2
            // 
            this.lblNoteTP2.Location = new System.Drawing.Point(205, 76);
            this.lblNoteTP2.Name = "lblNoteTP2";
            this.lblNoteTP2.Size = new System.Drawing.Size(84, 28);
            this.lblNoteTP2.TabIndex = 3;
            this.lblNoteTP2.Text = "TP 2 : ";
            // 
            // lblNoteTP1
            // 
            this.lblNoteTP1.Location = new System.Drawing.Point(205, 43);
            this.lblNoteTP1.Name = "lblNoteTP1";
            this.lblNoteTP1.Size = new System.Drawing.Size(72, 28);
            this.lblNoteTP1.TabIndex = 2;
            this.lblNoteTP1.Text = "TP 1 : ";
            // 
            // lblNoteFinal
            // 
            this.lblNoteFinal.Location = new System.Drawing.Point(16, 78);
            this.lblNoteFinal.Name = "lblNoteFinal";
            this.lblNoteFinal.Size = new System.Drawing.Size(98, 28);
            this.lblNoteFinal.TabIndex = 1;
            this.lblNoteFinal.Text = "Final : ";
            // 
            // lblNoteIntra
            // 
            this.lblNoteIntra.Location = new System.Drawing.Point(16, 42);
            this.lblNoteIntra.Name = "lblNoteIntra";
            this.lblNoteIntra.Size = new System.Drawing.Size(85, 28);
            this.lblNoteIntra.TabIndex = 0;
            this.lblNoteIntra.Text = "Intra : ";
            // 
            // cmdInscrireEtu
            // 
            this.cmdInscrireEtu.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInscrireEtu.Location = new System.Drawing.Point(594, 155);
            this.cmdInscrireEtu.Name = "cmdInscrireEtu";
            this.cmdInscrireEtu.Size = new System.Drawing.Size(392, 37);
            this.cmdInscrireEtu.TabIndex = 14;
            this.cmdInscrireEtu.Text = "&Inscrire un nouvel étudiant";
            this.cmdInscrireEtu.UseVisualStyleBackColor = true;
            this.cmdInscrireEtu.Click += new System.EventHandler(this.cmdInscrireEtu_Click);
            // 
            // cmdModifierEtu
            // 
            this.cmdModifierEtu.Enabled = false;
            this.cmdModifierEtu.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModifierEtu.Location = new System.Drawing.Point(594, 198);
            this.cmdModifierEtu.Name = "cmdModifierEtu";
            this.cmdModifierEtu.Size = new System.Drawing.Size(183, 38);
            this.cmdModifierEtu.TabIndex = 15;
            this.cmdModifierEtu.Text = "&Modifier";
            this.cmdModifierEtu.UseVisualStyleBackColor = true;
            this.cmdModifierEtu.Click += new System.EventHandler(this.cmdModifierEtu_Click);
            // 
            // cmdSupprimerEtu
            // 
            this.cmdSupprimerEtu.Enabled = false;
            this.cmdSupprimerEtu.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSupprimerEtu.Location = new System.Drawing.Point(803, 198);
            this.cmdSupprimerEtu.Name = "cmdSupprimerEtu";
            this.cmdSupprimerEtu.Size = new System.Drawing.Size(183, 38);
            this.cmdSupprimerEtu.TabIndex = 16;
            this.cmdSupprimerEtu.Text = "&Supprimer";
            this.cmdSupprimerEtu.UseVisualStyleBackColor = true;
            this.cmdSupprimerEtu.Click += new System.EventHandler(this.cmdSupprimerEtu_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Enabled = false;
            this.cmdOK.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.Location = new System.Drawing.Point(594, 242);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(183, 38);
            this.cmdOK.TabIndex = 17;
            this.cmdOK.Text = "&OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Enabled = false;
            this.cmdAnnuler.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnnuler.Location = new System.Drawing.Point(803, 242);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(183, 38);
            this.cmdAnnuler.TabIndex = 18;
            this.cmdAnnuler.Text = "&Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // groupNavigation
            // 
            this.groupNavigation.Controls.Add(this.lblMode);
            this.groupNavigation.Controls.Add(this.cmdDernier);
            this.groupNavigation.Controls.Add(this.cmdSuivant);
            this.groupNavigation.Controls.Add(this.cmdPrecedent);
            this.groupNavigation.Controls.Add(this.cmdPremier);
            this.groupNavigation.Enabled = false;
            this.groupNavigation.Location = new System.Drawing.Point(12, 526);
            this.groupNavigation.Name = "groupNavigation";
            this.groupNavigation.Size = new System.Drawing.Size(576, 75);
            this.groupNavigation.TabIndex = 10;
            this.groupNavigation.TabStop = false;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Open Sans Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.Maroon;
            this.lblMode.Location = new System.Drawing.Point(147, 24);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(263, 28);
            this.lblMode.TabIndex = 4;
            this.lblMode.Text = "*** Mode inscription ***";
            // 
            // cmdDernier
            // 
            this.cmdDernier.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDernier.Location = new System.Drawing.Point(502, 19);
            this.cmdDernier.Name = "cmdDernier";
            this.cmdDernier.Size = new System.Drawing.Size(55, 41);
            this.cmdDernier.TabIndex = 23;
            this.cmdDernier.Text = ">|";
            this.cmdDernier.UseVisualStyleBackColor = true;
            this.cmdDernier.Click += new System.EventHandler(this.cmdDernier_Click);
            // 
            // cmdSuivant
            // 
            this.cmdSuivant.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSuivant.Location = new System.Drawing.Point(441, 19);
            this.cmdSuivant.Name = "cmdSuivant";
            this.cmdSuivant.Size = new System.Drawing.Size(55, 41);
            this.cmdSuivant.TabIndex = 22;
            this.cmdSuivant.Text = ">";
            this.cmdSuivant.UseVisualStyleBackColor = true;
            this.cmdSuivant.Click += new System.EventHandler(this.cmdSuivant_Click);
            // 
            // cmdPrecedent
            // 
            this.cmdPrecedent.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrecedent.Location = new System.Drawing.Point(67, 19);
            this.cmdPrecedent.Name = "cmdPrecedent";
            this.cmdPrecedent.Size = new System.Drawing.Size(55, 41);
            this.cmdPrecedent.TabIndex = 21;
            this.cmdPrecedent.Text = "<";
            this.cmdPrecedent.UseVisualStyleBackColor = true;
            this.cmdPrecedent.Click += new System.EventHandler(this.cmdPrecedent_Click);
            // 
            // cmdPremier
            // 
            this.cmdPremier.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPremier.Location = new System.Drawing.Point(6, 19);
            this.cmdPremier.Name = "cmdPremier";
            this.cmdPremier.Size = new System.Drawing.Size(55, 41);
            this.cmdPremier.TabIndex = 20;
            this.cmdPremier.Text = "|<";
            this.cmdPremier.UseVisualStyleBackColor = true;
            this.cmdPremier.Click += new System.EventHandler(this.cmdPremier_Click);
            // 
            // err1
            // 
            this.err1.ContainerControl = this;
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(9, 91);
            this.txtRecherche.MaxLength = 30;
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(366, 29);
            this.txtRecherche.TabIndex = 25;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            this.txtRecherche.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValiderChaineAdresse);
            // 
            // groupRecherche
            // 
            this.groupRecherche.Controls.Add(this.lblNoteDClick);
            this.groupRecherche.Controls.Add(this.cmdRechSelectEtu);
            this.groupRecherche.Controls.Add(this.lvResultats);
            this.groupRecherche.Controls.Add(this.lblQteResultat);
            this.groupRecherche.Controls.Add(this.lblNbrResultats);
            this.groupRecherche.Controls.Add(this.groupFiltres);
            this.groupRecherche.Controls.Add(this.txtRecherche);
            this.groupRecherche.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupRecherche.Location = new System.Drawing.Point(594, 286);
            this.groupRecherche.Name = "groupRecherche";
            this.groupRecherche.Size = new System.Drawing.Size(392, 315);
            this.groupRecherche.TabIndex = 27;
            this.groupRecherche.TabStop = false;
            this.groupRecherche.Text = "Recherche";
            // 
            // lblNoteDClick
            // 
            this.lblNoteDClick.AutoSize = true;
            this.lblNoteDClick.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoteDClick.Location = new System.Drawing.Point(9, 296);
            this.lblNoteDClick.Name = "lblNoteDClick";
            this.lblNoteDClick.Size = new System.Drawing.Size(260, 15);
            this.lblNoteDClick.TabIndex = 37;
            this.lblNoteDClick.Text = "Double-Cliquez sur un résultat pour le récupérer.";
            // 
            // cmdRechSelectEtu
            // 
            this.cmdRechSelectEtu.Location = new System.Drawing.Point(9, 127);
            this.cmdRechSelectEtu.Name = "cmdRechSelectEtu";
            this.cmdRechSelectEtu.Size = new System.Drawing.Size(151, 28);
            this.cmdRechSelectEtu.TabIndex = 36;
            this.cmdRechSelectEtu.Text = "Sélectionner";
            this.cmdRechSelectEtu.UseVisualStyleBackColor = true;
            this.cmdRechSelectEtu.Click += new System.EventHandler(this.cmdRechSelectEtu_Click);
            // 
            // lvResultats
            // 
            this.lvResultats.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvResultats.FullRowSelect = true;
            this.lvResultats.GridLines = true;
            this.lvResultats.HideSelection = false;
            this.lvResultats.Location = new System.Drawing.Point(9, 162);
            this.lvResultats.MultiSelect = false;
            this.lvResultats.Name = "lvResultats";
            this.lvResultats.Size = new System.Drawing.Size(366, 130);
            this.lvResultats.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvResultats.TabIndex = 35;
            this.lvResultats.UseCompatibleStateImageBehavior = false;
            this.lvResultats.View = System.Windows.Forms.View.Details;
            this.lvResultats.DoubleClick += new System.EventHandler(this.cmdRechSelectEtu_Click);
            // 
            // lblQteResultat
            // 
            this.lblQteResultat.Location = new System.Drawing.Point(242, 127);
            this.lblQteResultat.Name = "lblQteResultat";
            this.lblQteResultat.Size = new System.Drawing.Size(39, 29);
            this.lblQteResultat.TabIndex = 34;
            this.lblQteResultat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNbrResultats
            // 
            this.lblNbrResultats.Location = new System.Drawing.Point(287, 127);
            this.lblNbrResultats.Name = "lblNbrResultats";
            this.lblNbrResultats.Size = new System.Drawing.Size(88, 29);
            this.lblNbrResultats.TabIndex = 33;
            this.lblNbrResultats.Text = "résultat(s)";
            this.lblNbrResultats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupFiltres
            // 
            this.groupFiltres.Controls.Add(this.optParCodePerm);
            this.groupFiltres.Controls.Add(this.optParNom);
            this.groupFiltres.Controls.Add(this.optParPrenom);
            this.groupFiltres.Location = new System.Drawing.Point(9, 28);
            this.groupFiltres.Name = "groupFiltres";
            this.groupFiltres.Size = new System.Drawing.Size(366, 55);
            this.groupFiltres.TabIndex = 27;
            this.groupFiltres.TabStop = false;
            this.groupFiltres.Text = "Filtres";
            // 
            // optParCodePerm
            // 
            this.optParCodePerm.AutoSize = true;
            this.optParCodePerm.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optParCodePerm.Location = new System.Drawing.Point(230, 27);
            this.optParCodePerm.Name = "optParCodePerm";
            this.optParCodePerm.Size = new System.Drawing.Size(130, 19);
            this.optParCodePerm.TabIndex = 2;
            this.optParCodePerm.TabStop = true;
            this.optParCodePerm.Text = "Par code permanent";
            this.optParCodePerm.UseVisualStyleBackColor = true;
            this.optParCodePerm.Click += new System.EventHandler(this.ViderRecherche);
            // 
            // optParNom
            // 
            this.optParNom.AutoSize = true;
            this.optParNom.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optParNom.Location = new System.Drawing.Point(129, 28);
            this.optParNom.Name = "optParNom";
            this.optParNom.Size = new System.Drawing.Size(69, 19);
            this.optParNom.TabIndex = 1;
            this.optParNom.TabStop = true;
            this.optParNom.Text = "Par nom";
            this.optParNom.UseVisualStyleBackColor = true;
            this.optParNom.Click += new System.EventHandler(this.ViderRecherche);
            // 
            // optParPrenom
            // 
            this.optParPrenom.AutoSize = true;
            this.optParPrenom.Checked = true;
            this.optParPrenom.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optParPrenom.Location = new System.Drawing.Point(11, 26);
            this.optParPrenom.Name = "optParPrenom";
            this.optParPrenom.Size = new System.Drawing.Size(86, 19);
            this.optParPrenom.TabIndex = 0;
            this.optParPrenom.TabStop = true;
            this.optParPrenom.Text = "Par prénom";
            this.optParPrenom.UseVisualStyleBackColor = true;
            this.optParPrenom.Click += new System.EventHandler(this.ViderRecherche);
            // 
            // cmdListeForm
            // 
            this.cmdListeForm.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListeForm.Location = new System.Drawing.Point(594, 617);
            this.cmdListeForm.Name = "cmdListeForm";
            this.cmdListeForm.Size = new System.Drawing.Size(392, 42);
            this.cmdListeForm.TabIndex = 28;
            this.cmdListeForm.Text = "Liste et statistiques";
            this.cmdListeForm.UseVisualStyleBackColor = true;
            this.cmdListeForm.Click += new System.EventHandler(this.cmdListeForm_Click);
            // 
            // frmGestionEtudiants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1016, 681);
            this.Controls.Add(this.cmdListeForm);
            this.Controls.Add(this.groupRecherche);
            this.Controls.Add(this.groupNavigation);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdSupprimerEtu);
            this.Controls.Add(this.cmdModifierEtu);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdInscrireEtu);
            this.Controls.Add(this.groupResultatsEtudiant);
            this.Controls.Add(this.groupInfoEtudiant);
            this.Name = "frmGestionEtudiants";
            this.Text = "Gestion des étudiants";
            this.Load += new System.EventHandler(this.frmGestionEtudiants_Load);
            this.groupInfoEtudiant.ResumeLayout(false);
            this.groupInfoEtudiant.PerformLayout();
            this.groupSexeEtu.ResumeLayout(false);
            this.groupSexeEtu.PerformLayout();
            this.groupResultatsEtudiant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numNoteTP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoteTP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoteFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoteIntra)).EndInit();
            this.groupNavigation.ResumeLayout(false);
            this.groupNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            this.groupRecherche.ResumeLayout(false);
            this.groupRecherche.PerformLayout();
            this.groupFiltres.ResumeLayout(false);
            this.groupFiltres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInfoEtudiant;
        private System.Windows.Forms.Label lblPrenomEtu;
        private System.Windows.Forms.Label lblNoIdentificationEtu;
        private System.Windows.Forms.GroupBox groupResultatsEtudiant;
        private System.Windows.Forms.Label lblNomEtu;
        private System.Windows.Forms.Label lblCodePermanent;
        private System.Windows.Forms.GroupBox groupSexeEtu;
        private System.Windows.Forms.RadioButton OptionFeminin;
        private System.Windows.Forms.RadioButton OptionMasculin;
        private System.Windows.Forms.Label lblAdresseEtu;
        private System.Windows.Forms.Label lblVilleEtu;
        private System.Windows.Forms.Label lblCodePostalEtu;
        private System.Windows.Forms.Label lblTelephoneEtu;
        private System.Windows.Forms.Label lblDateNaissanceEtu;
        private System.Windows.Forms.Label lblNoteTP2;
        private System.Windows.Forms.Label lblNoteTP1;
        private System.Windows.Forms.Label lblNoteFinal;
        private System.Windows.Forms.Label lblNoteIntra;
        private System.Windows.Forms.TextBox txtNomEtu;
        private System.Windows.Forms.TextBox txtPrenomEtu;
        private System.Windows.Forms.TextBox txtVilleEtu;
        private System.Windows.Forms.TextBox txtAdresseEtu;
        private System.Windows.Forms.NumericUpDown numNoteTP2;
        private System.Windows.Forms.NumericUpDown numNoteTP1;
        private System.Windows.Forms.NumericUpDown numNoteFinal;
        private System.Windows.Forms.NumericUpDown numNoteIntra;
        private System.Windows.Forms.Button cmdInscrireEtu;
        private System.Windows.Forms.Button cmdModifierEtu;
        private System.Windows.Forms.Button cmdSupprimerEtu;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdAnnuler;
        private System.Windows.Forms.MaskedTextBox mskTelephoneEtu;
        private System.Windows.Forms.GroupBox groupNavigation;
        private System.Windows.Forms.Button cmdPremier;
        private System.Windows.Forms.Button cmdDernier;
        private System.Windows.Forms.Button cmdSuivant;
        private System.Windows.Forms.Button cmdPrecedent;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.MaskedTextBox mskCodePostalEtu;
        private System.Windows.Forms.DateTimePicker dtpDateNaissanceEtu;
        private System.Windows.Forms.ErrorProvider err1;
        private System.Windows.Forms.TextBox txtNoIDEtu;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.GroupBox groupRecherche;
        private System.Windows.Forms.GroupBox groupFiltres;
        private System.Windows.Forms.RadioButton optParNom;
        private System.Windows.Forms.RadioButton optParPrenom;
        private System.Windows.Forms.RadioButton optParCodePerm;
        private System.Windows.Forms.Label lblValidationCP;
        private System.Windows.Forms.Label lblNoteSelectSexe;
        private System.Windows.Forms.Label lblQteResultat;
        private System.Windows.Forms.Label lblNbrResultats;
        private System.Windows.Forms.ListView lvResultats;
        private System.Windows.Forms.Button cmdRechSelectEtu;
        private System.Windows.Forms.Label lblNoteDClick;
        private System.Windows.Forms.TextBox txtCodePermEtu;
        private System.Windows.Forms.Button cmdListeForm;
    }
}

