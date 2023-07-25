namespace Hacettepe_Telekom
{
    partial class FrmPersonBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonBuy));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunmarkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunhafizaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunaciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblurunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hacettepeTelekomDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hacettepe_TelekomDataSet = new Hacettepe_Telekom.Hacettepe_TelekomDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStokGeri = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuyBuy = new DevExpress.XtraEditors.SimpleButton();
            this.rtxtBuyAciklama = new System.Windows.Forms.RichTextBox();
            this.txtBuyFiyat = new System.Windows.Forms.TextBox();
            this.cmbBuyRam = new System.Windows.Forms.ComboBox();
            this.cmbBuyHafiza = new System.Windows.Forms.ComboBox();
            this.cmbBuyModel = new System.Windows.Forms.ComboBox();
            this.cmbBuyMarka = new System.Windows.Forms.ComboBox();
            this.txtBuyId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_urunlerTableAdapter = new Hacettepe_Telekom.Hacettepe_TelekomDataSetTableAdapters.tbl_urunlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblurunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hacettepeTelekomDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hacettepe_TelekomDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(342, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(933, 641);
            this.dataGridView1.TabIndex = 6;
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
            this.tblurunlerBindingSource.DataSource = this.hacettepeTelekomDataSetBindingSource;
            // 
            // hacettepeTelekomDataSetBindingSource
            // 
            this.hacettepeTelekomDataSetBindingSource.DataSource = this.hacettepe_TelekomDataSet;
            this.hacettepeTelekomDataSetBindingSource.Position = 0;
            // 
            // hacettepe_TelekomDataSet
            // 
            this.hacettepe_TelekomDataSet.DataSetName = "Hacettepe_TelekomDataSet";
            this.hacettepe_TelekomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnStokGeri);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnBuyBuy);
            this.panel1.Controls.Add(this.rtxtBuyAciklama);
            this.panel1.Controls.Add(this.txtBuyFiyat);
            this.panel1.Controls.Add(this.cmbBuyRam);
            this.panel1.Controls.Add(this.cmbBuyHafiza);
            this.panel1.Controls.Add(this.cmbBuyModel);
            this.panel1.Controls.Add(this.cmbBuyMarka);
            this.panel1.Controls.Add(this.txtBuyId);
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
            this.panel1.TabIndex = 5;
            // 
            // btnStokGeri
            // 
            this.btnStokGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStokGeri.Location = new System.Drawing.Point(3, 3);
            this.btnStokGeri.Name = "btnStokGeri";
            this.btnStokGeri.Size = new System.Drawing.Size(67, 52);
            this.btnStokGeri.TabIndex = 26;
            this.btnStokGeri.Text = "<";
            this.btnStokGeri.UseVisualStyleBackColor = true;
            this.btnStokGeri.Click += new System.EventHandler(this.btnStokGeri_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(98, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 43);
            this.label8.TabIndex = 24;
            this.label8.Text = "SATIN AL";
            // 
            // btnBuyBuy
            // 
            this.btnBuyBuy.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyBuy.Appearance.Options.UseFont = true;
            this.btnBuyBuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBuyBuy.ImageOptions.Image")));
            this.btnBuyBuy.Location = new System.Drawing.Point(122, 544);
            this.btnBuyBuy.Name = "btnBuyBuy";
            this.btnBuyBuy.Size = new System.Drawing.Size(164, 33);
            this.btnBuyBuy.TabIndex = 21;
            this.btnBuyBuy.Text = "SATIN AL";
            this.btnBuyBuy.Click += new System.EventHandler(this.btnBuyBuy_Click);
            // 
            // rtxtBuyAciklama
            // 
            this.rtxtBuyAciklama.Location = new System.Drawing.Point(122, 390);
            this.rtxtBuyAciklama.Name = "rtxtBuyAciklama";
            this.rtxtBuyAciklama.Size = new System.Drawing.Size(164, 136);
            this.rtxtBuyAciklama.TabIndex = 19;
            this.rtxtBuyAciklama.Text = "";
            // 
            // txtBuyFiyat
            // 
            this.txtBuyFiyat.Location = new System.Drawing.Point(122, 334);
            this.txtBuyFiyat.Name = "txtBuyFiyat";
            this.txtBuyFiyat.Size = new System.Drawing.Size(164, 30);
            this.txtBuyFiyat.TabIndex = 18;
            // 
            // cmbBuyRam
            // 
            this.cmbBuyRam.FormattingEnabled = true;
            this.cmbBuyRam.Location = new System.Drawing.Point(122, 277);
            this.cmbBuyRam.Name = "cmbBuyRam";
            this.cmbBuyRam.Size = new System.Drawing.Size(164, 33);
            this.cmbBuyRam.TabIndex = 17;
            // 
            // cmbBuyHafiza
            // 
            this.cmbBuyHafiza.FormattingEnabled = true;
            this.cmbBuyHafiza.Location = new System.Drawing.Point(122, 222);
            this.cmbBuyHafiza.Name = "cmbBuyHafiza";
            this.cmbBuyHafiza.Size = new System.Drawing.Size(164, 33);
            this.cmbBuyHafiza.TabIndex = 16;
            // 
            // cmbBuyModel
            // 
            this.cmbBuyModel.FormattingEnabled = true;
            this.cmbBuyModel.Location = new System.Drawing.Point(122, 173);
            this.cmbBuyModel.Name = "cmbBuyModel";
            this.cmbBuyModel.Size = new System.Drawing.Size(164, 33);
            this.cmbBuyModel.TabIndex = 15;
            // 
            // cmbBuyMarka
            // 
            this.cmbBuyMarka.FormattingEnabled = true;
            this.cmbBuyMarka.Location = new System.Drawing.Point(122, 123);
            this.cmbBuyMarka.Name = "cmbBuyMarka";
            this.cmbBuyMarka.Size = new System.Drawing.Size(164, 33);
            this.cmbBuyMarka.TabIndex = 14;
            this.cmbBuyMarka.SelectedIndexChanged += new System.EventHandler(this.cmbBuyMarka_SelectedIndexChanged);
            // 
            // txtBuyId
            // 
            this.txtBuyId.Location = new System.Drawing.Point(122, 80);
            this.txtBuyId.Name = "txtBuyId";
            this.txtBuyId.Size = new System.Drawing.Size(164, 30);
            this.txtBuyId.TabIndex = 13;
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
            // tbl_urunlerTableAdapter
            // 
            this.tbl_urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPersonBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1266, 644);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPersonBuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonBuy";
            this.Load += new System.EventHandler(this.FrmPersonBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblurunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hacettepeTelekomDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hacettepe_TelekomDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnBuyBuy;
        private System.Windows.Forms.RichTextBox rtxtBuyAciklama;
        private System.Windows.Forms.TextBox txtBuyFiyat;
        private System.Windows.Forms.ComboBox cmbBuyRam;
        private System.Windows.Forms.ComboBox cmbBuyHafiza;
        private System.Windows.Forms.ComboBox cmbBuyModel;
        private System.Windows.Forms.ComboBox cmbBuyMarka;
        private System.Windows.Forms.TextBox txtBuyId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource hacettepeTelekomDataSetBindingSource;
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
        private System.Windows.Forms.Button btnStokGeri;
    }
}