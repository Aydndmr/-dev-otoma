namespace AydemirOto.UI
{
    partial class frmurun
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
            this.txturun = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbfiyat = new System.Windows.Forms.ComboBox();
            this.nmstok = new System.Windows.Forms.NumericUpDown();
            this.nmodel = new System.Windows.Forms.NumericUpDown();
            this.nmkm = new System.Windows.Forms.NumericUpDown();
            this.btnno = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.cbmarka = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmstok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmodel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmkm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txturun
            // 
            this.txturun.Location = new System.Drawing.Point(80, 40);
            this.txturun.Name = "txturun";
            this.txturun.Size = new System.Drawing.Size(228, 22);
            this.txturun.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stok";
            // 
            // txtıd
            // 
            this.txtıd.Location = new System.Drawing.Point(80, 12);
            this.txtıd.Name = "txtıd";
            this.txtıd.ReadOnly = true;
            this.txtıd.Size = new System.Drawing.Size(228, 22);
            this.txtıd.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kilometre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Marka";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ürün";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Fiyat";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbfiyat
            // 
            this.cbfiyat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfiyat.FormattingEnabled = true;
            this.cbfiyat.Items.AddRange(new object[] {
            "100.000",
            "200.000",
            "300.000",
            "400.000",
            "500.000"});
            this.cbfiyat.Location = new System.Drawing.Point(80, 196);
            this.cbfiyat.Name = "cbfiyat";
            this.cbfiyat.Size = new System.Drawing.Size(228, 24);
            this.cbfiyat.TabIndex = 6;
            // 
            // nmstok
            // 
            this.nmstok.Location = new System.Drawing.Point(80, 165);
            this.nmstok.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmstok.Name = "nmstok";
            this.nmstok.Size = new System.Drawing.Size(228, 22);
            this.nmstok.TabIndex = 5;
            // 
            // nmodel
            // 
            this.nmodel.Location = new System.Drawing.Point(80, 102);
            this.nmodel.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.nmodel.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.nmodel.Name = "nmodel";
            this.nmodel.Size = new System.Drawing.Size(228, 22);
            this.nmodel.TabIndex = 3;
            this.nmodel.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // nmkm
            // 
            this.nmkm.Location = new System.Drawing.Point(80, 130);
            this.nmkm.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nmkm.Name = "nmkm";
            this.nmkm.Size = new System.Drawing.Size(228, 22);
            this.nmkm.TabIndex = 4;
            // 
            // btnno
            // 
            this.btnno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnno.Location = new System.Drawing.Point(202, 257);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(107, 31);
            this.btnno.TabIndex = 8;
            this.btnno.Text = "İptal";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(99, 257);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(97, 31);
            this.btnok.TabIndex = 7;
            this.btnok.Text = "Tamam";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // cbmarka
            // 
            this.cbmarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmarka.FormattingEnabled = true;
            this.cbmarka.Items.AddRange(new object[] {
            "100.000",
            "200.000",
            "300.000",
            "400.000",
            "500.000"});
            this.cbmarka.Location = new System.Drawing.Point(81, 72);
            this.cbmarka.Name = "cbmarka";
            this.cbmarka.Size = new System.Drawing.Size(228, 24);
            this.cbmarka.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmurun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 313);
            this.Controls.Add(this.cbmarka);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.nmkm);
            this.Controls.Add(this.nmodel);
            this.Controls.Add(this.nmstok);
            this.Controls.Add(this.cbfiyat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txturun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtıd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmurun";
            this.Text = "frmurun";
            this.Load += new System.EventHandler(this.frmurun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmstok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmodel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmkm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txturun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbfiyat;
        private System.Windows.Forms.NumericUpDown nmstok;
        private System.Windows.Forms.NumericUpDown nmodel;
        private System.Windows.Forms.NumericUpDown nmkm;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.ComboBox cbmarka;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}