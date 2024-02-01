namespace InfoTechKapsulHacimHesaplama21012024.ChildForms
{
    partial class CylinderForm
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
            this.txt_radius = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictBox_cylinder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_cylinder)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapla.Location = new System.Drawing.Point(39, 194);
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
            this.dataGridView1.Location = new System.Drawing.Point(39, 261);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(749, 254);
            this.dataGridView1.TabIndex = 4;
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(215, 105);
            this.txt_height.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(199, 22);
            this.txt_height.TabIndex = 2;
            // 
            // txt_radius
            // 
            this.txt_radius.Location = new System.Drawing.Point(215, 52);
            this.txt_radius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_radius.Name = "txt_radius";
            this.txt_radius.Size = new System.Drawing.Size(199, 22);
            this.txt_radius.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yükseklik :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yarıçap :";
            // 
            // pictBox_cylinder
            // 
            this.pictBox_cylinder.Image = global::InfoTechKapsulHacimHesaplama21012024.Properties.Resources.silindir;
            this.pictBox_cylinder.Location = new System.Drawing.Point(535, 14);
            this.pictBox_cylinder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictBox_cylinder.Name = "pictBox_cylinder";
            this.pictBox_cylinder.Size = new System.Drawing.Size(253, 164);
            this.pictBox_cylinder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBox_cylinder.TabIndex = 31;
            this.pictBox_cylinder.TabStop = false;
            // 
            // CylinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 528);
            this.Controls.Add(this.pictBox_cylinder);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_radius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CylinderForm";
            this.Text = "Silindir";
            this.Load += new System.EventHandler(this.CylinderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_cylinder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBox_cylinder;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.TextBox txt_radius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}