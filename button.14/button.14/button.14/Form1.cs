using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double alisfiyat, satisfiyat, kar;
            alisfiyat = Convert.ToDouble(txtalis.Text);
            satisfiyat = Convert.ToDouble(txtsatis.Text);
            kar = satisfiyat - alisfiyat;

            lblkar.Text = "Kar Fiyatı: " + kar;

        }
    }
}
