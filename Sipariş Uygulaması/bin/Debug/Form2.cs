using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sipariş_Uygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBoxliste.Visible = false;

        }

        private void btnonayla_Click(object sender, EventArgs e)
        {
            groupBoxliste.Visible = true;
            string siparisler = "";
            int tutar = 0;
            if (checkBoxdoner.Checked==true)
            {
                siparisler += "döner";
                tutar += 10;
            }
            if (checkBoxhamburger.Checked==true)
            {
                siparisler += "hamburger";
                tutar += 7;
            }
            if (checkBoxlahmacun.Checked==true)
            {
                siparisler += "lahmacun";
                tutar += 3;
            }
            if (checkBoxsandwich.Checked==true)
            {
                siparisler += "sandwich";
                tutar += 2;
            }
            listBoxadsoyad.Items.Add(Form1.AdSoyad);
            listBoxtc.Items.Add(Form1.TcNo);
            listBoxtel.Items.Add(Form1.Telefon);
            listBoxcinsiyet.Items.Add(Form1.Cinsiyet);
            listBoxilce.Items.Add(Form1.il);
            listBoxadres.Items.Add(Form1.Adres);
            listBoxsiparis.Items.Add(siparisler);
            labeltutar.Text = tutar.ToString() + "TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

    }
}
