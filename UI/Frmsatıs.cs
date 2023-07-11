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
    public partial class Frmsatıs : Form
    {
        public Frmsatıs()
        {
            InitializeComponent();
        }
        public Musteri Musteri { get; set; }
        
        public urun   urun { get; set; }
        
        public satıs satıs { get; set; }
        private void Frmsatıs_Load(object sender, EventArgs e)
        {
            txtsatısıd.Text = satıs.Id.ToString();
            txtmusteri.Text = Musteri.ToString();
            cburun.Text = Musteri.ToString();

        }

        private void btnok_Click(object sender, EventArgs e)
        {
           if(cbfiyats.SelectedItem==null)
            {
                errorProvider1.SetError(cbfiyats, "lütfen fiyat seçiniz.");
                cbfiyats.Focus();
                return ;
            }
           else
            {
                errorProvider1.SetError(cbfiyats, "");

            }
            satıs.tarih = dateTimePicker1.Value;
        
            DialogResult = DialogResult.OK;
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
