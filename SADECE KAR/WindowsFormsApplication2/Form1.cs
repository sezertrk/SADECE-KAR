using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mal = int.Parse  (textBox1.Text);
            int madet = int.Parse  (textBox2.Text);
            int mall = int.Parse (textBox3 .Text );
            int madett= int .Parse (textBox4 .Text );
            int son=0;
            int ko;
            int koo;

            ko  = ((mal-(mal * 100 / 150)) )*madet;
            koo = ((mall-(mall  * 100 / 90)) )*madett;
            son = ko + koo ;
            MessageBox.Show (son.ToString());


        }
    }
}
