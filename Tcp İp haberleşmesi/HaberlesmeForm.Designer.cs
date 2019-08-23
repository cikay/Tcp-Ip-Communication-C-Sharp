namespace Tcp_İp_haberleşmesi
{
    partial class HaberlesmeForm
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
            this.ServerBaglanBtn = new System.Windows.Forms.Button();
            this.lbBaglantiBilgisi = new System.Windows.Forms.Label();
            this.ButonBox = new System.Windows.Forms.GroupBox();
            this.ButonEkle = new System.Windows.Forms.Button();
            this.ButonSil = new System.Windows.Forms.Button();
            this.GelenVeriBox = new System.Windows.Forms.ListBox();
            this.IpAdresiDuzeltBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServerBaglanBtn
            // 
            this.ServerBaglanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ServerBaglanBtn.Location = new System.Drawing.Point(752, 81);
            this.ServerBaglanBtn.Name = "ServerBaglanBtn";
            this.ServerBaglanBtn.Size = new System.Drawing.Size(151, 49);
            this.ServerBaglanBtn.TabIndex = 0;
            this.ServerBaglanBtn.Text = "Severa bağlanın";
            this.ServerBaglanBtn.UseVisualStyleBackColor = true;
            this.ServerBaglanBtn.Click += new System.EventHandler(this.SeverBaglanBtn_Click);
            // 
            // lbBaglantiBilgisi
            // 
            this.lbBaglantiBilgisi.AutoSize = true;
            this.lbBaglantiBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBaglantiBilgisi.Location = new System.Drawing.Point(707, 44);
            this.lbBaglantiBilgisi.Name = "lbBaglantiBilgisi";
            this.lbBaglantiBilgisi.Size = new System.Drawing.Size(196, 17);
            this.lbBaglantiBilgisi.TabIndex = 1;
            this.lbBaglantiBilgisi.Text = "Sunucuya bağlı değilsiniz!";
            // 
            // ButonBox
            // 
            this.ButonBox.Location = new System.Drawing.Point(12, 26);
            this.ButonBox.Name = "ButonBox";
            this.ButonBox.Size = new System.Drawing.Size(600, 385);
            this.ButonBox.TabIndex = 2;
            this.ButonBox.TabStop = false;
            this.ButonBox.Enter += new System.EventHandler(this.ButonBox_Enter);
            // 
            // ButonEkle
            // 
            this.ButonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButonEkle.Location = new System.Drawing.Point(507, 438);
            this.ButonEkle.Name = "ButonEkle";
            this.ButonEkle.Size = new System.Drawing.Size(105, 49);
            this.ButonEkle.TabIndex = 3;
            this.ButonEkle.Text = "Buton Ekle";
            this.ButonEkle.UseVisualStyleBackColor = true;
            this.ButonEkle.Click += new System.EventHandler(this.ButonEkle_Click);
            // 
            // ButonSil
            // 
            this.ButonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButonSil.Location = new System.Drawing.Point(633, 438);
            this.ButonSil.Name = "ButonSil";
            this.ButonSil.Size = new System.Drawing.Size(98, 49);
            this.ButonSil.TabIndex = 4;
            this.ButonSil.Text = "Buton Sil";
            this.ButonSil.UseVisualStyleBackColor = true;
            // 
            // GelenVeriBox
            // 
            this.GelenVeriBox.FormattingEnabled = true;
            this.GelenVeriBox.Location = new System.Drawing.Point(703, 167);
            this.GelenVeriBox.Name = "GelenVeriBox";
            this.GelenVeriBox.Size = new System.Drawing.Size(200, 199);
            this.GelenVeriBox.TabIndex = 5;
            // 
            // IpAdresiDuzeltBtn
            // 
            this.IpAdresiDuzeltBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IpAdresiDuzeltBtn.Location = new System.Drawing.Point(752, 438);
            this.IpAdresiDuzeltBtn.Name = "IpAdresiDuzeltBtn";
            this.IpAdresiDuzeltBtn.Size = new System.Drawing.Size(138, 49);
            this.IpAdresiDuzeltBtn.TabIndex = 6;
            this.IpAdresiDuzeltBtn.Text = "Ip adresi düzelt";
            this.IpAdresiDuzeltBtn.UseVisualStyleBackColor = true;
            this.IpAdresiDuzeltBtn.Click += new System.EventHandler(this.IpAdresiDuzeltBtn_Click);
            // 
            // HaberlesmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 532);
            this.Controls.Add(this.IpAdresiDuzeltBtn);
            this.Controls.Add(this.GelenVeriBox);
            this.Controls.Add(this.ButonSil);
            this.Controls.Add(this.ButonEkle);
            this.Controls.Add(this.ButonBox);
            this.Controls.Add(this.lbBaglantiBilgisi);
            this.Controls.Add(this.ServerBaglanBtn);
            this.Name = "HaberlesmeForm";
            this.Text = "HaberlesmeForm";
            this.Load += new System.EventHandler(this.HaberlesmeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ServerBaglanBtn;
        private System.Windows.Forms.Label lbBaglantiBilgisi;
        private System.Windows.Forms.GroupBox ButonBox;
        private System.Windows.Forms.Button ButonEkle;
        private System.Windows.Forms.Button ButonSil;
        private System.Windows.Forms.ListBox GelenVeriBox;
        private System.Windows.Forms.Button IpAdresiDuzeltBtn;
    }
}