namespace InfoTechKapsulHacimHesaplama21012024.ChildForms
{
    partial class QuadrangularForm
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
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.txt_longSide = new System.Windows.Forms.TextBox();
            this.txt_shortSide = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapla.Location = new System.Drawing.Point(26, 146);
            this.btn_hesapla.Margin = new System.Windows.Forms.Padding(2);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(562, 39);
            this.btn_hesapla.TabIndex = 21;
            this.btn_hesapla.Text = "Hacim Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 202);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(562, 206);
            this.dataGridView1.TabIndex = 20;
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(196, 100);
            this.txt_height.Margin = new System.Windows.Forms.Padding(2);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(150, 20);
            this.txt_height.TabIndex = 16;
            // 
            // txt_longSide
            // 
            this.txt_longSide.Location = new System.Drawing.Point(196, 60);
            this.txt_longSide.Margin = new System.Windows.Forms.Padding(2);
            this.txt_longSide.Name = "txt_longSide";
            this.txt_longSide.Size = new System.Drawing.Size(150, 20);
            this.txt_longSide.TabIndex = 17;
            // 
            // txt_shortSide
            // 
            this.txt_shortSide.Location = new System.Drawing.Point(196, 20);
            this.txt_shortSide.Margin = new System.Windows.Forms.Padding(2);
            this.txt_shortSide.Name = "txt_shortSide";
            this.txt_shortSide.Size = new System.Drawing.Size(150, 20);
            this.txt_shortSide.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Yükseklik :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Uzun Kenar Uzunluğu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kısa Kenar Uzunluğu :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InfoTechKapsulHacimHesaplama21012024.Properties.Resources.dikdortgenPrizma;
            this.pictureBox1.Location = new System.Drawing.Point(374, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // QuadrangularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 429);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_longSide);
            this.Controls.Add(this.txt_shortSide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QuadrangularForm";
            this.Text = "QuadrangularForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.TextBox txt_longSide;
        private System.Windows.Forms.TextBox txt_shortSide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}