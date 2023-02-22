
namespace KatmanliMimariProje
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblDersID = new System.Windows.Forms.Label();
            this.TxtDersID = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TxtDersAdi = new System.Windows.Forms.TextBox();
            this.LblDersAdi = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // LblDersID
            // 
            this.LblDersID.AutoSize = true;
            this.LblDersID.Location = new System.Drawing.Point(578, 14);
            this.LblDersID.Name = "LblDersID";
            this.LblDersID.Size = new System.Drawing.Size(64, 20);
            this.LblDersID.TabIndex = 1;
            this.LblDersID.Text = "DersID:";
            // 
            // TxtDersID
            // 
            this.TxtDersID.Location = new System.Drawing.Point(639, 12);
            this.TxtDersID.Name = "TxtDersID";
            this.TxtDersID.Size = new System.Drawing.Size(133, 26);
            this.TxtDersID.TabIndex = 1;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(639, 93);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(133, 27);
            this.BtnKaydet.TabIndex = 3;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtDersAdi
            // 
            this.TxtDersAdi.Location = new System.Drawing.Point(639, 44);
            this.TxtDersAdi.Name = "TxtDersAdi";
            this.TxtDersAdi.Size = new System.Drawing.Size(133, 26);
            this.TxtDersAdi.TabIndex = 2;
            // 
            // LblDersAdi
            // 
            this.LblDersAdi.AutoSize = true;
            this.LblDersAdi.Location = new System.Drawing.Point(568, 46);
            this.LblDersAdi.Name = "LblDersAdi";
            this.LblDersAdi.Size = new System.Drawing.Size(74, 20);
            this.LblDersAdi.TabIndex = 4;
            this.LblDersAdi.Text = "Ders Adı:";
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(639, 126);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(133, 27);
            this.BtnSil.TabIndex = 4;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(639, 159);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(133, 27);
            this.BtnGuncelle.TabIndex = 5;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(639, 192);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(133, 27);
            this.BtnListele.TabIndex = 6;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 230);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.TxtDersAdi);
            this.Controls.Add(this.LblDersAdi);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtDersID);
            this.Controls.Add(this.LblDersID);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Ders İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblDersID;
        private System.Windows.Forms.TextBox TxtDersID;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtDersAdi;
        private System.Windows.Forms.Label LblDersAdi;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnListele;
    }
}

