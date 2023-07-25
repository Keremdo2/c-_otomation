namespace Hacettepe_Telekom
{
    partial class FrmPersonNewPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonNewPerson));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbNewPersonBirim = new System.Windows.Forms.ComboBox();
            this.mtxtNewPersonTC = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNewPersonTel = new System.Windows.Forms.MaskedTextBox();
            this.btnNewPersonSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtNewPersonPayed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNewPersonPassAgain = new System.Windows.Forms.TextBox();
            this.txtNewPersonPass = new System.Windows.Forms.TextBox();
            this.txtNewPersonNickName = new System.Windows.Forms.TextBox();
            this.txtNewPersonSurName = new System.Windows.Forms.TextBox();
            this.txtNewPersonName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYeniPersonGeri = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbNewPersonBirim);
            this.panel1.Controls.Add(this.mtxtNewPersonTC);
            this.panel1.Controls.Add(this.mtxtNewPersonTel);
            this.panel1.Controls.Add(this.btnNewPersonSave);
            this.panel1.Controls.Add(this.txtNewPersonPayed);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtNewPersonPassAgain);
            this.panel1.Controls.Add(this.txtNewPersonPass);
            this.panel1.Controls.Add(this.txtNewPersonNickName);
            this.panel1.Controls.Add(this.txtNewPersonSurName);
            this.panel1.Controls.Add(this.txtNewPersonName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(352, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 589);
            this.panel1.TabIndex = 0;
            // 
            // cmbNewPersonBirim
            // 
            this.cmbNewPersonBirim.FormattingEnabled = true;
            this.cmbNewPersonBirim.Location = new System.Drawing.Point(150, 147);
            this.cmbNewPersonBirim.Name = "cmbNewPersonBirim";
            this.cmbNewPersonBirim.Size = new System.Drawing.Size(155, 33);
            this.cmbNewPersonBirim.TabIndex = 3;
            // 
            // mtxtNewPersonTC
            // 
            this.mtxtNewPersonTC.Location = new System.Drawing.Point(150, 206);
            this.mtxtNewPersonTC.Mask = "00000000000";
            this.mtxtNewPersonTC.Name = "mtxtNewPersonTC";
            this.mtxtNewPersonTC.Size = new System.Drawing.Size(155, 30);
            this.mtxtNewPersonTC.TabIndex = 4;
            this.mtxtNewPersonTC.ValidatingType = typeof(int);
            // 
            // mtxtNewPersonTel
            // 
            this.mtxtNewPersonTel.Location = new System.Drawing.Point(150, 264);
            this.mtxtNewPersonTel.Mask = "00000000000";
            this.mtxtNewPersonTel.Name = "mtxtNewPersonTel";
            this.mtxtNewPersonTel.Size = new System.Drawing.Size(155, 30);
            this.mtxtNewPersonTel.TabIndex = 5;
            this.mtxtNewPersonTel.ValidatingType = typeof(int);
            // 
            // btnNewPersonSave
            // 
            this.btnNewPersonSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewPersonSave.ImageOptions.Image")));
            this.btnNewPersonSave.Location = new System.Drawing.Point(150, 524);
            this.btnNewPersonSave.Name = "btnNewPersonSave";
            this.btnNewPersonSave.Size = new System.Drawing.Size(155, 47);
            this.btnNewPersonSave.TabIndex = 10;
            this.btnNewPersonSave.Text = "KAYDET";
            this.btnNewPersonSave.Click += new System.EventHandler(this.btnNewPersonSave_Click);
            // 
            // txtNewPersonPayed
            // 
            this.txtNewPersonPayed.Location = new System.Drawing.Point(150, 472);
            this.txtNewPersonPayed.Name = "txtNewPersonPayed";
            this.txtNewPersonPayed.Size = new System.Drawing.Size(155, 30);
            this.txtNewPersonPayed.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Maaş:";
            // 
            // txtNewPersonPassAgain
            // 
            this.txtNewPersonPassAgain.Location = new System.Drawing.Point(150, 422);
            this.txtNewPersonPassAgain.Name = "txtNewPersonPassAgain";
            this.txtNewPersonPassAgain.Size = new System.Drawing.Size(155, 30);
            this.txtNewPersonPassAgain.TabIndex = 8;
            this.txtNewPersonPassAgain.UseSystemPasswordChar = true;
            // 
            // txtNewPersonPass
            // 
            this.txtNewPersonPass.Location = new System.Drawing.Point(150, 367);
            this.txtNewPersonPass.Name = "txtNewPersonPass";
            this.txtNewPersonPass.Size = new System.Drawing.Size(155, 30);
            this.txtNewPersonPass.TabIndex = 7;
            this.txtNewPersonPass.UseSystemPasswordChar = true;
            // 
            // txtNewPersonNickName
            // 
            this.txtNewPersonNickName.Location = new System.Drawing.Point(150, 310);
            this.txtNewPersonNickName.Name = "txtNewPersonNickName";
            this.txtNewPersonNickName.Size = new System.Drawing.Size(155, 30);
            this.txtNewPersonNickName.TabIndex = 6;
            // 
            // txtNewPersonSurName
            // 
            this.txtNewPersonSurName.Location = new System.Drawing.Point(150, 87);
            this.txtNewPersonSurName.Name = "txtNewPersonSurName";
            this.txtNewPersonSurName.Size = new System.Drawing.Size(155, 30);
            this.txtNewPersonSurName.TabIndex = 2;
            // 
            // txtNewPersonName
            // 
            this.txtNewPersonName.Location = new System.Drawing.Point(150, 35);
            this.txtNewPersonName.Name = "txtNewPersonName";
            this.txtNewPersonName.Size = new System.Drawing.Size(155, 30);
            this.txtNewPersonName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Şifre Tekrar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kullanıcı Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soy isim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim:";
            // 
            // btnYeniPersonGeri
            // 
            this.btnYeniPersonGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeniPersonGeri.Location = new System.Drawing.Point(279, 43);
            this.btnYeniPersonGeri.Name = "btnYeniPersonGeri";
            this.btnYeniPersonGeri.Size = new System.Drawing.Size(67, 52);
            this.btnYeniPersonGeri.TabIndex = 27;
            this.btnYeniPersonGeri.Text = "<";
            this.btnYeniPersonGeri.UseVisualStyleBackColor = true;
            this.btnYeniPersonGeri.Click += new System.EventHandler(this.btnYeniPersonGeri_Click);
            // 
            // FrmPersonNewPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1165, 644);
            this.Controls.Add(this.btnYeniPersonGeri);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPersonNewPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPersonNewPerson";
            this.Load += new System.EventHandler(this.FrmPersonNewPerson_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnNewPersonSave;
        private System.Windows.Forms.TextBox txtNewPersonPayed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNewPersonPassAgain;
        private System.Windows.Forms.TextBox txtNewPersonPass;
        private System.Windows.Forms.TextBox txtNewPersonNickName;
        private System.Windows.Forms.TextBox txtNewPersonSurName;
        private System.Windows.Forms.TextBox txtNewPersonName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtNewPersonTC;
        private System.Windows.Forms.MaskedTextBox mtxtNewPersonTel;
        private System.Windows.Forms.ComboBox cmbNewPersonBirim;
        private System.Windows.Forms.Button btnYeniPersonGeri;
    }
}