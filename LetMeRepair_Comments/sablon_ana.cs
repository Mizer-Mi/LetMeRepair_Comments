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
    public partial class sablon_ana : Form
    {
        public sablon_ana()
        {

            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - this.Width, scrn.Bounds.Top- (-Properties.Settings.Default.paket_bosluk_yukari));
                    return;
                }
            }
        }

        private void Sablon_ana_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
