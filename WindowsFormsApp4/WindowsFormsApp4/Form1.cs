﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Rehber
        {
            //Sınıfımızı Oluşturduk.
            public string ad;
            public string soyad;
            public string numara;
            public string adres;

        }
        //Ekle Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            //Bir nesne türettik.
            //Nesnemizin içindeki propertieler'e textBox değerlerini atadık.
            Rehber rbr = new Rehber();
            rbr.ad = textBox1.Text;
            rbr.soyad = textBox2.Text;
            rbr.numara = textBox3.Text;
            rbr.adres = textBox4.Text;
            //Aktardığımız propertielerdeki verileri DataGridView1 ' e bastık.
            dataGridView1.Rows.Add(new object[] {rbr.ad,rbr.soyad,rbr.numara,rbr.adres });

        }
        //Temizle butonu
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Arama butonu 
            //TextBox5'e yazılan değeri tüm DataGridView' i gezerek arıyor ve bulduğunda duruyor ve onu seçiyor.
            string AramaButonu = textBox5.Text;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Selected = false;
                    if (row.Cells[0].Value.ToString().Equals(AramaButonu))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                //Try-catch ile hata bulduğu zaman ekrana basıyor.
                MessageBox.Show(exc.Message);
            }
        }
    }
}
