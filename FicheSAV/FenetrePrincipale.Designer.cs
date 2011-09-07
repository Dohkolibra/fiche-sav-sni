namespace FicheSAV
{
    partial class FenetrePrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetrePrincipale));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.valider = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboMatos = new System.Windows.Forms.ComboBox();
            this.materielBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mafichesavDataSet1 = new FicheSAV.mafichesavDataSet1();
            this.MarqueList = new System.Windows.Forms.ComboBox();
            this.marqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.savDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.savDataSet = new FicheSAV.savDataSet();
            this.lOS = new System.Windows.Forms.Label();
            this.OSlist = new System.Windows.Forms.ComboBox();
            this.osBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptifBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.accessoiresBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.modeleBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sToutes = new System.Windows.Forms.Button();
            this.sTerminee = new System.Windows.Forms.Button();
            this.sAttente = new System.Windows.Forms.Button();
            this.sAfaire = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.recherche = new System.Windows.Forms.Button();
            this.valeur_recherche = new System.Windows.Forms.TextBox();
            this.nom_client = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.num_fiche = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rcSupprimer = new System.Windows.Forms.Button();
            this.rcValider = new System.Windows.Forms.Button();
            this.rcMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rcVille = new System.Windows.Forms.TextBox();
            this.rcCP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rcAdresse = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rcTel2 = new System.Windows.Forms.TextBox();
            this.rcTel1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.rcNom = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rechercheClient = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.graphOS = new ZedGraph.ZedGraphControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.graphMarque = new ZedGraph.ZedGraphControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.graphEtat = new ZedGraph.ZedGraphControl();
            this.bquitter = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleFicheToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauTypeDeMatérielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelOsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvellePrioritéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materielTableAdapter1 = new FicheSAV.mafichesavDataSet1TableAdapters.materielTableAdapter();
            this.marqueTableAdapter = new FicheSAV.savDataSetTableAdapters.marqueTableAdapter();
            this.osTableAdapter = new FicheSAV.savDataSetTableAdapters.osTableAdapter();
            this.materielTableAdapter2 = new FicheSAV.mafichesavDataSet1TableAdapters.materielTableAdapter();
            this.mafichesavDataSet11 = new FicheSAV.mafichesavDataSet1();
            this.tableAdapterManager1 = new FicheSAV.mafichesavDataSet1TableAdapters.TableAdapterManager();
            this.savDataSet1 = new FicheSAV.savDataSet();
            this.marqueTableAdapter1 = new FicheSAV.savDataSetTableAdapters.marqueTableAdapter();
            this.marqueTableAdapter2 = new FicheSAV.savDataSetTableAdapters.marqueTableAdapter();
            this.osTableAdapter1 = new FicheSAV.savDataSetTableAdapters.osTableAdapter();
            this.tableAdapterManager2 = new FicheSAV.savDataSetTableAdapters.TableAdapterManager();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mafichesavDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.savDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.savDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mafichesavDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.savDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(12, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 592);
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
            this.tabPage1.Size = new System.Drawing.Size(703, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Créer fiche SAV";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // valider
            // 
            this.valider.Location = new System.Drawing.Point(298, 533);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(106, 23);
            this.valider.TabIndex = 17;
            this.valider.Text = "Valider la fiche";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.comboMatos);
            this.groupBox3.Controls.Add(this.MarqueList);
            this.groupBox3.Controls.Add(this.lOS);
            this.groupBox3.Controls.Add(this.OSlist);
            this.groupBox3.Controls.Add(this.descriptifBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.accessoiresBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.modeleBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.passBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(3, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(694, 288);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information matériel";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(489, 76);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(67, 17);
            this.checkBox2.TabIndex = 21;
            this.checkBox2.Text = "sacoche";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(396, 76);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "alimentation";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboMatos
            // 
            this.comboMatos.DataSource = this.materielBindingSource1;
            this.comboMatos.DisplayMember = "nom_materiel";
            this.comboMatos.FormattingEnabled = true;
            this.comboMatos.Location = new System.Drawing.Point(108, 45);
            this.comboMatos.Name = "comboMatos";
            this.comboMatos.Size = new System.Drawing.Size(121, 21);
            this.comboMatos.TabIndex = 10;
            this.comboMatos.ValueMember = "id_materiel";
            // 
            // materielBindingSource1
            // 
            this.materielBindingSource1.DataMember = "materiel";
            this.materielBindingSource1.DataSource = this.mafichesavDataSet1;
            // 
            // mafichesavDataSet1
            // 
            this.mafichesavDataSet1.DataSetName = "mafichesavDataSet1";
            this.mafichesavDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MarqueList
            // 
            this.MarqueList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MarqueList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MarqueList.DataSource = this.marqueBindingSource;
            this.MarqueList.DisplayMember = "nom_marque";
            this.MarqueList.FormattingEnabled = true;
            this.MarqueList.ItemHeight = 13;
            this.MarqueList.Location = new System.Drawing.Point(278, 46);
            this.MarqueList.Name = "MarqueList";
            this.MarqueList.Size = new System.Drawing.Size(112, 21);
            this.MarqueList.TabIndex = 11;
            this.MarqueList.ValueMember = "idmarque";
            // 
            // marqueBindingSource
            // 
            this.marqueBindingSource.DataMember = "marque";
            this.marqueBindingSource.DataSource = this.savDataSetBindingSource1;
            // 
            // savDataSetBindingSource1
            // 
            this.savDataSetBindingSource1.DataSource = this.savDataSet;
            this.savDataSetBindingSource1.Position = 0;
            // 
            // savDataSet
            // 
            this.savDataSet.DataSetName = "savDataSet";
            this.savDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOS
            // 
            this.lOS.AutoSize = true;
            this.lOS.Location = new System.Drawing.Point(547, 50);
            this.lOS.Name = "lOS";
            this.lOS.Size = new System.Drawing.Size(31, 13);
            this.lOS.TabIndex = 18;
            this.lOS.Text = "OS : ";
            // 
            // OSlist
            // 
            this.OSlist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.OSlist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.OSlist.DataSource = this.osBindingSource;
            this.OSlist.DisplayMember = "nom_os";
            this.OSlist.FormattingEnabled = true;
            this.OSlist.Location = new System.Drawing.Point(580, 45);
            this.OSlist.Name = "OSlist";
            this.OSlist.Size = new System.Drawing.Size(108, 21);
            this.OSlist.TabIndex = 13;
            this.OSlist.ValueMember = "id_os";
            // 
            // osBindingSource
            // 
            this.osBindingSource.DataMember = "os";
            this.osBindingSource.DataSource = this.savDataSetBindingSource1;
            // 
            // descriptifBox
            // 
            this.descriptifBox.Location = new System.Drawing.Point(108, 106);
            this.descriptifBox.Multiline = true;
            this.descriptifBox.Name = "descriptifBox";
            this.descriptifBox.Size = new System.Drawing.Size(580, 137);
            this.descriptifBox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "descriptif panne :";
            // 
            // accessoiresBox
            // 
            this.accessoiresBox.Location = new System.Drawing.Point(108, 74);
            this.accessoiresBox.Name = "accessoiresBox";
            this.accessoiresBox.Size = new System.Drawing.Size(282, 22);
            this.accessoiresBox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "accessoires :";
            // 
            // modeleBox
            // 
            this.modeleBox.Location = new System.Drawing.Point(449, 46);
            this.modeleBox.Name = "modeleBox";
            this.modeleBox.Size = new System.Drawing.Size(96, 22);
            this.modeleBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "modèle :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "marque :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "type :";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(108, 20);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(121, 22);
            this.passBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "mot de passe :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(3, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations client";
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(108, 82);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(240, 22);
            this.mailBox.TabIndex = 8;
            // 
            // lmail
            // 
            this.lmail.AutoSize = true;
            this.lmail.Location = new System.Drawing.Point(44, 84);
            this.lmail.Name = "lmail";
            this.lmail.Size = new System.Drawing.Size(47, 13);
            this.lmail.TabIndex = 15;
            this.lmail.Text = "e-mail : ";
            // 
            // lville
            // 
            this.lville.AutoSize = true;
            this.lville.Location = new System.Drawing.Point(368, 84);
            this.lville.Name = "lville";
            this.lville.Size = new System.Drawing.Size(35, 13);
            this.lville.TabIndex = 14;
            this.lville.Text = "Ville :";
            this.lville.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // villeBox
            // 
            this.villeBox.Location = new System.Drawing.Point(438, 81);
            this.villeBox.Name = "villeBox";
            this.villeBox.Size = new System.Drawing.Size(250, 22);
            this.villeBox.TabIndex = 7;
            // 
            // cpBox
            // 
            this.cpBox.Location = new System.Drawing.Point(438, 56);
            this.cpBox.Name = "cpBox";
            this.cpBox.Size = new System.Drawing.Size(118, 22);
            this.cpBox.TabIndex = 6;
            // 
            // lcp
            // 
            this.lcp.AutoSize = true;
            this.lcp.Location = new System.Drawing.Point(368, 59);
            this.lcp.Name = "lcp";
            this.lcp.Size = new System.Drawing.Size(29, 13);
            this.lcp.TabIndex = 11;
            this.lcp.Text = "CP : ";
            this.lcp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listClient
            // 
            this.listClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listClient.FormattingEnabled = true;
            this.listClient.Location = new System.Drawing.Point(108, 50);
            this.listClient.Name = "listClient";
            this.listClient.Size = new System.Drawing.Size(231, 54);
            this.listClient.TabIndex = 10;
            this.listClient.DoubleClick += new System.EventHandler(this.listClient_DoubleClick);
            // 
            // newClient
            // 
            this.newClient.Location = new System.Drawing.Point(252, 26);
            this.newClient.Name = "newClient";
            this.newClient.Size = new System.Drawing.Size(96, 23);
            this.newClient.TabIndex = 9;
            this.newClient.TabStop = false;
            this.newClient.Text = "Nouveau Client";
            this.newClient.UseVisualStyleBackColor = true;
            this.newClient.Click += new System.EventHandler(this.newClient_Click);
            // 
            // adresseBox
            // 
            this.adresseBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.adresseBox.Location = new System.Drawing.Point(108, 56);
            this.adresseBox.Name = "adresseBox";
            this.adresseBox.Size = new System.Drawing.Size(240, 22);
            this.adresseBox.TabIndex = 5;
            // 
            // ladresse
            // 
            this.ladresse.AutoSize = true;
            this.ladresse.Location = new System.Drawing.Point(33, 59);
            this.ladresse.Name = "ladresse";
            this.ladresse.Size = new System.Drawing.Size(53, 13);
            this.ladresse.TabIndex = 7;
            this.ladresse.Text = "Adresse :";
            // 
            // tel2Box
            // 
            this.tel2Box.Location = new System.Drawing.Point(562, 30);
            this.tel2Box.Name = "tel2Box";
            this.tel2Box.Size = new System.Drawing.Size(126, 22);
            this.tel2Box.TabIndex = 4;
            // 
            // tel1Box
            // 
            this.tel1Box.Location = new System.Drawing.Point(438, 30);
            this.tel1Box.Name = "tel1Box";
            this.tel1Box.Size = new System.Drawing.Size(118, 22);
            this.tel1Box.TabIndex = 3;
            // 
            // ltel
            // 
            this.ltel.AutoSize = true;
            this.ltel.Location = new System.Drawing.Point(368, 33);
            this.ltel.Name = "ltel";
            this.ltel.Size = new System.Drawing.Size(67, 13);
            this.ltel.TabIndex = 4;
            this.ltel.Text = "Telephone :";
            this.ltel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(108, 27);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(138, 22);
            this.nameBox.TabIndex = 2;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom client :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.dateBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 60);
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
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.sToutes);
            this.tabPage3.Controls.Add(this.sTerminee);
            this.tabPage3.Controls.Add(this.sAttente);
            this.tabPage3.Controls.Add(this.sAfaire);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(703, 566);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rechercher fiche SAV";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(3, 209);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(697, 350);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fiche";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nom";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Matériel";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 254;
            // 
            // sToutes
            // 
            this.sToutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sToutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sToutes.Location = new System.Drawing.Point(177, 180);
            this.sToutes.Name = "sToutes";
            this.sToutes.Size = new System.Drawing.Size(75, 23);
            this.sToutes.TabIndex = 13;
            this.sToutes.Text = "toutes";
            this.sToutes.UseVisualStyleBackColor = true;
            this.sToutes.Click += new System.EventHandler(this.sToutes_Click);
            // 
            // sTerminee
            // 
            this.sTerminee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sTerminee.ForeColor = System.Drawing.Color.Red;
            this.sTerminee.Location = new System.Drawing.Point(450, 180);
            this.sTerminee.Name = "sTerminee";
            this.sTerminee.Size = new System.Drawing.Size(75, 23);
            this.sTerminee.TabIndex = 12;
            this.sTerminee.Text = "terminée";
            this.sTerminee.UseVisualStyleBackColor = true;
            this.sTerminee.Click += new System.EventHandler(this.sTerminee_Click);
            // 
            // sAttente
            // 
            this.sAttente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sAttente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sAttente.Location = new System.Drawing.Point(359, 180);
            this.sAttente.Name = "sAttente";
            this.sAttente.Size = new System.Drawing.Size(75, 23);
            this.sAttente.TabIndex = 11;
            this.sAttente.Text = "en attente";
            this.sAttente.UseVisualStyleBackColor = true;
            this.sAttente.Click += new System.EventHandler(this.sAttente_Click);
            // 
            // sAfaire
            // 
            this.sAfaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sAfaire.ForeColor = System.Drawing.Color.Blue;
            this.sAfaire.Location = new System.Drawing.Point(268, 180);
            this.sAfaire.Name = "sAfaire";
            this.sAfaire.Size = new System.Drawing.Size(75, 23);
            this.sAfaire.TabIndex = 10;
            this.sAfaire.Text = "à faire";
            this.sAfaire.UseVisualStyleBackColor = true;
            this.sAfaire.Click += new System.EventHandler(this.sAfaire_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.listBox2);
            this.groupBox4.Controls.Add(this.recherche);
            this.groupBox4.Controls.Add(this.valeur_recherche);
            this.groupBox4.Controls.Add(this.nom_client);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.num_fiche);
            this.groupBox4.Location = new System.Drawing.Point(108, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(497, 160);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options de recherche";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(309, 71);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(170, 82);
            this.listBox2.TabIndex = 7;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // recherche
            // 
            this.recherche.Location = new System.Drawing.Point(220, 82);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(75, 23);
            this.recherche.TabIndex = 6;
            this.recherche.Text = "Rechercher";
            this.recherche.UseVisualStyleBackColor = true;
            this.recherche.Click += new System.EventHandler(this.recherche_Click);
            // 
            // valeur_recherche
            // 
            this.valeur_recherche.Location = new System.Drawing.Point(309, 44);
            this.valeur_recherche.Name = "valeur_recherche";
            this.valeur_recherche.Size = new System.Drawing.Size(170, 22);
            this.valeur_recherche.TabIndex = 0;
            this.valeur_recherche.TextChanged += new System.EventHandler(this.valeur_recherche_TextChanged);
            // 
            // nom_client
            // 
            this.nom_client.AutoSize = true;
            this.nom_client.Location = new System.Drawing.Point(140, 57);
            this.nom_client.Name = "nom_client";
            this.nom_client.Size = new System.Drawing.Size(96, 17);
            this.nom_client.TabIndex = 2;
            this.nom_client.Text = "Nom de client";
            this.nom_client.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rechercher par : ";
            // 
            // num_fiche
            // 
            this.num_fiche.AutoSize = true;
            this.num_fiche.Checked = true;
            this.num_fiche.Location = new System.Drawing.Point(140, 33);
            this.num_fiche.Name = "num_fiche";
            this.num_fiche.Size = new System.Drawing.Size(110, 17);
            this.num_fiche.TabIndex = 1;
            this.num_fiche.TabStop = true;
            this.num_fiche.Text = "Numéro de fiche";
            this.num_fiche.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(703, 566);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Rechercher client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox6.Controls.Add(this.rcSupprimer);
            this.groupBox6.Controls.Add(this.rcValider);
            this.groupBox6.Controls.Add(this.rcMail);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.rcVille);
            this.groupBox6.Controls.Add(this.rcCP);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.rcAdresse);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.rcTel2);
            this.groupBox6.Controls.Add(this.rcTel1);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.rcNom);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Location = new System.Drawing.Point(6, 204);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(691, 359);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Informations sur le client";
            // 
            // rcSupprimer
            // 
            this.rcSupprimer.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcSupprimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rcSupprimer.Location = new System.Drawing.Point(355, 160);
            this.rcSupprimer.Name = "rcSupprimer";
            this.rcSupprimer.Size = new System.Drawing.Size(158, 23);
            this.rcSupprimer.TabIndex = 30;
            this.rcSupprimer.Text = "Supprimer ce client";
            this.rcSupprimer.UseVisualStyleBackColor = true;
            this.rcSupprimer.Click += new System.EventHandler(this.rcSupprimer_Click);
            // 
            // rcValider
            // 
            this.rcValider.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcValider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rcValider.Location = new System.Drawing.Point(178, 160);
            this.rcValider.Name = "rcValider";
            this.rcValider.Size = new System.Drawing.Size(171, 23);
            this.rcValider.TabIndex = 29;
            this.rcValider.Text = "Valider les modifications";
            this.rcValider.UseVisualStyleBackColor = true;
            this.rcValider.Click += new System.EventHandler(this.rcValider_Click);
            // 
            // rcMail
            // 
            this.rcMail.Location = new System.Drawing.Point(93, 102);
            this.rcMail.Name = "rcMail";
            this.rcMail.Size = new System.Drawing.Size(240, 22);
            this.rcMail.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "e-mail : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(353, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Ville :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rcVille
            // 
            this.rcVille.Location = new System.Drawing.Point(423, 101);
            this.rcVille.Name = "rcVille";
            this.rcVille.Size = new System.Drawing.Size(250, 22);
            this.rcVille.TabIndex = 23;
            // 
            // rcCP
            // 
            this.rcCP.Location = new System.Drawing.Point(423, 76);
            this.rcCP.Name = "rcCP";
            this.rcCP.Size = new System.Drawing.Size(118, 22);
            this.rcCP.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(353, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "CP : ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rcAdresse
            // 
            this.rcAdresse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rcAdresse.Location = new System.Drawing.Point(93, 76);
            this.rcAdresse.Name = "rcAdresse";
            this.rcAdresse.Size = new System.Drawing.Size(240, 22);
            this.rcAdresse.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Adresse :";
            // 
            // rcTel2
            // 
            this.rcTel2.Location = new System.Drawing.Point(547, 50);
            this.rcTel2.Name = "rcTel2";
            this.rcTel2.Size = new System.Drawing.Size(126, 22);
            this.rcTel2.TabIndex = 19;
            // 
            // rcTel1
            // 
            this.rcTel1.Location = new System.Drawing.Point(423, 50);
            this.rcTel1.Name = "rcTel1";
            this.rcTel1.Size = new System.Drawing.Size(118, 22);
            this.rcTel1.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(353, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Telephone :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rcNom
            // 
            this.rcNom.Location = new System.Drawing.Point(93, 47);
            this.rcNom.Name = "rcNom";
            this.rcNom.Size = new System.Drawing.Size(240, 22);
            this.rcNom.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Nom client :";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.listBox1);
            this.groupBox5.Controls.Add(this.rechercheClient);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(115, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(491, 165);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rechercher un client";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(387, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(113, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(268, 95);
            this.listBox1.TabIndex = 3;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // rechercheClient
            // 
            this.rechercheClient.Location = new System.Drawing.Point(113, 30);
            this.rechercheClient.Name = "rechercheClient";
            this.rechercheClient.Size = new System.Drawing.Size(268, 22);
            this.rechercheClient.TabIndex = 2;
            this.rechercheClient.TextChanged += new System.EventHandler(this.rechercheClient_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "nom du client : ";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.graphOS);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(703, 566);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Statistiques par OS";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // graphOS
            // 
            this.graphOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphOS.Location = new System.Drawing.Point(65, 6);
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
            this.tabPage5.Controls.Add(this.graphMarque);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(703, 566);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Statistiques par Marque";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // graphMarque
            // 
            this.graphMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphMarque.Location = new System.Drawing.Point(68, 6);
            this.graphMarque.Margin = new System.Windows.Forms.Padding(6);
            this.graphMarque.Name = "graphMarque";
            this.graphMarque.ScrollGrace = 0D;
            this.graphMarque.ScrollMaxX = 0D;
            this.graphMarque.ScrollMaxY = 0D;
            this.graphMarque.ScrollMaxY2 = 0D;
            this.graphMarque.ScrollMinX = 0D;
            this.graphMarque.ScrollMinY = 0D;
            this.graphMarque.ScrollMinY2 = 0D;
            this.graphMarque.Size = new System.Drawing.Size(573, 552);
            this.graphMarque.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.graphEtat);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(703, 566);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Statistiques par fiches";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // graphEtat
            // 
            this.graphEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphEtat.Location = new System.Drawing.Point(72, 5);
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
            // bquitter
            // 
            this.bquitter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bquitter.Location = new System.Drawing.Point(306, 27);
            this.bquitter.Name = "bquitter";
            this.bquitter.Size = new System.Drawing.Size(123, 23);
            this.bquitter.TabIndex = 1;
            this.bquitter.Text = "Quitter l\'application";
            this.bquitter.UseVisualStyleBackColor = true;
            this.bquitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.créerToolStripMenuItem,
            this.statistiquesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(734, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
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
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // créerToolStripMenuItem
            // 
            this.créerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleFicheToolStripMenuItem1,
            this.nouveauTypeDeMatérielToolStripMenuItem,
            this.nouvelleMarqueToolStripMenuItem,
            this.nouvelOsToolStripMenuItem,
            this.nouvellePrioritéToolStripMenuItem});
            this.créerToolStripMenuItem.Name = "créerToolStripMenuItem";
            this.créerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.créerToolStripMenuItem.Text = "Créer";
            // 
            // nouvelleFicheToolStripMenuItem1
            // 
            this.nouvelleFicheToolStripMenuItem1.Name = "nouvelleFicheToolStripMenuItem1";
            this.nouvelleFicheToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nouvelleFicheToolStripMenuItem1.Size = new System.Drawing.Size(210, 22);
            this.nouvelleFicheToolStripMenuItem1.Text = "Nouvelle fiche";
            this.nouvelleFicheToolStripMenuItem1.Click += new System.EventHandler(this.nouvelleFicheToolStripMenuItem1_Click);
            // 
            // nouveauTypeDeMatérielToolStripMenuItem
            // 
            this.nouveauTypeDeMatérielToolStripMenuItem.Name = "nouveauTypeDeMatérielToolStripMenuItem";
            this.nouveauTypeDeMatérielToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.nouveauTypeDeMatérielToolStripMenuItem.Text = "Nouveau type de matériel";
            this.nouveauTypeDeMatérielToolStripMenuItem.Click += new System.EventHandler(this.nouveauTypeDeMatérielToolStripMenuItem_Click);
            // 
            // nouvelleMarqueToolStripMenuItem
            // 
            this.nouvelleMarqueToolStripMenuItem.Name = "nouvelleMarqueToolStripMenuItem";
            this.nouvelleMarqueToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.nouvelleMarqueToolStripMenuItem.Text = "Nouvelle marque";
            this.nouvelleMarqueToolStripMenuItem.Click += new System.EventHandler(this.nouvelleMarqueToolStripMenuItem_Click);
            // 
            // nouvelOsToolStripMenuItem
            // 
            this.nouvelOsToolStripMenuItem.Name = "nouvelOsToolStripMenuItem";
            this.nouvelOsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.nouvelOsToolStripMenuItem.Text = "Nouvel OS";
            this.nouvelOsToolStripMenuItem.Click += new System.EventHandler(this.nouvelOsToolStripMenuItem_Click);
            // 
            // nouvellePrioritéToolStripMenuItem
            // 
            this.nouvellePrioritéToolStripMenuItem.Name = "nouvellePrioritéToolStripMenuItem";
            this.nouvellePrioritéToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.nouvellePrioritéToolStripMenuItem.Text = "Nouvelle priorité";
            this.nouvellePrioritéToolStripMenuItem.Click += new System.EventHandler(this.nouvellePrioritéToolStripMenuItem_Click);
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.fichesToolStripMenuItem});
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // fichesToolStripMenuItem
            // 
            this.fichesToolStripMenuItem.Name = "fichesToolStripMenuItem";
            this.fichesToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.fichesToolStripMenuItem.Text = "Fiches";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposDeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposDeToolStripMenuItem
            // 
            this.aProposDeToolStripMenuItem.Name = "aProposDeToolStripMenuItem";
            this.aProposDeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aProposDeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aProposDeToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.helpToolStripMenuItem.Text = "A propos de";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // materielTableAdapter1
            // 
            this.materielTableAdapter1.ClearBeforeFill = true;
            // 
            // marqueTableAdapter
            // 
            this.marqueTableAdapter.ClearBeforeFill = true;
            // 
            // osTableAdapter
            // 
            this.osTableAdapter.ClearBeforeFill = true;
            // 
            // materielTableAdapter2
            // 
            this.materielTableAdapter2.ClearBeforeFill = true;
            // 
            // mafichesavDataSet11
            // 
            this.mafichesavDataSet11.DataSetName = "mafichesavDataSet1";
            this.mafichesavDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = FicheSAV.mafichesavDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // savDataSet1
            // 
            this.savDataSet1.DataSetName = "savDataSet";
            this.savDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marqueTableAdapter1
            // 
            this.marqueTableAdapter1.ClearBeforeFill = true;
            // 
            // marqueTableAdapter2
            // 
            this.marqueTableAdapter2.ClearBeforeFill = true;
            // 
            // osTableAdapter1
            // 
            this.osTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.marqueTableAdapter = this.marqueTableAdapter;
            this.tableAdapterManager2.osTableAdapter = this.osTableAdapter;
            this.tableAdapterManager2.UpdateOrder = FicheSAV.savDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 693);
            this.Controls.Add(this.bquitter);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(750, 731);
            this.MinimumSize = new System.Drawing.Size(750, 731);
            this.Name = "FenetrePrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Gestionnaire de Fiche SAV >> Sud Nivernais Informatique";
            this.Resize += new System.EventHandler(this.FenetrePrincipale_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materielBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mafichesavDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.savDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.savDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mafichesavDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.savDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private ZedGraph.ZedGraphControl graphEtat;
        private ZedGraph.ZedGraphControl graphMarque;
        private System.Windows.Forms.Button bquitter;
        private System.Windows.Forms.ComboBox MarqueList;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauTypeDeMatérielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleMarqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelOsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleFicheToolStripMenuItem1;
        private System.Windows.Forms.RadioButton nom_client;
        private System.Windows.Forms.RadioButton num_fiche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox valeur_recherche;
        private System.Windows.Forms.ToolStripMenuItem nouvellePrioritéToolStripMenuItem;
        private System.Windows.Forms.Button recherche;
        private System.Windows.Forms.ComboBox comboMatos;
        private System.Windows.Forms.BindingSource materielBindingSource1;
        private mafichesavDataSet1TableAdapters.materielTableAdapter materielTableAdapter1;
        private mafichesavDataSet1 mafichesavDataSet1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button sTerminee;
        private System.Windows.Forms.Button sAttente;
        private System.Windows.Forms.Button sAfaire;
        private System.Windows.Forms.BindingSource savDataSetBindingSource1;
        private savDataSet savDataSet;
        private System.Windows.Forms.BindingSource marqueBindingSource;
        private savDataSetTableAdapters.marqueTableAdapter marqueTableAdapter;
        private System.Windows.Forms.BindingSource osBindingSource;
        private savDataSetTableAdapters.osTableAdapter osTableAdapter;
        private System.Windows.Forms.Button sToutes;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private mafichesavDataSet1TableAdapters.materielTableAdapter materielTableAdapter2;
        private mafichesavDataSet1 mafichesavDataSet11;
        private mafichesavDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private savDataSet savDataSet1;
        private savDataSetTableAdapters.marqueTableAdapter marqueTableAdapter1;
        private savDataSetTableAdapters.marqueTableAdapter marqueTableAdapter2;
        private savDataSetTableAdapters.osTableAdapter osTableAdapter1;
        private savDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox rechercheClient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichesToolStripMenuItem;
        private System.Windows.Forms.TextBox rcMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox rcVille;
        private System.Windows.Forms.TextBox rcCP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox rcAdresse;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox rcTel2;
        private System.Windows.Forms.TextBox rcTel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox rcNom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button rcSupprimer;
        private System.Windows.Forms.Button rcValider;
    }
}

