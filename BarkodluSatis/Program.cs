﻿using BarkodluSatis.Sayfalar.Satış;
using BarkodluSatis.Sayfalar.Stok;
using BarkodluSatis.Sayfalar.Ürün;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fStok());
        }
    }
}
