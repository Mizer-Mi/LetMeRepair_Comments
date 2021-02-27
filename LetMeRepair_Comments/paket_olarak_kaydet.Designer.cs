namespace LetMeRepair_Comments
{
    partial class paket_olarak_kaydet
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paket_olarak_kaydet));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kydt = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.yeni = new System.Windows.Forms.Button();
            this.baslik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 32);
            this.comboBox1.TabIndex = 1;
            // 
            // kydt
            // 
            this.kydt.Enabled = false;
            this.kydt.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kydt.Image = ((System.Drawing.Image)(resources.GetObject("kydt.Image")));
            this.kydt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kydt.Location = new System.Drawing.Point(7, 103);
            this.kydt.Name = "kydt";
            this.kydt.Size = new System.Drawing.Size(89, 40);
            this.kydt.TabIndex = 31;
            this.kydt.Text = "Save";
            this.kydt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kydt.UseVisualStyleBackColor = true;
            this.kydt.Click += new System.EventHandler(this.Kydt_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(331, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 40);
            this.button4.TabIndex = 32;
            this.button4.Text = "Exit";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // yeni
            // 
            this.yeni.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.yeni.Image = ((System.Drawing.Image)(resources.GetObject("yeni.Image")));
            this.yeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yeni.Location = new System.Drawing.Point(7, 5);
            this.yeni.Name = "yeni";
            this.yeni.Size = new System.Drawing.Size(143, 41);
            this.yeni.TabIndex = 33;
            this.yeni.Text = "New Package";
            this.yeni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yeni.UseVisualStyleBackColor = true;
            this.yeni.Click += new System.EventHandler(this.Yeni_Click);
            // 
            // baslik
            // 
            this.baslik.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.Location = new System.Drawing.Point(80, 52);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(318, 28);
            this.baslik.TabIndex = 34;
            this.baslik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F);
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tittle:";
            // 
            // paket_olarak_kaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 146);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baslik);
            this.Controls.Add(this.yeni);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.kydt);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "paket_olarak_kaydet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "paket_olarak_kaydet";
            this.Load += new System.EventHandler(this.Paket_olarak_kaydet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button kydt;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button yeni;
        private System.Windows.Forms.TextBox baslik;
        private System.Windows.Forms.Label label1;
    }
}