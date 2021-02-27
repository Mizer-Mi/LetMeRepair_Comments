namespace LetMeRepair_Comments
{
    partial class duzenle_sirtuex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        dil_ayarlari dil = new dil_ayarlari();
        string dil_kapzasi;
        string yazi_guncellendi = "Seçili Kayıt Güncellendi.";
        string ayni_basliktan = "Aynı başlıktan Mevcut";
        string gecerli_baslik = "Lütfen Geçerli bir başlık giriniz.";
        string ana_baslik = "Düzenlemek istediğiniz başlığı seçin";

        private void dil_ayari_Cek()
        {
            if ((dil_kapzasi = dil.dil_ayari_yap("control_defect_yazisi")) == "Dil?") { } else { this.label1.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("solution_montage_yazisi")) == "Dil?") { } else { this.label2.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("final_test_end_Yazisi")) == "Dil?") { } else { this.label3.Text = dil_kapzasi; }


            if ((dil_kapzasi = dil.dil_ayari_yap("cikis")) == "Dil?") { } else { this.button4.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("trash_et")) == "Dil?") { } else { this.button1.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("kaydet")) == "Dil?") { } else { this.kydt.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("sil")) == "Dil?") { } else { this.sil.Text = dil_kapzasi; }


            if ((ayni_basliktan = dil.dil_ayari_yap("ayni_basliktan")) == "Dil?") { } else { }
            if ((gecerli_baslik = dil.dil_ayari_yap("gecerli_baslik")) == "Dil?") { } else { }
            if ((yazi_guncellendi = dil.dil_ayari_yap("yazi_guncellendi")) == "Dil?") { } else { }

            if ((dil_kapzasi = dil.dil_ayari_yap("baslik_ana")) == "Dil?") { } else { this.label7.Text = dil_kapzasi; }

            if ((dil_kapzasi = dil.dil_ayari_yap("secili_yazi")) == "Dil?") { } else { this.label5.Text = dil_kapzasi; }
            if ((ana_baslik = dil.dil_ayari_yap("ana_baslik_gnclle")) == "Dil?") { } else { this.label4.Text = ana_baslik; }
            if ((dil_kapzasi = dil.dil_ayari_yap("solution_of_fault")) == "Dil?") { } else { this.label9.Text = dil_kapzasi; }


        }








        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(duzenle_sirtuex));
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuSeparator3 = new ns1.BunifuSeparator();
            this.arama_kut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kut = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new ns1.BunifuSeparator();
            this.arama_parca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.degisen_parca = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.arama_ariza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ariza = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.panel_ariza_bagli = new System.Windows.Forms.Panel();
            this.bunifuSeparator4 = new ns1.BunifuSeparator();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.arizasi = new System.Windows.Forms.ListBox();
            this.kydt = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.baslik = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.english_rich = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.turkish_ric = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_ariza_bagli.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.bunifuSeparator3);
            this.panel3.Controls.Add(this.arama_kut);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.kut);
            this.panel3.Location = new System.Drawing.Point(564, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 291);
            this.panel3.TabIndex = 10;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(3, 66);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(262, 10);
            this.bunifuSeparator3.TabIndex = 9;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // arama_kut
            // 
            this.arama_kut.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.arama_kut.Location = new System.Drawing.Point(3, 41);
            this.arama_kut.MaxLength = 32;
            this.arama_kut.Name = "arama_kut";
            this.arama_kut.Size = new System.Drawing.Size(255, 27);
            this.arama_kut.TabIndex = 7;
            this.arama_kut.TextChanged += new System.EventHandler(this.Arama_kut_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(4, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Final Test/End";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kut
            // 
            this.kut.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.kut.FormattingEnabled = true;
            this.kut.ItemHeight = 21;
            this.kut.Location = new System.Drawing.Point(3, 78);
            this.kut.Name = "kut";
            this.kut.Size = new System.Drawing.Size(262, 193);
            this.kut.TabIndex = 3;
            this.kut.SelectedIndexChanged += new System.EventHandler(this.Kut_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bunifuSeparator2);
            this.panel2.Controls.Add(this.arama_parca);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.degisen_parca);
            this.panel2.Location = new System.Drawing.Point(288, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 291);
            this.panel2.TabIndex = 9;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(-1, 66);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(274, 10);
            this.bunifuSeparator2.TabIndex = 8;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // arama_parca
            // 
            this.arama_parca.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.arama_parca.Location = new System.Drawing.Point(3, 41);
            this.arama_parca.MaxLength = 32;
            this.arama_parca.Name = "arama_parca";
            this.arama_parca.Size = new System.Drawing.Size(262, 27);
            this.arama_parca.TabIndex = 6;
            this.arama_parca.TextChanged += new System.EventHandler(this.Arama_parca_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Solution/Montage";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // degisen_parca
            // 
            this.degisen_parca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degisen_parca.FormattingEnabled = true;
            this.degisen_parca.ItemHeight = 21;
            this.degisen_parca.Location = new System.Drawing.Point(3, 78);
            this.degisen_parca.Name = "degisen_parca";
            this.degisen_parca.Size = new System.Drawing.Size(262, 193);
            this.degisen_parca.Sorted = true;
            this.degisen_parca.TabIndex = 3;
            this.degisen_parca.SelectedIndexChanged += new System.EventHandler(this.Degisen_parca_SelectedIndexChanged);
            this.degisen_parca.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Degisen_parca_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.arama_ariza);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ariza);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 291);
            this.panel1.TabIndex = 8;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 66);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(274, 10);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // arama_ariza
            // 
            this.arama_ariza.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.arama_ariza.Location = new System.Drawing.Point(3, 41);
            this.arama_ariza.MaxLength = 32;
            this.arama_ariza.Name = "arama_ariza";
            this.arama_ariza.Size = new System.Drawing.Size(261, 27);
            this.arama_ariza.TabIndex = 5;
            this.arama_ariza.TextChanged += new System.EventHandler(this.Arama_ariza_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control/Defect";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ariza
            // 
            this.ariza.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ariza.FormattingEnabled = true;
            this.ariza.ItemHeight = 21;
            this.ariza.Location = new System.Drawing.Point(3, 78);
            this.ariza.Name = "ariza";
            this.ariza.Size = new System.Drawing.Size(262, 193);
            this.ariza.Sorted = true;
            this.ariza.TabIndex = 3;
            this.ariza.SelectedIndexChanged += new System.EventHandler(this.Ariza_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(819, 30);
            this.label4.TabIndex = 27;
            this.label4.Text = "Select the title you want to edit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_main
            // 
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Controls.Add(this.button1);
            this.panel_main.Controls.Add(this.sil);
            this.panel_main.Controls.Add(this.panel_ariza_bagli);
            this.panel_main.Controls.Add(this.kydt);
            this.panel_main.Controls.Add(this.panel4);
            this.panel_main.Controls.Add(this.panel7);
            this.panel_main.Controls.Add(this.panel5);
            this.panel_main.Controls.Add(this.label5);
            this.panel_main.Location = new System.Drawing.Point(12, 339);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(822, 320);
            this.panel_main.TabIndex = 28;
            this.panel_main.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 30;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // sil
            // 
            this.sil.Enabled = false;
            this.sil.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.Image = ((System.Drawing.Image)(resources.GetObject("sil.Image")));
            this.sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sil.Location = new System.Drawing.Point(464, 269);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(107, 40);
            this.sil.TabIndex = 38;
            this.sil.Text = "Delete";
            this.sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // panel_ariza_bagli
            // 
            this.panel_ariza_bagli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ariza_bagli.Controls.Add(this.bunifuSeparator4);
            this.panel_ariza_bagli.Controls.Add(this.textBox1);
            this.panel_ariza_bagli.Controls.Add(this.label9);
            this.panel_ariza_bagli.Controls.Add(this.arizasi);
            this.panel_ariza_bagli.Location = new System.Drawing.Point(473, 34);
            this.panel_ariza_bagli.Name = "panel_ariza_bagli";
            this.panel_ariza_bagli.Size = new System.Drawing.Size(344, 223);
            this.panel_ariza_bagli.TabIndex = 37;
            this.panel_ariza_bagli.Visible = false;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(3, 59);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(333, 10);
            this.bunifuSeparator4.TabIndex = 29;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Gothic", 10.75F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(3, 35);
            this.textBox1.MaxLength = 32;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 22);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(333, 30);
            this.label9.TabIndex = 27;
            this.label9.Text = "Which fault will this be solved?";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arizasi
            // 
            this.arizasi.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.arizasi.FormattingEnabled = true;
            this.arizasi.ItemHeight = 21;
            this.arizasi.Location = new System.Drawing.Point(3, 74);
            this.arizasi.Name = "arizasi";
            this.arizasi.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.arizasi.Size = new System.Drawing.Size(333, 130);
            this.arizasi.TabIndex = 0;
            this.arizasi.SelectedIndexChanged += new System.EventHandler(this.Arizasi_SelectedIndexChanged);
            // 
            // kydt
            // 
            this.kydt.Enabled = false;
            this.kydt.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kydt.Image = ((System.Drawing.Image)(resources.GetObject("kydt.Image")));
            this.kydt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kydt.Location = new System.Drawing.Point(577, 269);
            this.kydt.Name = "kydt";
            this.kydt.Size = new System.Drawing.Size(131, 40);
            this.kydt.TabIndex = 36;
            this.kydt.Text = "Update";
            this.kydt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kydt.UseVisualStyleBackColor = true;
            this.kydt.Click += new System.EventHandler(this.Kydt_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.baslik);
            this.panel4.Location = new System.Drawing.Point(3, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(455, 76);
            this.panel4.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            this.label7.Location = new System.Drawing.Point(7, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(428, 30);
            this.label7.TabIndex = 33;
            this.label7.Text = "Title";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baslik
            // 
            this.baslik.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.Location = new System.Drawing.Point(7, 35);
            this.baslik.MaxLength = 32;
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(428, 28);
            this.baslik.TabIndex = 32;
            this.baslik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.english_rich);
            this.panel7.Location = new System.Drawing.Point(3, 212);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(455, 99);
            this.panel7.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("MS Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Global Comment";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // english_rich
            // 
            this.english_rich.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.english_rich.Location = new System.Drawing.Point(7, 27);
            this.english_rich.Name = "english_rich";
            this.english_rich.Size = new System.Drawing.Size(428, 62);
            this.english_rich.TabIndex = 13;
            this.english_rich.Text = "";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.turkish_ric);
            this.panel5.Location = new System.Drawing.Point(3, 116);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(455, 99);
            this.panel5.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Customer Comment";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // turkish_ric
            // 
            this.turkish_ric.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.turkish_ric.Location = new System.Drawing.Point(7, 27);
            this.turkish_ric.Name = "turkish_ric";
            this.turkish_ric.Size = new System.Drawing.Size(428, 62);
            this.turkish_ric.TabIndex = 13;
            this.turkish_ric.Text = "";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(774, 34);
            this.label5.TabIndex = 27;
            this.label5.Text = "Selected Text";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(727, 608);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 42);
            this.button4.TabIndex = 29;
            this.button4.Text = "Exit";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Yu Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(658, 4);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(181, 12);
            this.linkLabel1.TabIndex = 30;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Devoloped by Mizer - © LetMeRepair 2019";
            // 
            // duzenle_sirtuex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(843, 669);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "duzenle_sirtuex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LetMeRepair - Comment Creator";
            this.Load += new System.EventHandler(this.Duzenle_sirtuex_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_ariza_bagli.ResumeLayout(false);
            this.panel_ariza_bagli.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox arama_kut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox kut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox arama_parca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox degisen_parca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox arama_ariza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ariza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox english_rich;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox turkish_ric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox baslik;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button kydt;
        private System.Windows.Forms.Panel panel_ariza_bagli;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox arizasi;
        private System.Windows.Forms.Button sil;
        private ns1.BunifuSeparator bunifuSeparator3;
        private ns1.BunifuSeparator bunifuSeparator2;
        private ns1.BunifuSeparator bunifuSeparator1;
        private ns1.BunifuSeparator bunifuSeparator4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}