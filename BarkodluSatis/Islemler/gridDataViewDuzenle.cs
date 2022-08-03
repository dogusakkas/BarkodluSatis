using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis.Islemler
{
    public class gridDataViewDuzenle
    {
        public static void GridDuzenle(DataGridView dataGridView)
        {
            if (dataGridView.Columns.Count > 0)
            {
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    switch (dataGridView.Columns[i].HeaderText)
                    {
                        case "Id":
                            dataGridView.Columns[i].HeaderText = "Numara";
                            dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;

                        case "IslemNo":
                            dataGridView.Columns[i].HeaderText = "İşlem No";
                            break;

                        case "UrunAd":
                            dataGridView.Columns[i].HeaderText = "Ürün Adı";
                            break;

                        case "UrunGrup":
                            dataGridView.Columns[i].HeaderText = "Ürün Grup";
                            break;

                        case "Aciklama":
                            dataGridView.Columns[i].HeaderText = "Açıklama";
                            break;

                        case "AlisFiyat":
                            dataGridView.Columns[i].HeaderText = "Alış Fiyatı";
                            dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dataGridView.Columns[i].DefaultCellStyle.Format = "C2";
                            break;

                        case "AlisFiyati":
                            dataGridView.Columns[i].HeaderText = "Alış Fiyatı";
                            dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dataGridView.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                        case "AlisFiyatToplam":
                            dataGridView.Columns[i].HeaderText = "Toplam Alış Fiyatı";
                            dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dataGridView.Columns[i].DefaultCellStyle.Format = "C2";
                            break;

                        case "SatisFiyat":
                            dataGridView.Columns[i].HeaderText = "Satış Fiyatı";
                            dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            dataGridView.Columns[i].DefaultCellStyle.Format = "C2";
                            break;

                        case "Miktar":
                            dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;

                        case "KdvOrani":
                            dataGridView.Columns[i].HeaderText = "Kdv Oranı";
                            dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;

                        case "KdvTutari":
                            dataGridView.Columns[i].HeaderText = "Kdv Tutarı";
                            dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;

                        case "OdemeSekli":
                            dataGridView.Columns[i].HeaderText = "Ödeme Şekli";
                            dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;

                        case "Iade":
                            dataGridView.Columns[i].HeaderText = "İade";
                            break;

                        case "Kullanici":
                            dataGridView.Columns[i].HeaderText = "Kullanıcı";
                            break;

                        case "Birim":
                            dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;

                        case "Kart":
                            dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dataGridView.Columns[i].DefaultCellStyle.Format = "C2";
                            break;

                        case "Nakit":
                            dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dataGridView.Columns[i].DefaultCellStyle.Format = "C2";
                            break;

                        case "Gelir":
                            dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dataGridView.Columns[i].DefaultCellStyle.Format = "C2";
                            break;

                        case "Gider":
                            dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            dataGridView.Columns[i].DefaultCellStyle.Format = "C2";
                            break;
                    }
                }
            }
        }
    }
}
