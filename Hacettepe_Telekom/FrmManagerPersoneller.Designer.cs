namespace Hacettepe_Telekom
{
    partial class FrmManagerPersoneller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManagerPersoneller));
            this.cmbPersonelBirim = new System.Windows.Forms.ComboBox();
            this.mtxtPersonelTC = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPersonelTel = new System.Windows.Forms.MaskedTextBox();
            this.btnPersonelSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtPersonelMaas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPersonelSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtPersonelSifre = new System.Windows.Forms.TextBox();
            this.txtPersonelKadi = new System.Windows.Forms.TextBox();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPersonelId = new System.Windows.Forms.TextBox();
            this.btnGeriGel = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeladDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelsifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelmaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelkadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeltelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelbolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblpersonellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hacettepe_TelekomDataSet3 = new Hacettepe_Telekom.Hacettepe_TelekomDataSet3();
            this.tbl_personellerTableAdapter = new Hacettepe_Telekom.Hacettepe_TelekomDataSet3TableAdapters.tbl_personellerTableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonellerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hacettepe_TelekomDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPersonelBirim
            // 
            this.cmbPersonelBirim.FormattingEnabled = true;
            this.cmbPersonelBirim.Location = new System.Drawing.Point(154, 190);
            this.cmbPersonelBirim.Name = "cmbPersonelBirim";
            this.cmbPersonelBirim.Size = new System.Drawing.Size(155, 33);
            this.cmbPersonelBirim.TabIndex = 23;
            // 
            // mtxtPersonelTC
            // 
            this.mtxtPersonelTC.Location = new System.Drawing.Point(154, 249);
            this.mtxtPersonelTC.Mask = "00000000000";
            this.mtxtPersonelTC.Name = "mtxtPersonelTC";
            this.mtxtPersonelTC.Size = new System.Drawing.Size(155, 30);
            this.mtxtPersonelTC.TabIndex = 25;
            this.mtxtPersonelTC.ValidatingType = typeof(int);
            // 
            // mtxtPersonelTel
            // 
            this.mtxtPersonelTel.Location = new System.Drawing.Point(154, 307);
            this.mtxtPersonelTel.Mask = "00000000000";
            this.mtxtPersonelTel.Name = "mtxtPersonelTel";
            this.mtxtPersonelTel.Size = new System.Drawing.Size(155, 30);
            this.mtxtPersonelTel.TabIndex = 26;
            this.mtxtPersonelTel.ValidatingType = typeof(int);
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelSil.ImageOptions.Image")));
            this.btnPersonelSil.Location = new System.Drawing.Point(189, 570);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(114, 47);
            this.btnPersonelSil.TabIndex = 34;
            this.btnPersonelSil.Text = "SİL";
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // txtPersonelMaas
            // 
            this.txtPersonelMaas.Location = new System.Drawing.Point(154, 515);
            this.txtPersonelMaas.Name = "txtPersonelMaas";
            this.txtPersonelMaas.Size = new System.Drawing.Size(155, 30);
            this.txtPersonelMaas.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 525);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "Maaş:";
            // 
            // txtPersonelSifreTekrar
            // 
            this.txtPersonelSifreTekrar.Location = new System.Drawing.Point(154, 465);
            this.txtPersonelSifreTekrar.Name = "txtPersonelSifreTekrar";
            this.txtPersonelSifreTekrar.Size = new System.Drawing.Size(113, 30);
            this.txtPersonelSifreTekrar.TabIndex = 32;
            this.txtPersonelSifreTekrar.UseSystemPasswordChar = true;
            // 
            // txtPersonelSifre
            // 
            this.txtPersonelSifre.Location = new System.Drawing.Point(154, 410);
            this.txtPersonelSifre.Name = "txtPersonelSifre";
            this.txtPersonelSifre.Size = new System.Drawing.Size(113, 30);
            this.txtPersonelSifre.TabIndex = 30;
            this.txtPersonelSifre.UseSystemPasswordChar = true;
            // 
            // txtPersonelKadi
            // 
            this.txtPersonelKadi.Location = new System.Drawing.Point(154, 353);
            this.txtPersonelKadi.Name = "txtPersonelKadi";
            this.txtPersonelKadi.Size = new System.Drawing.Size(155, 30);
            this.txtPersonelKadi.TabIndex = 28;
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Location = new System.Drawing.Point(154, 130);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(155, 30);
            this.txtPersonelSoyad.TabIndex = 21;
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(154, 78);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(155, 30);
            this.txtPersonelAd.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Şifre Tekrar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Kullanıcı Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "TC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Birim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Soy isim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "İsim:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtPersonelId);
            this.panel1.Controls.Add(this.btnGeriGel);
            this.panel1.Controls.Add(this.btnPersonelGuncelle);
            this.panel1.Controls.Add(this.btnPersonelKaydet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbPersonelBirim);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mtxtPersonelTC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mtxtPersonelTel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnPersonelSil);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPersonelMaas);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPersonelSifreTekrar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtPersonelSifre);
            this.panel1.Controls.Add(this.txtPersonelAd);
            this.panel1.Controls.Add(this.txtPersonelKadi);
            this.panel1.Controls.Add(this.txtPersonelSoyad);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 703);
            this.panel1.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 25);
            this.label10.TabIndex = 39;
            this.label10.Text = "ID:";
            // 
            // txtPersonelId
            // 
            this.txtPersonelId.Location = new System.Drawing.Point(154, 28);
            this.txtPersonelId.Name = "txtPersonelId";
            this.txtPersonelId.Size = new System.Drawing.Size(155, 30);
            this.txtPersonelId.TabIndex = 40;
            // 
            // btnGeriGel
            // 
            this.btnGeriGel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGeriGel.ImageOptions.Image")));
            this.btnGeriGel.Location = new System.Drawing.Point(189, 644);
            this.btnGeriGel.Name = "btnGeriGel";
            this.btnGeriGel.Size = new System.Drawing.Size(114, 47);
            this.btnGeriGel.TabIndex = 38;
            this.btnGeriGel.Text = "GERİ GEL";
            this.btnGeriGel.Click += new System.EventHandler(this.btnGeriGel_Click);
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPersonelGuncelle.ImageOptions.SvgImage")));
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(25, 644);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(114, 47);
            this.btnPersonelGuncelle.TabIndex = 37;
            this.btnPersonelGuncelle.Text = "GÜNCELLE";
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // btnPersonelKaydet
            // 
            this.btnPersonelKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelKaydet.ImageOptions.Image")));
            this.btnPersonelKaydet.Location = new System.Drawing.Point(25, 570);
            this.btnPersonelKaydet.Name = "btnPersonelKaydet";
            this.btnPersonelKaydet.Size = new System.Drawing.Size(114, 47);
            this.btnPersonelKaydet.TabIndex = 36;
            this.btnPersonelKaydet.Text = "KAYDET";
            this.btnPersonelKaydet.Click += new System.EventHandler(this.btnPersonelKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.personeladDataGridViewTextBoxColumn,
            this.personelsoyadDataGridViewTextBoxColumn,
            this.personelsifreDataGridViewTextBoxColumn,
            this.personelmaasDataGridViewTextBoxColumn,
            this.personelkadiDataGridViewTextBoxColumn,
            this.personelTCDataGridViewTextBoxColumn,
            this.personeltelefonDataGridViewTextBoxColumn,
            this.personelbolumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblpersonellerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(332, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1178, 703);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "personel_id";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.personelidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelidDataGridViewTextBoxColumn.Width = 125;
            // 
            // personeladDataGridViewTextBoxColumn
            // 
            this.personeladDataGridViewTextBoxColumn.DataPropertyName = "personel_ad";
            this.personeladDataGridViewTextBoxColumn.HeaderText = "AD";
            this.personeladDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personeladDataGridViewTextBoxColumn.Name = "personeladDataGridViewTextBoxColumn";
            this.personeladDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelsoyadDataGridViewTextBoxColumn
            // 
            this.personelsoyadDataGridViewTextBoxColumn.DataPropertyName = "personel_soyad";
            this.personelsoyadDataGridViewTextBoxColumn.HeaderText = "SOYAD";
            this.personelsoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelsoyadDataGridViewTextBoxColumn.Name = "personelsoyadDataGridViewTextBoxColumn";
            this.personelsoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelsifreDataGridViewTextBoxColumn
            // 
            this.personelsifreDataGridViewTextBoxColumn.DataPropertyName = "personel_sifre";
            this.personelsifreDataGridViewTextBoxColumn.HeaderText = "ŞİFRE";
            this.personelsifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelsifreDataGridViewTextBoxColumn.Name = "personelsifreDataGridViewTextBoxColumn";
            this.personelsifreDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelmaasDataGridViewTextBoxColumn
            // 
            this.personelmaasDataGridViewTextBoxColumn.DataPropertyName = "personel_maas";
            this.personelmaasDataGridViewTextBoxColumn.HeaderText = "MAAŞ";
            this.personelmaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelmaasDataGridViewTextBoxColumn.Name = "personelmaasDataGridViewTextBoxColumn";
            this.personelmaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelkadiDataGridViewTextBoxColumn
            // 
            this.personelkadiDataGridViewTextBoxColumn.DataPropertyName = "Personel_kadi";
            this.personelkadiDataGridViewTextBoxColumn.HeaderText = "K.ADİ";
            this.personelkadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelkadiDataGridViewTextBoxColumn.Name = "personelkadiDataGridViewTextBoxColumn";
            this.personelkadiDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelTCDataGridViewTextBoxColumn
            // 
            this.personelTCDataGridViewTextBoxColumn.DataPropertyName = "Personel_TC";
            this.personelTCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.personelTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelTCDataGridViewTextBoxColumn.Name = "personelTCDataGridViewTextBoxColumn";
            this.personelTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // personeltelefonDataGridViewTextBoxColumn
            // 
            this.personeltelefonDataGridViewTextBoxColumn.DataPropertyName = "Personel_telefon";
            this.personeltelefonDataGridViewTextBoxColumn.HeaderText = "TELEFON";
            this.personeltelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personeltelefonDataGridViewTextBoxColumn.Name = "personeltelefonDataGridViewTextBoxColumn";
            this.personeltelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelbolumDataGridViewTextBoxColumn
            // 
            this.personelbolumDataGridViewTextBoxColumn.DataPropertyName = "personel_bolum";
            this.personelbolumDataGridViewTextBoxColumn.HeaderText = "BİRİM";
            this.personelbolumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelbolumDataGridViewTextBoxColumn.Name = "personelbolumDataGridViewTextBoxColumn";
            this.personelbolumDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblpersonellerBindingSource
            // 
            this.tblpersonellerBindingSource.DataMember = "tbl_personeller";
            this.tblpersonellerBindingSource.DataSource = this.hacettepe_TelekomDataSet3;
            // 
            // hacettepe_TelekomDataSet3
            // 
            this.hacettepe_TelekomDataSet3.DataSetName = "Hacettepe_TelekomDataSet3";
            this.hacettepe_TelekomDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_personellerTableAdapter
            // 
            this.tbl_personellerTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(273, 410);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(36, 29);
            this.simpleButton1.TabIndex = 41;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(273, 465);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(36, 29);
            this.simpleButton2.TabIndex = 42;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // FrmManagerPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1515, 710);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmManagerPersoneller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManagerPersoneller";
            this.Load += new System.EventHandler(this.FrmManagerPersoneller_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonellerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hacettepe_TelekomDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPersonelBirim;
        private System.Windows.Forms.MaskedTextBox mtxtPersonelTC;
        private System.Windows.Forms.MaskedTextBox mtxtPersonelTel;
        private DevExpress.XtraEditors.SimpleButton btnPersonelSil;
        private System.Windows.Forms.TextBox txtPersonelMaas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPersonelSifreTekrar;
        private System.Windows.Forms.TextBox txtPersonelSifre;
        private System.Windows.Forms.TextBox txtPersonelKadi;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Hacettepe_TelekomDataSet3 hacettepe_TelekomDataSet3;
        private System.Windows.Forms.BindingSource tblpersonellerBindingSource;
        private Hacettepe_TelekomDataSet3TableAdapters.tbl_personellerTableAdapter tbl_personellerTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnGeriGel;
        private DevExpress.XtraEditors.SimpleButton btnPersonelGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnPersonelKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personeladDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelsifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelmaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelkadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personeltelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelbolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPersonelId;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}