
namespace BarkodluSatis.Sayfalar.Satış
{
    partial class fUrunGrubuEkle
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
            this.listUrunGrup = new System.Windows.Forms.ListBox();
            this.tUrunGrupAd = new BarkodluSatis.OzelNesneler.textboxStandart();
            this.labelStandart1 = new BarkodluSatis.OzelNesneler.labelStandart();
            this.bSil = new System.Windows.Forms.Button();
            this.bEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listUrunGrup
            // 
            this.listUrunGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listUrunGrup.FormattingEnabled = true;
            this.listUrunGrup.ItemHeight = 20;
            this.listUrunGrup.Location = new System.Drawing.Point(20, 83);
            this.listUrunGrup.Name = "listUrunGrup";
            this.listUrunGrup.Size = new System.Drawing.Size(318, 164);
            this.listUrunGrup.TabIndex = 2;
            // 
            // tUrunGrupAd
            // 
            this.tUrunGrupAd.BackColor = System.Drawing.Color.White;
            this.tUrunGrupAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunGrupAd.Location = new System.Drawing.Point(154, 25);
            this.tUrunGrupAd.Name = "tUrunGrupAd";
            this.tUrunGrupAd.Size = new System.Drawing.Size(184, 26);
            this.tUrunGrupAd.TabIndex = 1;
            // 
            // labelStandart1
            // 
            this.labelStandart1.AutoSize = true;
            this.labelStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStandart1.Location = new System.Drawing.Point(16, 29);
            this.labelStandart1.Name = "labelStandart1";
            this.labelStandart1.Size = new System.Drawing.Size(120, 20);
            this.labelStandart1.TabIndex = 0;
            this.labelStandart1.Text = "Ürün Grubu Adı";
            // 
            // bSil
            // 
            this.bSil.BackColor = System.Drawing.Color.DarkRed;
            this.bSil.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.bSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSil.ForeColor = System.Drawing.Color.White;
            this.bSil.Location = new System.Drawing.Point(20, 264);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(149, 104);
            this.bSil.TabIndex = 3;
            this.bSil.Text = "Sil";
            this.bSil.UseVisualStyleBackColor = false;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // bEkle
            // 
            this.bEkle.BackColor = System.Drawing.Color.YellowGreen;
            this.bEkle.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.bEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEkle.ForeColor = System.Drawing.Color.White;
            this.bEkle.Location = new System.Drawing.Point(189, 264);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(149, 104);
            this.bEkle.TabIndex = 4;
            this.bEkle.Text = "Ekle";
            this.bEkle.UseVisualStyleBackColor = false;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // fUrunGrubuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(364, 403);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.listUrunGrup);
            this.Controls.Add(this.tUrunGrupAd);
            this.Controls.Add(this.labelStandart1);
            this.Name = "fUrunGrubuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Grubu İşlemleri";
            this.Load += new System.EventHandler(this.fUrunGrubuEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OzelNesneler.labelStandart labelStandart1;
        private OzelNesneler.textboxStandart tUrunGrupAd;
        private System.Windows.Forms.ListBox listUrunGrup;
        private System.Windows.Forms.Button bSil;
        private System.Windows.Forms.Button bEkle;
    }
}