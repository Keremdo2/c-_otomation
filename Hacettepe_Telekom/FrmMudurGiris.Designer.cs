namespace Hacettepe_Telekom
{
    partial class FrmMudurGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMudurGiris));
            this.btnPersonLoginComeBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMudur = new DevExpress.XtraEditors.SimpleButton();
            this.txtMudurSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMudurKadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonLoginComeBack
            // 
            this.btnPersonLoginComeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonLoginComeBack.Location = new System.Drawing.Point(102, 433);
            this.btnPersonLoginComeBack.Name = "btnPersonLoginComeBack";
            this.btnPersonLoginComeBack.Size = new System.Drawing.Size(67, 52);
            this.btnPersonLoginComeBack.TabIndex = 34;
            this.btnPersonLoginComeBack.Text = "<";
            this.btnPersonLoginComeBack.UseVisualStyleBackColor = true;
            this.btnPersonLoginComeBack.Click += new System.EventHandler(this.btnPersonLoginComeBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btnMudur
            // 
            this.btnMudur.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMudur.Appearance.Options.UseFont = true;
            this.btnMudur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMudur.ImageOptions.Image")));
            this.btnMudur.Location = new System.Drawing.Point(233, 433);
            this.btnMudur.Name = "btnMudur";
            this.btnMudur.Size = new System.Drawing.Size(159, 49);
            this.btnMudur.TabIndex = 32;
            this.btnMudur.Text = "GİRİŞ YAP";
            this.btnMudur.Click += new System.EventHandler(this.btnMudur_Click);
            // 
            // txtMudurSifre
            // 
            this.txtMudurSifre.Location = new System.Drawing.Point(233, 383);
            this.txtMudurSifre.Name = "txtMudurSifre";
            this.txtMudurSifre.Size = new System.Drawing.Size(159, 30);
            this.txtMudurSifre.TabIndex = 31;
            this.txtMudurSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Şifre :";
            // 
            // txtMudurKadi
            // 
            this.txtMudurKadi.Location = new System.Drawing.Point(233, 320);
            this.txtMudurKadi.Name = "txtMudurKadi";
            this.txtMudurKadi.Size = new System.Drawing.Size(159, 30);
            this.txtMudurKadi.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // FrmMudurGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(489, 604);
            this.Controls.Add(this.btnPersonLoginComeBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMudur);
            this.Controls.Add(this.txtMudurSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMudurKadi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMudurGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMudurGiris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersonLoginComeBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnMudur;
        private System.Windows.Forms.TextBox txtMudurSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMudurKadi;
        private System.Windows.Forms.Label label1;
    }
}