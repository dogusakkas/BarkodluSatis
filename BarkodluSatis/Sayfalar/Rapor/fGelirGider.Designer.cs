
namespace BarkodluSatis.Sayfalar.Rapor
{
    partial class fGelirGider
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
            this.lGelirGider = new BarkodluSatis.OzelNesneler.labelStandart();
            this.cmbOdemeTuru = new System.Windows.Forms.ComboBox();
            this.labelStandart2 = new BarkodluSatis.OzelNesneler.labelStandart();
            this.tNakit = new BarkodluSatis.OzelNesneler.textboxStandart();
            this.labelStandart3 = new BarkodluSatis.OzelNesneler.labelStandart();
            this.labelStandart4 = new BarkodluSatis.OzelNesneler.labelStandart();
            this.tAciklama = new BarkodluSatis.OzelNesneler.textboxStandart();
            this.labelStandart5 = new BarkodluSatis.OzelNesneler.labelStandart();
            this.dateTarih = new System.Windows.Forms.DateTimePicker();
            this.labelStandart7 = new BarkodluSatis.OzelNesneler.labelStandart();
            this.tKart = new BarkodluSatis.OzelNesneler.textboxStandart();
            this.bEkle = new BarkodluSatis.OzelNesneler.buttonResimli();
            this.SuspendLayout();
            // 
            // lGelirGider
            // 
            this.lGelirGider.AutoSize = true;
            this.lGelirGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lGelirGider.Location = new System.Drawing.Point(13, 13);
            this.lGelirGider.Name = "lGelirGider";
            this.lGelirGider.Size = new System.Drawing.Size(85, 20);
            this.lGelirGider.TabIndex = 0;
            this.lGelirGider.Text = "Gelir Gider";
            // 
            // cmbOdemeTuru
            // 
            this.cmbOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOdemeTuru.FormattingEnabled = true;
            this.cmbOdemeTuru.Items.AddRange(new object[] {
            "Nakit",
            "Kart",
            "Nakit-Kart"});
            this.cmbOdemeTuru.Location = new System.Drawing.Point(17, 85);
            this.cmbOdemeTuru.Name = "cmbOdemeTuru";
            this.cmbOdemeTuru.Size = new System.Drawing.Size(196, 24);
            this.cmbOdemeTuru.TabIndex = 2;
            this.cmbOdemeTuru.SelectedIndexChanged += new System.EventHandler(this.cmbOdemeTuru_SelectedIndexChanged);
            // 
            // labelStandart2
            // 
            this.labelStandart2.AutoSize = true;
            this.labelStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStandart2.Location = new System.Drawing.Point(13, 51);
            this.labelStandart2.Name = "labelStandart2";
            this.labelStandart2.Size = new System.Drawing.Size(97, 20);
            this.labelStandart2.TabIndex = 3;
            this.labelStandart2.Text = "Ödeme Türü";
            // 
            // tNakit
            // 
            this.tNakit.BackColor = System.Drawing.Color.White;
            this.tNakit.Enabled = false;
            this.tNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tNakit.Location = new System.Drawing.Point(17, 145);
            this.tNakit.Name = "tNakit";
            this.tNakit.Size = new System.Drawing.Size(97, 26);
            this.tNakit.TabIndex = 4;
            this.tNakit.Text = "₺0,00";
            // 
            // labelStandart3
            // 
            this.labelStandart3.AutoSize = true;
            this.labelStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStandart3.Location = new System.Drawing.Point(16, 122);
            this.labelStandart3.Name = "labelStandart3";
            this.labelStandart3.Size = new System.Drawing.Size(45, 20);
            this.labelStandart3.TabIndex = 6;
            this.labelStandart3.Text = "Nakit";
            // 
            // labelStandart4
            // 
            this.labelStandart4.AutoSize = true;
            this.labelStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStandart4.Location = new System.Drawing.Point(116, 122);
            this.labelStandart4.Name = "labelStandart4";
            this.labelStandart4.Size = new System.Drawing.Size(38, 20);
            this.labelStandart4.TabIndex = 7;
            this.labelStandart4.Text = "Kart";
            // 
            // tAciklama
            // 
            this.tAciklama.BackColor = System.Drawing.Color.White;
            this.tAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tAciklama.Location = new System.Drawing.Point(13, 209);
            this.tAciklama.Multiline = true;
            this.tAciklama.Name = "tAciklama";
            this.tAciklama.Size = new System.Drawing.Size(201, 97);
            this.tAciklama.TabIndex = 8;
            // 
            // labelStandart5
            // 
            this.labelStandart5.AutoSize = true;
            this.labelStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStandart5.Location = new System.Drawing.Point(14, 186);
            this.labelStandart5.Name = "labelStandart5";
            this.labelStandart5.Size = new System.Drawing.Size(73, 20);
            this.labelStandart5.TabIndex = 9;
            this.labelStandart5.Text = "Açıklama";
            // 
            // dateTarih
            // 
            this.dateTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTarih.Location = new System.Drawing.Point(16, 346);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(200, 23);
            this.dateTarih.TabIndex = 11;
            // 
            // labelStandart7
            // 
            this.labelStandart7.AutoSize = true;
            this.labelStandart7.BackColor = System.Drawing.Color.Transparent;
            this.labelStandart7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStandart7.ForeColor = System.Drawing.Color.Red;
            this.labelStandart7.Location = new System.Drawing.Point(12, 321);
            this.labelStandart7.Name = "labelStandart7";
            this.labelStandart7.Size = new System.Drawing.Size(44, 20);
            this.labelStandart7.TabIndex = 10;
            this.labelStandart7.Text = "Tarih";
            // 
            // tKart
            // 
            this.tKart.BackColor = System.Drawing.Color.White;
            this.tKart.Enabled = false;
            this.tKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tKart.Location = new System.Drawing.Point(120, 145);
            this.tKart.Name = "tKart";
            this.tKart.Size = new System.Drawing.Size(97, 26);
            this.tKart.TabIndex = 12;
            this.tKart.Text = "₺0,00";
            // 
            // bEkle
            // 
            this.bEkle.BackColor = System.Drawing.Color.Tomato;
            this.bEkle.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.bEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEkle.ForeColor = System.Drawing.Color.White;
            this.bEkle.Image = global::BarkodluSatis.Properties.Resources.add;
            this.bEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEkle.Location = new System.Drawing.Point(65, 386);
            this.bEkle.Margin = new System.Windows.Forms.Padding(1);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(98, 54);
            this.bEkle.TabIndex = 0;
            this.bEkle.Text = "   Ekle";
            this.bEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bEkle.UseVisualStyleBackColor = false;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // fGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(239, 455);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.tKart);
            this.Controls.Add(this.dateTarih);
            this.Controls.Add(this.labelStandart7);
            this.Controls.Add(this.labelStandart5);
            this.Controls.Add(this.tAciklama);
            this.Controls.Add(this.labelStandart4);
            this.Controls.Add(this.labelStandart3);
            this.Controls.Add(this.tNakit);
            this.Controls.Add(this.labelStandart2);
            this.Controls.Add(this.cmbOdemeTuru);
            this.Controls.Add(this.lGelirGider);
            this.MaximumSize = new System.Drawing.Size(255, 494);
            this.MinimumSize = new System.Drawing.Size(255, 494);
            this.Name = "fGelirGider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelir Gider İşlemleri";
            this.Load += new System.EventHandler(this.fGelirGider_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OzelNesneler.labelStandart lGelirGider;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private OzelNesneler.labelStandart labelStandart2;
        private OzelNesneler.textboxStandart tNakit;
        private OzelNesneler.labelStandart labelStandart3;
        private OzelNesneler.labelStandart labelStandart4;
        private OzelNesneler.textboxStandart tAciklama;
        private OzelNesneler.labelStandart labelStandart5;
        private System.Windows.Forms.DateTimePicker dateTarih;
        private OzelNesneler.labelStandart labelStandart7;
        private OzelNesneler.textboxStandart tKart;
        private OzelNesneler.buttonResimli bEkle;
    }
}