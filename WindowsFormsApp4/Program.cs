/****************************************************************************
********************* SAKARYA ÜNİVERSİTESİ***********************************
************* BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ**********************
************** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ************************
**************** NESNEYE DAYALI PROGRAMLAMA DERSİ****************************
******************** 2019-2020 BAHAR DÖNEMİ**********************************
*****************************************************************************
** ÖDEV NUMARASI..........:1. Ödev  *****************************************
** ÖĞRENCİ ADI............:Çağlar YILMAZ  ***********************************
** ÖĞRENCİ NUMARASI.......:B151200029  **************************************
** DERSİN ALINDIĞI GRUP...: A Grubu  ****************************************
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
