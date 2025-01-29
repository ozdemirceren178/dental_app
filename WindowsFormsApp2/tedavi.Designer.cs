namespace WindowsFormsApp2
{
    partial class tedavi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tedavi));
            this.tutartext = new System.Windows.Forms.TextBox();
            this.tedaviad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tedavigrid = new System.Windows.Forms.DataGridView();
            this.Tbtnsil = new System.Windows.Forms.Button();
            this.Tbtndüzenle = new System.Windows.Forms.Button();
            this.Tbtnkaydet = new System.Windows.Forms.Button();
            this.txtaçıklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tedavigrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tutartext
            // 
            this.tutartext.BackColor = System.Drawing.Color.Snow;
            this.tutartext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tutartext.Location = new System.Drawing.Point(155, 82);
            this.tutartext.Name = "tutartext";
            this.tutartext.Size = new System.Drawing.Size(157, 27);
            this.tutartext.TabIndex = 11;
            this.tutartext.TextChanged += new System.EventHandler(this.tutartext_TextChanged);
            // 
            // tedaviad
            // 
            this.tedaviad.BackColor = System.Drawing.Color.Snow;
            this.tedaviad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tedaviad.Location = new System.Drawing.Point(155, 38);
            this.tedaviad.Name = "tedaviad";
            this.tedaviad.Size = new System.Drawing.Size(157, 27);
            this.tedaviad.TabIndex = 10;
            this.tedaviad.TextChanged += new System.EventHandler(this.tedaviad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tutar : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tedavi Ad : ";
            // 
            // tedavigrid
            // 
            this.tedavigrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tedavigrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tedavigrid.GridColor = System.Drawing.Color.DarkGray;
            this.tedavigrid.Location = new System.Drawing.Point(3, 21);
            this.tedavigrid.Name = "tedavigrid";
            this.tedavigrid.RowHeadersWidth = 51;
            this.tedavigrid.RowTemplate.Height = 24;
            this.tedavigrid.Size = new System.Drawing.Size(434, 290);
            this.tedavigrid.TabIndex = 13;
            this.tedavigrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tedavigrid_CellClick);
            // 
            // Tbtnsil
            // 
            this.Tbtnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tbtnsil.Location = new System.Drawing.Point(98, 217);
            this.Tbtnsil.Name = "Tbtnsil";
            this.Tbtnsil.Size = new System.Drawing.Size(132, 38);
            this.Tbtnsil.TabIndex = 18;
            this.Tbtnsil.Text = "Sil";
            this.Tbtnsil.UseVisualStyleBackColor = true;
            this.Tbtnsil.Click += new System.EventHandler(this.Tbtnsil_Click);
            // 
            // Tbtndüzenle
            // 
            this.Tbtndüzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tbtndüzenle.Location = new System.Drawing.Point(170, 173);
            this.Tbtndüzenle.Name = "Tbtndüzenle";
            this.Tbtndüzenle.Size = new System.Drawing.Size(132, 38);
            this.Tbtndüzenle.TabIndex = 17;
            this.Tbtndüzenle.Text = "Düzenle";
            this.Tbtndüzenle.UseVisualStyleBackColor = true;
            this.Tbtndüzenle.Click += new System.EventHandler(this.Tbtndüzenle_Click);
            // 
            // Tbtnkaydet
            // 
            this.Tbtnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tbtnkaydet.Location = new System.Drawing.Point(33, 173);
            this.Tbtnkaydet.Name = "Tbtnkaydet";
            this.Tbtnkaydet.Size = new System.Drawing.Size(121, 38);
            this.Tbtnkaydet.TabIndex = 16;
            this.Tbtnkaydet.Text = "Kaydet";
            this.Tbtnkaydet.UseVisualStyleBackColor = true;
            this.Tbtnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtaçıklama
            // 
            this.txtaçıklama.BackColor = System.Drawing.Color.Snow;
            this.txtaçıklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtaçıklama.Location = new System.Drawing.Point(160, 119);
            this.txtaçıklama.Name = "txtaçıklama";
            this.txtaçıklama.Size = new System.Drawing.Size(152, 27);
            this.txtaçıklama.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Açıklama :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 36);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tedaviad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtaçıklama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tutartext);
            this.groupBox1.Controls.Add(this.Tbtnsil);
            this.groupBox1.Controls.Add(this.Tbtnkaydet);
            this.groupBox1.Controls.Add(this.Tbtndüzenle);
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 311);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "tedavi bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tedavigrid);
            this.groupBox2.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(372, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 314);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "tedavi sorgu ";
            // 
            // tedavi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(876, 407);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "tedavi";
            this.Text = "tedavi";
            this.Load += new System.EventHandler(this.tedavi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tedavigrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tutartext;
        private System.Windows.Forms.TextBox tedaviad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tedavigrid;
        private System.Windows.Forms.Button Tbtnsil;
        private System.Windows.Forms.Button Tbtndüzenle;
        private System.Windows.Forms.Button Tbtnkaydet;
        private System.Windows.Forms.TextBox txtaçıklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}