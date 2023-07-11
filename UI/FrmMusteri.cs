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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public Musteri Musteri { get;set; }
        private void btnok_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtad)) return;
            if (!ErrorControl(txtadr)) return;
            if (!ErrorControl(txtmail)) return;
            if (!ErrorControl(txtsoyad)) return;
            if (!ErrorControl(txttel)) return;

            Musteri.ad = txtad.Text;
            Musteri.soyad = txtsoyad.Text;
            Musteri.telefon = txttel.Text;
            Musteri.mail = txtmail.Text;
            Musteri.adres = txtadr.Text;
            DialogResult = DialogResult.OK;

        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "eksik veya hatalı bilgi.");
                    c.Focus();
                    return false;

                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider1.SetError(c, "eksik veya hatalı bilgi.");
                    c.Focus();
                    return false;

                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            return true;


        }

        private void btnno_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txttel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FrmMusteri_Load(object sender, EventArgs e)
        {

        }
    }
}
