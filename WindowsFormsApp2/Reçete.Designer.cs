namespace WindowsFormsApp2
{
    partial class Reçete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reçete));
            this.txttedavi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.txttutar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnkayde = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.reçetegrid = new System.Windows.Forms.DataGridView();
            this.txtreçete = new System.Windows.Forms.TextBox();
            this.btnyazdır = new System.Windows.Forms.Button();
            this.cmbad = new System.Windows.Forms.ComboBox();
            this.txtilac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.reçetegrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttedavi
            // 
            this.txttedavi.BackColor = System.Drawing.Color.Snow;
            this.txttedavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttedavi.Location = new System.Drawing.Point(174, 101);
            this.txttedavi.Name = "txttedavi";
            this.txttedavi.Size = new System.Drawing.Size(160, 28);
            this.txttedavi.TabIndex = 10;
            this.txttedavi.TextChanged += new System.EventHandler(this.txttedavi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tedavi  : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ad Soyad  : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmiktar
            // 
            this.txtmiktar.BackColor = System.Drawing.Color.Snow;
            this.txtmiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmiktar.Location = new System.Drawing.Point(174, 250);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(160, 28);
            this.txtmiktar.TabIndex = 15;
            this.txtmiktar.TextChanged += new System.EventHandler(this.txtmiktar_TextChanged);
            // 
            // txttutar
            // 
            this.txttutar.BackColor = System.Drawing.Color.Snow;
            this.txttutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttutar.Location = new System.Drawing.Point(174, 198);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(160, 28);
            this.txttutar.TabIndex = 14;
            this.txttutar.TextChanged += new System.EventHandler(this.txttutar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(48, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Miktar  :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(59, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tutar  : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnkayde
            // 
            this.btnkayde.BackColor = System.Drawing.Color.Snow;
            this.btnkayde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkayde.Location = new System.Drawing.Point(170, 302);
            this.btnkayde.Name = "btnkayde";
            this.btnkayde.Size = new System.Drawing.Size(164, 40);
            this.btnkayde.TabIndex = 16;
            this.btnkayde.Text = "Kaydet ";
            this.btnkayde.UseVisualStyleBackColor = false;
            this.btnkayde.Click += new System.EventHandler(this.btnkayde_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Snow;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(0, 302);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(164, 39);
            this.btnsil.TabIndex = 17;
            this.btnsil.Text = "Sil ";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // reçetegrid
            // 
            this.reçetegrid.BackgroundColor = System.Drawing.Color.DarkGray;
            this.reçetegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reçetegrid.Location = new System.Drawing.Point(6, 55);
            this.reçetegrid.Name = "reçetegrid";
            this.reçetegrid.RowHeadersWidth = 51;
            this.reçetegrid.RowTemplate.Height = 24;
            this.reçetegrid.Size = new System.Drawing.Size(522, 265);
            this.reçetegrid.TabIndex = 18;
            this.reçetegrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reçetegrid_CellClick);
            this.reçetegrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtreçete
            // 
            this.txtreçete.BackColor = System.Drawing.Color.Snow;
            this.txtreçete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtreçete.Location = new System.Drawing.Point(118, 21);
            this.txtreçete.Name = "txtreçete";
            this.txtreçete.Size = new System.Drawing.Size(294, 28);
            this.txtreçete.TabIndex = 19;
            this.txtreçete.TextChanged += new System.EventHandler(this.txtreçete_TextChanged);
            // 
            // btnyazdır
            // 
            this.btnyazdır.BackColor = System.Drawing.Color.Snow;
            this.btnyazdır.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyazdır.Location = new System.Drawing.Point(6, 326);
            this.btnyazdır.Name = "btnyazdır";
            this.btnyazdır.Size = new System.Drawing.Size(528, 40);
            this.btnyazdır.TabIndex = 21;
            this.btnyazdır.Text = "Yazdır ";
            this.btnyazdır.UseVisualStyleBackColor = false;
            this.btnyazdır.Click += new System.EventHandler(this.btnyazdır_Click);
            // 
            // cmbad
            // 
            this.cmbad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbad.FormattingEnabled = true;
            this.cmbad.Location = new System.Drawing.Point(174, 58);
            this.cmbad.Name = "cmbad";
            this.cmbad.Size = new System.Drawing.Size(160, 28);
            this.cmbad.TabIndex = 23;
            this.cmbad.SelectedIndexChanged += new System.EventHandler(this.cmbad_SelectedIndexChanged);
            this.cmbad.SelectionChangeCommitted += new System.EventHandler(this.cmbad_SelectionChangeCommitted);
            // 
            // txtilac
            // 
            this.txtilac.BackColor = System.Drawing.Color.Snow;
            this.txtilac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtilac.Location = new System.Drawing.Point(174, 153);
            this.txtilac.Name = "txtilac";
            this.txtilac.Size = new System.Drawing.Size(160, 28);
            this.txtilac.TabIndex = 26;
            this.txtilac.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(37, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ilaçlar  :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 38);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txttedavi);
            this.groupBox1.Controls.Add(this.txtilac);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbad);
            this.groupBox1.Controls.Add(this.txttutar);
            this.groupBox1.Controls.Add(this.txtmiktar);
            this.groupBox1.Controls.Add(this.btnkayde);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(5, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 372);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "reçete bilgi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtreçete);
            this.groupBox2.Controls.Add(this.reçetegrid);
            this.groupBox2.Controls.Add(this.btnyazdır);
            this.groupBox2.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(392, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 372);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "reçete sorgu";
            // 
            // Reçete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1001, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Reçete";
            this.Text = "Reçete";
            this.Load += new System.EventHandler(this.Reçete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reçetegrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txttedavi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnkayde;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.DataGridView reçetegrid;
        private System.Windows.Forms.TextBox txtreçete;
        private System.Windows.Forms.Button btnyazdır;
        private System.Windows.Forms.ComboBox cmbad;
        private System.Windows.Forms.TextBox txtilac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}