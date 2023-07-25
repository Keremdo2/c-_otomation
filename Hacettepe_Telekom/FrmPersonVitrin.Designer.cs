namespace Hacettepe_Telekom
{
    partial class FrmPersonVitrin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonVitrin));
            this.btnVitrinSell = new DevExpress.XtraEditors.SimpleButton();
            this.rtxtVitrinAciklama = new System.Windows.Forms.RichTextBox();
            this.txtVitrinFiyat = new System.Windows.Forms.TextBox();
            this.cmbVitrinRam = new System.Windows.Forms.ComboBox();
            this.cmbVitrinHafiza = new System.Windows.Forms.ComboBox();
            this.cmbVitrinModel = new System.Windows.Forms.ComboBox();
            this.cmbVitrinMarka = new System.Windows.Forms.ComboBox();
            this.txtVitrinId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMusteriTel = new System.Windows.Forms.Label();
            this.lblMusteriTC = new System.Windows.Forms.Label();
            this.lblMusteriSoyad = new System.Windows.Forms.Label();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.btnVitrinGeri = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.hacettepe_TelekomDataSet1 = new Hacettepe_Telekom.Hacettepe_TelekomDataSet1();
            this.tblvitrinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunmarkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunhafizaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunaciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblvitrinBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hacettepeTelekomDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_vitrinTableAdapter = new Hacettepe_Telekom.Hacettepe_TelekomDataSet1TableAdapters.tbl_vitrinTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVitrinMusteriAd = new System.Windows.Forms.TextBox();
            this.txtVitrinMusteriSoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.mtxtVitrinMusteriEmail = new System.Windows.Forms.MaskedTextBox();
            this.mtxtVitrinMusteriTC = new System.Windows.Forms.MaskedTextBox();
            this.mtxtVitrinMusteriTel = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hacettepe_TelekomDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblvitrinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblvitrinBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hacettepeTelekomDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVitrinSell
            // 
            this.btnVitrinSell.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVitrinSell.Appearance.Options.UseFont = true;
            this.btnVitrinSell.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVitrinSell.ImageOptions.Image")));
            this.btnVitrinSell.Location = new System.Drawing.Point(122, 544);
            this.btnVitrinSell.Name = "btnVitrinSell";
            this.btnVitrinSell.Size = new System.Drawing.Size(164, 33);
            this.btnVitrinSell.TabIndex = 25;
            this.btnVitrinSell.Text = "ÇIKAR";
            this.btnVitrinSell.Click += new System.EventHandler(this.btnVitrinSell_Click);
            // 
            // rtxtVitrinAciklama
            // 
            this.rtxtVitrinAciklama.Location = new System.Drawing.Point(122, 390);
            this.rtxtVitrinAciklama.Name = "rtxtVitrinAciklama";
            this.rtxtVitrinAciklama.Size = new System.Drawing.Size(164, 136);
            this.rtxtVitrinAciklama.TabIndex = 19;
            this.rtxtVitrinAciklama.Text = "";
            // 
            // txtVitrinFiyat
            // 
            this.txtVitrinFiyat.Location = new System.Drawing.Point(122, 334);
            this.txtVitrinFiyat.Name = "txtVitrinFiyat";
            this.txtVitrinFiyat.Size = new System.Drawing.Size(164, 30);
            this.txtVitrinFiyat.TabIndex = 18;
            // 
            // cmbVitrinRam
            // 
            this.cmbVitrinRam.FormattingEnabled = true;
            this.cmbVitrinRam.Location = new System.Drawing.Point(122, 277);
            this.cmbVitrinRam.Name = "cmbVitrinRam";
            this.cmbVitrinRam.Size = new System.Drawing.Size(164, 33);
            this.cmbVitrinRam.TabIndex = 17;
            // 
            // cmbVitrinHafiza
            // 
            this.cmbVitrinHafiza.FormattingEnabled = true;
            this.cmbVitrinHafiza.Location = new System.Drawing.Point(122, 222);
            this.cmbVitrinHafiza.Name = "cmbVitrinHafiza";
            this.cmbVitrinHafiza.Size = new System.Drawing.Size(164, 33);
            this.cmbVitrinHafiza.TabIndex = 16;
            // 
            // cmbVitrinModel
            // 
            this.cmbVitrinModel.FormattingEnabled = true;
            this.cmbVitrinModel.Location = new System.Drawing.Point(122, 173);
            this.cmbVitrinModel.Name = "cmbVitrinModel";
            this.cmbVitrinModel.Size = new System.Drawing.Size(164, 33);
            this.cmbVitrinModel.TabIndex = 15;
           // this.cmbVitrinModel.SelectedIndexChanged += new System.EventHandler(this.cmbVitrinModel_SelectedIndexChanged);
            // 
            // cmbVitrinMarka
            // 
            this.cmbVitrinMarka.FormattingEnabled = true;
            this.cmbVitrinMarka.Location = new System.Drawing.Point(122, 123);
            this.cmbVitrinMarka.Name = "cmbVitrinMarka";
            this.cmbVitrinMarka.Size = new System.Drawing.Size(164, 33);
            this.cmbVitrinMarka.TabIndex = 14;
            this.cmbVitrinMarka.SelectedIndexChanged += new System.EventHandler(this.cmbVitrinMarka_SelectedIndexChanged);
            // 
            // txtVitrinId
            // 
            this.txtVitrinId.Location = new System.Drawing.Point(122, 80);
            this.txtVitrinId.Name = "txtVitrinId";
            this.txtVitrinId.Size = new System.Drawing.Size(164, 30);
            this.txtVitrinId.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Açıklama:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fiyat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ram:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hafıza:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblMusteriTel);
            this.panel1.Controls.Add(this.lblMusteriTC);
            this.panel1.Controls.Add(this.lblMusteriSoyad);
            this.panel1.Controls.Add(this.lblMusteriAd);
            this.panel1.Controls.Add(this.btnVitrinGeri);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnVitrinSell);
            this.panel1.Controls.Add(this.rtxtVitrinAciklama);
            this.panel1.Controls.Add(this.txtVitrinFiyat);
            this.panel1.Controls.Add(this.cmbVitrinRam);
            this.panel1.Controls.Add(this.cmbVitrinHafiza);
            this.panel1.Controls.Add(this.cmbVitrinModel);
            this.panel1.Controls.Add(this.cmbVitrinMarka);
            this.panel1.Controls.Add(this.txtVitrinId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 641);
            this.panel1.TabIndex = 3;
            // 
            // lblMusteriTel
            // 
            this.lblMusteriTel.AutoSize = true;
            this.lblMusteriTel.Location = new System.Drawing.Point(9, 593);
            this.lblMusteriTel.Name = "lblMusteriTel";
            this.lblMusteriTel.Size = new System.Drawing.Size(37, 25);
            this.lblMusteriTel.TabIndex = 30;
            this.lblMusteriTel.Text = "ID:";
            this.lblMusteriTel.Visible = false;
            // 
            // lblMusteriTC
            // 
            this.lblMusteriTC.AutoSize = true;
            this.lblMusteriTC.Location = new System.Drawing.Point(9, 549);
            this.lblMusteriTC.Name = "lblMusteriTC";
            this.lblMusteriTC.Size = new System.Drawing.Size(37, 25);
            this.lblMusteriTC.TabIndex = 29;
            this.lblMusteriTC.Text = "ID:";
            this.lblMusteriTC.Visible = false;
            // 
            // lblMusteriSoyad
            // 
            this.lblMusteriSoyad.AutoSize = true;
            this.lblMusteriSoyad.Location = new System.Drawing.Point(9, 501);
            this.lblMusteriSoyad.Name = "lblMusteriSoyad";
            this.lblMusteriSoyad.Size = new System.Drawing.Size(37, 25);
            this.lblMusteriSoyad.TabIndex = 28;
            this.lblMusteriSoyad.Text = "ID:";
            this.lblMusteriSoyad.Visible = false;
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Location = new System.Drawing.Point(9, 453);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(37, 25);
            this.lblMusteriAd.TabIndex = 27;
            this.lblMusteriAd.Text = "ID:";
            this.lblMusteriAd.Visible = false;
            // 
            // btnVitrinGeri
            // 
            this.btnVitrinGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVitrinGeri.Location = new System.Drawing.Point(3, 3);
            this.btnVitrinGeri.Name = "btnVitrinGeri";
            this.btnVitrinGeri.Size = new System.Drawing.Size(67, 52);
            this.btnVitrinGeri.TabIndex = 26;
            this.btnVitrinGeri.Text = "<";
            this.btnVitrinGeri.UseVisualStyleBackColor = true;
            this.btnVitrinGeri.Click += new System.EventHandler(this.btnVitrinGeri_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(98, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 43);
            this.label8.TabIndex = 24;
            this.label8.Text = "VİTRİN";
            // 
            // hacettepe_TelekomDataSet1
            // 
            this.hacettepe_TelekomDataSet1.DataSetName = "Hacettepe_TelekomDataSet1";
            this.hacettepe_TelekomDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblvitrinBindingSource
            // 
            this.tblvitrinBindingSource.DataMember = "tbl_vitrin";
            this.tblvitrinBindingSource.DataSource = this.hacettepe_TelekomDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunidDataGridViewTextBoxColumn,
            this.urunmarkaDataGridViewTextBoxColumn,
            this.urunmodelDataGridViewTextBoxColumn,
            this.urunhafizaDataGridViewTextBoxColumn,
            this.urunramDataGridViewTextBoxColumn,
            this.urunfiyatDataGridViewTextBoxColumn,
            this.urunaciklamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblvitrinBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(342, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(930, 380);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // urunidDataGridViewTextBoxColumn
            // 
            this.urunidDataGridViewTextBoxColumn.DataPropertyName = "urun_id";
            this.urunidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.urunidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunidDataGridViewTextBoxColumn.Name = "urunidDataGridViewTextBoxColumn";
            this.urunidDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunidDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunmarkaDataGridViewTextBoxColumn
            // 
            this.urunmarkaDataGridViewTextBoxColumn.DataPropertyName = "urun_marka";
            this.urunmarkaDataGridViewTextBoxColumn.HeaderText = "MARKA";
            this.urunmarkaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunmarkaDataGridViewTextBoxColumn.Name = "urunmarkaDataGridViewTextBoxColumn";
            this.urunmarkaDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunmodelDataGridViewTextBoxColumn
            // 
            this.urunmodelDataGridViewTextBoxColumn.DataPropertyName = "urun_model";
            this.urunmodelDataGridViewTextBoxColumn.HeaderText = "MODEL";
            this.urunmodelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunmodelDataGridViewTextBoxColumn.Name = "urunmodelDataGridViewTextBoxColumn";
            this.urunmodelDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunhafizaDataGridViewTextBoxColumn
            // 
            this.urunhafizaDataGridViewTextBoxColumn.DataPropertyName = "urun_hafiza";
            this.urunhafizaDataGridViewTextBoxColumn.HeaderText = "HAFIZA";
            this.urunhafizaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunhafizaDataGridViewTextBoxColumn.Name = "urunhafizaDataGridViewTextBoxColumn";
            this.urunhafizaDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunramDataGridViewTextBoxColumn
            // 
            this.urunramDataGridViewTextBoxColumn.DataPropertyName = "urun_ram";
            this.urunramDataGridViewTextBoxColumn.HeaderText = "RAM";
            this.urunramDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunramDataGridViewTextBoxColumn.Name = "urunramDataGridViewTextBoxColumn";
            this.urunramDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunfiyatDataGridViewTextBoxColumn
            // 
            this.urunfiyatDataGridViewTextBoxColumn.DataPropertyName = "urun_fiyat";
            this.urunfiyatDataGridViewTextBoxColumn.HeaderText = "FİYAT";
            this.urunfiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunfiyatDataGridViewTextBoxColumn.Name = "urunfiyatDataGridViewTextBoxColumn";
            this.urunfiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunaciklamaDataGridViewTextBoxColumn
            // 
            this.urunaciklamaDataGridViewTextBoxColumn.DataPropertyName = "urun_aciklama";
            this.urunaciklamaDataGridViewTextBoxColumn.HeaderText = "AÇIKLAMA";
            this.urunaciklamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunaciklamaDataGridViewTextBoxColumn.Name = "urunaciklamaDataGridViewTextBoxColumn";
            this.urunaciklamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblvitrinBindingSource1
            // 
            this.tblvitrinBindingSource1.DataMember = "tbl_vitrin";
            this.tblvitrinBindingSource1.DataSource = this.hacettepeTelekomDataSet1BindingSource;
            // 
            // hacettepeTelekomDataSet1BindingSource
            // 
            this.hacettepeTelekomDataSet1BindingSource.DataSource = this.hacettepe_TelekomDataSet1;
            this.hacettepeTelekomDataSet1BindingSource.Position = 0;
            // 
            // tbl_vitrinTableAdapter
            // 
            this.tbl_vitrinTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Ad:";
            // 
            // txtVitrinMusteriAd
            // 
            this.txtVitrinMusteriAd.Location = new System.Drawing.Point(470, 392);
            this.txtVitrinMusteriAd.Name = "txtVitrinMusteriAd";
            this.txtVitrinMusteriAd.Size = new System.Drawing.Size(164, 30);
            this.txtVitrinMusteriAd.TabIndex = 20;
            // 
            // txtVitrinMusteriSoyad
            // 
            this.txtVitrinMusteriSoyad.Location = new System.Drawing.Point(470, 450);
            this.txtVitrinMusteriSoyad.Name = "txtVitrinMusteriSoyad";
            this.txtVitrinMusteriSoyad.Size = new System.Drawing.Size(164, 30);
            this.txtVitrinMusteriSoyad.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 25);
            this.label10.TabIndex = 29;
            this.label10.Text = "Soyad :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352, 513);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "E-Posta :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(352, 567);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 25);
            this.label12.TabIndex = 33;
            this.label12.Text = "TC :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(352, 619);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 25);
            this.label13.TabIndex = 35;
            this.label13.Text = "Telefon :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(982, 595);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(290, 46);
            this.label14.TabIndex = 36;
            this.label14.Text = "Müşteri Bilgileri";
            // 
            // mtxtVitrinMusteriEmail
            // 
            this.mtxtVitrinMusteriEmail.Location = new System.Drawing.Point(470, 508);
            this.mtxtVitrinMusteriEmail.Name = "mtxtVitrinMusteriEmail";
            this.mtxtVitrinMusteriEmail.Size = new System.Drawing.Size(164, 30);
            this.mtxtVitrinMusteriEmail.TabIndex = 22;
            // 
            // mtxtVitrinMusteriTC
            // 
            this.mtxtVitrinMusteriTC.Location = new System.Drawing.Point(470, 562);
            this.mtxtVitrinMusteriTC.Mask = "00000000000";
            this.mtxtVitrinMusteriTC.Name = "mtxtVitrinMusteriTC";
            this.mtxtVitrinMusteriTC.Size = new System.Drawing.Size(164, 30);
            this.mtxtVitrinMusteriTC.TabIndex = 23;
            this.mtxtVitrinMusteriTC.ValidatingType = typeof(int);
            // 
            // mtxtVitrinMusteriTel
            // 
            this.mtxtVitrinMusteriTel.Location = new System.Drawing.Point(470, 613);
            this.mtxtVitrinMusteriTel.Mask = "00000000000";
            this.mtxtVitrinMusteriTel.Name = "mtxtVitrinMusteriTel";
            this.mtxtVitrinMusteriTel.Size = new System.Drawing.Size(164, 30);
            this.mtxtVitrinMusteriTel.TabIndex = 24;
            this.mtxtVitrinMusteriTel.ValidatingType = typeof(int);
            // 
            // FrmPersonVitrin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1275, 659);
            this.Controls.Add(this.mtxtVitrinMusteriTel);
            this.Controls.Add(this.mtxtVitrinMusteriTC);
            this.Controls.Add(this.mtxtVitrinMusteriEmail);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtVitrinMusteriSoyad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVitrinMusteriAd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPersonVitrin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonVitrin";
            this.Load += new System.EventHandler(this.FrmPersonVitrin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hacettepe_TelekomDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblvitrinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblvitrinBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hacettepeTelekomDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnVitrinSell;
        private System.Windows.Forms.RichTextBox rtxtVitrinAciklama;
        private System.Windows.Forms.TextBox txtVitrinFiyat;
        private System.Windows.Forms.ComboBox cmbVitrinRam;
        private System.Windows.Forms.ComboBox cmbVitrinHafiza;
        private System.Windows.Forms.ComboBox cmbVitrinModel;
        private System.Windows.Forms.ComboBox cmbVitrinMarka;
        private System.Windows.Forms.TextBox txtVitrinId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource tblvitrinBindingSource;
        private Hacettepe_TelekomDataSet1 hacettepe_TelekomDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hacettepeTelekomDataSet1BindingSource;
        private System.Windows.Forms.BindingSource tblvitrinBindingSource1;
        private Hacettepe_TelekomDataSet1TableAdapters.tbl_vitrinTableAdapter tbl_vitrinTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunmarkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunhafizaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunaciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnVitrinGeri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVitrinMusteriAd;
        private System.Windows.Forms.TextBox txtVitrinMusteriSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mtxtVitrinMusteriEmail;
        private System.Windows.Forms.MaskedTextBox mtxtVitrinMusteriTC;
        private System.Windows.Forms.MaskedTextBox mtxtVitrinMusteriTel;
        private System.Windows.Forms.Label lblMusteriTC;
        private System.Windows.Forms.Label lblMusteriSoyad;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.Label lblMusteriTel;
    }
}