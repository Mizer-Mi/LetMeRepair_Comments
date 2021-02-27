using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace LetMeRepair_Comments
{
    public partial class ekle_sirtuex : Form
    {
        public ekle_sirtuex()
        {
            InitializeComponent();
        }
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        string baglanti_id;
        DataTable ariza_list = baglanti.listele("ariza", "0");
        private void button1_Click(object sender, EventArgs e)
        {



            if ( baslik.Text.StartsWith(" ") || baslik.Text.Replace(" ","") == "" || baslik.Text.Length <= 4 )
            {
                MessageBox.Show(gecerli_baslik, "LetMeRepair - Mizer - Hatalı Başlık", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            if (baglanti.tekrar_sorgula(secili_tur,baslik.Text) == "Devam")
            {
                if (secili_tur=="degisen_parca")
                {
                
                  baglanti_id= baglanti.baglanti_no_cekme(arizasi.SelectedItem.ToString());
                }
                string secili_arizasilar = "";
                string getirici = "";
                for (int i = 0; arizasi.SelectedItems.Count > i ; i++)
                {

                    getirici = ((DataRowView)arizasi.SelectedItems[i])["id"].ToString();
                secili_arizasilar = secili_arizasilar + "-" + getirici;
                }

                baglanti.ekle_tur(secili_tur, baslik.Text, english_rich.Text, turkish_ric.Text, secili_arizasilar);
                    ariza_listesi_yenile();
                MessageBox.Show(kayit_eklendi,"LMR-Sirtuex-Mizer",MessageBoxButtons.OK,MessageBoxIcon.Information);
                temizle();
                
                
            }
            else if (baglanti.tekrar_sorgula(secili_tur, baslik.Text) == "Mevcut")
            {
                MessageBox.Show(ayni_basliktan,"LMR-Sirtuex-Mizer",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            }

        }
        private void temizle()
        {
            english_rich.Text = "";
            turkish_ric.Text = "";
            baslik.Text = "";
            
        }
        private void ariza_CheckedChanged(object sender, EventArgs e)
        {
            turu_sec_sorgusu();
        }
        string secili_tur;
        string bagli_no;
        private void turu_sec_sorgusu()
        {
            if (ariza.Checked == true)
            {
                panel_ariza_bagli.Visible = false;
                panel_main.Visible = true;
                secili_tur = "ariza";
                textBox1_TextChanged(null, null);

            }
            else if (degisen_parca.Checked == true)
            {
                panel_ariza_bagli.Visible = true;
                panel_main.Visible = true;
                secili_tur = "degisen_parca";
                textBox1_TextChanged(null, null);
            }
            else if (kut.Checked == true)
            {
                panel_ariza_bagli.Visible = false;
                panel_main.Visible = true;
                secili_tur = "kut";
                textBox1_TextChanged(null, null);
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (baslik.Text == "" || baslik.Text == " " || baslik.Text == "   " || baslik.Text.StartsWith(" ") )
            {
                kydt.Enabled = false;
            }
            else
            {
                kydt.Enabled = true;
                arizasi_SelectedIndexChanged(null, null);
               
            }
        }

        private void degisen_parca_CheckedChanged(object sender, EventArgs e)
        {
            turu_sec_sorgusu();
        }

        private void kut_CheckedChanged(object sender, EventArgs e)
        {
            turu_sec_sorgusu();
        }

        private void ekle_sirtuex_Load(object sender, EventArgs e)
        {
            dil_ayari_Cek();
            Blink();
            secili_tur = "ariza";
            bagli_no = "0";
            baglanti_id = "0";
            arizasi.DataSource = ariza_list;
            arizasi.DisplayMember = "baslik";
            arizasi.ValueMember = "id";

            SendMessage(arama_parca.Handle, EM_SETCUEBANNER, 0, dil.dil_ayari_yap("arama_parca"));
            SendMessage(baslik.Handle, EM_SETCUEBANNER, 0, dil.dil_ayari_yap("baslik_plchldr"));
        }
        private async void Blink()
        {
            while (true)
            {
                if (panel_main.Visible == true)
                {
                    await Task.Delay(250);
                    label4.Visible = false;
                }
                else
                {
                    label4.Visible = true;
                    await Task.Delay(500);
                    if (label4.ForeColor == Color.Red) { label4.ForeColor = Color.Green; } else { label4.ForeColor = Color.Red; }
                }

            }

        }
        private void ariza_listesi_yenile()
        {
            ariza_list = baglanti.listele("ariza", "0");
        }
        private void arizasi_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (secili_tur == "degisen_parca")
            { 
           if (  arizasi.SelectedItem == null)
            {
                kydt.Enabled = false;
            }
           else
            {
                kydt.Enabled = true;
            }
            }
           */
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            english_rich.Text = "";
            baslik.Text = "";
            turkish_ric.Text = "";
            panel_main.Visible = false;
        }
    }
}
