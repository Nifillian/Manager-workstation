using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АРМ_менеджер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Assembly form3 = new Assembly();
            form3.TopLevel = false;
            form3.Show();
            panel1.Controls.Add(form3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Comps form2 = new Comps();
            form2.TopLevel = false;
            form2.Show();
            panel1.Controls.Add(form2);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Parts form4 = new Parts();
            form4.TopLevel = false;
            form4.Show();
            panel1.Controls.Add(form4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Clients form4 = new Clients();
            form4.TopLevel = false;
            form4.Show();
            panel1.Controls.Add(form4);
        }
    }
}
