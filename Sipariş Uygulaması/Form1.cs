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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupboxkisiselbilgiler_Enter(object sender, EventArgs e)
        {

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            groupboxkisiselbilgiler.Enabled = false;
          
        }
        private void toolStripMenuItemkb_Click(object sender, EventArgs e)
        {
            groupboxkisiselbilgiler.Enabled = true;
        }
        public static string AdSoyad, TcNo, Telefon, Adres, Cinsiyet, il;

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            AdSoyad = textboxadsoyad.Text.ToString();
            TcNo = textboxtc.Text.ToString();
            Telefon = textboxtel.Text.ToString();
            Adres = textboxadres.Text.ToString();
            if (radiobuttonerkek.Checked == true)
            {
                Cinsiyet = "Erkek";
            }
            else
            {
                Cinsiyet = "Kadın";
            }
            il = comboboxil.Text.ToString();
        }


        private void btnsifirla_Click(object sender, EventArgs e)
        {
            textboxadsoyad.Text = "";
            textboxtc.Text = "";
            textboxtel.Text = "";
            textboxadres.Text = "";
            comboboxil.Text = "";
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void toolStripMenuItemhk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İsmail Aktaş Tarafından Yazılmıştır");
        }

    }
}
