namespace Hacettepe_Telekom
{
    partial class FrmManagerFaturalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManagerFaturalar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGeriGel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.txtFaturaTutar = new System.Windows.Forms.TextBox();
            this.txtFaturaId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.faturaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturabedelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturatarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturatelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblfaturalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hacettepe_TelekomDataSet4 = new Hacettepe_Telekom.Hacettepe_TelekomDataSet4();
            this.tbl_faturalarTableAdapter = new Hacettepe_Telekom.Hacettepe_TelekomDataSet4TableAdapters.tbl_faturalarTableAdapter();
            this.mtxtFaturaTC = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFaturaTarih = new System.Windows.Forms.MaskedTextBox();
            this.mtxtFaturaTel = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfaturalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hacettepe_TelekomDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mtxtFaturaTel);
            this.panel1.Controls.Add(this.mtxtFaturaTarih);
            this.panel1.Controls.Add(this.mtxtFaturaTC);
            this.panel1.Controls.Add(this.btnGeriGel);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.txtFaturaTutar);
            this.panel1.Controls.Add(this.txtFaturaId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 397);
            this.panel1.TabIndex = 0;
            // 
            // btnGeriGel
            // 
            this.btnGeriGel.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeriGel.Appearance.Options.UseFont = true;
            this.btnGeriGel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGeriGel.ImageOptions.SvgImage")));
            this.btnGeriGel.Location = new System.Drawing.Point(20, 332);
            this.btnGeriGel.Name = "btnGeriGel";
            this.btnGeriGel.Size = new System.Drawing.Size(259, 40);
            this.btnGeriGel.TabIndex = 8;
            this.btnGeriGel.Text = "GERİ GEL";
            this.btnGeriGel.Click += new System.EventHandler(this.btnGeriGel_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSil.ImageOptions.SvgImage")));
            this.btnSil.Location = new System.Drawing.Point(171, 271);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(108, 40);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuncelle.ImageOptions.SvgImage")));
            this.btnGuncelle.Location = new System.Drawing.Point(20, 271);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(108, 40);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtFaturaTutar
            // 
            this.txtFaturaTutar.Location = new System.Drawing.Point(141, 134);
            this.txtFaturaTutar.Name = "txtFaturaTutar";
            this.txtFaturaTutar.Size = new System.Drawing.Size(164, 30);
            this.txtFaturaTutar.TabIndex = 3;
            // 
            // txtFaturaId
            // 
            this.txtFaturaId.Location = new System.Drawing.Point(141, 47);
            this.txtFaturaId.Name = "txtFaturaId";
            this.txtFaturaId.Size = new System.Drawing.Size(164, 30);
            this.txtFaturaId.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "TELEFON :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "TARİH :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "TUTAR :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faturaidDataGridViewTextBoxColumn,
            this.faturaTCDataGridViewTextBoxColumn,
            this.faturabedelDataGridViewTextBoxColumn,
            this.faturatarihDataGridViewTextBoxColumn,
            this.faturatelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblfaturalarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(326, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 394);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // faturaidDataGridViewTextBoxColumn
            // 
            this.faturaidDataGridViewTextBoxColumn.DataPropertyName = "fatura_id";
            this.faturaidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.faturaidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faturaidDataGridViewTextBoxColumn.Name = "faturaidDataGridViewTextBoxColumn";
            this.faturaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.faturaidDataGridViewTextBoxColumn.Width = 125;
            // 
            // faturaTCDataGridViewTextBoxColumn
            // 
            this.faturaTCDataGridViewTextBoxColumn.DataPropertyName = "fatura_TC";
            this.faturaTCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.faturaTCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faturaTCDataGridViewTextBoxColumn.Name = "faturaTCDataGridViewTextBoxColumn";
            this.faturaTCDataGridViewTextBoxColumn.Width = 125;
            // 
            // faturabedelDataGridViewTextBoxColumn
            // 
            this.faturabedelDataGridViewTextBoxColumn.DataPropertyName = "fatura_bedel";
            this.faturabedelDataGridViewTextBoxColumn.HeaderText = "TUTAR";
            this.faturabedelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faturabedelDataGridViewTextBoxColumn.Name = "faturabedelDataGridViewTextBoxColumn";
            this.faturabedelDataGridViewTextBoxColumn.Width = 125;
            // 
            // faturatarihDataGridViewTextBoxColumn
            // 
            this.faturatarihDataGridViewTextBoxColumn.DataPropertyName = "fatura_tarih";
            this.faturatarihDataGridViewTextBoxColumn.HeaderText = "TARİH";
            this.faturatarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faturatarihDataGridViewTextBoxColumn.Name = "faturatarihDataGridViewTextBoxColumn";
            this.faturatarihDataGridViewTextBoxColumn.Width = 125;
            // 
            // faturatelDataGridViewTextBoxColumn
            // 
            this.faturatelDataGridViewTextBoxColumn.DataPropertyName = "fatura_tel";
            this.faturatelDataGridViewTextBoxColumn.HeaderText = "TELEFON";
            this.faturatelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.faturatelDataGridViewTextBoxColumn.Name = "faturatelDataGridViewTextBoxColumn";
            this.faturatelDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblfaturalarBindingSource
            // 
            this.tblfaturalarBindingSource.DataMember = "tbl_faturalar";
            this.tblfaturalarBindingSource.DataSource = this.hacettepe_TelekomDataSet4;
            // 
            // hacettepe_TelekomDataSet4
            // 
            this.hacettepe_TelekomDataSet4.DataSetName = "Hacettepe_TelekomDataSet4";
            this.hacettepe_TelekomDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_faturalarTableAdapter
            // 
            this.tbl_faturalarTableAdapter.ClearBeforeFill = true;
            // 
            // mtxtFaturaTC
            // 
            this.mtxtFaturaTC.Location = new System.Drawing.Point(141, 89);
            this.mtxtFaturaTC.Mask = "00000000000";
            this.mtxtFaturaTC.Name = "mtxtFaturaTC";
            this.mtxtFaturaTC.Size = new System.Drawing.Size(164, 30);
            this.mtxtFaturaTC.TabIndex = 2;
            this.mtxtFaturaTC.ValidatingType = typeof(int);
            // 
            // mtxtFaturaTarih
            // 
            this.mtxtFaturaTarih.Location = new System.Drawing.Point(141, 178);
            this.mtxtFaturaTarih.Name = "mtxtFaturaTarih";
            this.mtxtFaturaTarih.Size = new System.Drawing.Size(164, 30);
            this.mtxtFaturaTarih.TabIndex = 4;
            // 
            // mtxtFaturaTel
            // 
            this.mtxtFaturaTel.Location = new System.Drawing.Point(141, 221);
            this.mtxtFaturaTel.Mask = "00000000000";
            this.mtxtFaturaTel.Name = "mtxtFaturaTel";
            this.mtxtFaturaTel.Size = new System.Drawing.Size(164, 30);
            this.mtxtFaturaTel.TabIndex = 5;
            this.mtxtFaturaTel.ValidatingType = typeof(int);
            // 
            // FrmManagerFaturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1011, 416);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmManagerFaturalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManagerFaturalar";
            this.Load += new System.EventHandler(this.FrmManagerFaturalar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfaturalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hacettepe_TelekomDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Hacettepe_TelekomDataSet4 hacettepe_TelekomDataSet4;
        private System.Windows.Forms.BindingSource tblfaturalarBindingSource;
        private Hacettepe_TelekomDataSet4TableAdapters.tbl_faturalarTableAdapter tbl_faturalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturabedelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturatarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturatelDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.SimpleButton btnGeriGel;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private System.Windows.Forms.TextBox txtFaturaTutar;
        private System.Windows.Forms.TextBox txtFaturaId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtFaturaTel;
        private System.Windows.Forms.MaskedTextBox mtxtFaturaTarih;
        private System.Windows.Forms.MaskedTextBox mtxtFaturaTC;
    }
}