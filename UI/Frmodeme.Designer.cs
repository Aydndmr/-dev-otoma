namespace AydemirOto.UI
{
    partial class Frmodeme
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbfiyats = new System.Windows.Forms.ComboBox();
            this.cbtur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnno = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.txtmusteri = new System.Windows.Forms.TextBox();
            this.txtsatısıd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtacıklama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Tarih";
            // 
            // cbfiyats
            // 
            this.cbfiyats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfiyats.FormattingEnabled = true;
            this.cbfiyats.Items.AddRange(new object[] {
            "100.000",
            "200.000",
            "300.000",
            "400.000",
            "500.000"});
            this.cbfiyats.Location = new System.Drawing.Point(102, 129);
            this.cbfiyats.Name = "cbfiyats";
            this.cbfiyats.Size = new System.Drawing.Size(255, 24);
            this.cbfiyats.TabIndex = 3;
            this.cbfiyats.SelectedIndexChanged += new System.EventHandler(this.cbfiyats_SelectedIndexChanged);
            // 
            // cbtur
            // 
            this.cbtur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtur.FormattingEnabled = true;
            this.cbtur.Items.AddRange(new object[] {
            "Kredi kartı",
            "nakit",
            "Veresiye"});
            this.cbtur.Location = new System.Drawing.Point(102, 86);
            this.cbtur.Name = "cbtur";
            this.cbtur.Size = new System.Drawing.Size(255, 24);
            this.cbtur.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "Fiyat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnno
            // 
            this.btnno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnno.Location = new System.Drawing.Point(250, 301);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(107, 31);
            this.btnno.TabIndex = 7;
            this.btnno.Text = "İptal";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(147, 301);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(97, 31);
            this.btnok.TabIndex = 6;
            this.btnok.Text = "Tamam";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtmusteri
            // 
            this.txtmusteri.Location = new System.Drawing.Point(102, 48);
            this.txtmusteri.Name = "txtmusteri";
            this.txtmusteri.Size = new System.Drawing.Size(255, 22);
            this.txtmusteri.TabIndex = 1;
            // 
            // txtsatısıd
            // 
            this.txtsatısıd.Location = new System.Drawing.Point(102, 10);
            this.txtsatısıd.Name = "txtsatısıd";
            this.txtsatısıd.ReadOnly = true;
            this.txtsatısıd.Size = new System.Drawing.Size(255, 22);
            this.txtsatısıd.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Ödeme Türü";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Musteri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "ID";
            // 
            // txtacıklama
            // 
            this.txtacıklama.Location = new System.Drawing.Point(102, 211);
            this.txtacıklama.Multiline = true;
            this.txtacıklama.Name = "txtacıklama";
            this.txtacıklama.Size = new System.Drawing.Size(255, 84);
            this.txtacıklama.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 62;
            this.label6.Text = "Açıklama";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frmodeme
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnno;
            this.ClientSize = new System.Drawing.Size(369, 353);
            this.Controls.Add(this.txtacıklama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbfiyats);
            this.Controls.Add(this.cbtur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtmusteri);
            this.Controls.Add(this.txtsatısıd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frmodeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Frmodeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbfiyats;
        private System.Windows.Forms.ComboBox cbtur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtmusteri;
        private System.Windows.Forms.TextBox txtsatısıd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtacıklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}