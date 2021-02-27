namespace LetMeRepair_Comments
{
    partial class anaform_sirtuex
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        dil_ayarlari dil = new dil_ayarlari();
        string dil_kapzasi;
        private void dil_ayari_Cek()
            {
            if ((dil_kapzasi = dil.dil_ayari_yap("yorum_olusturucu_ana_duzenle")) == "Dil?") { } else { this.duzenle.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("yorum_olusturucu_ana_duzenle")) == "Dil?") { } else { this.duzenle.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("yorum_olusturucu_ana_duzenle")) == "Dil?") { } else { this.duzenle.Text = dil_kapzasi; }
            if ( (dil_kapzasi= dil.dil_ayari_yap("yorum_olusturucu_ana_duzenle")) == "Dil?"){}else {this.duzenle.Text =dil_kapzasi;}
            if ((dil_kapzasi = dil.dil_ayari_yap("yorum_olusturucu_ana_yeni")) == "Dil?") { } else { this.yeni.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("control_defect_yazisi")) == "Dil?") { } else { this.label1.Text = dil_kapzasi; this.label4.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("solution_montage_yazisi")) == "Dil?") { } else { this.label2.Text = dil_kapzasi; this.label5.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("final_test_end_Yazisi")) == "Dil?") { } else { this.label3.Text = dil_kapzasi; this.label6.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("sadece_ariza")) == "Dil?") { } else { this.button8.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("sadece_cozum")) == "Dil?") { } else { this.button7.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("defect_and_solution")) == "Dil?") { } else { this.generator_1.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("son_yazi_ekle")) == "Dil?") { } else { this.kut_generator_1.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("remove_et")) == "Dil?") { } else { this.button1.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("trash_et")) == "Dil?") { } else { this.button5.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("cikis")) == "Dil?") { } else { this.button4.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("tum_link_cozumler")) == "Dil?") { } else { this.tum_cozumler.Text = dil_kapzasi; }




        }








        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaform_sirtuex));
            this.label1 = new System.Windows.Forms.Label();
            this.ariza = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.arama_ariza = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tum_cozumler = new System.Windows.Forms.CheckBox();
            this.arama_parca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.degisen_parca = new System.Windows.Forms.ListBox();
            this.generator_1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.arama_kut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kut = new System.Windows.Forms.ListBox();
            this.kut_generator_1 = new System.Windows.Forms.Button();
            this.frame = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new ns1.BunifuSeparator();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.label6 = new System.Windows.Forms.Label();
            this.secili_kut = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.selici_degisen_parca = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.secili_ariza = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.koopyala_english = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.kopyala_turkish = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.yeni = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.duzenle = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paketModuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.imagelist = new System.Windows.Forms.ImageList(this.components);
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control/Defect";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ariza
            // 
            this.ariza.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ariza.FormattingEnabled = true;
            this.ariza.ItemHeight = 21;
            this.ariza.Location = new System.Drawing.Point(3, 91);
            this.ariza.Name = "ariza";
            this.ariza.Size = new System.Drawing.Size(262, 277);
            this.ariza.Sorted = true;
            this.ariza.TabIndex = 3;
            this.ariza.SelectedIndexChanged += new System.EventHandler(this.ariza_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 71);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.arama_ariza);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ariza);
            this.panel1.Location = new System.Drawing.Point(12, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 379);
            this.panel1.TabIndex = 5;
            // 
            // arama_ariza
            // 
            this.arama_ariza.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.arama_ariza.Location = new System.Drawing.Point(3, 58);
            this.arama_ariza.MaxLength = 32;
            this.arama_ariza.Name = "arama_ariza";
            this.arama_ariza.Size = new System.Drawing.Size(262, 27);
            this.arama_ariza.TabIndex = 5;
            this.arama_ariza.TextChanged += new System.EventHandler(this.Arama_ariza_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tum_cozumler);
            this.panel2.Controls.Add(this.arama_parca);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.degisen_parca);
            this.panel2.Location = new System.Drawing.Point(288, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 379);
            this.panel2.TabIndex = 6;
            // 
            // tum_cozumler
            // 
            this.tum_cozumler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tum_cozumler.Location = new System.Drawing.Point(3, 39);
            this.tum_cozumler.Name = "tum_cozumler";
            this.tum_cozumler.Size = new System.Drawing.Size(261, 19);
            this.tum_cozumler.TabIndex = 7;
            this.tum_cozumler.Text = "Unlink to Control/Defect";
            this.tum_cozumler.UseVisualStyleBackColor = true;
            this.tum_cozumler.CheckedChanged += new System.EventHandler(this.Tum_cozumler_CheckedChanged);
            // 
            // arama_parca
            // 
            this.arama_parca.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.arama_parca.Location = new System.Drawing.Point(3, 58);
            this.arama_parca.MaxLength = 32;
            this.arama_parca.Name = "arama_parca";
            this.arama_parca.Size = new System.Drawing.Size(261, 27);
            this.arama_parca.TabIndex = 6;
            this.arama_parca.TextChanged += new System.EventHandler(this.Arama_parca_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Solution/Montage";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // degisen_parca
            // 
            this.degisen_parca.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.degisen_parca.FormattingEnabled = true;
            this.degisen_parca.ItemHeight = 21;
            this.degisen_parca.Location = new System.Drawing.Point(3, 91);
            this.degisen_parca.Name = "degisen_parca";
            this.degisen_parca.Size = new System.Drawing.Size(262, 277);
            this.degisen_parca.Sorted = true;
            this.degisen_parca.TabIndex = 3;
            // 
            // generator_1
            // 
            this.generator_1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generator_1.Image = ((System.Drawing.Image)(resources.GetObject("generator_1.Image")));
            this.generator_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generator_1.Location = new System.Drawing.Point(108, 492);
            this.generator_1.Name = "generator_1";
            this.generator_1.Size = new System.Drawing.Size(348, 43);
            this.generator_1.TabIndex = 5;
            this.generator_1.Text = "Defect and Solution Add";
            this.generator_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generator_1.UseVisualStyleBackColor = true;
            this.generator_1.Click += new System.EventHandler(this.generator_1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.arama_kut);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.kut);
            this.panel3.Location = new System.Drawing.Point(564, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 379);
            this.panel3.TabIndex = 7;
            // 
            // arama_kut
            // 
            this.arama_kut.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.arama_kut.Location = new System.Drawing.Point(3, 58);
            this.arama_kut.MaxLength = 32;
            this.arama_kut.Name = "arama_kut";
            this.arama_kut.Size = new System.Drawing.Size(262, 27);
            this.arama_kut.TabIndex = 7;
            this.arama_kut.TextChanged += new System.EventHandler(this.Arama_kut_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Final Test/End";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kut
            // 
            this.kut.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.kut.FormattingEnabled = true;
            this.kut.ItemHeight = 21;
            this.kut.Location = new System.Drawing.Point(3, 91);
            this.kut.Name = "kut";
            this.kut.Size = new System.Drawing.Size(262, 277);
            this.kut.TabIndex = 3;
            // 
            // kut_generator_1
            // 
            this.kut_generator_1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kut_generator_1.Image = ((System.Drawing.Image)(resources.GetObject("kut_generator_1.Image")));
            this.kut_generator_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kut_generator_1.Location = new System.Drawing.Point(568, 491);
            this.kut_generator_1.Name = "kut_generator_1";
            this.kut_generator_1.Size = new System.Drawing.Size(262, 43);
            this.kut_generator_1.TabIndex = 6;
            this.kut_generator_1.Text = "Final Text Add";
            this.kut_generator_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kut_generator_1.UseVisualStyleBackColor = true;
            this.kut_generator_1.Click += new System.EventHandler(this.kut_generator_1_Click);
            // 
            // frame
            // 
            this.frame.BackColor = System.Drawing.Color.Coral;
            this.frame.Enabled = false;
            this.frame.Location = new System.Drawing.Point(842, 30);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(18, 515);
            this.frame.TabIndex = 8;
            this.frame.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.bunifuSeparator2);
            this.panel4.Controls.Add(this.bunifuSeparator1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.secili_kut);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.selici_degisen_parca);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.secili_ariza);
            this.panel4.Location = new System.Drawing.Point(866, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 450);
            this.panel4.TabIndex = 9;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 162);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(246, 10);
            this.bunifuSeparator2.TabIndex = 9;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 301);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(246, 10);
            this.bunifuSeparator1.TabIndex = 8;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 27);
            this.label6.TabIndex = 6;
            this.label6.Text = "Final Test/End";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secili_kut
            // 
            this.secili_kut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secili_kut.FormattingEnabled = true;
            this.secili_kut.ItemHeight = 20;
            this.secili_kut.Location = new System.Drawing.Point(7, 344);
            this.secili_kut.Name = "secili_kut";
            this.secili_kut.Size = new System.Drawing.Size(236, 104);
            this.secili_kut.TabIndex = 7;
            this.secili_kut.SelectedIndexChanged += new System.EventHandler(this.Secili_kut_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(0, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Solution/Montage";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selici_degisen_parca
            // 
            this.selici_degisen_parca.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selici_degisen_parca.FormattingEnabled = true;
            this.selici_degisen_parca.ItemHeight = 20;
            this.selici_degisen_parca.Location = new System.Drawing.Point(7, 202);
            this.selici_degisen_parca.Name = "selici_degisen_parca";
            this.selici_degisen_parca.Size = new System.Drawing.Size(236, 104);
            this.selici_degisen_parca.TabIndex = 5;
            this.selici_degisen_parca.SelectedIndexChanged += new System.EventHandler(this.Selici_degisen_parca_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(0, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Control/Defect";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secili_ariza
            // 
            this.secili_ariza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secili_ariza.FormattingEnabled = true;
            this.secili_ariza.ItemHeight = 20;
            this.secili_ariza.Location = new System.Drawing.Point(7, 55);
            this.secili_ariza.Name = "secili_ariza";
            this.secili_ariza.Size = new System.Drawing.Size(236, 104);
            this.secili_ariza.TabIndex = 3;
            this.secili_ariza.SelectedIndexChanged += new System.EventHandler(this.Secili_ariza_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(870, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Remove";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(12, 534);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1110, 18);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(348, 62);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.richTextBox1);
            this.panel5.Controls.Add(this.koopyala_english);
            this.panel5.Location = new System.Drawing.Point(12, 558);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(448, 99);
            this.panel5.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("MS Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Global Comment";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // koopyala_english
            // 
            this.koopyala_english.Image = ((System.Drawing.Image)(resources.GetObject("koopyala_english.Image")));
            this.koopyala_english.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.koopyala_english.Location = new System.Drawing.Point(361, 4);
            this.koopyala_english.Name = "koopyala_english";
            this.koopyala_english.Size = new System.Drawing.Size(82, 85);
            this.koopyala_english.TabIndex = 16;
            this.koopyala_english.UseVisualStyleBackColor = true;
            this.koopyala_english.Click += new System.EventHandler(this.Koopyala_english_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.kopyala_turkish);
            this.panel6.Controls.Add(this.richTextBox2);
            this.panel6.Location = new System.Drawing.Point(466, 558);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(444, 99);
            this.panel6.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("MS Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Customer Comment";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // kopyala_turkish
            // 
            this.kopyala_turkish.Image = ((System.Drawing.Image)(resources.GetObject("kopyala_turkish.Image")));
            this.kopyala_turkish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kopyala_turkish.Location = new System.Drawing.Point(357, 4);
            this.kopyala_turkish.Name = "kopyala_turkish";
            this.kopyala_turkish.Size = new System.Drawing.Size(82, 85);
            this.kopyala_turkish.TabIndex = 17;
            this.kopyala_turkish.UseVisualStyleBackColor = true;
            this.kopyala_turkish.Click += new System.EventHandler(this.Kopyala_turkish_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(7, 27);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(348, 62);
            this.richTextBox2.TabIndex = 13;
            this.richTextBox2.Text = "";
            // 
            // yeni
            // 
            this.yeni.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.yeni.Image = ((System.Drawing.Image)(resources.GetObject("yeni.Image")));
            this.yeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yeni.Location = new System.Drawing.Point(698, 32);
            this.yeni.Name = "yeni";
            this.yeni.Size = new System.Drawing.Size(136, 48);
            this.yeni.TabIndex = 20;
            this.yeni.Text = "New";
            this.yeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yeni.UseVisualStyleBackColor = true;
            this.yeni.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(994, 558);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 51);
            this.button4.TabIndex = 21;
            this.button4.Text = "Exit";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(994, 486);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 42);
            this.button5.TabIndex = 22;
            this.button5.Text = "Clear";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // duzenle
            // 
            this.duzenle.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F);
            this.duzenle.Image = ((System.Drawing.Image)(resources.GetObject("duzenle.Image")));
            this.duzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.duzenle.Location = new System.Drawing.Point(557, 32);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(131, 48);
            this.duzenle.TabIndex = 23;
            this.duzenle.Text = "Edit";
            this.duzenle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.duzenle.UseVisualStyleBackColor = true;
            this.duzenle.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(470, 491);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 43);
            this.button7.TabIndex = 8;
            this.button7.Text = "Solution Add";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(12, 491);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 43);
            this.button8.TabIndex = 24;
            this.button8.Text = "Defect Add";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(994, 615);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 27);
            this.button3.TabIndex = 25;
            this.button3.Text = "Package Mode";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Yu Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(936, 645);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(181, 12);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Devoloped by Mizer - © LetMeRepair 2019";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripComboBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1121, 27);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "Seçenekler";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniEkleToolStripMenuItem,
            this.duzenleToolStripMenuItem,
            this.paketModuToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(75, 23);
            this.toolStripMenuItem1.Text = "Seçenekler";
            // 
            // yeniEkleToolStripMenuItem
            // 
            this.yeniEkleToolStripMenuItem.Name = "yeniEkleToolStripMenuItem";
            this.yeniEkleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.yeniEkleToolStripMenuItem.Text = "Yeni Ekle";
            this.yeniEkleToolStripMenuItem.Click += new System.EventHandler(this.YeniEkleToolStripMenuItem_Click);
            // 
            // duzenleToolStripMenuItem
            // 
            this.duzenleToolStripMenuItem.Name = "duzenleToolStripMenuItem";
            this.duzenleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.duzenleToolStripMenuItem.Text = "Düzenle";
            this.duzenleToolStripMenuItem.Click += new System.EventHandler(this.DuzenleToolStripMenuItem_Click);
            // 
            // paketModuToolStripMenuItem
            // 
            this.paketModuToolStripMenuItem.Name = "paketModuToolStripMenuItem";
            this.paketModuToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.paketModuToolStripMenuItem.Text = "Paket Modu";
            this.paketModuToolStripMenuItem.Click += new System.EventHandler(this.PaketModuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(56, 23);
            this.toolStripMenuItem2.Text = "Ayarlar";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(69, 23);
            this.toolStripMenuItem3.Text = "Hakkında";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Turkish",
            "English"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // imagelist
            // 
            this.imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelist.ImageStream")));
            this.imagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelist.Images.SetKeyName(0, "Turkey-Flag.png");
            this.imagelist.Images.SetKeyName(1, "english_flag.png");
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(912, 558);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 84);
            this.button6.TabIndex = 29;
            this.button6.Text = "Save as Package";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click_1);
            // 
            // anaform_sirtuex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1121, 661);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.kut_generator_1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.generator_1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.yeni);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.frame);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "anaform_sirtuex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comments - LetMeRepair Turkey";
            this.Load += new System.EventHandler(this.anaform_sirtuex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ariza;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox degisen_parca;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox kut;
        private System.Windows.Forms.Button frame;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox secili_kut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox selici_degisen_parca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox secili_ariza;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button kopyala_turkish;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button generator_1;
        private System.Windows.Forms.Button kut_generator_1;
        private System.Windows.Forms.TextBox arama_ariza;
        private System.Windows.Forms.TextBox arama_parca;
        private System.Windows.Forms.TextBox arama_kut;
        private System.Windows.Forms.Button koopyala_english;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox tum_cozumler;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private ns1.BunifuSeparator bunifuSeparator2;
        private ns1.BunifuSeparator bunifuSeparator1;
        public System.Windows.Forms.Button yeni;
        public System.Windows.Forms.Button duzenle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ImageList imagelist;
        private System.Windows.Forms.ToolStripMenuItem yeniEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paketModuToolStripMenuItem;
        private System.Windows.Forms.Button button6;
    }
}

