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
    public partial class frmurun : Form
    {
        public frmurun()
        {
            InitializeComponent();
        }

        private void frmurun_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public urun urun  { get; set; }
        private void btnok_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txturun)) return;
            if (!ErrorControl(nmkm)) return;
            if (!ErrorControl(nmodel)) return;
            if (!ErrorControl(nmstok)) return;
            if (!ErrorControl(cbfiyat)) return;
            if (!ErrorControl(cbmarka)) return;

            urun.ad = txturun.Text;
            urun.km = (double)nmkm.Value;
            urun.stok = (double)nmstok.Value;
            urun.marka = cbmarka.Text;
            urun.Fiyat = cbfiyat.Text;
            urun.stok = (double)nmstok.Value;

            DialogResult = DialogResult.OK;

        }

        private void btnno_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox) 
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "eksik yada hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }
            }
            if( c is NumericUpDown) 
            {
              if (((NumericUpDown)c).Value == 0) 
                {
                    errorProvider1.SetError(c, "eksik yada hatalı bilgi.");
                    c.Focus(); return false;    

                }
              else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            return true;
        }
    }
}
