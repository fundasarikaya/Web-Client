namespace webclient
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.btnsonuc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsayi1
            // 
            this.txtsayi1.Location = new System.Drawing.Point(152, 12);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(100, 20);
            this.txtsayi1.TabIndex = 0;
            // 
            // txtsayi2
            // 
            this.txtsayi2.Location = new System.Drawing.Point(152, 64);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(100, 20);
            this.txtsayi2.TabIndex = 1;
            // 
            // btnsonuc
            // 
            this.btnsonuc.Location = new System.Drawing.Point(177, 121);
            this.btnsonuc.Name = "btnsonuc";
            this.btnsonuc.Size = new System.Drawing.Size(75, 23);
            this.btnsonuc.TabIndex = 2;
            this.btnsonuc.Text = "sonuc";
            this.btnsonuc.UseVisualStyleBackColor = true;
            this.btnsonuc.Click += new System.EventHandler(this.btnsonuc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "sayi 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "sayi 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsonuc);
            this.Controls.Add(this.txtsayi2);
            this.Controls.Add(this.txtsayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.TextBox txtsayi2;
        private System.Windows.Forms.Button btnsonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

