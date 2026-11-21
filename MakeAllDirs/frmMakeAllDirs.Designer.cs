namespace LaunchAll
{
    partial class frmMakeAllDirs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMakeAllDirs));
            label2 = new Label();
            txtRootDir = new TextBox();
            btnCreaECopia = new Button();
            txtCartellaCopia = new TextBox();
            label4 = new Label();
            btnMenoCopia = new Button();
            btnPiuCopia = new Button();
            btnCreaCartelle = new Button();
            btnMenoAlbero = new Button();
            btnPiuAlbero = new Button();
            btnCartellaRoot = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            btnCartellaCopia = new Button();
            opfilScelta = new OpenFileDialog();
            txtEdit = new TextBox();
            btnPiuInizio = new Button();
            btnCopia = new Button();
            btnMenoMeno = new Button();
            btnPiuPiu = new Button();
            btnLaunchAll = new Button();
            btnNuovo = new Button();
            btnApriFile = new Button();
            btnTrovaESostituisci = new Button();
            btnSalva = new Button();
            btnApriFileConfigurazione = new Button();
            btnEsporta = new Button();
            btnImporta = new Button();
            label8 = new Label();
            txtFileConfigurazione = new TextBox();
            svfilConfigurazione = new SaveFileDialog();
            opfilConfigurazione = new OpenFileDialog();
            splitContainer1 = new SplitContainer();
            txtStringa2Da = new TextBox();
            txtStringa2A = new TextBox();
            btnCheckOff = new Button();
            btnCheckOn = new Button();
            label7 = new Label();
            label6 = new Label();
            txtStringaDa = new TextBox();
            txtStringaA = new TextBox();
            lstvwFileDaCopiare = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label3 = new Label();
            btnDeCheckAll = new Button();
            btnCheckAll = new Button();
            btnCartellaPerCopiare = new Button();
            btnCopiaStruttura = new Button();
            txtNuova = new TextBox();
            label5 = new Label();
            label1 = new Label();
            trwCartelleDaCreare = new TreeView();
            btnDisabilitaCreare = new Button();
            btnAbilitaCreare = new Button();
            btnOrdina = new Button();
            btnCreaCartella = new Button();
            label9 = new Label();
            label10 = new Label();
            txtDiscoVecchio = new TextBox();
            btnCambiaDisco = new Button();
            txtDiscoNuovo = new TextBox();
            grpFileConfigurazione = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            grpFileConfigurazione.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 122);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(244, 15);
            label2.TabIndex = 2;
            label2.Text = "Cartella di partenza in cui creare cartelle e file";
            // 
            // txtRootDir
            // 
            txtRootDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRootDir.Location = new Point(252, 118);
            txtRootDir.Margin = new Padding(4);
            txtRootDir.Name = "txtRootDir";
            txtRootDir.Size = new Size(697, 23);
            txtRootDir.TabIndex = 2;
            txtRootDir.MouseDoubleClick += txtRootDir_MouseDoubleClick;
            // 
            // btnCreaECopia
            // 
            btnCreaECopia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreaECopia.BackColor = Color.FromArgb(0, 192, 0);
            btnCreaECopia.ForeColor = Color.White;
            btnCreaECopia.Location = new Point(1012, 33);
            btnCreaECopia.Margin = new Padding(4);
            btnCreaECopia.Name = "btnCreaECopia";
            btnCreaECopia.Size = new Size(91, 32);
            btnCreaECopia.TabIndex = 5;
            btnCreaECopia.Text = "Crea e copia";
            btnCreaECopia.UseVisualStyleBackColor = false;
            btnCreaECopia.Click += btnCreaECopia_Click;
            // 
            // txtCartellaCopia
            // 
            txtCartellaCopia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCartellaCopia.Location = new Point(158, 150);
            txtCartellaCopia.Margin = new Padding(4);
            txtCartellaCopia.Name = "txtCartellaCopia";
            txtCartellaCopia.Size = new Size(898, 23);
            txtCartellaCopia.TabIndex = 3;
            txtCartellaCopia.MouseDoubleClick += txtCartellaCopia_MouseDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 154);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(143, 15);
            label4.TabIndex = 7;
            label4.Text = "Cartella da cui copiare file";
            // 
            // btnMenoCopia
            // 
            btnMenoCopia.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMenoCopia.Location = new Point(32, 347);
            btnMenoCopia.Margin = new Padding(4);
            btnMenoCopia.Name = "btnMenoCopia";
            btnMenoCopia.Size = new Size(31, 24);
            btnMenoCopia.TabIndex = 45;
            btnMenoCopia.Text = "-";
            btnMenoCopia.UseVisualStyleBackColor = true;
            btnMenoCopia.Click += btnMenoCopia_Click;
            // 
            // btnPiuCopia
            // 
            btnPiuCopia.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPiuCopia.Location = new Point(0, 347);
            btnPiuCopia.Margin = new Padding(4);
            btnPiuCopia.Name = "btnPiuCopia";
            btnPiuCopia.Size = new Size(28, 24);
            btnPiuCopia.TabIndex = 44;
            btnPiuCopia.Text = "+";
            btnPiuCopia.UseVisualStyleBackColor = true;
            btnPiuCopia.Click += btnPiuCopia_Click;
            // 
            // btnCreaCartelle
            // 
            btnCreaCartelle.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCreaCartelle.Location = new Point(383, 347);
            btnCreaCartelle.Margin = new Padding(4);
            btnCreaCartelle.Name = "btnCreaCartelle";
            btnCreaCartelle.Size = new Size(88, 24);
            btnCreaCartelle.TabIndex = 49;
            btnCreaCartelle.Text = "Crea cartelle";
            btnCreaCartelle.UseVisualStyleBackColor = true;
            btnCreaCartelle.Click += btnCreaCartelle_Click;
            // 
            // btnMenoAlbero
            // 
            btnMenoAlbero.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMenoAlbero.Location = new Point(83, 347);
            btnMenoAlbero.Margin = new Padding(4);
            btnMenoAlbero.Name = "btnMenoAlbero";
            btnMenoAlbero.Size = new Size(24, 24);
            btnMenoAlbero.TabIndex = 48;
            btnMenoAlbero.Text = "-";
            btnMenoAlbero.UseVisualStyleBackColor = true;
            btnMenoAlbero.Click += btnMenoAlbero_Click;
            // 
            // btnPiuAlbero
            // 
            btnPiuAlbero.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPiuAlbero.Location = new Point(59, 347);
            btnPiuAlbero.Margin = new Padding(4);
            btnPiuAlbero.Name = "btnPiuAlbero";
            btnPiuAlbero.Size = new Size(24, 24);
            btnPiuAlbero.TabIndex = 47;
            btnPiuAlbero.Text = "+";
            btnPiuAlbero.UseVisualStyleBackColor = true;
            btnPiuAlbero.Click += btnPiuAlbero_Click;
            // 
            // btnCartellaRoot
            // 
            btnCartellaRoot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCartellaRoot.Location = new Point(1058, 117);
            btnCartellaRoot.Margin = new Padding(4);
            btnCartellaRoot.Name = "btnCartellaRoot";
            btnCartellaRoot.Size = new Size(42, 25);
            btnCartellaRoot.TabIndex = 50;
            btnCartellaRoot.Text = "..";
            btnCartellaRoot.UseVisualStyleBackColor = true;
            btnCartellaRoot.Click += btnCartellaRoot_Click;
            // 
            // btnCartellaCopia
            // 
            btnCartellaCopia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCartellaCopia.Location = new Point(1058, 149);
            btnCartellaCopia.Margin = new Padding(4);
            btnCartellaCopia.Name = "btnCartellaCopia";
            btnCartellaCopia.Size = new Size(42, 25);
            btnCartellaCopia.TabIndex = 51;
            btnCartellaCopia.Text = "..";
            btnCartellaCopia.UseVisualStyleBackColor = true;
            btnCartellaCopia.Click += btnCartellaCopia_Click;
            // 
            // opfilScelta
            // 
            opfilScelta.FileName = "da_creare.mall";
            // 
            // txtEdit
            // 
            txtEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEdit.Location = new Point(351, 184);
            txtEdit.Margin = new Padding(4);
            txtEdit.Name = "txtEdit";
            txtEdit.ReadOnly = true;
            txtEdit.Size = new Size(750, 23);
            txtEdit.TabIndex = 52;
            txtEdit.MouseDoubleClick += txtEdit_MouseDoubleClick;
            // 
            // btnPiuInizio
            // 
            btnPiuInizio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPiuInizio.Location = new Point(1, 347);
            btnPiuInizio.Margin = new Padding(4);
            btnPiuInizio.Name = "btnPiuInizio";
            btnPiuInizio.Size = new Size(57, 24);
            btnPiuInizio.TabIndex = 60;
            btnPiuInizio.Text = "+ inizio";
            btnPiuInizio.UseVisualStyleBackColor = true;
            btnPiuInizio.Click += button1_Click;
            // 
            // btnCopia
            // 
            btnCopia.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCopia.Location = new Point(521, 347);
            btnCopia.Margin = new Padding(4);
            btnCopia.Name = "btnCopia";
            btnCopia.Size = new Size(99, 24);
            btnCopia.TabIndex = 63;
            btnCopia.Text = "Copia files";
            btnCopia.UseVisualStyleBackColor = true;
            btnCopia.Click += btnCopia_Click;
            // 
            // btnMenoMeno
            // 
            btnMenoMeno.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMenoMeno.Location = new Point(181, 347);
            btnMenoMeno.Margin = new Padding(4);
            btnMenoMeno.Name = "btnMenoMeno";
            btnMenoMeno.Size = new Size(28, 24);
            btnMenoMeno.TabIndex = 63;
            btnMenoMeno.Text = "--";
            btnMenoMeno.UseVisualStyleBackColor = true;
            btnMenoMeno.Click += btnMenoMeno_Click;
            // 
            // btnPiuPiu
            // 
            btnPiuPiu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPiuPiu.Location = new Point(152, 347);
            btnPiuPiu.Margin = new Padding(4);
            btnPiuPiu.Name = "btnPiuPiu";
            btnPiuPiu.Size = new Size(28, 24);
            btnPiuPiu.TabIndex = 62;
            btnPiuPiu.Text = "++";
            btnPiuPiu.UseVisualStyleBackColor = true;
            btnPiuPiu.Click += btnPiuPiu_Click;
            // 
            // btnLaunchAll
            // 
            btnLaunchAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLaunchAll.BackColor = Color.FromArgb(192, 0, 0);
            btnLaunchAll.ForeColor = Color.White;
            btnLaunchAll.Location = new Point(918, 33);
            btnLaunchAll.Margin = new Padding(4);
            btnLaunchAll.Name = "btnLaunchAll";
            btnLaunchAll.Size = new Size(91, 32);
            btnLaunchAll.TabIndex = 64;
            btnLaunchAll.Text = "LaunchAll";
            btnLaunchAll.UseVisualStyleBackColor = false;
            btnLaunchAll.Visible = false;
            btnLaunchAll.Click += btnLaunchAll_Click;
            // 
            // btnNuovo
            // 
            btnNuovo.Location = new Point(500, 23);
            btnNuovo.Margin = new Padding(4);
            btnNuovo.Name = "btnNuovo";
            btnNuovo.Size = new Size(91, 32);
            btnNuovo.TabIndex = 71;
            btnNuovo.Text = "Nuovo";
            btnNuovo.UseVisualStyleBackColor = true;
            btnNuovo.Click += btnNuovo_Click;
            // 
            // btnApriFile
            // 
            btnApriFile.Location = new Point(598, 23);
            btnApriFile.Margin = new Padding(4);
            btnApriFile.Name = "btnApriFile";
            btnApriFile.Size = new Size(91, 32);
            btnApriFile.TabIndex = 70;
            btnApriFile.Text = "Apri";
            btnApriFile.UseVisualStyleBackColor = true;
            btnApriFile.Click += btnApriFile_Click;
            // 
            // btnTrovaESostituisci
            // 
            btnTrovaESostituisci.Enabled = false;
            btnTrovaESostituisci.Location = new Point(147, 23);
            btnTrovaESostituisci.Margin = new Padding(4);
            btnTrovaESostituisci.Name = "btnTrovaESostituisci";
            btnTrovaESostituisci.Size = new Size(122, 32);
            btnTrovaESostituisci.TabIndex = 69;
            btnTrovaESostituisci.Text = "Trova e sostituisci";
            btnTrovaESostituisci.UseVisualStyleBackColor = true;
            btnTrovaESostituisci.Click += btnTrovaESostituisci_Click;
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(695, 23);
            btnSalva.Margin = new Padding(4);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(91, 32);
            btnSalva.TabIndex = 68;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // btnApriFileConfigurazione
            // 
            btnApriFileConfigurazione.Location = new Point(791, 23);
            btnApriFileConfigurazione.Margin = new Padding(4);
            btnApriFileConfigurazione.Name = "btnApriFileConfigurazione";
            btnApriFileConfigurazione.Size = new Size(91, 32);
            btnApriFileConfigurazione.TabIndex = 67;
            btnApriFileConfigurazione.Text = "Scegli file";
            btnApriFileConfigurazione.UseVisualStyleBackColor = true;
            btnApriFileConfigurazione.Click += btnApriFileConfigurazione_Click;
            // 
            // btnEsporta
            // 
            btnEsporta.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEsporta.Location = new Point(276, 23);
            btnEsporta.Margin = new Padding(4);
            btnEsporta.Name = "btnEsporta";
            btnEsporta.Size = new Size(122, 32);
            btnEsporta.TabIndex = 66;
            btnEsporta.Text = "Salva con nome";
            btnEsporta.UseVisualStyleBackColor = true;
            btnEsporta.Click += btnEsporta_Click;
            // 
            // btnImporta
            // 
            btnImporta.Location = new Point(404, 23);
            btnImporta.Margin = new Padding(4);
            btnImporta.Name = "btnImporta";
            btnImporta.Size = new Size(91, 32);
            btnImporta.TabIndex = 65;
            btnImporta.Text = "Importa";
            btnImporta.UseVisualStyleBackColor = true;
            btnImporta.Click += btnImporta_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 41);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(120, 15);
            label8.TabIndex = 73;
            label8.Text = "File di configurazione";
            // 
            // txtFileConfigurazione
            // 
            txtFileConfigurazione.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFileConfigurazione.Location = new Point(9, 59);
            txtFileConfigurazione.Margin = new Padding(4);
            txtFileConfigurazione.Name = "txtFileConfigurazione";
            txtFileConfigurazione.Size = new Size(873, 23);
            txtFileConfigurazione.TabIndex = 1;
            txtFileConfigurazione.TextChanged += txtFileConfigurazione_TextChanged;
            // 
            // svfilConfigurazione
            // 
            svfilConfigurazione.FileName = "da_creare.mall";
            // 
            // opfilConfigurazione
            // 
            opfilConfigurazione.FileName = "da_creare.mall";
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(7, 215);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnCopia);
            splitContainer1.Panel1.Controls.Add(txtStringa2Da);
            splitContainer1.Panel1.Controls.Add(txtStringa2A);
            splitContainer1.Panel1.Controls.Add(btnCheckOff);
            splitContainer1.Panel1.Controls.Add(btnCheckOn);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(txtStringaDa);
            splitContainer1.Panel1.Controls.Add(txtStringaA);
            splitContainer1.Panel1.Controls.Add(lstvwFileDaCopiare);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(btnPiuCopia);
            splitContainer1.Panel1.Controls.Add(btnMenoCopia);
            splitContainer1.Panel1.Controls.Add(btnDeCheckAll);
            splitContainer1.Panel1.Controls.Add(btnCheckAll);
            splitContainer1.Panel1.Controls.Add(btnCartellaPerCopiare);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnCopiaStruttura);
            splitContainer1.Panel2.Controls.Add(btnCreaCartelle);
            splitContainer1.Panel2.Controls.Add(txtNuova);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(trwCartelleDaCreare);
            splitContainer1.Panel2.Controls.Add(btnPiuInizio);
            splitContainer1.Panel2.Controls.Add(btnPiuAlbero);
            splitContainer1.Panel2.Controls.Add(btnMenoAlbero);
            splitContainer1.Panel2.Controls.Add(btnPiuPiu);
            splitContainer1.Panel2.Controls.Add(btnMenoMeno);
            splitContainer1.Panel2.Controls.Add(btnDisabilitaCreare);
            splitContainer1.Panel2.Controls.Add(btnAbilitaCreare);
            splitContainer1.Panel2.Controls.Add(btnOrdina);
            splitContainer1.Size = new Size(1105, 388);
            splitContainer1.SplitterDistance = 622;
            splitContainer1.TabIndex = 74;
            // 
            // txtStringa2Da
            // 
            txtStringa2Da.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtStringa2Da.Location = new Point(0, 317);
            txtStringa2Da.Margin = new Padding(4);
            txtStringa2Da.Name = "txtStringa2Da";
            txtStringa2Da.Size = new Size(333, 23);
            txtStringa2Da.TabIndex = 8;
            txtStringa2Da.Text = "YYYY";
            // 
            // txtStringa2A
            // 
            txtStringa2A.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtStringa2A.Location = new Point(340, 317);
            txtStringa2A.Margin = new Padding(4);
            txtStringa2A.Name = "txtStringa2A";
            txtStringa2A.Size = new Size(280, 23);
            txtStringa2A.TabIndex = 9;
            // 
            // btnCheckOff
            // 
            btnCheckOff.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCheckOff.Location = new Point(66, 347);
            btnCheckOff.Margin = new Padding(4);
            btnCheckOff.Name = "btnCheckOff";
            btnCheckOff.Size = new Size(38, 24);
            btnCheckOff.TabIndex = 66;
            btnCheckOff.Text = "off";
            btnCheckOff.UseVisualStyleBackColor = true;
            btnCheckOff.Click += btnCheckOff_Click;
            // 
            // btnCheckOn
            // 
            btnCheckOn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCheckOn.Location = new Point(107, 347);
            btnCheckOn.Margin = new Padding(4);
            btnCheckOn.Name = "btnCheckOn";
            btnCheckOn.Size = new Size(38, 24);
            btnCheckOn.TabIndex = 67;
            btnCheckOn.Text = "on";
            btnCheckOn.UseVisualStyleBackColor = true;
            btnCheckOn.Click += btnCheckOn_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(340, 272);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 63;
            label7.Text = "Stringa A: ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(0, 272);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(224, 15);
            label6.TabIndex = 62;
            label6.Text = "Sostituzione durante la copia: stringa Da: ";
            // 
            // txtStringaDa
            // 
            txtStringaDa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtStringaDa.Location = new Point(0, 290);
            txtStringaDa.Margin = new Padding(4);
            txtStringaDa.Name = "txtStringaDa";
            txtStringaDa.Size = new Size(333, 23);
            txtStringaDa.TabIndex = 6;
            txtStringaDa.Text = "XXXX";
            // 
            // txtStringaA
            // 
            txtStringaA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtStringaA.Location = new Point(340, 290);
            txtStringaA.Margin = new Padding(4);
            txtStringaA.Name = "txtStringaA";
            txtStringaA.Size = new Size(280, 23);
            txtStringaA.TabIndex = 7;
            // 
            // lstvwFileDaCopiare
            // 
            lstvwFileDaCopiare.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstvwFileDaCopiare.BackColor = Color.FromArgb(200, 255, 200);
            lstvwFileDaCopiare.CheckBoxes = true;
            lstvwFileDaCopiare.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lstvwFileDaCopiare.Location = new Point(0, 19);
            lstvwFileDaCopiare.Margin = new Padding(4);
            lstvwFileDaCopiare.Name = "lstvwFileDaCopiare";
            lstvwFileDaCopiare.Size = new Size(622, 248);
            lstvwFileDaCopiare.TabIndex = 56;
            lstvwFileDaCopiare.UseCompatibleStateImageBehavior = false;
            lstvwFileDaCopiare.View = View.Details;
            lstvwFileDaCopiare.SelectedIndexChanged += lstvwFileDaCopiare_SelectedIndexChanged;
            lstvwFileDaCopiare.DoubleClick += lstvwFileDaCopiare_DoubleClick;
            lstvwFileDaCopiare.Enter += lstvwFileDaCopiare_Enter;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "File da copiare";
            columnHeader1.Width = 299;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cartella ove copiare";
            columnHeader2.Width = 253;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-4, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 54;
            label3.Text = "File da copiare";
            // 
            // btnDeCheckAll
            // 
            btnDeCheckAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeCheckAll.Location = new Point(275, 347);
            btnDeCheckAll.Margin = new Padding(4);
            btnDeCheckAll.Name = "btnDeCheckAll";
            btnDeCheckAll.Size = new Size(69, 24);
            btnDeCheckAll.TabIndex = 65;
            btnDeCheckAll.Text = "Disabilita";
            btnDeCheckAll.UseVisualStyleBackColor = true;
            btnDeCheckAll.Click += btnDeCheckAll_Click;
            // 
            // btnCheckAll
            // 
            btnCheckAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCheckAll.Location = new Point(347, 347);
            btnCheckAll.Margin = new Padding(4);
            btnCheckAll.Name = "btnCheckAll";
            btnCheckAll.Size = new Size(69, 24);
            btnCheckAll.TabIndex = 64;
            btnCheckAll.Text = "Abilita";
            btnCheckAll.UseVisualStyleBackColor = true;
            btnCheckAll.Click += btnCheckAll_Click;
            // 
            // btnCartellaPerCopiare
            // 
            btnCartellaPerCopiare.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCartellaPerCopiare.Location = new Point(419, 347);
            btnCartellaPerCopiare.Margin = new Padding(4);
            btnCartellaPerCopiare.Name = "btnCartellaPerCopiare";
            btnCartellaPerCopiare.Size = new Size(99, 24);
            btnCartellaPerCopiare.TabIndex = 55;
            btnCartellaPerCopiare.Text = "Scegli cartella";
            btnCartellaPerCopiare.UseVisualStyleBackColor = true;
            btnCartellaPerCopiare.Click += btnCartellaPerCopiare_Click;
            // 
            // btnCopiaStruttura
            // 
            btnCopiaStruttura.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCopiaStruttura.Location = new Point(285, 347);
            btnCopiaStruttura.Margin = new Padding(4);
            btnCopiaStruttura.Name = "btnCopiaStruttura";
            btnCopiaStruttura.Size = new Size(102, 24);
            btnCopiaStruttura.TabIndex = 69;
            btnCopiaStruttura.Text = "Copia struttura";
            btnCopiaStruttura.UseVisualStyleBackColor = true;
            btnCopiaStruttura.Click += btnCopiaStruttura_Click;
            // 
            // txtNuova
            // 
            txtNuova.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNuova.Location = new Point(3, 317);
            txtNuova.Margin = new Padding(4);
            txtNuova.Name = "txtNuova";
            txtNuova.Size = new Size(465, 23);
            txtNuova.TabIndex = 10;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(-1, 298);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 56;
            label5.Text = "Nome nuova cartella";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 3;
            label1.Text = "Cartelle da creare";
            // 
            // trwCartelleDaCreare
            // 
            trwCartelleDaCreare.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trwCartelleDaCreare.BackColor = Color.FromArgb(200, 255, 200);
            trwCartelleDaCreare.CheckBoxes = true;
            trwCartelleDaCreare.HideSelection = false;
            trwCartelleDaCreare.LabelEdit = true;
            trwCartelleDaCreare.Location = new Point(1, 19);
            trwCartelleDaCreare.Margin = new Padding(4);
            trwCartelleDaCreare.Name = "trwCartelleDaCreare";
            trwCartelleDaCreare.Size = new Size(468, 276);
            trwCartelleDaCreare.TabIndex = 2;
            trwCartelleDaCreare.AfterSelect += trwCartelleDaCreare_AfterSelect;
            trwCartelleDaCreare.KeyDown += trwCartelleDaCreare_KeyDown;
            // 
            // btnDisabilitaCreare
            // 
            btnDisabilitaCreare.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDisabilitaCreare.Location = new Point(210, 347);
            btnDisabilitaCreare.Margin = new Padding(4);
            btnDisabilitaCreare.Name = "btnDisabilitaCreare";
            btnDisabilitaCreare.Size = new Size(38, 24);
            btnDisabilitaCreare.TabIndex = 67;
            btnDisabilitaCreare.Text = "off";
            btnDisabilitaCreare.UseVisualStyleBackColor = true;
            btnDisabilitaCreare.Click += btnDisabilitaCreare_Click;
            // 
            // btnAbilitaCreare
            // 
            btnAbilitaCreare.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAbilitaCreare.Location = new Point(248, 347);
            btnAbilitaCreare.Margin = new Padding(4);
            btnAbilitaCreare.Name = "btnAbilitaCreare";
            btnAbilitaCreare.Size = new Size(38, 24);
            btnAbilitaCreare.TabIndex = 66;
            btnAbilitaCreare.Text = "on";
            btnAbilitaCreare.UseVisualStyleBackColor = true;
            btnAbilitaCreare.Click += btnAbilitaCreare_Click;
            // 
            // btnOrdina
            // 
            btnOrdina.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnOrdina.Location = new Point(108, 347);
            btnOrdina.Margin = new Padding(4);
            btnOrdina.Name = "btnOrdina";
            btnOrdina.Size = new Size(44, 24);
            btnOrdina.TabIndex = 68;
            btnOrdina.Text = "Ord";
            btnOrdina.UseVisualStyleBackColor = true;
            btnOrdina.Click += btnOrdina_Click;
            // 
            // btnCreaCartella
            // 
            btnCreaCartella.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreaCartella.Location = new Point(957, 117);
            btnCreaCartella.Margin = new Padding(4);
            btnCreaCartella.Name = "btnCreaCartella";
            btnCreaCartella.Size = new Size(97, 25);
            btnCreaCartella.TabIndex = 77;
            btnCreaCartella.Text = "Crea cartella";
            btnCreaCartella.UseVisualStyleBackColor = true;
            btnCreaCartella.Click += btnCreaCartella_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(235, 187);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 82;
            label9.Text = "a";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(112, 187);
            label10.Name = "label10";
            label10.Size = new Size(21, 15);
            label10.TabIndex = 81;
            label10.Text = "Da";
            // 
            // txtDiscoVecchio
            // 
            txtDiscoVecchio.Location = new Point(136, 184);
            txtDiscoVecchio.Margin = new Padding(4);
            txtDiscoVecchio.Name = "txtDiscoVecchio";
            txtDiscoVecchio.Size = new Size(92, 23);
            txtDiscoVecchio.TabIndex = 4;
            txtDiscoVecchio.MouseClick += txtDiscoVecchio_MouseClick;
            txtDiscoVecchio.Leave += txtDiscoVecchio_Leave;
            // 
            // btnCambiaDisco
            // 
            btnCambiaDisco.Location = new Point(7, 180);
            btnCambiaDisco.Margin = new Padding(4);
            btnCambiaDisco.Name = "btnCambiaDisco";
            btnCambiaDisco.Size = new Size(102, 29);
            btnCambiaDisco.TabIndex = 79;
            btnCambiaDisco.Text = "Cambia Disco";
            btnCambiaDisco.UseVisualStyleBackColor = true;
            btnCambiaDisco.Click += btnCambiaDisco_Click;
            // 
            // txtDiscoNuovo
            // 
            txtDiscoNuovo.Location = new Point(252, 184);
            txtDiscoNuovo.Margin = new Padding(4);
            txtDiscoNuovo.Name = "txtDiscoNuovo";
            txtDiscoNuovo.Size = new Size(92, 23);
            txtDiscoNuovo.TabIndex = 5;
            txtDiscoNuovo.MouseClick += txtDiscoNuovo_MouseClick;
            txtDiscoNuovo.Leave += txtDiscoNuovo_Leave;
            // 
            // grpFileConfigurazione
            // 
            grpFileConfigurazione.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpFileConfigurazione.Controls.Add(btnNuovo);
            grpFileConfigurazione.Controls.Add(btnImporta);
            grpFileConfigurazione.Controls.Add(btnEsporta);
            grpFileConfigurazione.Controls.Add(btnApriFileConfigurazione);
            grpFileConfigurazione.Controls.Add(btnSalva);
            grpFileConfigurazione.Controls.Add(btnTrovaESostituisci);
            grpFileConfigurazione.Controls.Add(btnApriFile);
            grpFileConfigurazione.Controls.Add(txtFileConfigurazione);
            grpFileConfigurazione.Controls.Add(label8);
            grpFileConfigurazione.Location = new Point(13, 10);
            grpFileConfigurazione.Name = "grpFileConfigurazione";
            grpFileConfigurazione.Size = new Size(898, 101);
            grpFileConfigurazione.TabIndex = 83;
            grpFileConfigurazione.TabStop = false;
            grpFileConfigurazione.Text = "Operazioni sui file di configurazione  del programma";
            // 
            // frmMakeAllDirs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1110, 595);
            Controls.Add(grpFileConfigurazione);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtDiscoVecchio);
            Controls.Add(btnCambiaDisco);
            Controls.Add(txtDiscoNuovo);
            Controls.Add(btnCreaCartella);
            Controls.Add(splitContainer1);
            Controls.Add(btnCreaECopia);
            Controls.Add(btnLaunchAll);
            Controls.Add(txtEdit);
            Controls.Add(btnCartellaCopia);
            Controls.Add(btnCartellaRoot);
            Controls.Add(txtCartellaCopia);
            Controls.Add(label4);
            Controls.Add(txtRootDir);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmMakeAllDirs";
            Text = "MakeAllDirs: crea cartelle e copia files";
            Load += frmMakeAllDirs_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            grpFileConfigurazione.ResumeLayout(false);
            grpFileConfigurazione.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtRootDir;
        private System.Windows.Forms.Button btnCreaECopia;
        public System.Windows.Forms.TextBox txtCartellaCopia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMenoCopia;
        private System.Windows.Forms.Button btnPiuCopia;
        private System.Windows.Forms.Button btnCreaCartelle;
        private System.Windows.Forms.Button btnMenoAlbero;
        private System.Windows.Forms.Button btnPiuAlbero;
        private System.Windows.Forms.Button btnCartellaRoot;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnCartellaCopia;
        private System.Windows.Forms.OpenFileDialog opfilScelta;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.Button btnPiuInizio;
        private System.Windows.Forms.Button btnCopia;
        private System.Windows.Forms.Button btnMenoMeno;
        private System.Windows.Forms.Button btnPiuPiu;
        private System.Windows.Forms.Button btnLaunchAll;
        private System.Windows.Forms.Button btnNuovo;
        private System.Windows.Forms.Button btnApriFile;
        private System.Windows.Forms.Button btnTrovaESostituisci;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnApriFileConfigurazione;
        private System.Windows.Forms.Button btnEsporta;
        private System.Windows.Forms.Button btnImporta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFileConfigurazione;
        private System.Windows.Forms.SaveFileDialog svfilConfigurazione;
        private System.Windows.Forms.OpenFileDialog opfilConfigurazione;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.ListView lstvwFileDaCopiare;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnCartellaPerCopiare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TreeView trwCartelleDaCreare;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNuova;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeCheckAll;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnDisabilitaCreare;
        private System.Windows.Forms.Button btnAbilitaCreare;
        private System.Windows.Forms.Button btnCheckOff;
        private System.Windows.Forms.Button btnCheckOn;
        private System.Windows.Forms.Button btnCreaCartella;
        private System.Windows.Forms.TextBox txtStringa2Da;
        private System.Windows.Forms.TextBox txtStringa2A;
        private System.Windows.Forms.TextBox txtStringaDa;
        private System.Windows.Forms.TextBox txtStringaA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiscoVecchio;
        private System.Windows.Forms.Button btnCambiaDisco;
        private System.Windows.Forms.TextBox txtDiscoNuovo;
        private System.Windows.Forms.Button btnOrdina;
        private Button btnCopiaStruttura;
        private GroupBox grpFileConfigurazione;
    }
}