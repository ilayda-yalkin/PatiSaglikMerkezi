namespace Veteriner_web
{
    partial class FrmKullaniciSsayfasi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblSoyad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblAd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbHastaCinsiyet = new System.Windows.Forms.ComboBox();
            this.cmbHastaTuru = new System.Windows.Forms.ComboBox();
            this.mskSahipTc = new System.Windows.Forms.MaskedTextBox();
            this.txtHastaCinsi = new System.Windows.Forms.TextBox();
            this.txtHastaCipNo = new System.Windows.Forms.TextBox();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHastaCinsiyet = new System.Windows.Forms.Label();
            this.lblHastaCinsi = new System.Windows.Forms.Label();
            this.lblHastaTuru = new System.Windows.Forms.Label();
            this.lblHastaCipNo = new System.Windows.Forms.Label();
            this.lblHastaAdi = new System.Windows.Forms.Label();
            this.txtHastaid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grp = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grp.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 295);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(124, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(569, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pati Sağlık Merkezi Kullanıcı Sayfası";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblSoyad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LblAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 152);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgilerim";
            // 
            // LblSoyad
            // 
            this.LblSoyad.AutoSize = true;
            this.LblSoyad.Location = new System.Drawing.Point(108, 76);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(47, 25);
            this.LblSoyad.TabIndex = 6;
            this.LblSoyad.Text = "Null";
            this.LblSoyad.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Soyisim:";
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Location = new System.Drawing.Point(108, 33);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(47, 25);
            this.LblAd.TabIndex = 4;
            this.LblAd.Text = "Null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "İsim:";
            // 
            // cmbHastaCinsiyet
            // 
            this.cmbHastaCinsiyet.FormattingEnabled = true;
            this.cmbHastaCinsiyet.Items.AddRange(new object[] {
            "Dişi",
            "Erkek"});
            this.cmbHastaCinsiyet.Location = new System.Drawing.Point(1019, 324);
            this.cmbHastaCinsiyet.Name = "cmbHastaCinsiyet";
            this.cmbHastaCinsiyet.Size = new System.Drawing.Size(176, 33);
            this.cmbHastaCinsiyet.TabIndex = 39;
            // 
            // cmbHastaTuru
            // 
            this.cmbHastaTuru.FormattingEnabled = true;
            this.cmbHastaTuru.Items.AddRange(new object[] {
            "Köpek",
            "Kedi",
            "Kuş"});
            this.cmbHastaTuru.Location = new System.Drawing.Point(1019, 222);
            this.cmbHastaTuru.Name = "cmbHastaTuru";
            this.cmbHastaTuru.Size = new System.Drawing.Size(176, 33);
            this.cmbHastaTuru.TabIndex = 38;
            // 
            // mskSahipTc
            // 
            this.mskSahipTc.Location = new System.Drawing.Point(1019, 70);
            this.mskSahipTc.Mask = "00000000000";
            this.mskSahipTc.Name = "mskSahipTc";
            this.mskSahipTc.Size = new System.Drawing.Size(176, 33);
            this.mskSahipTc.TabIndex = 37;
            this.mskSahipTc.ValidatingType = typeof(int);
            // 
            // txtHastaCinsi
            // 
            this.txtHastaCinsi.Location = new System.Drawing.Point(1019, 269);
            this.txtHastaCinsi.Name = "txtHastaCinsi";
            this.txtHastaCinsi.Size = new System.Drawing.Size(176, 33);
            this.txtHastaCinsi.TabIndex = 32;
            // 
            // txtHastaCipNo
            // 
            this.txtHastaCipNo.Location = new System.Drawing.Point(1019, 175);
            this.txtHastaCipNo.Name = "txtHastaCipNo";
            this.txtHastaCipNo.Size = new System.Drawing.Size(176, 33);
            this.txtHastaCipNo.TabIndex = 31;
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(1019, 124);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(176, 33);
            this.txtHastaAdi.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(908, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Sahip TC:";
            // 
            // lblHastaCinsiyet
            // 
            this.lblHastaCinsiyet.AutoSize = true;
            this.lblHastaCinsiyet.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaCinsiyet.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHastaCinsiyet.Location = new System.Drawing.Point(852, 324);
            this.lblHastaCinsiyet.Name = "lblHastaCinsiyet";
            this.lblHastaCinsiyet.Size = new System.Drawing.Size(150, 25);
            this.lblHastaCinsiyet.TabIndex = 24;
            this.lblHastaCinsiyet.Text = "Hasta Cinsiyeti:";
            // 
            // lblHastaCinsi
            // 
            this.lblHastaCinsi.AutoSize = true;
            this.lblHastaCinsi.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaCinsi.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHastaCinsi.Location = new System.Drawing.Point(859, 269);
            this.lblHastaCinsi.Name = "lblHastaCinsi";
            this.lblHastaCinsi.Size = new System.Drawing.Size(145, 25);
            this.lblHastaCinsi.TabIndex = 23;
            this.lblHastaCinsi.Text = "Hastanın Cinsi:";
            // 
            // lblHastaTuru
            // 
            this.lblHastaTuru.AutoSize = true;
            this.lblHastaTuru.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaTuru.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHastaTuru.Location = new System.Drawing.Point(859, 225);
            this.lblHastaTuru.Name = "lblHastaTuru";
            this.lblHastaTuru.Size = new System.Drawing.Size(143, 25);
            this.lblHastaTuru.TabIndex = 22;
            this.lblHastaTuru.Text = "Hastanın Türü:";
            // 
            // lblHastaCipNo
            // 
            this.lblHastaCipNo.AutoSize = true;
            this.lblHastaCipNo.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaCipNo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHastaCipNo.Location = new System.Drawing.Point(779, 178);
            this.lblHastaCipNo.Name = "lblHastaCipNo";
            this.lblHastaCipNo.Size = new System.Drawing.Size(223, 25);
            this.lblHastaCipNo.TabIndex = 21;
            this.lblHastaCipNo.Text = "Hastanın Çip Numarası:";
            // 
            // lblHastaAdi
            // 
            this.lblHastaAdi.AutoSize = true;
            this.lblHastaAdi.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaAdi.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHastaAdi.Location = new System.Drawing.Point(870, 127);
            this.lblHastaAdi.Name = "lblHastaAdi";
            this.lblHastaAdi.Size = new System.Drawing.Size(132, 25);
            this.lblHastaAdi.TabIndex = 20;
            this.lblHastaAdi.Text = "Hastanın Adı:";
            // 
            // txtHastaid
            // 
            this.txtHastaid.Location = new System.Drawing.Point(1019, 20);
            this.txtHastaid.Name = "txtHastaid";
            this.txtHastaid.Size = new System.Drawing.Size(176, 33);
            this.txtHastaid.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(908, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 25);
            this.label11.TabIndex = 40;
            this.label11.Text = "Hasta İd:";
            // 
            // grp
            // 
            this.grp.Controls.Add(this.btnSil);
            this.grp.Controls.Add(this.btnGüncelle);
            this.grp.Controls.Add(this.btn_ekle);
            this.grp.Location = new System.Drawing.Point(418, 56);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(347, 152);
            this.grp.TabIndex = 43;
            this.grp.TabStop = false;
            this.grp.Text = "İşlemler";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSil.Location = new System.Drawing.Point(33, 102);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(270, 33);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGüncelle.Location = new System.Drawing.Point(33, 63);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(270, 33);
            this.btnGüncelle.TabIndex = 1;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_ekle.Location = new System.Drawing.Point(33, 25);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(270, 33);
            this.btn_ekle.TabIndex = 0;
            this.btn_ekle.Text = "Hasta Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGeri.Location = new System.Drawing.Point(12, 9);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 35);
            this.btnGeri.TabIndex = 44;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(15, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(807, 327);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hastalar";
            // 
            // FrmKullaniciSsayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1207, 589);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.txtHastaid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbHastaCinsiyet);
            this.Controls.Add(this.cmbHastaTuru);
            this.Controls.Add(this.mskSahipTc);
            this.Controls.Add(this.txtHastaCinsi);
            this.Controls.Add(this.txtHastaCipNo);
            this.Controls.Add(this.txtHastaAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblHastaCinsiyet);
            this.Controls.Add(this.lblHastaCinsi);
            this.Controls.Add(this.lblHastaTuru);
            this.Controls.Add(this.lblHastaCipNo);
            this.Controls.Add(this.lblHastaAdi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmKullaniciSsayfasi";
            this.Text = "FrmKullaniciSsayfasi";
            this.Load += new System.EventHandler(this.FrmKullaniciSsayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbHastaCinsiyet;
        private System.Windows.Forms.ComboBox cmbHastaTuru;
        private System.Windows.Forms.MaskedTextBox mskSahipTc;
        private System.Windows.Forms.TextBox txtHastaCinsi;
        private System.Windows.Forms.TextBox txtHastaCipNo;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHastaCinsiyet;
        private System.Windows.Forms.Label lblHastaCinsi;
        private System.Windows.Forms.Label lblHastaTuru;
        private System.Windows.Forms.Label lblHastaCipNo;
        private System.Windows.Forms.Label lblHastaAdi;
        private System.Windows.Forms.TextBox txtHastaid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}