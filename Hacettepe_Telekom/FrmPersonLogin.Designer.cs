namespace Hacettepe_Telekom
{
    partial class FrmPersonLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonLoginNick = new System.Windows.Forms.TextBox();
            this.txtPersonLoginPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPersonLogin = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPersonLoginComeBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txtPersonLoginNick
            // 
            this.txtPersonLoginNick.Location = new System.Drawing.Point(214, 276);
            this.txtPersonLoginNick.Name = "txtPersonLoginNick";
            this.txtPersonLoginNick.Size = new System.Drawing.Size(159, 30);
            this.txtPersonLoginNick.TabIndex = 1;
            // 
            // txtPersonLoginPass
            // 
            this.txtPersonLoginPass.Location = new System.Drawing.Point(214, 339);
            this.txtPersonLoginPass.Name = "txtPersonLoginPass";
            this.txtPersonLoginPass.Size = new System.Drawing.Size(159, 30);
            this.txtPersonLoginPass.TabIndex = 3;
            this.txtPersonLoginPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre :";
            // 
            // btnPersonLogin
            // 
            this.btnPersonLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonLogin.Appearance.Options.UseFont = true;
            this.btnPersonLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnPersonLogin.Location = new System.Drawing.Point(214, 389);
            this.btnPersonLogin.Name = "btnPersonLogin";
            this.btnPersonLogin.Size = new System.Drawing.Size(159, 49);
            this.btnPersonLogin.TabIndex = 4;
            this.btnPersonLogin.Text = "GİRİŞ YAP";
            this.btnPersonLogin.Click += new System.EventHandler(this.btnPersonLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnPersonLoginComeBack
            // 
            this.btnPersonLoginComeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonLoginComeBack.Location = new System.Drawing.Point(83, 389);
            this.btnPersonLoginComeBack.Name = "btnPersonLoginComeBack";
            this.btnPersonLoginComeBack.Size = new System.Drawing.Size(67, 52);
            this.btnPersonLoginComeBack.TabIndex = 27;
            this.btnPersonLoginComeBack.Text = "<";
            this.btnPersonLoginComeBack.UseVisualStyleBackColor = true;
            this.btnPersonLoginComeBack.Click += new System.EventHandler(this.btnPersonLoginComeBack_Click);
            // 
            // FrmPersonLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(489, 604);
            this.Controls.Add(this.btnPersonLoginComeBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPersonLogin);
            this.Controls.Add(this.txtPersonLoginPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPersonLoginNick);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPersonLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonLoginNick;
        private System.Windows.Forms.TextBox txtPersonLoginPass;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnPersonLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPersonLoginComeBack;
    }
}