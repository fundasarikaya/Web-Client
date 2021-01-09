using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webclient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        wss.WebServiceSoapClient service = new wss.WebServiceSoapClient();
        private void btnsonuc_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt16(txtsayi1.Text);
            int sayi2 = Convert.ToInt16(txtsayi2.Text);
            int sonuc;
            // label3.Text = sonuc.ToString();
            sonuc = service.topla(sayi1,sayi2);
            label3.Text = sonuc.ToString();
        }
    }
}
