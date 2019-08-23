namespace Tcp_İp_haberleşmesi
{
    partial class ButonSilForm
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
            this.SeciliButonlariSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SeciliButonlariSil
            // 
            this.SeciliButonlariSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SeciliButonlariSil.Location = new System.Drawing.Point(559, 352);
            this.SeciliButonlariSil.Name = "SeciliButonlariSil";
            this.SeciliButonlariSil.Size = new System.Drawing.Size(168, 53);
            this.SeciliButonlariSil.TabIndex = 0;
            this.SeciliButonlariSil.Text = "Seçilen Butonları Sil";
            this.SeciliButonlariSil.UseVisualStyleBackColor = true;
            this.SeciliButonlariSil.Click += new System.EventHandler(this.SeciliButonlariSil_Click);
            // 
            // ButonSilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SeciliButonlariSil);
            this.Name = "ButonSilForm";
            this.Text = "ButonSilForm";
            this.Load += new System.EventHandler(this.ButonSilForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SeciliButonlariSil;
    }
}