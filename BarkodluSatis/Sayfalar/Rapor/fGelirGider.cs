﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis.Sayfalar.Rapor
{
    public partial class fGelirGider : Form
    {
        public fGelirGider()
        {
            InitializeComponent();
        }

        public string GelirGider { get; set; }
        public string Kullanici { get; set; }

        private void fGelirGider_Load(object sender, EventArgs e)
        {
            lGelirGider.Text = GelirGider + "İşlemi Yapılıyor";
        }

        private void cmbOdemeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOdemeTuru.SelectedIndex == 0)
            {
                tNakit.Enabled = true;
                tKart.Enabled = false;
            }

            else if (cmbOdemeTuru.SelectedIndex == 1)
            {
                tNakit.Enabled = false;
                tKart.Enabled = true;
            }

            else if (cmbOdemeTuru.SelectedIndex == 2)
            {
                tNakit.Enabled = true;
                tKart.Enabled = true;
            }
            tNakit.Text = "0";
            tKart.Text = "0";
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            if (cmbOdemeTuru.Text != "")
            {
                if (tNakit.Text != "" && tKart.Text != "")
                {
                    if (tKart.Text != "0" || tNakit.Text != "0")
                    {
                        using (var db = new BarkodluDbEntities())
                        {
                            IslemOzet io = new IslemOzet();
                            io.IslemNo = 0;
                            io.Iade = false;
                            io.OdemeSekli = cmbOdemeTuru.Text;
                            io.Nakit = Islemler.Double.DoubleYap(tNakit.Text);
                            io.Kart = Islemler.Double.DoubleYap(tKart.Text);

                            if (GelirGider == "Gelir")
                            {
                                io.Gelir = true;
                                io.Gider = false;
                            }
                            else
                            {
                                io.Gelir = false;
                                io.Gider = true;
                            }
                            io.AlisFiyatToplam = 0;
                            io.Aciklama = GelirGider + " - işlemi " + tAciklama.Text;
                            io.Tarih = dateTarih.Value;
                            io.Kullanici = Kullanici;

                            db.IslemOzet.Add(io);
                            db.SaveChanges();
                            MessageBox.Show(GelirGider + " işlemi kaydedildi");

                            tNakit.Text = "0";
                            tKart.Text = "0";
                            tAciklama.Clear();
                            cmbOdemeTuru.Text = "";

                            fRapor f = (fRapor)Application.OpenForms["fRapor"];
                            if (f != null)
                            {
                                f.bGoster_Click(null, null);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nakit yada kart fiyatı 0₺ olamaz!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen ödeme türünü belirleyiniz");
            }
        }
    }
}
