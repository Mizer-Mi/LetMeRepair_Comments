using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetMeRepair_Comments
{
    public partial class paket_ekle_duzenle : Form
    {
        public paket_ekle_duzenle()
        {
            InitializeComponent();
        }

        private void Paket_ekle_duzenle_Load(object sender, EventArgs e)
        {
            paketleri_listele();
            ComboBox1_SelectedIndexChanged(null,null) ;
        }

        private void paketleri_listele()
        {

            DataTable degisen_parca_tum_db = baglanti.listele("paket", "0");
            comboBox1.DataSource = degisen_parca_tum_db;
            comboBox1.DisplayMember = "baslik";
            /// ((DataRowView)ariza.SelectedItem)["id"].ToString();
            if (comboBox1.Items.Count > 0) { comboBox1.SelectedIndex = 0; } else {}

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          if (comboBox1.SelectedItem != null )
            {
             textBox4.Text =  ((DataRowView)comboBox1.SelectedItem)["baslik"].ToString();
                label8.Text ="ID="+ ((DataRowView)comboBox1.SelectedItem)["id"].ToString();
                update_panel.Visible = true;
            }
          else
            {
                update_panel.Visible = false;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Button2_Click(object sender, EventArgs e)
        {


            if (textBox2.Text.StartsWith(" ") || textBox2.Text.Replace(" ", "") == "" || textBox2.Text.Length <= 4)
            {
                MessageBox.Show(gecerli_baslik, "LetMeRepair - Mizer - Hatalı Başlık", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (baglanti.tekrar_sorgula("paket", textBox2.Text) == "Devam")
                {
                  
                    baglanti.Paket_ekle("paket",textBox2.Text,"","",0);
                    MessageBox.Show(kayit_eklendi, "LMR-Sirtuex-Mizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox4.Text = "";
                    paketleri_listele();


                }
                else if (baglanti.tekrar_sorgula("paket", textBox2.Text) == "Mevcut")
                {
                    MessageBox.Show(ayni_basliktan, "LMR-Sirtuex-Mizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == " " || textBox2.Text == "   " || textBox2.Text.StartsWith(" "))
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
             

            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox4.Text == " " || textBox4.Text == "   " || textBox4.Text.StartsWith(" "))
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;


            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
