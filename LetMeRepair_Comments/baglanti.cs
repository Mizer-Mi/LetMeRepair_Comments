using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace LetMeRepair_Comments
{
    class baglanti
    {
        public static OleDbConnection con = new OleDbConnection("Provider = Microsoft.JET.OLEDB.4.0; Data Source = mizer_sirtuex_vt.mdb");
        public static OleDbDataAdapter da;
        public static  OleDbCommand cmd = new OleDbCommand();


        public static string tekrar_sorgula (string tur,string baslik)
        {
            
            
            string sorgu = "";

        sorgu = "Select baslik from "+tur+" where baslik=@baslik";

            cmd = new OleDbCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@baslik", baslik);

            con.Open();
            OleDbDataReader okuma = cmd.ExecuteReader();
            if (okuma.Read())
            {
                con.Close();
                return "Mevcut";
            }
            else
            {
                con.Close();
                return "Devam";
            }
        }

        public static Boolean ekle_tur(string tur,string baslik,string english, string turkish,string bagli_no)
        {
           /// try
           /// { 
            string sorgu = "";
            if (tur == "degisen_parca")
            {
              
                 sorgu = "Insert into "+tur+ " (baslik,english,turkish,bagli_oldugu_ariza) values (@baslik,@english,@turkish,@bagli_oldugu_ariza)";
               
            }
            else
            {
                 sorgu = "Insert into " + tur + " (baslik,english,turkish) values (@baslik,@english,@turkish)";
            }
          
            cmd = new OleDbCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@baslik", baslik);
            cmd.Parameters.AddWithValue("@english", english);
            cmd.Parameters.AddWithValue("@turkish", turkish);
            cmd.Parameters.AddWithValue("@bagli_oldugu_ariza", bagli_no +"-");

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
                return true;
          ////  }
           /* catch
            {
                return false;
            }
            */
        }

        public static Boolean guncelle_tur(string tur, string baslik, string english, string turkish, string bagli_no,int id)
        {
            /// try
            /// { 
            string sorgu = "";
            if (tur == "degisen_parca")
            {

                sorgu = "UPDATE " + tur + " set baslik = @baslik,english = @english,turkish = @turkish,bagli_oldugu_ariza = @bagli_oldugu_ariza WHERE id ="+id;
                 
            }
            else
            {
                sorgu = "update " + tur + " SET baslik = @baslik, english = @english, turkish = @turkish WHERE id ="+id;
            }

            cmd = new OleDbCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@baslik", baslik);
            cmd.Parameters.AddWithValue("@english", english);
            cmd.Parameters.AddWithValue("@turkish", turkish);
            cmd.Parameters.AddWithValue("@bagli_oldugu_ariza", bagli_no + "-");
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            
            con.Close();
            return true;
            ////  }
            /* catch
             {
                 return false;
             }
             */
        }

        public static Boolean sil_tur (string tur,int id)
        {
           string sorgu = "DELETE from " + tur + " WHERE id =" + id;
            cmd = new OleDbCommand(sorgu, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public static DataTable listele(string tur,string degisen_parca_id)
        {
         
            string sorgu = "";
            string data_bir = "";
            DataTable datalar = new DataTable();
            if (tur == "degisen_parca") { sorgu = "Select * from " + tur + " where bagli_oldugu_ariza LIKE '%"+degisen_parca_id+"%'"; }
            else
            { 
            sorgu = "Select * from " + tur + "";
            }
            cmd = new OleDbCommand(sorgu, con);
            con.Open();
            datalar.Load(cmd.ExecuteReader());
            
            con.Close();
            return datalar;

        }

        public static string baglanti_no_cekme(string ariza_baslik)
        {
            string sorgu = "";

            sorgu = "Select id from ariza where baslik=@baslik";
            string hafiza;
            cmd = new OleDbCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@baslik", ariza_baslik);

            con.Open();
            OleDbDataReader okuma = cmd.ExecuteReader();
            if (okuma.Read())
            {
             
                hafiza = okuma["id"].ToString();
                con.Close();
                return hafiza;
               
            }
            else
            {
                con.Close();
                return "0";
            }
        }

        public static int paket_id_cekme(string paket_ismi)
        {
            string sorgu = "";

            sorgu = "Select id from paket where baslik=@baslik";
            string hafiza;
            cmd = new OleDbCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@baslik", paket_ismi);

            con.Open();
            OleDbDataReader okuma = cmd.ExecuteReader();
            if (okuma.Read())
            {

                hafiza = okuma["id"].ToString();
                con.Close();
                return Convert.ToInt32(hafiza);

            }
            else
            {
                con.Close();
                return 0;
            }
        }

        public static Boolean Paket_ekle (string tur, string baslik, string turkish, string english,int bag)
        {
            string sorgu = "";
            if (tur == "paket_uyesi")
            {

                sorgu = "Insert into " + tur + " (baslik,english,turkish,paket_id) values (@baslik,@english,@turkish,@paket_id)";

            }
            else
            {
                sorgu = "Insert into " + tur + " (baslik) values (@baslik)";
            }

            cmd = new OleDbCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@baslik", baslik);
            cmd.Parameters.AddWithValue("@english", english);
            cmd.Parameters.AddWithValue("@turkish", turkish);
            cmd.Parameters.AddWithValue("@paket_id", bag );

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return true;



        }

        public static string comment_cek_Mizer(string tur, string dil,string baslik)
        {
            string sorgu = "";

            sorgu = "Select * from " + tur + " where baslik=@baslik";

            cmd = new OleDbCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@baslik", baslik);

            con.Open();
            OleDbDataReader okuma = cmd.ExecuteReader();
            if (okuma.Read())
            {
                string okuma_degeri = okuma[dil].ToString();
                con.Close();
                return okuma_degeri;
            }
            else
            {
                con.Close();
                return "";
            }
        }

    }

    


}
