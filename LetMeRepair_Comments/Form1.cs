using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetMeRepair_Comments
{
    public partial class anaform_sirtuex : Form
    {
        public anaform_sirtuex()
        {
            InitializeComponent();
        }
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);
        private void Ana_yorum_oluşturucu_motor()
        {
            string ariza_EN = "";
            string ariza_TR = "";
            string degisen_parca_EN = "";
            string degisen_parca_TR = "";
            string kut_EN = "";
            string kut_TR = "";

            foreach (var baslik in secili_ariza.Items)
            {
                ariza_EN = ariza_EN + baglanti.comment_cek_Mizer("ariza", "english", baslik.ToString()) + " ";
                ariza_TR = ariza_TR + baglanti.comment_cek_Mizer("ariza", "turkish", baslik.ToString()) + " ";
            }
            foreach (var baslik in selici_degisen_parca.Items)
            {
                degisen_parca_EN = degisen_parca_EN + baglanti.comment_cek_Mizer("degisen_parca", "english", baslik.ToString()) + " ";
                degisen_parca_TR = degisen_parca_TR + baglanti.comment_cek_Mizer("degisen_parca", "turkish", baslik.ToString()) +" ";
            }
            foreach (var baslik in secili_kut.Items)
            {
                kut_EN = kut_EN + baglanti.comment_cek_Mizer("kut", "english", baslik.ToString()) + " ";
                kut_TR = kut_TR + baglanti.comment_cek_Mizer("kut", "turkish", baslik.ToString()) + " ";
            }
            richTextBox1.Text = ariza_EN + degisen_parca_EN + kut_EN;
            richTextBox2.Text = ariza_TR + degisen_parca_TR + kut_TR;

        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (ekle_sirtuex frm_ac = new ekle_sirtuex())
            {
                frm_ac.ShowDialog();
            }
        }
        DataTable ariza_list = baglanti.listele("ariza", "0");
        DataTable kut_list = baglanti.listele("kut", "0");
        private void anaform_sirtuex_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dil == "turkce")
            {
              
                toolStripComboBox1.SelectedIndex = 0;
               
            }
            else
            {
                toolStripComboBox1.SelectedIndex = 1;
            }


            dil_ayari_Cek();

            if (Properties.Settings.Default.bag_kaldir == true)
            {
                tum_cozumler.Checked = true;
            }
            else
            { tum_cozumler.Checked = false; }
            ariza.DataSource = ariza_list;
            ariza.DisplayMember = "baslik";
            ariza.ValueMember = "id";
            ariza.Tag = "baslik";

            degisen_parca.DisplayMember = "baslik";
            degisen_parca.ValueMember = "id";
            degisen_parca.Tag = "baslik";

            kut.DataSource = kut_list;
            kut.DisplayMember = "baslik";
            kut.ValueMember = "id";
            kut.Tag = "baslik";

            if (tum_cozumler.Checked == true)
            {
                try
                {
                    degisen_parca.DataSource = degisen_parca_tum_db;
                }
                catch
                { }
            }
            else
            {
                parca_bagli_ariza();
            }



            SendMessage(arama_ariza.Handle, EM_SETCUEBANNER, 0, "Search for Control/Defect");
            SendMessage(arama_ariza.Handle, EM_SETCUEBANNER, 0, dil.dil_ayari_yap("arama_ariza")); 
            SendMessage(arama_parca.Handle, EM_SETCUEBANNER, 0, "Search for Solution/Montage");
            SendMessage(arama_ariza.Handle, EM_SETCUEBANNER, 0, dil.dil_ayari_yap("arama_parca"));
            SendMessage(arama_kut.Handle, EM_SETCUEBANNER, 0, "Search for Final Test/End");
            SendMessage(arama_ariza.Handle, EM_SETCUEBANNER, 0, dil.dil_ayari_yap("arama_kut"));



        }

        private void ariza_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tum_cozumler.Checked == true)
            { }
            else
            {
                parca_bagli_ariza();
            }
        }

        private void parca_bagli_ariza()
            {
            if (ariza.SelectedItem != null)
            {
                degisen_parca.Enabled = true;
                string baglanti_id = "0";
                try
                { 
               
                baglanti_id = ((DataRowView)ariza.SelectedItem)["id"].ToString();

                degisen_parca.DataSource = baglanti.listele("degisen_parca", baglanti_id);
                }
                catch
                {

                }
            }
            else
            { degisen_parca.Enabled = false; }
        }




        private void generator_1_Click(object sender, EventArgs e)
        {
      
            secili_ariza.Items.Add(((DataRowView)ariza.SelectedItem)["baslik"].ToString());
            selici_degisen_parca.Items.Add(((DataRowView)degisen_parca.SelectedItem)["baslik"].ToString());

            secili_ariza.Refresh();
            selici_degisen_parca.Refresh();
            Ana_yorum_oluşturucu_motor();
            button1.Enabled = true;
        }

       

        private void kut_generator_1_Click(object sender, EventArgs e)
        {
          string  secili_baslik = ((DataRowView)kut.SelectedItem)["baslik"].ToString();
            Boolean varmi = false;
            foreach (var item in secili_kut.Items)
            {
                if (item.ToString() == secili_baslik)
                {
                    MessageBox.Show("Küt zaten ekli");
                    varmi = true;
                }
            }

            if (varmi == false)
            {
                secili_kut.Items.Add(((DataRowView)kut.SelectedItem)["baslik"].ToString());

              
 
                button1.Enabled = true;

            }
            Ana_yorum_oluşturucu_motor();

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            secili_ariza.Items.Clear();
            secili_kut.Items.Clear();
            selici_degisen_parca.Items.Clear();
            Ana_yorum_oluşturucu_motor();
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (secili_ariza.SelectedItem != null)
                {
                    secili_ariza.Items.RemoveAt(secili_ariza.SelectedIndex);
                }
                else if (selici_degisen_parca.SelectedItem != null)
                {
                    selici_degisen_parca.Items.RemoveAt(selici_degisen_parca.SelectedIndex);
                }
                else if (secili_kut.SelectedItem != null)
                {
                    secili_kut.Items.RemoveAt(secili_kut.SelectedIndex);
                }
                else {  }
                Ana_yorum_oluşturucu_motor();
            }
            catch{}    
        }

        private void Secili_ariza_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (secili_ariza.SelectedItem != null)
            {

          
            selici_degisen_parca.SelectedItem = null;
            secili_kut.SelectedItem = null;

            }
        }

        private void Selici_degisen_parca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selici_degisen_parca.SelectedItem != null)
            {

                secili_ariza.SelectedItem = null;
                secili_kut.SelectedItem = null;
            }
        }

        private void Secili_kut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (secili_kut.SelectedItem != null)
            {

                secili_ariza.SelectedItem = null;
                selici_degisen_parca.SelectedItem = null;
            }
        }
        DataView dataView_ariza;
        private void Arama_ariza_TextChanged(object sender, EventArgs e)
        {

          dataView_ariza = ariza_list.DefaultView;
            dataView_ariza.RowFilter="baslik LIKE '%"+arama_ariza.Text+"%'";
            if (dataView_ariza.Count != 0)
            { ariza.SelectedIndex = ariza.TopIndex; ariza.Refresh(); }
            else
            { }
        }

        private void Koopyala_english_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void Kopyala_turkish_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox2.Text);
        }
        DataTable degisen_parca_tum_db = baglanti.listele("degisen_parca", "%");
        private void Tum_cozumler_CheckedChanged(object sender, EventArgs e)
        {
            if (tum_cozumler.Checked==true)
            {
                arama_parca.Enabled = true;
            degisen_parca.DataSource = degisen_parca_tum_db;
                Properties.Settings.Default.bag_kaldir = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                arama_parca.Enabled = false;
                parca_bagli_ariza();
                Properties.Settings.Default.bag_kaldir = false;
                Properties.Settings.Default.Save();
            }
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            using (duzenle_sirtuex frm_ac = new duzenle_sirtuex())
            {
                frm_ac.ShowDialog();
            }
        }
        DataView cozum_ara;
        private void Arama_parca_TextChanged(object sender, EventArgs e)
        {
            cozum_ara = degisen_parca_tum_db.DefaultView;
            cozum_ara.RowFilter = "baslik LIKE '%" + arama_parca.Text + "%'";
            if (cozum_ara.Count != 0)
            { degisen_parca.SelectedIndex = degisen_parca.TopIndex; ariza.Refresh(); }
            else
            { }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
        
            selici_degisen_parca.Items.Add(((DataRowView)degisen_parca.SelectedItem)["baslik"].ToString());

            selici_degisen_parca.Refresh();
            Ana_yorum_oluşturucu_motor();
            button1.Enabled = true;
        }

        private void Button8_Click(object sender, EventArgs e)
        {

            secili_ariza.Items.Add(((DataRowView)ariza.SelectedItem)["baslik"].ToString());
            secili_ariza.Refresh();
            Ana_yorum_oluşturucu_motor();
            button1.Enabled = true;
        }
        DataView kut_ara;
        private void Arama_kut_TextChanged(object sender, EventArgs e)
        {
            kut_ara = kut_list.DefaultView;
            kut_ara.RowFilter = "baslik LIKE '%" + arama_kut.Text + "%'";
            if (cozum_ara.Count != 0)
            { kut.SelectedIndex = kut.TopIndex; ariza.Refresh(); }
            else
            { }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            using (sablon_ana frm_Ac = new sablon_ana())
            {
                frm_Ac.ShowDialog();
                this.Show();
            }
         
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            using (mizer_about frm_ac = new mizer_about())
            {
                frm_ac.ShowDialog();
            }
        }

        private void YeniEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ekle_sirtuex frm_ac = new ekle_sirtuex())
            {
                frm_ac.ShowDialog();
            }
        }

        private void PaketModuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (sablon_ana frm_Ac = new sablon_ana())
            {
                frm_Ac.ShowDialog();
                this.Show();
            }
        }

        private void DuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (duzenle_sirtuex frm_ac = new duzenle_sirtuex())
            {
                frm_ac.ShowDialog();
            }
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            using (paket_olarak_kaydet frm_ac = new paket_olarak_kaydet())
            {
                frm_ac.turkishcomment = richTextBox2.Text;
                frm_ac.englishcomment = richTextBox1.Text;
                frm_ac.ShowDialog();
            }
        }
    }
}
