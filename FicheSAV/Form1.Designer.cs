namespace FicheSAV
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.valider = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.prioriteBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lOS = new System.Windows.Forms.Label();
            this.OSlist = new System.Windows.Forms.ComboBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.descriptifBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.accessoiresBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.modeleBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.marqueBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.lmail = new System.Windows.Forms.Label();
            this.lville = new System.Windows.Forms.Label();
            this.villeBox = new System.Windows.Forms.TextBox();
            this.cpBox = new System.Windows.Forms.TextBox();
            this.lcp = new System.Windows.Forms.Label();
            this.listClient = new System.Windows.Forms.ListBox();
            this.newClient = new System.Windows.Forms.Button();
            this.adresseBox = new System.Windows.Forms.TextBox();
            this.ladresse = new System.Windows.Forms.Label();
            this.tel2Box = new System.Windows.Forms.TextBox();
            this.tel1Box = new System.Windows.Forms.TextBox();
            this.ltel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.graphOS = new ZedGraph.ZedGraphControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.graphEtat = new ZedGraph.ZedGraphControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(926, 588);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.valider);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(918, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Créer fiche SAV";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(402, 533);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(106, 23);
            this.valider.TabIndex = 3;
            this.valider.Text = "Valider la fiche";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.prioriteBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lOS);
            this.groupBox3.Controls.Add(this.OSlist);
            this.groupBox3.Controls.Add(this.typeBox);
            this.groupBox3.Controls.Add(this.descriptifBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.accessoiresBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.modeleBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.marqueBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.passBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(82, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(747, 288);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information matériel";
            // 
            // prioriteBox
            // 
            this.prioriteBox.FormattingEnabled = true;
            this.prioriteBox.Location = new System.Drawing.Point(331, 250);
            this.prioriteBox.Name = "prioriteBox";
            this.prioriteBox.Size = new System.Drawing.Size(121, 21);
            this.prioriteBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Priorité : ";
            // 
            // lOS
            // 
            this.lOS.AutoSize = true;
            this.lOS.Location = new System.Drawing.Point(578, 50);
            this.lOS.Name = "lOS";
            this.lOS.Size = new System.Drawing.Size(31, 13);
            this.lOS.TabIndex = 18;
            this.lOS.Text = "OS : ";
            // 
            // OSlist
            // 
            this.OSlist.FormattingEnabled = true;
            this.OSlist.Location = new System.Drawing.Point(611, 45);
            this.OSlist.Name = "OSlist";
            this.OSlist.Size = new System.Drawing.Size(121, 21);
            this.OSlist.TabIndex = 17;
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(108, 46);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(122, 20);
            this.typeBox.TabIndex = 16;
            // 
            // descriptifBox
            // 
            this.descriptifBox.Location = new System.Drawing.Point(108, 106);
            this.descriptifBox.Multiline = true;
            this.descriptifBox.Name = "descriptifBox";
            this.descriptifBox.Size = new System.Drawing.Size(624, 137);
            this.descriptifBox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "descriptif panne :";
            // 
            // accessoiresBox
            // 
            this.accessoiresBox.Location = new System.Drawing.Point(108, 74);
            this.accessoiresBox.Name = "accessoiresBox";
            this.accessoiresBox.Size = new System.Drawing.Size(282, 20);
            this.accessoiresBox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "accessoires :";
            // 
            // modeleBox
            // 
            this.modeleBox.Location = new System.Drawing.Point(449, 46);
            this.modeleBox.Name = "modeleBox";
            this.modeleBox.Size = new System.Drawing.Size(122, 20);
            this.modeleBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "modele :";
            // 
            // marqueBox
            // 
            this.marqueBox.Location = new System.Drawing.Point(290, 46);
            this.marqueBox.Name = "marqueBox";
            this.marqueBox.Size = new System.Drawing.Size(100, 20);
            this.marqueBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "marque :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "type :";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(108, 20);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(122, 20);
            this.passBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "mot de passe :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mailBox);
            this.groupBox2.Controls.Add(this.lmail);
            this.groupBox2.Controls.Add(this.lville);
            this.groupBox2.Controls.Add(this.villeBox);
            this.groupBox2.Controls.Add(this.cpBox);
            this.groupBox2.Controls.Add(this.lcp);
            this.groupBox2.Controls.Add(this.listClient);
            this.groupBox2.Controls.Add(this.newClient);
            this.groupBox2.Controls.Add(this.adresseBox);
            this.groupBox2.Controls.Add(this.ladresse);
            this.groupBox2.Controls.Add(this.tel2Box);
            this.groupBox2.Controls.Add(this.tel1Box);
            this.groupBox2.Controls.Add(this.ltel);
            this.groupBox2.Controls.Add(this.nameBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(82, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations client";
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(108, 82);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(254, 20);
            this.mailBox.TabIndex = 16;
            // 
            // lmail
            // 
            this.lmail.AutoSize = true;
            this.lmail.Location = new System.Drawing.Point(44, 84);
            this.lmail.Name = "lmail";
            this.lmail.Size = new System.Drawing.Size(43, 13);
            this.lmail.TabIndex = 15;
            this.lmail.Text = "e-mail : ";
            // 
            // lville
            // 
            this.lville.AutoSize = true;
            this.lville.Location = new System.Drawing.Point(478, 60);
            this.lville.Name = "lville";
            this.lville.Size = new System.Drawing.Size(32, 13);
            this.lville.TabIndex = 14;
            this.lville.Text = "Ville :";
            // 
            // villeBox
            // 
            this.villeBox.Location = new System.Drawing.Point(516, 57);
            this.villeBox.Name = "villeBox";
            this.villeBox.Size = new System.Drawing.Size(216, 20);
            this.villeBox.TabIndex = 13;
            // 
            // cpBox
            // 
            this.cpBox.Location = new System.Drawing.Point(408, 57);
            this.cpBox.Name = "cpBox";
            this.cpBox.Size = new System.Drawing.Size(64, 20);
            this.cpBox.TabIndex = 12;
            // 
            // lcp
            // 
            this.lcp.AutoSize = true;
            this.lcp.Location = new System.Drawing.Point(368, 60);
            this.lcp.Name = "lcp";
            this.lcp.Size = new System.Drawing.Size(30, 13);
            this.lcp.TabIndex = 11;
            this.lcp.Text = "CP : ";
            // 
            // listClient
            // 
            this.listClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listClient.FormattingEnabled = true;
            this.listClient.Location = new System.Drawing.Point(108, 56);
            this.listClient.Name = "listClient";
            this.listClient.Size = new System.Drawing.Size(161, 54);
            this.listClient.TabIndex = 10;
            this.listClient.DoubleClick += new System.EventHandler(this.listClient_DoubleClick);
            // 
            // newClient
            // 
            this.newClient.Location = new System.Drawing.Point(237, 25);
            this.newClient.Name = "newClient";
            this.newClient.Size = new System.Drawing.Size(96, 23);
            this.newClient.TabIndex = 9;
            this.newClient.Text = "Nouveau Client";
            this.newClient.UseVisualStyleBackColor = true;
            this.newClient.Click += new System.EventHandler(this.newClient_Click);
            // 
            // adresseBox
            // 
            this.adresseBox.Location = new System.Drawing.Point(108, 56);
            this.adresseBox.Name = "adresseBox";
            this.adresseBox.Size = new System.Drawing.Size(254, 20);
            this.adresseBox.TabIndex = 8;
            // 
            // ladresse
            // 
            this.ladresse.AutoSize = true;
            this.ladresse.Location = new System.Drawing.Point(33, 59);
            this.ladresse.Name = "ladresse";
            this.ladresse.Size = new System.Drawing.Size(51, 13);
            this.ladresse.TabIndex = 7;
            this.ladresse.Text = "Adresse :";
            // 
            // tel2Box
            // 
            this.tel2Box.Location = new System.Drawing.Point(585, 30);
            this.tel2Box.Name = "tel2Box";
            this.tel2Box.Size = new System.Drawing.Size(147, 20);
            this.tel2Box.TabIndex = 6;
            // 
            // tel1Box
            // 
            this.tel1Box.Location = new System.Drawing.Point(438, 30);
            this.tel1Box.Name = "tel1Box";
            this.tel1Box.Size = new System.Drawing.Size(141, 20);
            this.tel1Box.TabIndex = 5;
            // 
            // ltel
            // 
            this.ltel.AutoSize = true;
            this.ltel.Location = new System.Drawing.Point(368, 33);
            this.ltel.Name = "ltel";
            this.ltel.Size = new System.Drawing.Size(64, 13);
            this.ltel.TabIndex = 4;
            this.ltel.Text = "Telephone :";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(108, 27);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(122, 20);
            this.nameBox.TabIndex = 3;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom client :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(82, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dépôt";
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(108, 20);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(122, 20);
            this.dateBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date de dépôt :";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(917, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rechercher un client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(917, 562);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rechercher une fiche SAV";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.graphOS);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(917, 562);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Statistiques par OS";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // graphOS
            // 
            this.graphOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphOS.Location = new System.Drawing.Point(6, 6);
            this.graphOS.Margin = new System.Windows.Forms.Padding(6);
            this.graphOS.Name = "graphOS";
            this.graphOS.ScrollGrace = 0D;
            this.graphOS.ScrollMaxX = 0D;
            this.graphOS.ScrollMaxY = 0D;
            this.graphOS.ScrollMaxY2 = 0D;
            this.graphOS.ScrollMinX = 0D;
            this.graphOS.ScrollMinY = 0D;
            this.graphOS.ScrollMinY2 = 0D;
            this.graphOS.Size = new System.Drawing.Size(573, 552);
            this.graphOS.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(917, 562);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Statistiques par Marque";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.graphEtat);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(917, 562);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Statistiques par fiches";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // graphEtat
            // 
            this.graphEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphEtat.Location = new System.Drawing.Point(6, 6);
            this.graphEtat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.graphEtat.Name = "graphEtat";
            this.graphEtat.ScrollGrace = 0D;
            this.graphEtat.ScrollMaxX = 0D;
            this.graphEtat.ScrollMaxY = 0D;
            this.graphEtat.ScrollMaxY2 = 0D;
            this.graphEtat.ScrollMinX = 0D;
            this.graphEtat.ScrollMinY = 0D;
            this.graphEtat.ScrollMinY2 = 0D;
            this.graphEtat.Size = new System.Drawing.Size(573, 552);
            this.graphEtat.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 693);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gestion de fiche SAV >> Sud Nivernais Informatique";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox adresseBox;
        private System.Windows.Forms.Label ladresse;
        private System.Windows.Forms.TextBox tel2Box;
        private System.Windows.Forms.TextBox tel1Box;
        private System.Windows.Forms.Label ltel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox descriptifBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox accessoiresBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox modeleBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox marqueBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Button newClient;
        private System.Windows.Forms.ListBox listClient;
        private System.Windows.Forms.Label lville;
        private System.Windows.Forms.TextBox villeBox;
        private System.Windows.Forms.TextBox cpBox;
        private System.Windows.Forms.Label lcp;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.Label lmail;
        private System.Windows.Forms.Label lOS;
        private System.Windows.Forms.ComboBox OSlist;
        private ZedGraph.ZedGraphControl graphOS;
        private System.Windows.Forms.ComboBox prioriteBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private ZedGraph.ZedGraphControl graphEtat;
    }
}

