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
    public partial class duzenle_sirtuex : Form
    {
        public duzenle_sirtuex()
        {
            InitializeComponent();
        }


        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);


        private void liste_yenilemesi ()
        {
             degisen_parca_tum_db = baglanti.listele("degisen_parca", "%");
            degisen_parca.DataSource = degisen_parca_tum_db;


            ariza_list = baglanti.listele("ariza", "0");
            ariza.DataSource = ariza_list;

            arizasi_list = baglanti.listele("ariza", "0");
            arizasi.DataSource = arizasi_list;


            kut_list = baglanti.listele("kut", "0");
            kut.DataSource = kut_list;



            kut.SelectedIndex = -1;
          
            panel_main.Visible = false;



        }
            

        private void Ariza_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (ariza.SelectedItem != null)
            {

                kut.SelectedItem = null;
                degisen_parca.SelectedItem = null;
                string secili_baslik = ((DataRowView)ariza.SelectedItem)["baslik"].ToString();
                baslik.Text = "";
                turkish_ric.Text = "";
                english_rich.Text = "";
                baslik.Text = secili_baslik;
                english_rich.Text = baglanti.comment_cek_Mizer("ariza", "english", secili_baslik);
                turkish_ric.Text = baglanti.comment_cek_Mizer("ariza", "turkish", secili_baslik);
                panel_main.Visible = true;
                kydt.Enabled = true;
                sil.Enabled = true;
                panel_ariza_bagli.Visible = false;
            }
          



        }
        
        private void Degisen_parca_SelectedIndexChanged(object sender, EventArgs e)
        {
          
             
            
        }

        private void Kut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kut.SelectedItem != null)
            {

                ariza.SelectedItem = null;
                degisen_parca.SelectedItem = null;
                string secili_baslik = ((DataRowView)kut.SelectedItem)["baslik"].ToString();
                baslik.Text = "";
                turkish_ric.Text = "";
                english_rich.Text = "";
                baslik.Text = secili_baslik;
                english_rich.Text = baglanti.comment_cek_Mizer("kut", "english", secili_baslik) ;
                turkish_ric.Text = baglanti.comment_cek_Mizer("kut", "turkish", secili_baslik) ;
                panel_main.Visible = true;
                kydt.Enabled = true;
                sil.Enabled = true;
                panel_ariza_bagli.Visible = false;
            }

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
        private void Button4_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        DataTable degisen_parca_tum_db = baglanti.listele("degisen_parca", "%");
        DataTable ariza_list = baglanti.listele("ariza", "0");
        DataTable arizasi_list = baglanti.listele("ariza", "0");
        DataTable kut_list = baglanti.listele("kut", "0");
        private void Duzenle_sirtuex_Load(object sender, EventArgs e)
        {
           
            dil_ayari_Cek();
            Blink();
            arizasi.SelectedIndex = -1;
            degisen_parca.SelectedIndex = -1;
            kut.SelectedIndex = -1;
            ariza.DataSource = ariza_list;
            ariza.DisplayMember = "baslik";
            ariza.ValueMember = "id";
            ariza.Tag = "baslik";

            degisen_parca.DataSource = degisen_parca_tum_db;
            degisen_parca.DisplayMember = "baslik";
            degisen_parca.ValueMember = "id";
            degisen_parca.Tag = "baslik";

            kut.DataSource = kut_list;
            kut.DisplayMember = "baslik";
            kut.ValueMember = "id";
            kut.Tag = "baslik";

            arizasi.DataSource = arizasi_list;
            arizasi.DisplayMember = "baslik";
            arizasi.ValueMember = "id";
            arizasi.Tag = "baslik";

            panel_main.Visible = false;


            SendMessage(arama_ariza.Handle, EM_SETCUEBANNER, 0, "Search for Control/Defect");
            SendMessage(arama_parca.Handle, EM_SETCUEBANNER, 0, "Search for Solution/Montage");
            SendMessage(textBox1.Handle, EM_SETCUEBANNER, 0, "Search for Solution/Montage");
            SendMessage(arama_kut.Handle, EM_SETCUEBANNER, 0, "Search for Final Test/End");

            SendMessage(arama_ariza.Handle, EM_SETCUEBANNER, 0, dil.dil_ayari_yap("arama_ariza"));
            SendMessage(arama_parca.Handle, EM_SETCUEBANNER, 0, dil.dil_ayari_yap("arama_parca"));
            SendMessage(textBox1.Handle, EM_SETCUEBANNER, 0, dil.dil_ayari_yap("arama_parca"));
            SendMessage(arama_kut.Handle, EM_SETCUEBANNER, 0, dil.dil_ayari_yap("arama_kut"));

        }
        DataView cozum_ara;
        DataView dataView_ariza;
        DataView kut_ara;
        DataView arizasi_ara;
        private void Arama_parca_TextChanged(object sender, EventArgs e)
        {
            cozum_ara = degisen_parca_tum_db.DefaultView;
            cozum_ara.RowFilter = "baslik LIKE '%" + arama_parca.Text + "%'";
            if (cozum_ara.Count != 0)
            { degisen_parca.SelectedIndex = degisen_parca.TopIndex; degisen_parca.Refresh(); }
            else
            { }
        }

        private void Arama_ariza_TextChanged(object sender, EventArgs e)
        {
            dataView_ariza = ariza_list.DefaultView;
            dataView_ariza.RowFilter = "baslik LIKE '%" + arama_ariza.Text + "%'";
            if (dataView_ariza.Count != 0)
            { ariza.SelectedIndex = ariza.TopIndex; ariza.Refresh(); }
            else
            { }
        }

        private void Arama_kut_TextChanged(object sender, EventArgs e)
        {
            kut_ara = kut_list.DefaultView;
            kut_ara.RowFilter = "baslik LIKE '%" + arama_kut.Text + "%'";
            if (kut_ara.Count != 0)
            { kut.SelectedIndex = kut.TopIndex; kut.Refresh(); }
            else
            { }
        }

        private void Kydt_Click(object sender, EventArgs e)
        {
            string secili_tur ="yok";
            string srgu = "";
            if (ariza.SelectedItem != null)
            {
                secili_tur = "ariza";
                 srgu = ((DataRowView)ariza.SelectedItem)["baslik"].ToString();
            }
           else if (degisen_parca.SelectedItem != null)
            {
                secili_tur = "degisen_parca";
                srgu= ((DataRowView)degisen_parca.SelectedItem)["baslik"].ToString();
            }
            else if (kut.SelectedItem != null)
            {
                secili_tur = "kut";
                 srgu = ((DataRowView)kut.SelectedItem)["baslik"].ToString();
            }
            else
            {
                return;
            }



            if (baslik.Text.StartsWith(" ") || baslik.Text.Replace(" ", "") == "" || baslik.Text.Length <= 4)
            {
                MessageBox.Show(gecerli_baslik, "LetMeRepair - Mizer - Hatalı Başlık", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ( (srgu !=baslik.Text) && (baglanti.tekrar_sorgula(secili_tur, baslik.Text) == "Mevcut"))
            {
                MessageBox.Show(ayni_basliktan, "LMR-Sirtuex-Mizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int secili_id;

                if (ariza.SelectedItem != null)
                {
                    secili_id = Convert.ToInt32(((DataRowView)ariza.SelectedItem)["id"]);
                    baglanti.guncelle_tur("ariza", baslik.Text, english_rich.Text, turkish_ric.Text, "0", secili_id);
                    MessageBox.Show("Record Updated - 1", "LMR-Sirtuex-Mizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (degisen_parca.SelectedItem != null)
                {
                    secili_id = Convert.ToInt32(((DataRowView)degisen_parca.SelectedItem)["id"]);
                    string secili_idler = "";
                    foreach (var secili_itemler in arizasi.SelectedItems)
                    {
                        secili_idler = secili_idler + "-" + ((DataRowView)secili_itemler)["id"].ToString();
                    }
                    baglanti.guncelle_tur("degisen_parca", baslik.Text, english_rich.Text, turkish_ric.Text, secili_idler, secili_id);
                    MessageBox.Show("Record Updated - 2", "LMR-Sirtuex-Mizer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (kut.SelectedItem != null)
                {
                    secili_id = Convert.ToInt32(((DataRowView)kut.SelectedItem)["id"]);
                    baglanti.guncelle_tur("kut", baslik.Text, english_rich.Text, turkish_ric.Text, "0", secili_id);
                    MessageBox.Show("Record Updated - 3", "LMR-Sirtuex-Mizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Select");
                }

                liste_yenilemesi();
            }
           
            
          


        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            arizasi_ara = arizasi_list.DefaultView;
            arizasi_ara.RowFilter = "baslik LIKE '%" + textBox1.Text + "%'";
            if (arizasi_ara.Count != 0)
            {  }
            else
            { }

        }
        
        private void Degisen_parca_MouseDown(object sender, MouseEventArgs e)
        {
            arizasi.SelectedIndex = -1;

            if (degisen_parca.SelectedIndex != -1)
            {
                kut.SelectedItem = null;
                ariza.SelectedItem = null;
                string secili_baslik = ((DataRowView)degisen_parca.SelectedItem)["baslik"].ToString();
                if (secili_baslik == "")
                {
                    panel_main.Visible = false;
                    return;
                }
                baslik.Text = "";
                turkish_ric.Text = "";
                english_rich.Text = "";
                baslik.Text = secili_baslik;
                english_rich.Text = baglanti.comment_cek_Mizer("degisen_parca", "english", secili_baslik);
                turkish_ric.Text = baglanti.comment_cek_Mizer("degisen_parca", "turkish", secili_baslik);
                string secili_sayilar_yansitma = baglanti.comment_cek_Mizer("degisen_parca", "bagli_oldugu_ariza", secili_baslik);
                panel_main.Visible = true;
                kydt.Enabled = true;
                sil.Enabled = true;
                panel_ariza_bagli.Visible = true;
                if (secili_sayilar_yansitma.EndsWith("-"))
                {
                    secili_sayilar_yansitma = secili_sayilar_yansitma.Remove(secili_sayilar_yansitma.Length - 1, 1);
                }
                if (secili_sayilar_yansitma.StartsWith("-"))
                {
                    secili_sayilar_yansitma = secili_sayilar_yansitma.Remove(0, 1);
                }
                try
                {
                    string[] ali = new string[] { " " };
                    if (secili_sayilar_yansitma.Contains('-'))
                    {

                        ali = secili_sayilar_yansitma.Split('-');
                    }
                    else
                    {
                        ali[0] = secili_sayilar_yansitma;

                    }
                    int[] deger = new int[] { 0 };
                    if (ali.Count() > 1)
                    {
                        deger = Array.ConvertAll<string, int>(ali, int.Parse);
                    }
                    else
                    {
                        deger[0] = Convert.ToInt32(secili_sayilar_yansitma);
                    }
                    string secilecek_index_no = "";
                    foreach (int oku in deger)
                    {
                        foreach (DataRowView item in arizasi.Items)
                        {

                            if (Convert.ToInt32(item["id"].ToString()) == oku)
                            {
                                //    arizasi.SetSelected(arizasi.Items.IndexOf(item),true);

                                secilecek_index_no = secilecek_index_no + "-" + (arizasi.Items.IndexOf(item)).ToString();

                            }

                        }
                    }
                    /// KISALTILACAK
                    if (secilecek_index_no.StartsWith("-"))
                    {
                        secilecek_index_no = secilecek_index_no.Remove(0, 1);
                    }

                    arizasi.ClearSelected();
                    try
                    {
                        string[] ali2 = secilecek_index_no.Split('-');
                        int[] deger2 = Array.ConvertAll<string, int>(ali2, int.Parse);

                        foreach (int indx in deger2)
                        {
                            arizasi.SetSelected(indx, true);
                        }
                    }
                    catch
                    {

                    }
                }
                catch { }
                }


        
         

        }

        private void Sil_Click(object sender, EventArgs e)
        {
            int secili_id;

            if (ariza.SelectedItem != null)
            {
                secili_id = Convert.ToInt32(((DataRowView)ariza.SelectedItem)["id"]);
                baglanti.sil_tur("ariza", secili_id);
                MessageBox.Show("Record Deleted - 1", "LMR-Sirtuex-Mizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (degisen_parca.SelectedItem != null)
            {
                secili_id = Convert.ToInt32(((DataRowView)degisen_parca.SelectedItem)["id"]);
                string secili_idler = "";
                foreach (var secili_itemler in arizasi.SelectedItems)
                {
                    secili_idler = secili_idler + "-" + ((DataRowView)secili_itemler)["id"].ToString();
                }
                baglanti.sil_tur("degisen_parca", secili_id);
                MessageBox.Show("Record Deleted - 2", "LMR-Sirtuex-Mizer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (kut.SelectedItem != null)
            {
                secili_id = Convert.ToInt32(((DataRowView)kut.SelectedItem)["id"]);
                baglanti.sil_tur("kut", secili_id);
                MessageBox.Show("Record Deleted - 3", "LMR-Sirtuex-Mizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Select");
            }

            liste_yenilemesi();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            liste_yenilemesi();
          
        }

        private void Arizasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
