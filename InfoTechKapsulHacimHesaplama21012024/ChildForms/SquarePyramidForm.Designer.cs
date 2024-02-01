namespace InfoTechKapsulHacimHesaplama21012024.ChildForms
{
    partial class SquarePyramidForm
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
            this.txt_side = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictBox_squarePyramid = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_squarePyramid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapla.Location = new System.Drawing.Point(44, 190);
            this.btn_hesapla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(749, 48);
            this.btn_hesapla.TabIndex = 3;
            this.btn_hesapla.Text = "Hacim Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 258);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 254);
            this.dataGridView1.TabIndex = 4;
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(260, 111);
            this.txt_height.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(199, 22);
            this.txt_height.TabIndex = 2;
            // 
            // txt_side
            // 
            this.txt_side.Location = new System.Drawing.Point(260, 58);
            this.txt_side.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_side.Name = "txt_side";
            this.txt_side.Size = new System.Drawing.Size(199, 22);
            this.txt_side.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(40, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yükseklik :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kenar Uzunluğu :";
            // 
            // pictBox_squarePyramid
            // 
            this.pictBox_squarePyramid.Image = global::InfoTechKapsulHacimHesaplama21012024.Properties.Resources.karePiramit;
            this.pictBox_squarePyramid.Location = new System.Drawing.Point(537, 20);
            this.pictBox_squarePyramid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictBox_squarePyramid.Name = "pictBox_squarePyramid";
            this.pictBox_squarePyramid.Size = new System.Drawing.Size(256, 151);
            this.pictBox_squarePyramid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBox_squarePyramid.TabIndex = 49;
            this.pictBox_squarePyramid.TabStop = false;
            // 
            // SquarePyramidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 528);
            this.Controls.Add(this.pictBox_squarePyramid);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_side);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SquarePyramidForm";
            this.Text = "Kare Prizma";
            this.Load += new System.EventHandler(this.SquarePyramidForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_squarePyramid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBox_squarePyramid;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.TextBox txt_side;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}