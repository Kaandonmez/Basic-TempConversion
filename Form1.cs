using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cel_Click(object sender, EventArgs e)
        {
            float c = 0;

            try { c = float.Parse(txt_cel.Text); }
            catch { MessageBox.Show("Only numbers are allowed"); }
            

            //Celcius To Fah
            float f = 9 / 5f * c + 32;
            txt_fah.Text = f.ToString();

            //Celcius to Kelvin
            float k = c + 273;
            txt_kelv.Text = k.ToString();
        }

        private void btn_fah_Click(object sender, EventArgs e)
        {
            float f = 0;
            
            try { f = float.Parse(txt_fah.Text); }
            catch { MessageBox.Show("Only numbers are allowed"); }

            //Fah to Celcius
            float c = 5 / 9f * (f - 32);
            txt_cel.Text = c.ToString();

            //Fah to Kelvin
            float k = 5 / 9f * (f - 32) + 273;
            txt_kelv.Text = k.ToString();


        }

        private void btn_kelv_Click(object sender, EventArgs e)
        {
            float k = 0;
            
            try { k = float.Parse(txt_kelv.Text);}
            catch { MessageBox.Show("Only numbers are allowed"); }

            //Kelvin To Celcius
            float c = k - 273;
            txt_cel.Text = c.ToString();

            //Kelvin To Fah
            float f = 9 / 5f * (k - 273) + 32;
            txt_fah.Text = f.ToString();
        }

        private void txt_cel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_fah_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_kelv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
