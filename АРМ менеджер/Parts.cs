using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace АРМ_менеджер
{
    public partial class Parts : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();

            dataGridView1.DataSource = bindingSource1;

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM GPU", "Data Source=localhost;Initial Catalog=comps;Integrated Security=True");

            DataTable table = new DataTable();

            dataAdapter.Fill(table);

            bindingSource1.DataSource = table;
            bindingSource1.EndEdit();

            dataAdapter.Update(table);
        }
        public Parts()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();

            dataGridView1.DataSource = bindingSource1;

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Power_unit", "Data Source=localhost;Initial Catalog=comps;Integrated Security=True");

            DataTable table = new DataTable();

            dataAdapter.Fill(table);

            bindingSource1.DataSource = table;
            bindingSource1.EndEdit();

            dataAdapter.Update(table);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();

            dataGridView1.DataSource = bindingSource1;

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM CPU", "Data Source=localhost;Initial Catalog=comps;Integrated Security=True");

            DataTable table = new DataTable();

            dataAdapter.Fill(table);

            bindingSource1.DataSource = table;
            bindingSource1.EndEdit();

            dataAdapter.Update(table);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();

            dataGridView1.DataSource = bindingSource1;

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM RAM", "Data Source=localhost;Initial Catalog=comps;Integrated Security=True");

            DataTable table = new DataTable();

            dataAdapter.Fill(table);

            bindingSource1.DataSource = table;
            bindingSource1.EndEdit();

            dataAdapter.Update(table);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();

            dataGridView1.DataSource = bindingSource1;

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Motherboard", "Data Source=localhost;Initial Catalog=comps;Integrated Security=True");

            DataTable table = new DataTable();

            dataAdapter.Fill(table);

            bindingSource1.DataSource = table;
            bindingSource1.EndEdit();

            dataAdapter.Update(table);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();

            dataGridView1.DataSource = bindingSource1;

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM SSD", "Data Source=localhost;Initial Catalog=comps;Integrated Security=True");

            DataTable table = new DataTable();

            dataAdapter.Fill(table);

            bindingSource1.DataSource = table;
            bindingSource1.EndEdit();

            dataAdapter.Update(table);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BindingSource bindingSource1 = new BindingSource();

            dataGridView1.DataSource = bindingSource1;

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM HDD", "Data Source=localhost;Initial Catalog=comps;Integrated Security=True");

            DataTable table = new DataTable();

            dataAdapter.Fill(table);

            bindingSource1.DataSource = table;
            bindingSource1.EndEdit();

            dataAdapter.Update(table);
        }
    }
}
