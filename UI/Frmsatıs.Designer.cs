namespace AydemirOto.UI
{
    partial class Frmsatıs
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
            this.cbfiyats = new System.Windows.Forms.ComboBox();
            this.cburun = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnno = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.txtmusteri = new System.Windows.Forms.TextBox();
            this.txtsatısıd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.cbfiyats.Location = new System.Drawing.Point(86, 164);
            this.cbfiyats.Name = "cbfiyats";
            this.cbfiyats.Size = new System.Drawing.Size(255, 24);
            this.cbfiyats.TabIndex = 46;
            // 
            // cburun
            // 
            this.cburun.FormattingEnabled = true;
            this.cburun.Items.AddRange(new object[] {
            "Mercedes",
            "Audi",
            "BMW",
            "Volkswagen",
            "Renault",
            "Fiat",
            "Toyota ",
            "Nissan ",
            "Tofaş"});
            this.cburun.Location = new System.Drawing.Point(86, 121);
            this.cburun.Name = "cburun";
            this.cburun.Size = new System.Drawing.Size(255, 24);
            this.cburun.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Fiyat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnno
            // 
            this.btnno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnno.Location = new System.Drawing.Point(254, 276);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(107, 31);
            this.btnno.TabIndex = 37;
            this.btnno.Text = "İptal";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(151, 276);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(97, 31);
            this.btnok.TabIndex = 36;
            this.btnok.Text = "Tamam";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtmusteri
            // 
            this.txtmusteri.Location = new System.Drawing.Point(86, 83);
            this.txtmusteri.Name = "txtmusteri";
            this.txtmusteri.Size = new System.Drawing.Size(255, 22);
            this.txtmusteri.TabIndex = 32;
            // 
            // txtsatısıd
            // 
            this.txtsatısıd.Location = new System.Drawing.Point(86, 45);
            this.txtsatısıd.Name = "txtsatısıd";
            this.txtsatısıd.ReadOnly = true;
            this.txtsatısıd.Size = new System.Drawing.Size(255, 22);
            this.txtsatısıd.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ürün";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Musteri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Tarih";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 218);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frmsatıs
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnno;
            this.ClientSize = new System.Drawing.Size(373, 332);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbfiyats);
            this.Controls.Add(this.cburun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtmusteri);
            this.Controls.Add(this.txtsatısıd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frmsatıs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frmsatıs";
            this.Load += new System.EventHandler(this.Frmsatıs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbfiyats;
        private System.Windows.Forms.ComboBox cburun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.TextBox txtmusteri;
        private System.Windows.Forms.TextBox txtsatısıd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}