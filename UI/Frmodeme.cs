using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AydemirOto.UI
{
    public partial class Frmodeme : Form
    {
        public Frmodeme()
        {
            InitializeComponent();
        }

        private void Frmodeme_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbfiyats_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public odeme odeme { get; set; }

        private void btnok_Click(object sender, EventArgs e)
        {

            if(cbfiyats.SelectedItem == null)
            {
                errorProvider1.SetError(cbfiyats, "lütfen fiyat seçiniz.");
                cbfiyats.Focus();
                return;
            }
           else
            {
                errorProvider1.SetError(cbfiyats, "");

            }
            if (txtmusteri.Text == "")
            {
                errorProvider1.SetError(txtmusteri, "eksik veya hatalı bilgi.");
                txtmusteri.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtmusteri, "");
            }
            if (cbtur.SelectedItem == null)
            {
                errorProvider1.SetError(cbtur, "lütfen fiyat seçiniz.");
                cbtur.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(cbtur, "");

            if (txtacıklama.Text == "") 
            {
                errorProvider1.SetError(txtacıklama, "eksik veya hatalı bilgi.");
                txtacıklama.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtacıklama, "");
            }
            
            }
            odeme.tarih = dateTimePicker1.Value;

            DialogResult = DialogResult.OK;
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
