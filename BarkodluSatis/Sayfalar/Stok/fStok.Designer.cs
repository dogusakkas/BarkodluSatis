
namespace BarkodluSatis.Sayfalar.Stok
{
    partial class fStok
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbIslemTuru = new System.Windows.Forms.ComboBox();
            this.bAra = new System.Windows.Forms.Button();
            this.panelTarihler = new System.Windows.Forms.Panel();
            this.dataBitisTarih = new System.Windows.Forms.DateTimePicker();
            this.dateBaslangicTarih = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbUrunGrubunaGore = new System.Windows.Forms.RadioButton();
            this.rbTumu = new System.Windows.Forms.RadioButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.labelStandart1 = new BarkodluSatis.OzelNesneler.labelStandart();
            this.labelStandart5 = new BarkodluSatis.OzelNesneler.labelStandart();
            this.labelStandart4 = new BarkodluSatis.OzelNesneler.labelStandart();
            this.labelStandart3 = new BarkodluSatis.OzelNesneler.labelStandart();
            this.labelStandart2 = new BarkodluSatis.OzelNesneler.labelStandart();
            this.tUrunAra = new BarkodluSatis.OzelNesneler.textboxStandart();
            this.labelStandart6 = new BarkodluSatis.OzelNesneler.labelStandart();
            this.gridListe = new BarkodluSatis.OzelNesneler.gridDataViewOzel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelTarihler.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.bAra);
            this.splitContainer1.Panel1.Controls.Add(this.panelTarihler);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 544);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelStandart1);
            this.panel4.Controls.Add(this.cmbIslemTuru);
            this.panel4.Location = new System.Drawing.Point(12, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 70);
            this.panel4.TabIndex = 8;
            // 
            // cmbIslemTuru
            // 
            this.cmbIslemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIslemTuru.FormattingEnabled = true;
            this.cmbIslemTuru.Items.AddRange(new object[] {
            "Stok Durumu",
            "Stok Giriş İzleme"});
            this.cmbIslemTuru.Location = new System.Drawing.Point(14, 35);
            this.cmbIslemTuru.Name = "cmbIslemTuru";
            this.cmbIslemTuru.Size = new System.Drawing.Size(152, 24);
            this.cmbIslemTuru.TabIndex = 1;
            // 
            // bAra
            // 
            this.bAra.BackColor = System.Drawing.Color.Teal;
            this.bAra.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.bAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAra.ForeColor = System.Drawing.Color.White;
            this.bAra.Location = new System.Drawing.Point(75, 442);
            this.bAra.Name = "bAra";
            this.bAra.Size = new System.Drawing.Size(103, 73);
            this.bAra.TabIndex = 7;
            this.bAra.Text = "Ara";
            this.bAra.UseVisualStyleBackColor = false;
            this.bAra.Click += new System.EventHandler(this.bAra_Click);
            // 
            // panelTarihler
            // 
            this.panelTarihler.Controls.Add(this.dataBitisTarih);
            this.panelTarihler.Controls.Add(this.labelStandart5);
            this.panelTarihler.Controls.Add(this.dateBaslangicTarih);
            this.panelTarihler.Controls.Add(this.labelStandart4);
            this.panelTarihler.Location = new System.Drawing.Point(12, 273);
            this.panelTarihler.Name = "panelTarihler";
            this.panelTarihler.Size = new System.Drawing.Size(237, 143);
            this.panelTarihler.TabIndex = 6;
            // 
            // dataBitisTarih
            // 
            this.dataBitisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataBitisTarih.Location = new System.Drawing.Point(14, 109);
            this.dataBitisTarih.Name = "dataBitisTarih";
            this.dataBitisTarih.Size = new System.Drawing.Size(200, 23);
            this.dataBitisTarih.TabIndex = 3;
            // 
            // dateBaslangicTarih
            // 
            this.dateBaslangicTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBaslangicTarih.Location = new System.Drawing.Point(14, 38);
            this.dateBaslangicTarih.Name = "dateBaslangicTarih";
            this.dateBaslangicTarih.Size = new System.Drawing.Size(200, 23);
            this.dateBaslangicTarih.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelStandart3);
            this.panel2.Controls.Add(this.cmbUrunGrubu);
            this.panel2.Location = new System.Drawing.Point(12, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 71);
            this.panel2.TabIndex = 5;
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Location = new System.Drawing.Point(14, 33);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(152, 24);
            this.cmbUrunGrubu.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbUrunGrubunaGore);
            this.panel1.Controls.Add(this.rbTumu);
            this.panel1.Controls.Add(this.labelStandart2);
            this.panel1.Location = new System.Drawing.Point(12, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 100);
            this.panel1.TabIndex = 4;
            // 
            // rbUrunGrubunaGore
            // 
            this.rbUrunGrubunaGore.AutoSize = true;
            this.rbUrunGrubunaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbUrunGrubunaGore.Location = new System.Drawing.Point(13, 59);
            this.rbUrunGrubunaGore.Name = "rbUrunGrubunaGore";
            this.rbUrunGrubunaGore.Size = new System.Drawing.Size(153, 21);
            this.rbUrunGrubunaGore.TabIndex = 4;
            this.rbUrunGrubunaGore.Text = "Ürün Grubuna Göre";
            this.rbUrunGrubunaGore.UseVisualStyleBackColor = true;
            // 
            // rbTumu
            // 
            this.rbTumu.AutoSize = true;
            this.rbTumu.Checked = true;
            this.rbTumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTumu.Location = new System.Drawing.Point(13, 32);
            this.rbTumu.Name = "rbTumu";
            this.rbTumu.Size = new System.Drawing.Size(62, 21);
            this.rbTumu.TabIndex = 3;
            this.rbTumu.TabStop = true;
            this.rbTumu.Text = "Tümü";
            this.rbTumu.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer2.Panel1.Controls.Add(this.tUrunAra);
            this.splitContainer2.Panel1.Controls.Add(this.labelStandart6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gridListe);
            this.splitContainer2.Size = new System.Drawing.Size(541, 544);
            this.splitContainer2.SplitterDistance = 46;
            this.splitContainer2.TabIndex = 0;
            // 
            // labelStandart1
            // 
            this.labelStandart1.AutoSize = true;
            this.labelStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStandart1.ForeColor = System.Drawing.Color.Red;
            this.labelStandart1.Location = new System.Drawing.Point(10, 12);
            this.labelStandart1.Name = "labelStandart1";
            this.labelStandart1.Size = new System.Drawing.Size(83, 20);
            this.labelStandart1.TabIndex = 0;
            this.labelStandart1.Text = "İşlem Türü";
            // 
            // labelStandart5
            // 
            this.labelStandart5.AutoSize = true;
            this.labelStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStandart5.ForeColor = System.Drawing.Color.Red;
            this.labelStandart5.Location = new System.Drawing.Point(10, 84);
            this.labelStandart5.Name = "labelStandart5";
            this.labelStandart5.Size = new System.Drawing.Size(81, 20);
            this.labelStandart5.TabIndex = 2;
            this.labelStandart5.Text = "Bitiş Tarihi";
            // 
            // labelStandart4
            // 
            this.labelStandart4.AutoSize = true;
            this.labelStandart4.BackColor = System.Drawing.Color.Transparent;
            this.labelStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStandart4.ForeColor = System.Drawing.Color.Red;
            this.labelStandart4.Location = new System.Drawing.Point(10, 13);
            this.labelStandart4.Name = "labelStandart4";
            this.labelStandart4.Size = new System.Drawing.Size(120, 20);
            this.labelStandart4.TabIndex = 0;
            this.labelStandart4.Text = "Başlangıç Tarihi";
            // 
            // labelStandart3
            // 
            this.labelStandart3.AutoSize = true;
            this.labelStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStandart3.ForeColor = System.Drawing.Color.Red;
            this.labelStandart3.Location = new System.Drawing.Point(14, 7);
            this.labelStandart3.Name = "labelStandart3";
            this.labelStandart3.Size = new System.Drawing.Size(93, 20);
            this.labelStandart3.TabIndex = 6;
            this.labelStandart3.Text = "Ürün Grubu";
            // 
            // labelStandart2
            // 
            this.labelStandart2.AutoSize = true;
            this.labelStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStandart2.ForeColor = System.Drawing.Color.Red;
            this.labelStandart2.Location = new System.Drawing.Point(9, 9);
            this.labelStandart2.Name = "labelStandart2";
            this.labelStandart2.Size = new System.Drawing.Size(114, 20);
            this.labelStandart2.TabIndex = 2;
            this.labelStandart2.Text = "Filtreleme Türü";
            // 
            // tUrunAra
            // 
            this.tUrunAra.BackColor = System.Drawing.Color.White;
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAra.Location = new System.Drawing.Point(110, 10);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(250, 26);
            this.tUrunAra.TabIndex = 1;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // labelStandart6
            // 
            this.labelStandart6.AutoSize = true;
            this.labelStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStandart6.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelStandart6.Location = new System.Drawing.Point(20, 13);
            this.labelStandart6.Name = "labelStandart6";
            this.labelStandart6.Size = new System.Drawing.Size(73, 20);
            this.labelStandart6.TabIndex = 0;
            this.labelStandart6.Text = "Ürün Ara";
            // 
            // gridListe
            // 
            this.gridListe.AllowUserToAddRows = false;
            this.gridListe.AllowUserToDeleteRows = false;
            this.gridListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListe.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListe.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridListe.EnableHeadersVisualStyles = false;
            this.gridListe.Location = new System.Drawing.Point(0, 0);
            this.gridListe.Name = "gridListe";
            this.gridListe.ReadOnly = true;
            this.gridListe.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListe.RowHeadersVisible = false;
            this.gridListe.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListe.RowTemplate.Height = 35;
            this.gridListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListe.Size = new System.Drawing.Size(541, 494);
            this.gridListe.TabIndex = 23;
            this.gridListe.TabStop = false;
            // 
            // fStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fStok";
            this.Text = "Stok İzleme";
            this.Load += new System.EventHandler(this.fStok_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelTarihler.ResumeLayout(false);
            this.panelTarihler.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel4;
        private OzelNesneler.labelStandart labelStandart1;
        private System.Windows.Forms.Button bAra;
        private System.Windows.Forms.Panel panelTarihler;
        private System.Windows.Forms.DateTimePicker dataBitisTarih;
        private OzelNesneler.labelStandart labelStandart5;
        private System.Windows.Forms.DateTimePicker dateBaslangicTarih;
        private OzelNesneler.labelStandart labelStandart4;
        private System.Windows.Forms.Panel panel2;
        private OzelNesneler.labelStandart labelStandart3;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbUrunGrubunaGore;
        private System.Windows.Forms.RadioButton rbTumu;
        private OzelNesneler.labelStandart labelStandart2;
        private System.Windows.Forms.ComboBox cmbIslemTuru;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private OzelNesneler.textboxStandart tUrunAra;
        private OzelNesneler.labelStandart labelStandart6;
        private OzelNesneler.gridDataViewOzel gridListe;
    }
}