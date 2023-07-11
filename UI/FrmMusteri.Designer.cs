namespace AydemirOto.UI
{
    partial class FrmMusteri
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtadr = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.MaskedTextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtıd
            // 
            this.txtıd.Location = new System.Drawing.Point(84, 34);
            this.txtıd.Name = "txtıd";
            this.txtıd.ReadOnly = true;
            this.txtıd.Size = new System.Drawing.Size(228, 22);
            this.txtıd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "AD";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(84, 62);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(228, 22);
            this.txtad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "SOYAD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(84, 90);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(228, 22);
            this.txtsoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "TELEFON";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "MAİL";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(84, 146);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(228, 22);
            this.txtmail.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "ADRES";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtadr
            // 
            this.txtadr.Location = new System.Drawing.Point(84, 174);
            this.txtadr.Multiline = true;
            this.txtadr.Name = "txtadr";
            this.txtadr.Size = new System.Drawing.Size(228, 105);
            this.txtadr.TabIndex = 5;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(84, 118);
            this.txttel.Mask = "(999) 000-0000";
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(228, 22);
            this.txttel.TabIndex = 3;
            this.txttel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txttel_MaskInputRejected);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(202, 338);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(97, 31);
            this.btnok.TabIndex = 6;
            this.btnok.Text = "Tamam";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnno
            // 
            this.btnno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnno.Location = new System.Drawing.Point(305, 338);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(107, 31);
            this.btnno.TabIndex = 7;
            this.btnno.Text = "İptal";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmMusteri
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnno;
            this.ClientSize = new System.Drawing.Size(424, 410);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtadr);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtıd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMusteri";
            this.Load += new System.EventHandler(this.FrmMusteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtadr;
        private System.Windows.Forms.MaskedTextBox txttel;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}