namespace Hacettepe_Telekom
{
    partial class FrmPersonStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonStok));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStokGeri = new System.Windows.Forms.Button();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStokVitrin = new DevExpress.XtraEditors.SimpleButton();
            this.btnStokDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnStokAdd = new DevExpress.XtraEditors.SimpleButton();
            this.RtxtStokAciklama = new System.Windows.Forms.RichTextBox();
            this.txtStokFiyat = new System.Windows.Forms.TextBox();
            this.cmbStokRam = new System.Windows.Forms.ComboBox();
            this.cmbStokHafiza = new System.Windows.Forms.ComboBox();
            this.cmbStokModel = new System.Windows.Forms.ComboBox();
            this.cmbStokMarka = new System.Windows.Forms.ComboBox();
            this.txtstokid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunmarkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunhafizaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunaciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblurunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hacettepe_TelekomDataSet = new Hacettepe_Telekom.Hacettepe_TelekomDataSet();
            this.tbl_urunlerTableAdapter = new Hacettepe_Telekom.Hacettepe_TelekomDataSetTableAdapters.tbl_urunlerTableAdapter();
            this.tbl_vitrinTableAdapter = new Hacettepe_Telekom.Hacettepe_TelekomDataSet1TableAdapters.tbl_vitrinTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblurunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hacettepe_TelekomDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStokGeri);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnStokVitrin);
            this.panel1.Controls.Add(this.btnStokDelete);
            this.panel1.Controls.Add(this.btnStokAdd);
            this.panel1.Controls.Add(this.RtxtStokAciklama);
            this.panel1.Controls.Add(this.txtStokFiyat);
            this.panel1.Controls.Add(this.cmbStokRam);
            this.panel1.Controls.Add(this.cmbStokHafiza);
            this.panel1.Controls.Add(this.cmbStokModel);
            this.panel1.Controls.Add(this.cmbStokMarka);
            this.panel1.Controls.Add(this.txtstokid);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 641);
            this.panel1.TabIndex = 1;
            // 
            // btnStokGeri
            // 
            this.btnStokGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStokGeri.Location = new System.Drawing.Point(3, 3);
            this.btnStokGeri.Name = "btnStokGeri";
            this.btnStokGeri.Size = new System.Drawing.Size(67, 52);
            this.btnStokGeri.TabIndex = 25;
            this.btnStokGeri.Text = "<";
            this.btnStokGeri.UseVisualStyleBackColor = true;
            this.btnStokGeri.Click += new System.EventHandler(this.btnStokGeri_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(175, 588);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(143, 33);
            this.simpleButton1.TabIndex = 24;
            this.simpleButton1.Text = "GÜNCELLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(101, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 43);
            this.label8.TabIndex = 23;
            this.label8.Text = "STOK";
            // 
            // btnStokVitrin
            // 
            this.btnStokVitrin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStokVitrin.Appearance.Options.UseFont = true;
            this.btnStokVitrin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStokVitrin.ImageOptions.Image")));
            this.btnStokVitrin.Location = new System.Drawing.Point(14, 588);
            this.btnStokVitrin.Name = "btnStokVitrin";
            this.btnStokVitrin.Size = new System.Drawing.Size(143, 33);
            this.btnStokVitrin.TabIndex = 9;
            this.btnStokVitrin.Text = "VİTRİN";
            this.btnStokVitrin.Click += new System.EventHandler(this.btnStokVitrin_Click);
            // 
            // btnStokDelete
            // 
            this.btnStokDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStokDelete.Appearance.Options.UseFont = true;
            this.btnStokDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStokDelete.ImageOptions.Image")));
            this.btnStokDelete.Location = new System.Drawing.Point(175, 532);
            this.btnStokDelete.Name = "btnStokDelete";
            this.btnStokDelete.Size = new System.Drawing.Size(143, 33);
            this.btnStokDelete.TabIndex = 8;
            this.btnStokDelete.Text = "SİL";
            this.btnStokDelete.Click += new System.EventHandler(this.btnStokDelete_Click);
            // 
            // btnStokAdd
            // 
            this.btnStokAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStokAdd.Appearance.Options.UseFont = true;
            this.btnStokAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStokAdd.ImageOptions.Image")));
            this.btnStokAdd.Location = new System.Drawing.Point(14, 532);
            this.btnStokAdd.Name = "btnStokAdd";
            this.btnStokAdd.Size = new System.Drawing.Size(143, 33);
            this.btnStokAdd.TabIndex = 7;
            this.btnStokAdd.Text = "EKLE";
            this.btnStokAdd.Click += new System.EventHandler(this.btnStokAdd_Click);
            // 
            // RtxtStokAciklama
            // 
            this.RtxtStokAciklama.Location = new System.Drawing.Point(122, 390);
            this.RtxtStokAciklama.Name = "RtxtStokAciklama";
            this.RtxtStokAciklama.Size = new System.Drawing.Size(164, 136);
            this.RtxtStokAciklama.TabIndex = 6;
            this.RtxtStokAciklama.Text = "";
            // 
            // txtStokFiyat
            // 
            this.txtStokFiyat.Location = new System.Drawing.Point(122, 334);
            this.txtStokFiyat.Name = "txtStokFiyat";
            this.txtStokFiyat.Size = new System.Drawing.Size(164, 30);
            this.txtStokFiyat.TabIndex = 5;
            // 
            // cmbStokRam
            // 
            this.cmbStokRam.FormattingEnabled = true;
            this.cmbStokRam.Location = new System.Drawing.Point(122, 277);
            this.cmbStokRam.Name = "cmbStokRam";
            this.cmbStokRam.Size = new System.Drawing.Size(164, 33);
            this.cmbStokRam.TabIndex = 4;
            // 
            // cmbStokHafiza
            // 
            this.cmbStokHafiza.FormattingEnabled = true;
            this.cmbStokHafiza.Location = new System.Drawing.Point(122, 222);
            this.cmbStokHafiza.Name = "cmbStokHafiza";
            this.cmbStokHafiza.Size = new System.Drawing.Size(164, 33);
            this.cmbStokHafiza.TabIndex = 3;
            // 
            // cmbStokModel
            // 
            this.cmbStokModel.FormattingEnabled = true;
            this.cmbStokModel.Location = new System.Drawing.Point(122, 173);
            this.cmbStokModel.Name = "cmbStokModel";
            this.cmbStokModel.Size = new System.Drawing.Size(164, 33);
            this.cmbStokModel.TabIndex = 2;
            // 
            // cmbStokMarka
            // 
            this.cmbStokMarka.FormattingEnabled = true;
            this.cmbStokMarka.Location = new System.Drawing.Point(122, 123);
            this.cmbStokMarka.Name = "cmbStokMarka";
            this.cmbStokMarka.Size = new System.Drawing.Size(164, 33);
            this.cmbStokMarka.TabIndex = 1;
            this.cmbStokMarka.SelectedIndexChanged += new System.EventHandler(this.cmbStokMarka_SelectedIndexChanged);
            // 
            // txtstokid
            // 
            this.txtstokid.Location = new System.Drawing.Point(122, 80);
            this.txtstokid.Name = "txtstokid";
            this.txtstokid.Size = new System.Drawing.Size(164, 30);
            this.txtstokid.TabIndex = 13;
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
            this.dataGridView1.DataSource = this.tblurunlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(342, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(921, 641);
            this.dataGridView1.TabIndex = 2;
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
            // tblurunlerBindingSource
            // 
            this.tblurunlerBindingSource.DataMember = "tbl_urunler";
            this.tblurunlerBindingSource.DataSource = this.hacettepe_TelekomDataSet;
            // 
            // hacettepe_TelekomDataSet
            // 
            this.hacettepe_TelekomDataSet.DataSetName = "Hacettepe_TelekomDataSet";
            this.hacettepe_TelekomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_urunlerTableAdapter
            // 
            this.tbl_urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_vitrinTableAdapter
            // 
            this.tbl_vitrinTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPersonStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1263, 644);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPersonStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonStok";
            this.Load += new System.EventHandler(this.FrmPersonStok_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblurunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hacettepe_TelekomDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnStokDelete;
        private DevExpress.XtraEditors.SimpleButton btnStokAdd;
        private System.Windows.Forms.RichTextBox RtxtStokAciklama;
        private System.Windows.Forms.TextBox txtStokFiyat;
        private System.Windows.Forms.ComboBox cmbStokRam;
        private System.Windows.Forms.ComboBox cmbStokHafiza;
        private System.Windows.Forms.ComboBox cmbStokModel;
        private System.Windows.Forms.ComboBox cmbStokMarka;
        private System.Windows.Forms.TextBox txtstokid;
        private DevExpress.XtraEditors.SimpleButton btnStokVitrin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private Hacettepe_TelekomDataSet hacettepe_TelekomDataSet;
        private System.Windows.Forms.BindingSource tblurunlerBindingSource;
        private Hacettepe_TelekomDataSetTableAdapters.tbl_urunlerTableAdapter tbl_urunlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunmarkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunhafizaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunramDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunaciklamaDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Hacettepe_TelekomDataSet1TableAdapters.tbl_vitrinTableAdapter tbl_vitrinTableAdapter;
        private System.Windows.Forms.Button btnStokGeri;
    }
}