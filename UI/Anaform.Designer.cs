namespace AydemirOto
{
    partial class Anaform
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnurunekle = new System.Windows.Forms.ToolStripButton();
            this.btnurundüzenle = new System.Windows.Forms.ToolStripButton();
            this.btnurunsil = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.btnurunbul = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnmusteriekle = new System.Windows.Forms.ToolStripButton();
            this.btnmusteriedit = new System.Windows.Forms.ToolStripButton();
            this.btnmusterisil = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btnbul = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(819, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteriler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(3, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(813, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnurunekle,
            this.btnurundüzenle,
            this.btnurunsil,
            this.toolStripLabel2,
            this.toolStripTextBox2,
            this.btnurunbul});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(813, 27);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnurunekle
            // 
            this.btnurunekle.Image = global::AydemirOto.Properties.Resources.user;
            this.btnurunekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnurunekle.Name = "btnurunekle";
            this.btnurunekle.Size = new System.Drawing.Size(60, 24);
            this.btnurunekle.Text = "Ekle";
            this.btnurunekle.Click += new System.EventHandler(this.btnurunekle_Click);
            // 
            // btnurundüzenle
            // 
            this.btnurundüzenle.Image = global::AydemirOto.Properties.Resources.edit;
            this.btnurundüzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnurundüzenle.Name = "btnurundüzenle";
            this.btnurundüzenle.Size = new System.Drawing.Size(87, 24);
            this.btnurundüzenle.Text = "Düzenle";
            this.btnurundüzenle.Click += new System.EventHandler(this.btnurundüzenle_Click);
            // 
            // btnurunsil
            // 
            this.btnurunsil.Image = global::AydemirOto.Properties.Resources.delete;
            this.btnurunsil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnurunsil.Name = "btnurunsil";
            this.btnurunsil.Size = new System.Drawing.Size(49, 24);
            this.btnurunsil.Text = "Sil";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(32, 24);
            this.toolStripLabel2.Text = "Ara";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(200, 27);
            // 
            // btnurunbul
            // 
            this.btnurunbul.Image = global::AydemirOto.Properties.Resources.search;
            this.btnurunbul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnurunbul.Name = "btnurunbul";
            this.btnurunbul.Size = new System.Drawing.Size(54, 24);
            this.btnurunbul.Text = "Bul";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(813, 456);
            this.dataGridView2.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Controls.Add(this.statusStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(819, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürünler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Location = new System.Drawing.Point(3, 459);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(813, 22);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnmusteriekle,
            this.btnmusteriedit,
            this.btnmusterisil,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.btnbul});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(813, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnmusteriekle
            // 
            this.btnmusteriekle.Image = global::AydemirOto.Properties.Resources.user;
            this.btnmusteriekle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmusteriekle.Name = "btnmusteriekle";
            this.btnmusteriekle.Size = new System.Drawing.Size(60, 24);
            this.btnmusteriekle.Text = "Ekle";
            this.btnmusteriekle.Click += new System.EventHandler(this.btnmusteriekle_Click);
            // 
            // btnmusteriedit
            // 
            this.btnmusteriedit.Image = global::AydemirOto.Properties.Resources.edit;
            this.btnmusteriedit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmusteriedit.Name = "btnmusteriedit";
            this.btnmusteriedit.Size = new System.Drawing.Size(87, 24);
            this.btnmusteriedit.Text = "Düzenle";
            // 
            // btnmusterisil
            // 
            this.btnmusterisil.Image = global::AydemirOto.Properties.Resources.delete;
            this.btnmusterisil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmusterisil.Name = "btnmusterisil";
            this.btnmusterisil.Size = new System.Drawing.Size(49, 24);
            this.btnmusterisil.Text = "Sil";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 24);
            this.toolStripLabel1.Text = "Ara";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 27);
            // 
            // btnbul
            // 
            this.btnbul.Image = global::AydemirOto.Properties.Resources.search;
            this.btnbul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(54, 24);
            this.btnbul.Text = "Bul";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(813, 429);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 513);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 513);
            this.Controls.Add(this.tabControl1);
            this.Name = "Anaform";
            this.Text = "Aydemir OTO";
            this.Load += new System.EventHandler(this.Anaform_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnurunekle;
        private System.Windows.Forms.ToolStripButton btnurundüzenle;
        private System.Windows.Forms.ToolStripButton btnurunsil;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripButton btnurunbul;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnmusteriekle;
        private System.Windows.Forms.ToolStripButton btnmusteriedit;
        private System.Windows.Forms.ToolStripButton btnmusterisil;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton btnbul;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

