using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFADersDurumuUygulumaÖrneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                    int sinav1 = Convert.ToInt32(txtSinav1.Text);

                    int sinav2 = Convert.ToInt32(txtSinav2.Text);

                    int sinav3 = Convert.ToInt32(txtSinav3.Text);

                    int ortalama = (sinav1 + sinav2 + sinav3) / 3;

                    lblOrtalama.Text = ortalama.ToString();



                    if ( ortalama >= 50 )
                    {
                         lblDurum.Text = "Geçti";
                    }
                    else
                    {
                         lblDurum.Text = "Kaldı";
                    }

            }

            catch  
            {
                MessageBox.Show("LÜTFEN SAYISAL DEĞER GİRİNİZ !!!");
                    
            }
        }     
    }
}