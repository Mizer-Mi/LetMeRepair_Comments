namespace LetMeRepair_Comments
{
    partial class ekle_sirtuex
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
        string kayit_eklendi = "Kayıt Eklendi";
        string ayni_basliktan = "Aynı başlıktan Mevcut";
        string gecerli_baslik = "Lütfen Geçerli bir başlık giriniz.";
        string ana_baslik = "Lütfen Yorum tipini seçip; Benzirsiz bir başlık girin.";

        private void dil_ayari_Cek()
        {
            if ((dil_kapzasi = dil.dil_ayari_yap("control_defect_yazisi")) == "Dil?") { } else { this.ariza.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("solution_montage_yazisi")) == "Dil?") { } else { this.degisen_parca.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("final_test_end_Yazisi")) == "Dil?") { } else { this.kut.Text = dil_kapzasi; }


            if ((dil_kapzasi = dil.dil_ayari_yap("cikis")) == "Dil?") { } else { this.button2.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("trash_et")) == "Dil?") { } else { this.button1.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("kaydet")) == "Dil?") { } else { this.kydt.Text = dil_kapzasi; }

            if ((kayit_eklendi = dil.dil_ayari_yap("kaydet")) == "Dil?") { } else {  }
            if ((ayni_basliktan = dil.dil_ayari_yap("kaydet")) == "Dil?") { } else {  }
            if ((gecerli_baslik = dil.dil_ayari_yap("kaydet")) == "Dil?") { } else {  }

            if ((dil_kapzasi = dil.dil_ayari_yap("ana_baslik")) == "Dil?") { } else { this.label4.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("baslik_set")) == "Dil?") { } else { this.label7.Text = dil_kapzasi; }
            if ((dil_kapzasi = dil.dil_ayari_yap("yorum_set")) == "Dil?") { } else { this.label5.Text = dil_kapzasi; }


        }




        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ekle_sirtuex));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.english_rich = new System.Windows.Forms.RichTextBox();
            this.ariza = new System.Windows.Forms.RadioButton();
            this.degisen_parca = new System.Windows.Forms.RadioButton();
            this.kut = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.bunifuSeparator4 = new ns1.BunifuSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.turkish_ric = new System.Windows.Forms.RichTextBox();
            this.panel_ariza_bagli = new System.Windows.Forms.Panel();
            this.arama_parca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.arizasi = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kydt = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.baslik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_ariza_bagli.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.english_rich);
            this.panel1.Location = new System.Drawing.Point(12, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 99);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "English Comment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // english_rich
            // 
            this.english_rich.Location = new System.Drawing.Point(7, 27);
            this.english_rich.Name = "english_rich";
            this.english_rich.Size = new System.Drawing.Size(399, 62);
            this.english_rich.TabIndex = 13;
            this.english_rich.Text = "";
            // 
            // ariza
            // 
            this.ariza.Appearance = System.Windows.Forms.Appearance.Button;
            this.ariza.AutoSize = true;
            this.ariza.Font = new System.Drawing.Font("MS Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.ariza.Location = new System.Drawing.Point(9, 17);
            this.ariza.Name = "ariza";
            this.ariza.Size = new System.Drawing.Size(232, 37);
            this.ariza.TabIndex = 23;
            this.ariza.Text = "Control/Defect";
            this.ariza.UseVisualStyleBackColor = true;
            this.ariza.CheckedChanged += new System.EventHandler(this.ariza_CheckedChanged);
            // 
            // degisen_parca
            // 
            this.degisen_parca.Appearance = System.Windows.Forms.Appearance.Button;
            this.degisen_parca.AutoSize = true;
            this.degisen_parca.Font = new System.Drawing.Font("MS Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.degisen_parca.Location = new System.Drawing.Point(256, 17);
            this.degisen_parca.Name = "degisen_parca";
            this.degisen_parca.Size = new System.Drawing.Size(262, 37);
            this.degisen_parca.TabIndex = 24;
            this.degisen_parca.Text = "Solution/Montage";
            this.degisen_parca.UseVisualStyleBackColor = true;
            this.degisen_parca.CheckedChanged += new System.EventHandler(this.degisen_parca_CheckedChanged);
            // 
            // kut
            // 
            this.kut.Appearance = System.Windows.Forms.Appearance.Button;
            this.kut.AutoSize = true;
            this.kut.Font = new System.Drawing.Font("MS Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.kut.Location = new System.Drawing.Point(545, 17);
            this.kut.Name = "kut";
            this.kut.Size = new System.Drawing.Size(232, 37);
            this.kut.TabIndex = 25;
            this.kut.Text = "Final Test/End";
            this.kut.UseVisualStyleBackColor = true;
            this.kut.CheckedChanged += new System.EventHandler(this.kut_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(782, 30);
            this.label4.TabIndex = 26;
            this.label4.Text = "Select comment Type and Specify the Title by typing.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_main
            // 
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Controls.Add(this.bunifuSeparator4);
            this.panel_main.Controls.Add(this.button1);
            this.panel_main.Controls.Add(this.panel3);
            this.panel_main.Controls.Add(this.panel_ariza_bagli);
            this.panel_main.Controls.Add(this.panel1);
            this.panel_main.Controls.Add(this.label5);
            this.panel_main.Controls.Add(this.kydt);
            this.panel_main.Location = new System.Drawing.Point(20, 214);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(782, 317);
            this.panel_main.TabIndex = 27;
            this.panel_main.Visible = false;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(4, 34);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(467, 10);
            this.bunifuSeparator4.TabIndex = 37;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(477, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 38);
            this.button1.TabIndex = 36;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.turkish_ric);
            this.panel3.Location = new System.Drawing.Point(12, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 99);
            this.panel3.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Turkish Comment";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // turkish_ric
            // 
            this.turkish_ric.Location = new System.Drawing.Point(7, 27);
            this.turkish_ric.Name = "turkish_ric";
            this.turkish_ric.Size = new System.Drawing.Size(399, 62);
            this.turkish_ric.TabIndex = 13;
            this.turkish_ric.Text = "";
            // 
            // panel_ariza_bagli
            // 
            this.panel_ariza_bagli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ariza_bagli.Controls.Add(this.arama_parca);
            this.panel_ariza_bagli.Controls.Add(this.label6);
            this.panel_ariza_bagli.Controls.Add(this.arizasi);
            this.panel_ariza_bagli.Location = new System.Drawing.Point(477, 4);
            this.panel_ariza_bagli.Name = "panel_ariza_bagli";
            this.panel_ariza_bagli.Size = new System.Drawing.Size(304, 205);
            this.panel_ariza_bagli.TabIndex = 29;
            this.panel_ariza_bagli.Visible = false;
            // 
            // arama_parca
            // 
            this.arama_parca.Font = new System.Drawing.Font("MS Gothic", 10.75F, System.Drawing.FontStyle.Bold);
            this.arama_parca.Location = new System.Drawing.Point(7, 39);
            this.arama_parca.Name = "arama_parca";
            this.arama_parca.Size = new System.Drawing.Size(286, 22);
            this.arama_parca.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            this.label6.Location = new System.Drawing.Point(7, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 30);
            this.label6.TabIndex = 27;
            this.label6.Text = "Link to Control/Defect";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arizasi
            // 
            this.arizasi.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.arizasi.FormattingEnabled = true;
            this.arizasi.ItemHeight = 21;
            this.arizasi.Location = new System.Drawing.Point(7, 67);
            this.arizasi.Name = "arizasi";
            this.arizasi.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.arizasi.Size = new System.Drawing.Size(286, 130);
            this.arizasi.TabIndex = 0;
            this.arizasi.SelectedIndexChanged += new System.EventHandler(this.arizasi_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(467, 30);
            this.label5.TabIndex = 27;
            this.label5.Text = "Set Comment";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kydt
            // 
            this.kydt.Enabled = false;
            this.kydt.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kydt.Image = ((System.Drawing.Image)(resources.GetObject("kydt.Image")));
            this.kydt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kydt.Location = new System.Drawing.Point(477, 257);
            this.kydt.Name = "kydt";
            this.kydt.Size = new System.Drawing.Size(161, 50);
            this.kydt.TabIndex = 30;
            this.kydt.Text = "Save";
            this.kydt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kydt.UseVisualStyleBackColor = true;
            this.kydt.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.kut);
            this.panel5.Controls.Add(this.ariza);
            this.panel5.Controls.Add(this.degisen_parca);
            this.panel5.Location = new System.Drawing.Point(20, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(782, 79);
            this.panel5.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(675, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 50);
            this.button2.TabIndex = 31;
            this.button2.Text = "Exit";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // baslik
            // 
            this.baslik.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.Location = new System.Drawing.Point(74, 42);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(428, 28);
            this.baslik.TabIndex = 32;
            this.baslik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.baslik.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(561, 30);
            this.label7.TabIndex = 33;
            this.label7.Text = "Set Title";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.baslik);
            this.panel4.Controls.Add(this.bunifuSeparator1);
            this.panel4.Location = new System.Drawing.Point(138, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(569, 76);
            this.panel4.TabIndex = 34;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-1, 29);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(569, 10);
            this.bunifuSeparator1.TabIndex = 38;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Yu Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(621, 2);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(181, 12);
            this.linkLabel1.TabIndex = 38;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Devoloped by Mizer - © LetMeRepair 2019";
            // 
            // ekle_sirtuex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(814, 535);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ekle_sirtuex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LetMeRepair - Comment Creator";
            this.Load += new System.EventHandler(this.ekle_sirtuex_Load);
            this.panel1.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_ariza_bagli.ResumeLayout(false);
            this.panel_ariza_bagli.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox english_rich;
        private System.Windows.Forms.RadioButton ariza;
        private System.Windows.Forms.RadioButton degisen_parca;
        private System.Windows.Forms.RadioButton kut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel_ariza_bagli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox arizasi;
        private System.Windows.Forms.Button kydt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox baslik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox arama_parca;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox turkish_ric;
        private System.Windows.Forms.Button button1;
        private ns1.BunifuSeparator bunifuSeparator4;
        private ns1.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}