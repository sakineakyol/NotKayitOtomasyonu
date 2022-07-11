
namespace NotKayıtOtomasyonu
{
    partial class FrmOgretmenDetay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmenDetay));
            this.grpOgrenciEkle = new System.Windows.Forms.GroupBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mskNumara = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpNotGiris = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtSinav3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSinav2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSinav1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKalanSayisi = new System.Windows.Forms.Label();
            this.lblGecenSayisi = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpSinavNotlari = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oGRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRNUMARADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRS3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRTALAMADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dURUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblDersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbNotKayitDataSet = new NotKayıtOtomasyonu.DbNotKayitDataSet();
            this.tblDersTableAdapter = new NotKayıtOtomasyonu.DbNotKayitDataSetTableAdapters.TblDersTableAdapter();
            this.grpOgrenciEkle.SuspendLayout();
            this.grpNotGiris.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpSinavNotlari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOgrenciEkle
            // 
            this.grpOgrenciEkle.Controls.Add(this.btnOgrenciEkle);
            this.grpOgrenciEkle.Controls.Add(this.label3);
            this.grpOgrenciEkle.Controls.Add(this.txtSoyad);
            this.grpOgrenciEkle.Controls.Add(this.label2);
            this.grpOgrenciEkle.Controls.Add(this.txtAd);
            this.grpOgrenciEkle.Controls.Add(this.mskNumara);
            this.grpOgrenciEkle.Controls.Add(this.label1);
            this.grpOgrenciEkle.Location = new System.Drawing.Point(24, 12);
            this.grpOgrenciEkle.Name = "grpOgrenciEkle";
            this.grpOgrenciEkle.Size = new System.Drawing.Size(336, 273);
            this.grpOgrenciEkle.TabIndex = 0;
            this.grpOgrenciEkle.TabStop = false;
            this.grpOgrenciEkle.Text = "Öğrenci Ekle";
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(130, 191);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(138, 36);
            this.btnOgrenciEkle.TabIndex = 6;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyad :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(130, 133);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(138, 28);
            this.txtSoyad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(130, 90);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(138, 28);
            this.txtAd.TabIndex = 2;
            // 
            // mskNumara
            // 
            this.mskNumara.Location = new System.Drawing.Point(130, 46);
            this.mskNumara.Mask = "0000";
            this.mskNumara.Name = "mskNumara";
            this.mskNumara.Size = new System.Drawing.Size(138, 28);
            this.mskNumara.TabIndex = 1;
            this.mskNumara.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara :";
            // 
            // grpNotGiris
            // 
            this.grpNotGiris.Controls.Add(this.btnGuncelle);
            this.grpNotGiris.Controls.Add(this.txtSinav3);
            this.grpNotGiris.Controls.Add(this.label4);
            this.grpNotGiris.Controls.Add(this.txtSinav2);
            this.grpNotGiris.Controls.Add(this.label5);
            this.grpNotGiris.Controls.Add(this.txtSinav1);
            this.grpNotGiris.Controls.Add(this.label6);
            this.grpNotGiris.Location = new System.Drawing.Point(392, 12);
            this.grpNotGiris.Name = "grpNotGiris";
            this.grpNotGiris.Size = new System.Drawing.Size(336, 273);
            this.grpNotGiris.TabIndex = 1;
            this.grpNotGiris.TabStop = false;
            this.grpNotGiris.Text = "Not Ekle";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(130, 191);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(138, 36);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtSinav3
            // 
            this.txtSinav3.Location = new System.Drawing.Point(130, 140);
            this.txtSinav3.Name = "txtSinav3";
            this.txtSinav3.Size = new System.Drawing.Size(138, 28);
            this.txtSinav3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sınav 3 :";
            // 
            // txtSinav2
            // 
            this.txtSinav2.Location = new System.Drawing.Point(130, 90);
            this.txtSinav2.Name = "txtSinav2";
            this.txtSinav2.Size = new System.Drawing.Size(138, 28);
            this.txtSinav2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sınav 2 :";
            // 
            // txtSinav1
            // 
            this.txtSinav1.Location = new System.Drawing.Point(130, 49);
            this.txtSinav1.Name = "txtSinav1";
            this.txtSinav1.Size = new System.Drawing.Size(138, 28);
            this.txtSinav1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sınav 1 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKalanSayisi);
            this.groupBox1.Controls.Add(this.lblGecenSayisi);
            this.groupBox1.Controls.Add(this.lblOrtalama);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(754, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 273);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ortalamalar ";
            // 
            // lblKalanSayisi
            // 
            this.lblKalanSayisi.AutoSize = true;
            this.lblKalanSayisi.Location = new System.Drawing.Point(152, 143);
            this.lblKalanSayisi.Name = "lblKalanSayisi";
            this.lblKalanSayisi.Size = new System.Drawing.Size(28, 21);
            this.lblKalanSayisi.TabIndex = 8;
            this.lblKalanSayisi.Text = "00";
            // 
            // lblGecenSayisi
            // 
            this.lblGecenSayisi.AutoSize = true;
            this.lblGecenSayisi.Location = new System.Drawing.Point(152, 97);
            this.lblGecenSayisi.Name = "lblGecenSayisi";
            this.lblGecenSayisi.Size = new System.Drawing.Size(28, 21);
            this.lblGecenSayisi.TabIndex = 7;
            this.lblGecenSayisi.Text = "00";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(152, 49);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(28, 21);
            this.lblOrtalama.TabIndex = 6;
            this.lblOrtalama.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Kalan Sayısı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Geçen Sayısı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ortalama :";
            // 
            // grpSinavNotlari
            // 
            this.grpSinavNotlari.Controls.Add(this.dataGridView1);
            this.grpSinavNotlari.Location = new System.Drawing.Point(24, 309);
            this.grpSinavNotlari.Name = "grpSinavNotlari";
            this.grpSinavNotlari.Size = new System.Drawing.Size(1082, 268);
            this.grpSinavNotlari.TabIndex = 3;
            this.grpSinavNotlari.TabStop = false;
            this.grpSinavNotlari.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oGRIDDataGridViewTextBoxColumn,
            this.oGRNUMARADataGridViewTextBoxColumn,
            this.oGRADDataGridViewTextBoxColumn,
            this.oGRSOYADDataGridViewTextBoxColumn,
            this.oGRS1DataGridViewTextBoxColumn,
            this.oGRS2DataGridViewTextBoxColumn,
            this.oGRS3DataGridViewTextBoxColumn,
            this.oRTALAMADataGridViewTextBoxColumn,
            this.dURUMDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblDersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1076, 241);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // oGRIDDataGridViewTextBoxColumn
            // 
            this.oGRIDDataGridViewTextBoxColumn.DataPropertyName = "OGRID";
            this.oGRIDDataGridViewTextBoxColumn.HeaderText = "OGRID";
            this.oGRIDDataGridViewTextBoxColumn.Name = "oGRIDDataGridViewTextBoxColumn";
            this.oGRIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oGRNUMARADataGridViewTextBoxColumn
            // 
            this.oGRNUMARADataGridViewTextBoxColumn.DataPropertyName = "OGRNUMARA";
            this.oGRNUMARADataGridViewTextBoxColumn.HeaderText = "OGRNUMARA";
            this.oGRNUMARADataGridViewTextBoxColumn.Name = "oGRNUMARADataGridViewTextBoxColumn";
            // 
            // oGRADDataGridViewTextBoxColumn
            // 
            this.oGRADDataGridViewTextBoxColumn.DataPropertyName = "OGRAD";
            this.oGRADDataGridViewTextBoxColumn.HeaderText = "OGRAD";
            this.oGRADDataGridViewTextBoxColumn.Name = "oGRADDataGridViewTextBoxColumn";
            // 
            // oGRSOYADDataGridViewTextBoxColumn
            // 
            this.oGRSOYADDataGridViewTextBoxColumn.DataPropertyName = "OGRSOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.HeaderText = "OGRSOYAD";
            this.oGRSOYADDataGridViewTextBoxColumn.Name = "oGRSOYADDataGridViewTextBoxColumn";
            // 
            // oGRS1DataGridViewTextBoxColumn
            // 
            this.oGRS1DataGridViewTextBoxColumn.DataPropertyName = "OGRS1";
            this.oGRS1DataGridViewTextBoxColumn.HeaderText = "OGRS1";
            this.oGRS1DataGridViewTextBoxColumn.Name = "oGRS1DataGridViewTextBoxColumn";
            // 
            // oGRS2DataGridViewTextBoxColumn
            // 
            this.oGRS2DataGridViewTextBoxColumn.DataPropertyName = "OGRS2";
            this.oGRS2DataGridViewTextBoxColumn.HeaderText = "OGRS2";
            this.oGRS2DataGridViewTextBoxColumn.Name = "oGRS2DataGridViewTextBoxColumn";
            // 
            // oGRS3DataGridViewTextBoxColumn
            // 
            this.oGRS3DataGridViewTextBoxColumn.DataPropertyName = "OGRS3";
            this.oGRS3DataGridViewTextBoxColumn.HeaderText = "OGRS3";
            this.oGRS3DataGridViewTextBoxColumn.Name = "oGRS3DataGridViewTextBoxColumn";
            // 
            // oRTALAMADataGridViewTextBoxColumn
            // 
            this.oRTALAMADataGridViewTextBoxColumn.DataPropertyName = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.HeaderText = "ORTALAMA";
            this.oRTALAMADataGridViewTextBoxColumn.Name = "oRTALAMADataGridViewTextBoxColumn";
            // 
            // dURUMDataGridViewCheckBoxColumn
            // 
            this.dURUMDataGridViewCheckBoxColumn.DataPropertyName = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.HeaderText = "DURUM";
            this.dURUMDataGridViewCheckBoxColumn.Name = "dURUMDataGridViewCheckBoxColumn";
            // 
            // tblDersBindingSource
            // 
            this.tblDersBindingSource.DataMember = "TblDers";
            this.tblDersBindingSource.DataSource = this.dbNotKayitDataSet;
            // 
            // dbNotKayitDataSet
            // 
            this.dbNotKayitDataSet.DataSetName = "DbNotKayitDataSet";
            this.dbNotKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDersTableAdapter
            // 
            this.tblDersTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOgretmenDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1145, 589);
            this.Controls.Add(this.grpSinavNotlari);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpNotGiris);
            this.Controls.Add(this.grpOgrenciEkle);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmOgretmenDetay";
            this.Text = "Öğretmen Detay";
            this.Load += new System.EventHandler(this.FrmOgretmenDetay_Load);
            this.grpOgrenciEkle.ResumeLayout(false);
            this.grpOgrenciEkle.PerformLayout();
            this.grpNotGiris.ResumeLayout(false);
            this.grpNotGiris.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSinavNotlari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNotKayitDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgrenciEkle;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mskNumara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpNotGiris;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtSinav3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSinav2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSinav1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblKalanSayisi;
        private System.Windows.Forms.Label lblGecenSayisi;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.GroupBox grpSinavNotlari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbNotKayitDataSet dbNotKayitDataSet;
        private System.Windows.Forms.BindingSource tblDersBindingSource;
        private DbNotKayitDataSetTableAdapters.TblDersTableAdapter tblDersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRNUMARADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oGRS3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRTALAMADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dURUMDataGridViewCheckBoxColumn;
    }
}