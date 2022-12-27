namespace vtys
{
    partial class frmTakimlar
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtTakimAdi = new System.Windows.Forms.TextBox();
            this.txtYasOrtalamasi = new System.Windows.Forms.TextBox();
            this.txtTakimUlkesi = new System.Windows.Forms.TextBox();
            this.txtLigSirasi = new System.Windows.Forms.TextBox();
            this.txtKadroDegeri = new System.Windows.Forms.TextBox();
            this.txtStatAdi = new System.Windows.Forms.TextBox();
            this.txtTakimLigi = new System.Windows.Forms.TextBox();
            this.txtTakimId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOyuncuSayisi = new System.Windows.Forms.TextBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEkle.BackgroundImage = global::vtys.Properties.Resources.icons8_done_30px;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.Location = new System.Drawing.Point(32, 309);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(35, 35);
            this.btnEkle.TabIndex = 85;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSil.BackgroundImage = global::vtys.Properties.Resources.icons8_waste_30px;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(636, 309);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(35, 35);
            this.btnSil.TabIndex = 84;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::vtys.Properties.Resources.icons8_synchronize_30px;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(99, 309);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(35, 35);
            this.btnGuncelle.TabIndex = 83;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackgroundImage = global::vtys.Properties.Resources.icons8_search_30px;
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAra.Location = new System.Drawing.Point(603, 92);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(33, 33);
            this.btnAra.TabIndex = 82;
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(145)))), ((int)(((byte)(184)))));
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnListele.Location = new System.Drawing.Point(324, 2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(83, 26);
            this.btnListele.TabIndex = 81;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtTakimAdi
            // 
            this.txtTakimAdi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTakimAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTakimAdi.Location = new System.Drawing.Point(75, 93);
            this.txtTakimAdi.Name = "txtTakimAdi";
            this.txtTakimAdi.Size = new System.Drawing.Size(78, 20);
            this.txtTakimAdi.TabIndex = 80;
            // 
            // txtYasOrtalamasi
            // 
            this.txtYasOrtalamasi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtYasOrtalamasi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYasOrtalamasi.Location = new System.Drawing.Point(75, 116);
            this.txtYasOrtalamasi.Name = "txtYasOrtalamasi";
            this.txtYasOrtalamasi.Size = new System.Drawing.Size(78, 20);
            this.txtYasOrtalamasi.TabIndex = 79;
            // 
            // txtTakimUlkesi
            // 
            this.txtTakimUlkesi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTakimUlkesi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTakimUlkesi.Location = new System.Drawing.Point(75, 164);
            this.txtTakimUlkesi.Name = "txtTakimUlkesi";
            this.txtTakimUlkesi.Size = new System.Drawing.Size(78, 20);
            this.txtTakimUlkesi.TabIndex = 78;
            // 
            // txtLigSirasi
            // 
            this.txtLigSirasi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLigSirasi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLigSirasi.Location = new System.Drawing.Point(75, 260);
            this.txtLigSirasi.Name = "txtLigSirasi";
            this.txtLigSirasi.Size = new System.Drawing.Size(78, 20);
            this.txtLigSirasi.TabIndex = 77;
            // 
            // txtKadroDegeri
            // 
            this.txtKadroDegeri.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtKadroDegeri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKadroDegeri.Location = new System.Drawing.Point(75, 236);
            this.txtKadroDegeri.Name = "txtKadroDegeri";
            this.txtKadroDegeri.Size = new System.Drawing.Size(78, 20);
            this.txtKadroDegeri.TabIndex = 76;
            // 
            // txtStatAdi
            // 
            this.txtStatAdi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtStatAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatAdi.Location = new System.Drawing.Point(75, 212);
            this.txtStatAdi.Name = "txtStatAdi";
            this.txtStatAdi.Size = new System.Drawing.Size(78, 20);
            this.txtStatAdi.TabIndex = 75;
            // 
            // txtTakimLigi
            // 
            this.txtTakimLigi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTakimLigi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTakimLigi.Location = new System.Drawing.Point(75, 188);
            this.txtTakimLigi.Name = "txtTakimLigi";
            this.txtTakimLigi.Size = new System.Drawing.Size(78, 20);
            this.txtTakimLigi.TabIndex = 74;
            // 
            // txtTakimId
            // 
            this.txtTakimId.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTakimId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTakimId.Location = new System.Drawing.Point(75, 69);
            this.txtTakimId.Name = "txtTakimId";
            this.txtTakimId.Size = new System.Drawing.Size(78, 20);
            this.txtTakimId.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.label9.Location = new System.Drawing.Point(15, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 23);
            this.label9.TabIndex = 72;
            this.label9.Text = "Adı";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.label8.Location = new System.Drawing.Point(15, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 23);
            this.label8.TabIndex = 71;
            this.label8.Text = "Yaş Ort";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.label7.Location = new System.Drawing.Point(15, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 70;
            this.label7.Text = "Takım Ülk";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.label6.Location = new System.Drawing.Point(15, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 69;
            this.label6.Text = "Lig Sırası";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.label4.Location = new System.Drawing.Point(15, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 68;
            this.label4.Text = "Kadro Değ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.label3.Location = new System.Drawing.Point(15, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 67;
            this.label3.Text = "Stat Adı";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.label2.Location = new System.Drawing.Point(15, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 66;
            this.label2.Text = "Takim Ligi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 65;
            this.label1.Text = "Takim ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(145)))), ((int)(((byte)(184)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(171, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 228);
            this.dataGridView1.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.label5.Location = new System.Drawing.Point(15, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 23);
            this.label5.TabIndex = 86;
            this.label5.Text = "OyuncSay";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOyuncuSayisi
            // 
            this.txtOyuncuSayisi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtOyuncuSayisi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOyuncuSayisi.Location = new System.Drawing.Point(75, 140);
            this.txtOyuncuSayisi.Name = "txtOyuncuSayisi";
            this.txtOyuncuSayisi.Size = new System.Drawing.Size(78, 20);
            this.txtOyuncuSayisi.TabIndex = 87;
            // 
            // txtAra
            // 
            this.txtAra.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAra.Location = new System.Drawing.Point(642, 98);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(62, 20);
            this.txtAra.TabIndex = 88;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // frmTakimlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::vtys.Properties.Resources.bacground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 383);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.txtOyuncuSayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtTakimAdi);
            this.Controls.Add(this.txtYasOrtalamasi);
            this.Controls.Add(this.txtTakimUlkesi);
            this.Controls.Add(this.txtLigSirasi);
            this.Controls.Add(this.txtKadroDegeri);
            this.Controls.Add(this.txtStatAdi);
            this.Controls.Add(this.txtTakimLigi);
            this.Controls.Add(this.txtTakimId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "frmTakimlar";
            this.Text = "frmTakimlar";
            this.Load += new System.EventHandler(this.frmTakimlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtTakimAdi;
        private System.Windows.Forms.TextBox txtYasOrtalamasi;
        private System.Windows.Forms.TextBox txtTakimUlkesi;
        private System.Windows.Forms.TextBox txtLigSirasi;
        private System.Windows.Forms.TextBox txtKadroDegeri;
        private System.Windows.Forms.TextBox txtStatAdi;
        private System.Windows.Forms.TextBox txtTakimLigi;
        private System.Windows.Forms.TextBox txtTakimId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOyuncuSayisi;
        private System.Windows.Forms.TextBox txtAra;
    }
}