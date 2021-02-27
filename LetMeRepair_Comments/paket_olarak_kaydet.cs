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
    public partial class paket_olarak_kaydet : Form
    {
        public paket_olarak_kaydet()
        {
            InitializeComponent();
        }
        public string turkishcomment {get;set;}
        public string englishcomment { get; set; }
        private void Paket_olarak_kaydet_Load(object sender, EventArgs e)
        {
            paketleri_listele();
        }
        
        private void paketleri_listele()
        {
            
            DataTable degisen_parca_tum_db = baglanti.listele("paket", "0");
            degisen_parca_tum_db.Rows.Add(0,"Hepsi");
            comboBox1.DataSource = degisen_parca_tum_db;
            comboBox1.DisplayMember = "baslik";
           /// ((DataRowView)ariza.SelectedItem)["id"].ToString();
            comboBox1.SelectedIndex = 0;
            
        }
        private void Kydt_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedText == "Hepsi")
            {
                baglanti.Paket_ekle("paket_uyesi", baslik.Text, turkishcomment, englishcomment,0);
            }
            else
            {
                baglanti.Paket_ekle("paket_uyesi", baslik.Text, turkishcomment, englishcomment,Convert.ToInt32(((DataRowView)comboBox1.SelectedItem)["id"].ToString()));
            }
          
        }

        private void Yeni_Click(object sender, EventArgs e)
        {
            using (paket_ekle_duzenle frmac= new paket_ekle_duzenle())
            {
                frmac.ShowDialog();
          
            }
            paketleri_listele();
        }
    }
}
