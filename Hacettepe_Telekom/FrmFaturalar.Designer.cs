namespace Hacettepe_Telekom
{
    partial class FrmFaturalar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.faturaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturabedelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturatarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturatelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblfaturalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hacettepe_TelekomDataSet2 = new Hacettepe_Telekom.Hacettepe_TelekomDataSet2();
            this.tbl_faturalarTableAdapter = new Hacettepe_Telekom.Hacettepe_TelekomDataSet2TableAdapters.tbl_faturalarTableAdapter();
            this.btnPersonLoginComeBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfaturalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hacettepe_TelekomDataSet2)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 462);
            this.dataGridView1.TabIndex = 0;
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
            this.tblfaturalarBindingSource.DataSource = this.hacettepe_TelekomDataSet2;
            // 
            // hacettepe_TelekomDataSet2
            // 
            this.hacettepe_TelekomDataSet2.DataSetName = "Hacettepe_TelekomDataSet2";
            this.hacettepe_TelekomDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_faturalarTableAdapter
            // 
            this.tbl_faturalarTableAdapter.ClearBeforeFill = true;
            // 
            // btnPersonLoginComeBack
            // 
            this.btnPersonLoginComeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonLoginComeBack.Location = new System.Drawing.Point(0, 461);
            this.btnPersonLoginComeBack.Name = "btnPersonLoginComeBack";
            this.btnPersonLoginComeBack.Size = new System.Drawing.Size(680, 71);
            this.btnPersonLoginComeBack.TabIndex = 35;
            this.btnPersonLoginComeBack.Text = "<";
            this.btnPersonLoginComeBack.UseVisualStyleBackColor = true;
            this.btnPersonLoginComeBack.Click += new System.EventHandler(this.btnPersonLoginComeBack_Click);
            // 
            // FrmFaturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 533);
            this.Controls.Add(this.btnPersonLoginComeBack);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFaturalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFaturalar";
            this.Load += new System.EventHandler(this.FrmFaturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfaturalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hacettepe_TelekomDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Hacettepe_TelekomDataSet2 hacettepe_TelekomDataSet2;
        private System.Windows.Forms.BindingSource tblfaturalarBindingSource;
        private Hacettepe_TelekomDataSet2TableAdapters.tbl_faturalarTableAdapter tbl_faturalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturabedelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturatarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturatelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPersonLoginComeBack;
    }
}