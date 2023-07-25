namespace Hacettepe_Telekom
{
    partial class FrmManagerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManagerUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFrmPersonCikisyap = new DevExpress.XtraEditors.SimpleButton();
            this.btnFaturalar = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersoneller = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFrmPersonCikisyap);
            this.panel1.Controls.Add(this.btnFaturalar);
            this.panel1.Controls.Add(this.btnPersoneller);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 637);
            this.panel1.TabIndex = 0;
            // 
            // btnFrmPersonCikisyap
            // 
            this.btnFrmPersonCikisyap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmPersonCikisyap.Appearance.Options.UseFont = true;
            this.btnFrmPersonCikisyap.Location = new System.Drawing.Point(65, 499);
            this.btnFrmPersonCikisyap.Name = "btnFrmPersonCikisyap";
            this.btnFrmPersonCikisyap.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnFrmPersonCikisyap.Size = new System.Drawing.Size(156, 56);
            this.btnFrmPersonCikisyap.TabIndex = 11;
            this.btnFrmPersonCikisyap.Text = "ÇIKIŞ YAP";
            this.btnFrmPersonCikisyap.Click += new System.EventHandler(this.btnFrmPersonCikisyap_Click);
            // 
            // btnFaturalar
            // 
            this.btnFaturalar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturalar.Appearance.Options.UseFont = true;
            this.btnFaturalar.Location = new System.Drawing.Point(65, 151);
            this.btnFaturalar.Name = "btnFaturalar";
            this.btnFaturalar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnFaturalar.Size = new System.Drawing.Size(156, 56);
            this.btnFaturalar.TabIndex = 7;
            this.btnFaturalar.Text = "FATURALAR";
            this.btnFaturalar.Click += new System.EventHandler(this.btnFaturalar_Click);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersoneller.Appearance.Options.UseFont = true;
            this.btnPersoneller.Location = new System.Drawing.Point(65, 64);
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPersoneller.Size = new System.Drawing.Size(156, 56);
            this.btnPersoneller.TabIndex = 6;
            this.btnPersoneller.Text = "PERSONELLER";
            this.btnPersoneller.Click += new System.EventHandler(this.btnPersoneller_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 72);
            this.label1.TabIndex = 4;
            this.label1.Text = "Telekom Hacettepe Hos Geldiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(592, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1169, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmManagerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManagerUI";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnFrmPersonCikisyap;
        private DevExpress.XtraEditors.SimpleButton btnFaturalar;
        private DevExpress.XtraEditors.SimpleButton btnPersoneller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}