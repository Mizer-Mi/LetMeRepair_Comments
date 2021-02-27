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
    public partial class sablonlari_yonet : Form
    {
        public sablonlari_yonet()
        {
            InitializeComponent();
        }

        private void Sablonlari_yonet_Load(object sender, EventArgs e)
        {
            paketleri_listele();
        }
        private void paketleri_listele()
        {

            DataTable degisen_parca_tum_db = baglanti.listele("paket_uyesi", "0");
            comboBox1.DataSource = degisen_parca_tum_db;
            comboBox1.DisplayMember = "baslik";
            /// ((DataRowView)ariza.SelectedItem)["id"].ToString();
            if (comboBox1.Items.Count > 0) { comboBox1.SelectedIndex = 0; } else { }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.StartsWith(" ") || textBox4.Text.Replace(" ", "") == "" || textBox4.Text.Length <= 3)
            {
                MessageBox.Show(gecerli_baslik, "LetMeRepair - Mizer - Hatalı Başlık", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if ("Devam" == baglanti.tekrar_sorgula("paket_uyesi", textBox4.Text))
                {
                    if (baglanti.guncelle_tur("paket_uyesi", textBox4.Text, richTextBox1.Text, richTextBox2.Text, "", Convert.ToInt32(((DataRowView)comboBox1.SelectedItem)["id"].ToString())) == true)
                    {
                        MessageBox.Show("Successful Updated. - Güncelleme Başarılı");
                        paketleri_listele();
                    }
                    else
                    {
                        MessageBox.Show("Cannot Update - Güncellenemiyor.");
                        paketleri_listele();
                    }
                }
            
                else if (baglanti.tekrar_sorgula("paket_uyesi", textBox4.Text) == "Mevcut")
              {
                    MessageBox.Show(ayni_basliktan, "LMR-Sirtuex-Mizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
        }
           
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (baglanti.sil_tur("paket_uyesi", Convert.ToInt32(((DataRowView)comboBox1.SelectedItem)["id"].ToString())) == true)
            {
                MessageBox.Show("Successful Deleted. - Silme Başarılı");
                paketleri_listele();
            }
            else
            {
                MessageBox.Show("Cannot Deleted - Silinemiyor.");
                paketleri_listele();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                textBox4.Text = ((DataRowView)comboBox1.SelectedItem)["baslik"].ToString();
                label8.Text = "ID=" + ((DataRowView)comboBox1.SelectedItem)["id"].ToString();
                richTextBox1.Text= ((DataRowView)comboBox1.SelectedItem)["english"].ToString();
                richTextBox2.Text = ((DataRowView)comboBox1.SelectedItem)["turkish"].ToString();
                update_panel.Visible = true;
                sil.Enabled = true;
            }
            else
            {
                sil.Enabled = false;

                update_panel.Visible = false;
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
    }
}
