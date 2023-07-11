using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AydemirOto.BL;
using AydemirOto.UI;

namespace AydemirOto
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }

        private void Anaform_Load(object sender, EventArgs e)
        {

        }

        private void btnmusteriekle_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnurundüzenle_Click(object sender, EventArgs e)
        {

        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            FrmMusteri frmMusteri = new FrmMusteri()
            {
                Text = "Müşteri ekle",
                Musteri = new Musteri() { Id = Guid.NewGuid() },
            };
            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                Blogic.Musteriekle(frmMusteri.Musteri);
            }

        }
    }
}
