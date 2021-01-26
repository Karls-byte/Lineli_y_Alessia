using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
         public partial class Form1 : Form
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (cdxoperacion.Text == "Suma") 
            {
                lblresult.Text = (op.Suma(double.Parse(txtV1.Text), double.Parse(txtV2.Text))).ToString();
            }
            else if (cdxoperacion.Text == "Resta")
            {
                lblresult.Text = (op.Resta(double.Parse(txtV1.Text), double.Parse(txtV2.Text))).ToString();
            }
            else if (cdxoperacion.Text == "Multiplicación")
            {
                lblresult.Text = (op.Multiplicación(double.Parse(txtV1.Text), double.Parse(txtV2.Text))).ToString();
            }
            else if (cdxoperacion.Text == "División")
            {
                lblresult.Text = (op.División(double.Parse(txtV1.Text), double.Parse(txtV2.Text))).ToString();
            }
        }

        private void txtV1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
