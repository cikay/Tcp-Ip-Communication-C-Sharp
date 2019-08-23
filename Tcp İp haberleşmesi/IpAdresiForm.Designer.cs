namespace Tcp_İp_haberleşmesi
{
    partial class IpAdresiForm
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
            this.Baglan = new System.Windows.Forms.Button();
            this.IpAdresiTextBox = new System.Windows.Forms.TextBox();
            this.PortNoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Baglan
            // 
            this.Baglan.Location = new System.Drawing.Point(168, 264);
            this.Baglan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Baglan.Name = "Baglan";
            this.Baglan.Size = new System.Drawing.Size(118, 42);
            this.Baglan.TabIndex = 0;
            this.Baglan.Text = "Bağlan";
            this.Baglan.UseVisualStyleBackColor = true;
            this.Baglan.Click += new System.EventHandler(this.Baglan_Click);
            // 
            // IpAdresiTextBox
            // 
            this.IpAdresiTextBox.Location = new System.Drawing.Point(145, 89);
            this.IpAdresiTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IpAdresiTextBox.Name = "IpAdresiTextBox";
            this.IpAdresiTextBox.Size = new System.Drawing.Size(221, 26);
            this.IpAdresiTextBox.TabIndex = 1;
            // 
            // PortNoTextBox
            // 
            this.PortNoTextBox.Location = new System.Drawing.Point(145, 194);
            this.PortNoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PortNoTextBox.Name = "PortNoTextBox";
            this.PortNoTextBox.Size = new System.Drawing.Size(221, 26);
            this.PortNoTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ip Adresi:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(75, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port No:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // IpAdresiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortNoTextBox);
            this.Controls.Add(this.IpAdresiTextBox);
            this.Controls.Add(this.Baglan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IpAdresiForm";
            this.Text = "IpAdresiForm";
            this.Load += new System.EventHandler(this.IpAdresiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Baglan;
        private System.Windows.Forms.TextBox IpAdresiTextBox;
        private System.Windows.Forms.TextBox PortNoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}