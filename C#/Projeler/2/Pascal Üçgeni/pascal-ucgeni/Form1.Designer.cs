
namespace pascal_ucgeni
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
            this.btn_pascalHesapla = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.num_pascalKatman = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_pascalKatman)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_pascalHesapla
            // 
            this.btn_pascalHesapla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pascalHesapla.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pascalHesapla.ForeColor = System.Drawing.Color.Red;
            this.btn_pascalHesapla.Location = new System.Drawing.Point(12, 84);
            this.btn_pascalHesapla.Name = "btn_pascalHesapla";
            this.btn_pascalHesapla.Size = new System.Drawing.Size(776, 45);
            this.btn_pascalHesapla.TabIndex = 0;
            this.btn_pascalHesapla.Text = "Pascal Üçgeni Hesapla";
            this.btn_pascalHesapla.UseVisualStyleBackColor = true;
            this.btn_pascalHesapla.Click += new System.EventHandler(this.btn_pascalHesapla_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(12, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 283);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // num_pascalKatman
            // 
            this.num_pascalKatman.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num_pascalKatman.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.num_pascalKatman.Location = new System.Drawing.Point(12, 35);
            this.num_pascalKatman.Name = "num_pascalKatman";
            this.num_pascalKatman.Size = new System.Drawing.Size(776, 43);
            this.num_pascalKatman.TabIndex = 2;
            this.num_pascalKatman.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.num_pascalKatman);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_pascalHesapla);
            this.Name = "Form1";
            this.Text = "SALIH CORUH PASCAL UCGENI PROJE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_pascalKatman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pascalHesapla;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown num_pascalKatman;
    }
}

