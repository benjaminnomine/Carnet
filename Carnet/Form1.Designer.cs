namespace Carnet
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label7 = new System.Windows.Forms.Label();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSauve = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.boxVille = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boxPrenom = new System.Windows.Forms.TextBox();
            this.boxNom = new System.Windows.Forms.TextBox();
            this.boxAdresse = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeContact = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.boxProvince = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.boxTel = new System.Windows.Forms.MaskedTextBox();
            this.boxCP = new System.Windows.Forms.TextBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Wheat;
            this.label7.Location = new System.Drawing.Point(225, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Email";
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(324, 76);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.ReadOnly = true;
            this.boxEmail.Size = new System.Drawing.Size(266, 20);
            this.boxEmail.TabIndex = 3;
            // 
            // btnModif
            // 
            this.btnModif.Enabled = false;
            this.btnModif.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btnModif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnModif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModif.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModif.Image = ((System.Drawing.Image)(resources.GetObject("btnModif.Image")));
            this.btnModif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModif.Location = new System.Drawing.Point(216, 297);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(86, 34);
            this.btnModif.TabIndex = 38;
            this.btnModif.Text = "Modifier";
            this.btnModif.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnSauve
            // 
            this.btnSauve.Enabled = false;
            this.btnSauve.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btnSauve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnSauve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSauve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSauve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSauve.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSauve.Image = ((System.Drawing.Image)(resources.GetObject("btnSauve.Image")));
            this.btnSauve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSauve.Location = new System.Drawing.Point(308, 297);
            this.btnSauve.Name = "btnSauve";
            this.btnSauve.Size = new System.Drawing.Size(86, 34);
            this.btnSauve.TabIndex = 37;
            this.btnSauve.Text = "Sauver";
            this.btnSauve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSauve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSauve.UseVisualStyleBackColor = true;
            this.btnSauve.Click += new System.EventHandler(this.btnSauve_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Wheat;
            this.label5.Location = new System.Drawing.Point(412, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ville";
            // 
            // boxVille
            // 
            this.boxVille.Location = new System.Drawing.Point(452, 208);
            this.boxVille.Name = "boxVille";
            this.boxVille.ReadOnly = true;
            this.boxVille.Size = new System.Drawing.Size(138, 20);
            this.boxVille.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Wheat;
            this.label4.Location = new System.Drawing.Point(225, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Code Postal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Wheat;
            this.label3.Location = new System.Drawing.Point(225, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Wheat;
            this.label2.Location = new System.Drawing.Point(412, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Prénom";
            // 
            // btnAjout
            // 
            this.btnAjout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAjout.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btnAjout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnAjout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAjout.Image = ((System.Drawing.Image)(resources.GetObject("btnAjout.Image")));
            this.btnAjout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAjout.Location = new System.Drawing.Point(32, 297);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(86, 34);
            this.btnAjout.TabIndex = 26;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(225, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nom";
            // 
            // boxPrenom
            // 
            this.boxPrenom.Location = new System.Drawing.Point(481, 44);
            this.boxPrenom.Name = "boxPrenom";
            this.boxPrenom.ReadOnly = true;
            this.boxPrenom.Size = new System.Drawing.Size(109, 20);
            this.boxPrenom.TabIndex = 2;
            // 
            // boxNom
            // 
            this.boxNom.Location = new System.Drawing.Point(277, 44);
            this.boxNom.Name = "boxNom";
            this.boxNom.ReadOnly = true;
            this.boxNom.Size = new System.Drawing.Size(129, 20);
            this.boxNom.TabIndex = 1;
            // 
            // boxAdresse
            // 
            this.boxAdresse.Location = new System.Drawing.Point(324, 155);
            this.boxAdresse.Multiline = true;
            this.boxAdresse.Name = "boxAdresse";
            this.boxAdresse.ReadOnly = true;
            this.boxAdresse.Size = new System.Drawing.Size(266, 44);
            this.boxAdresse.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(613, 24);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitterToolStripMenuItem.Image")));
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aProposToolStripMenuItem.Image")));
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // listeContact
            // 
            this.listeContact.FormattingEnabled = true;
            this.listeContact.Location = new System.Drawing.Point(15, 43);
            this.listeContact.Name = "listeContact";
            this.listeContact.Size = new System.Drawing.Size(164, 238);
            this.listeContact.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Wheat;
            this.label8.Location = new System.Drawing.Point(225, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "Téléphone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Wheat;
            this.label9.Location = new System.Drawing.Point(225, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "Province";
            // 
            // boxProvince
            // 
            this.boxProvince.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.boxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxProvince.DropDownWidth = 164;
            this.boxProvince.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.boxProvince.FormattingEnabled = true;
            this.boxProvince.ItemHeight = 16;
            this.boxProvince.Items.AddRange(new object[] {
            "Alberta",
            "Colombie Britannique",
            "Île-du-Prince-Édouard",
            "Manitoba",
            "Nouveau Brunswick",
            "Nova Scotia",
            "Nunavut",
            "Ontario",
            "Québec",
            "Saskatchewan",
            "Terre-Neuve-et-Labrador",
            "Territoires du Nord-Ouest",
            "Yukon"});
            this.boxProvince.Location = new System.Drawing.Point(324, 242);
            this.boxProvince.Name = "boxProvince";
            this.boxProvince.Size = new System.Drawing.Size(175, 22);
            this.boxProvince.Sorted = true;
            this.boxProvince.TabIndex = 9;
            this.boxProvince.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.boxProvince_DrawItem);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Enabled = false;
            this.btnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btnAnnuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnAnnuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnuler.Image")));
            this.btnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnuler.Location = new System.Drawing.Point(400, 297);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(86, 34);
            this.btnAnnuler.TabIndex = 22;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnnuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btnSupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSupp.Image = ((System.Drawing.Image)(resources.GetObject("btnSupp.Image")));
            this.btnSupp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupp.Location = new System.Drawing.Point(124, 297);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(86, 34);
            this.btnSupp.TabIndex = 48;
            this.btnSupp.Text = "Effacer";
            this.btnSupp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(185, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(185, 118);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(185, 153);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 52;
            this.pictureBox4.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.btnQuitter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnQuitter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuitter.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitter.Image")));
            this.btnQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitter.Location = new System.Drawing.Point(492, 297);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(86, 34);
            this.btnQuitter.TabIndex = 53;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // boxTel
            // 
            this.boxTel.Location = new System.Drawing.Point(324, 120);
            this.boxTel.Name = "boxTel";
            this.boxTel.Size = new System.Drawing.Size(266, 20);
            this.boxTel.TabIndex = 54;
            // 
            // boxCP
            // 
            this.boxCP.Location = new System.Drawing.Point(324, 208);
            this.boxCP.Name = "boxCP";
            this.boxCP.Size = new System.Drawing.Size(82, 20);
            this.boxCP.TabIndex = 55;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "alberta.png");
            this.imageList2.Images.SetKeyName(1, "british_columbia.png");
            this.imageList2.Images.SetKeyName(2, "prince_edward_island.png");
            this.imageList2.Images.SetKeyName(3, "manitoba.png");
            this.imageList2.Images.SetKeyName(4, "new_brunswick.png");
            this.imageList2.Images.SetKeyName(5, "nova_scotia.png");
            this.imageList2.Images.SetKeyName(6, "nunavut.png");
            this.imageList2.Images.SetKeyName(7, "ontario.png");
            this.imageList2.Images.SetKeyName(8, "québec.png");
            this.imageList2.Images.SetKeyName(9, "saskatchewan.png");
            this.imageList2.Images.SetKeyName(10, "newfoundland_and_labrador.png");
            this.imageList2.Images.SetKeyName(11, "northwest_territories.png");
            this.imageList2.Images.SetKeyName(12, "yukon.png");
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSauve;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(613, 343);
            this.ControlBox = false;
            this.Controls.Add(this.boxCP);
            this.Controls.Add(this.boxTel);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.boxProvince);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listeContact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnSauve);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxVille);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxPrenom);
            this.Controls.Add(this.boxNom);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.boxAdresse);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSupp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Carnet d\'adresse";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSauve;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxVille;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxPrenom;
        private System.Windows.Forms.TextBox boxNom;
        private System.Windows.Forms.TextBox boxAdresse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ListBox listeContact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox boxProvince;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.MaskedTextBox boxTel;
        private System.Windows.Forms.TextBox boxCP;
        private System.Windows.Forms.ImageList imageList2;
    }
}