﻿
namespace BarkodluSatis.Sayfalar.Rapor
{
    partial class fDetayGoster
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
            this.lIslemNo = new BarkodluSatis.OzelNesneler.labelStandart();
            this.lTarih = new BarkodluSatis.OzelNesneler.labelStandart();
            this.labelStandart2 = new BarkodluSatis.OzelNesneler.labelStandart();
            this.labelStandart1 = new BarkodluSatis.OzelNesneler.labelStandart();
            this.gridListe = new BarkodluSatis.OzelNesneler.gridDataViewOzel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lIslemNo);
            this.splitContainer1.Panel1.Controls.Add(this.lTarih);
            this.splitContainer1.Panel1.Controls.Add(this.labelStandart2);
            this.splitContainer1.Panel1.Controls.Add(this.labelStandart1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridListe);
            this.splitContainer1.Size = new System.Drawing.Size(523, 340);
            this.splitContainer1.SplitterDistance = 89;
            this.splitContainer1.TabIndex = 0;
            // 
            // lIslemNo
            // 
            this.lIslemNo.AutoSize = true;
            this.lIslemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lIslemNo.Location = new System.Drawing.Point(98, 13);
            this.lIslemNo.Name = "lIslemNo";
            this.lIslemNo.Size = new System.Drawing.Size(18, 20);
            this.lIslemNo.TabIndex = 3;
            this.lIslemNo.Text = "0";
            // 
            // lTarih
            // 
            this.lTarih.AutoSize = true;
            this.lTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lTarih.Location = new System.Drawing.Point(98, 47);
            this.lTarih.Name = "lTarih";
            this.lTarih.Size = new System.Drawing.Size(113, 20);
            this.lTarih.TabIndex = 2;
            this.lTarih.Text = "labelStandart3";
            // 
            // labelStandart2
            // 
            this.labelStandart2.AutoSize = true;
            this.labelStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStandart2.Location = new System.Drawing.Point(40, 47);
            this.labelStandart2.Name = "labelStandart2";
            this.labelStandart2.Size = new System.Drawing.Size(52, 20);
            this.labelStandart2.TabIndex = 1;
            this.labelStandart2.Text = "Tarih :";
            // 
            // labelStandart1
            // 
            this.labelStandart1.AutoSize = true;
            this.labelStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelStandart1.Location = new System.Drawing.Point(13, 13);
            this.labelStandart1.Name = "labelStandart1";
            this.labelStandart1.Size = new System.Drawing.Size(79, 20);
            this.labelStandart1.TabIndex = 0;
            this.labelStandart1.Text = "İşlem No :";
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
            this.gridListe.Size = new System.Drawing.Size(523, 247);
            this.gridListe.TabIndex = 25;
            this.gridListe.TabStop = false;
            // 
            // fDetayGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 340);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fDetayGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detay Göster";
            this.Load += new System.EventHandler(this.fDetayGoster_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private OzelNesneler.labelStandart lTarih;
        private OzelNesneler.labelStandart labelStandart2;
        private OzelNesneler.labelStandart labelStandart1;
        private OzelNesneler.gridDataViewOzel gridListe;
        private OzelNesneler.labelStandart lIslemNo;
    }
}