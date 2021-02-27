using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetMeRepair_Comments
{
   public  class dil_ayarlari
    {

        // Mizer Windows Form Dil Seçeneği ayarlanması v.001 FrameWork
      
        public string dil_ayari_yap(string duzenlenecek_yer)
        {
            string hata = "Dil?";
            
                string result = string.Empty;
                var lines = File.ReadAllLines(@"dil_ayarlari\"+Properties.Settings.Default.dil+".mizer");
                foreach (var line in lines)
                {
                    if (line.Contains(duzenlenecek_yer))
                    {
                        var text = line.Replace(duzenlenecek_yer + "=", "");
                        text = text.Trim();
                        text = text.Replace(@"""","");
                        result = text.Trim();
                        return result;
                    }
                }
            
            return hata;
           



        }








    }
}
