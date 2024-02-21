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
using System.Data;

namespace АРМ_менеджер
{
    public partial class Assembly : Form
    {
        public Assembly()
        {
            InitializeComponent();
        }

        private void accemblyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accemblyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.compsDataSet);

        }

        private void Assembly_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "compsDataSet.HDD". При необходимости она может быть перемещена или удалена.
            this.hDDTableAdapter.Fill(this.compsDataSet.HDD);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "compsDataSet.SSD". При необходимости она может быть перемещена или удалена.
            this.sSDTableAdapter.Fill(this.compsDataSet.SSD);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "compsDataSet.Power_unit". При необходимости она может быть перемещена или удалена.
            this.power_unitTableAdapter.Fill(this.compsDataSet.Power_unit);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "compsDataSet.RAM". При необходимости она может быть перемещена или удалена.
            this.rAMTableAdapter.Fill(this.compsDataSet.RAM);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "compsDataSet.GPU". При необходимости она может быть перемещена или удалена.
            this.gPUTableAdapter.Fill(this.compsDataSet.GPU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "compsDataSet.Motherboard". При необходимости она может быть перемещена или удалена.
            this.motherboardTableAdapter.Fill(this.compsDataSet.Motherboard);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "compsDataSet.CPU". При необходимости она может быть перемещена или удалена.
            this.cPUTableAdapter.Fill(this.compsDataSet.CPU);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "compsDataSet.Accembly". При необходимости она может быть перемещена или удалена.
            this.accemblyTableAdapter.Fill(this.compsDataSet.Accembly);

        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedValue == null) // если нет выбранного значения
                comboBox2.Enabled = false; // отключить combobox2
            else{
                comboBox2.Enabled = true; // включить combobox2
                // создаем подключение к базе данных SQL
                string connectionString = "Data Source=localhost;Initial Catalog=comps;Integrated Security=True";
                string query = "SELECT name FROM CPU WHERE socket = (SELECT socket FROM Motherboard WHERE name = @name)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", comboBox3.Text);
                    DataTable dataTable = new DataTable();
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dataTable.Load(reader);
                    connection.Close();

                    // устанавливаем свойство DataSource для ComboBox в объект DataTable
                    comboBox2.DataSource = dataTable;

                    // устанавливаем свойства DisplayMember и ValueMember для ComboBox
                    comboBox2.DisplayMember = "CPUData";
                    comboBox2.ValueMember = "ID";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            accemblyBindingSource1.MoveFirst();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            accemblyBindingSource1.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            accemblyBindingSource1.MovePrevious();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            accemblyBindingSource1.MoveNext();
        }

        private void Кнопка_Добавить_Click(object sender, EventArgs e)
        {
            accemblyBindingSource1.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            accemblyBindingSource1.RemoveCurrent();
        }

        private void Кнопка_Сохранить_Click(object sender, EventArgs e)
        {
            Validate();
            accemblyBindingSource1.EndEdit();
            tableAdapterManager.UpdateAll(compsDataSet);
            Кнопка_Сохранить.Enabled = false;
        }
    }
}