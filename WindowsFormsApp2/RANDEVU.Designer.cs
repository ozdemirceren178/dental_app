namespace WindowsFormsApp2
{
    partial class RANDEVU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RANDEVU));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbtedavi = new System.Windows.Forms.ComboBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.cmbad = new System.Windows.Forms.ComboBox();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.msksaat = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.randevugrid = new System.Windows.Forms.DataGridView();
            this.randevutxt = new System.Windows.Forms.TextBox();
            this.dentisDataSet = new WindowsFormsApp2.DentisDataSet();
            this.dentisDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randevugrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentisDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbtedavi);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btngüncelle);
            this.groupBox1.Controls.Add(this.btnkaydet);
            this.groupBox1.Controls.Add(this.cmbad);
            this.groupBox1.Controls.Add(this.msktarih);
            this.groupBox1.Controls.Add(this.msksaat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(32, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Ekleme ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // cmbtedavi
            // 
            this.cmbtedavi.BackColor = System.Drawing.Color.Snow;
            this.cmbtedavi.FormattingEnabled = true;
            this.cmbtedavi.Location = new System.Drawing.Point(163, 182);
            this.cmbtedavi.Name = "cmbtedavi";
            this.cmbtedavi.Size = new System.Drawing.Size(144, 30);
            this.cmbtedavi.TabIndex = 30;
            // 
            // btnsil
            // 
            this.btnsil.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.Location = new System.Drawing.Point(26, 250);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(143, 30);
            this.btnsil.TabIndex = 29;
            this.btnsil.Text = "Sil ";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngüncelle.Location = new System.Drawing.Point(110, 297);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(143, 30);
            this.btngüncelle.TabIndex = 28;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkaydet.Location = new System.Drawing.Point(184, 250);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(143, 30);
            this.btnkaydet.TabIndex = 27;
            this.btnkaydet.Text = "Kaydet ";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // cmbad
            // 
            this.cmbad.BackColor = System.Drawing.Color.Snow;
            this.cmbad.FormattingEnabled = true;
            this.cmbad.Location = new System.Drawing.Point(163, 61);
            this.cmbad.Name = "cmbad";
            this.cmbad.Size = new System.Drawing.Size(144, 30);
            this.cmbad.TabIndex = 24;
            // 
            // msktarih
            // 
            this.msktarih.BackColor = System.Drawing.Color.Snow;
            this.msktarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msktarih.Location = new System.Drawing.Point(163, 104);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(144, 27);
            this.msktarih.TabIndex = 23;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // msksaat
            // 
            this.msksaat.BackColor = System.Drawing.Color.Snow;
            this.msksaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msksaat.Location = new System.Drawing.Point(163, 140);
            this.msksaat.Mask = "00:00";
            this.msksaat.Name = "msksaat";
            this.msksaat.Size = new System.Drawing.Size(144, 27);
            this.msksaat.TabIndex = 22;
            this.msksaat.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tedavi : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Saat : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tarih : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "AD SOYAD :";
            // 
            // randevugrid
            // 
            this.randevugrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.randevugrid.Location = new System.Drawing.Point(0, 67);
            this.randevugrid.Name = "randevugrid";
            this.randevugrid.RowHeadersWidth = 51;
            this.randevugrid.RowTemplate.Height = 24;
            this.randevugrid.Size = new System.Drawing.Size(603, 338);
            this.randevugrid.TabIndex = 1;
            this.randevugrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.randevugrid_CellClick);
            // 
            // randevutxt
            // 
            this.randevutxt.BackColor = System.Drawing.Color.Snow;
            this.randevutxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevutxt.Location = new System.Drawing.Point(93, 32);
            this.randevutxt.Name = "randevutxt";
            this.randevutxt.Size = new System.Drawing.Size(376, 27);
            this.randevutxt.TabIndex = 30;
            this.randevutxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dentisDataSet
            // 
            this.dentisDataSet.DataSetName = "DentisDataSet";
            this.dentisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dentisDataSetBindingSource
            // 
            this.dentisDataSetBindingSource.DataSource = this.dentisDataSet;
            this.dentisDataSetBindingSource.Position = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 36);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.randevugrid);
            this.groupBox2.Controls.Add(this.randevutxt);
            this.groupBox2.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(456, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 403);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "randevu sorgu";
            // 
            // RANDEVU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1122, 517);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "RANDEVU";
            this.Text = "RANDEVU";
            this.Load += new System.EventHandler(this.RANDEVU_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.randevugrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentisDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.ComboBox cmbad;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private System.Windows.Forms.MaskedTextBox msksaat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView randevugrid;
        private System.Windows.Forms.TextBox randevutxt;
        private System.Windows.Forms.ComboBox cmbtedavi;
        private DentisDataSet dentisDataSet;
        private System.Windows.Forms.BindingSource dentisDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}