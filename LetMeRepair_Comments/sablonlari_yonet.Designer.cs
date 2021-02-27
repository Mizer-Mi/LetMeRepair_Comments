namespace LetMeRepair_Comments
{
    partial class sablonlari_yonet
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
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sablonlari_yonet));
            this.Exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bunifuSeparator3 = new ns1.BunifuSeparator();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.bunifuSeparator4 = new ns1.BunifuSeparator();
            this.sil = new System.Windows.Forms.Button();
            this.update_panel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel6.SuspendLayout();
            this.update_panel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F);
            this.Exit.Location = new System.Drawing.Point(12, 399);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(585, 37);
            this.Exit.TabIndex = 51;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(561, 30);
            this.label5.TabIndex = 33;
            this.label5.Text = "Select Template";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(561, 38);
            this.label4.TabIndex = 45;
            this.label4.Text = "Update/Delete Template";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.bunifuSeparator3);
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Location = new System.Drawing.Point(8, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(569, 76);
            this.panel6.TabIndex = 39;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(-1, 29);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(569, 10);
            this.bunifuSeparator3.TabIndex = 38;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 32);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 30);
            this.label8.TabIndex = 48;
            this.label8.Text = "ID=";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(561, 30);
            this.label6.TabIndex = 33;
            this.label6.Text = "Set Title";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(7, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 40);
            this.button3.TabIndex = 47;
            this.button3.Text = "Update";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(74, 42);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(428, 28);
            this.textBox4.TabIndex = 32;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(-1, 29);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(569, 10);
            this.bunifuSeparator4.TabIndex = 38;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // sil
            // 
            this.sil.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil.Image = ((System.Drawing.Image)(resources.GetObject("sil.Image")));
            this.sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sil.Location = new System.Drawing.Point(452, 199);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(107, 40);
            this.sil.TabIndex = 48;
            this.sil.Text = "Delete";
            this.sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // update_panel
            // 
            this.update_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.update_panel.Controls.Add(this.sil);
            this.update_panel.Controls.Add(this.panel1);
            this.update_panel.Controls.Add(this.panel2);
            this.update_panel.Controls.Add(this.label8);
            this.update_panel.Controls.Add(this.button3);
            this.update_panel.Controls.Add(this.label6);
            this.update_panel.Controls.Add(this.textBox4);
            this.update_panel.Controls.Add(this.bunifuSeparator4);
            this.update_panel.Location = new System.Drawing.Point(8, 132);
            this.update_panel.Name = "update_panel";
            this.update_panel.Size = new System.Drawing.Size(569, 244);
            this.update_panel.TabIndex = 46;
            this.update_panel.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.update_panel);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(585, 381);
            this.panel5.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Location = new System.Drawing.Point(280, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 105);
            this.panel1.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Customer Comment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(3, 29);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(271, 73);
            this.richTextBox2.TabIndex = 13;
            this.richTextBox2.Text = "";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(7, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 105);
            this.panel2.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("MS Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(-1, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Global Comment";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(2, 26);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(259, 76);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // sablonlari_yonet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 437);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.panel5);
            this.Name = "sablonlari_yonet";
            this.Text = "sablonlari_yonet";
            this.Load += new System.EventHandler(this.Sablonlari_yonet_Load);
            this.panel6.ResumeLayout(false);
            this.update_panel.ResumeLayout(false);
            this.update_panel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private ns1.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox4;
        private ns1.BunifuSeparator bunifuSeparator4;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Panel update_panel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}