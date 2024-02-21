
namespace АРМ_менеджер
{
    partial class Assembly
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cpu_idLabel;
            System.Windows.Forms.Label gpu_idLabel;
            System.Windows.Forms.Label motherboard_idLabel;
            System.Windows.Forms.Label ram_countLabel;
            System.Windows.Forms.Label ram_idLabel;
            System.Windows.Forms.Label power_unit_idLabel;
            System.Windows.Forms.Label ssd_idLabel;
            System.Windows.Forms.Label hdd_idLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.compsDataSet = new АРМ_менеджер.compsDataSet();
            this.accemblyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accemblyTableAdapter = new АРМ_менеджер.compsDataSetTableAdapters.AccemblyTableAdapter();
            this.tableAdapterManager = new АРМ_менеджер.compsDataSetTableAdapters.TableAdapterManager();
            this.cPUTableAdapter = new АРМ_менеджер.compsDataSetTableAdapters.CPUTableAdapter();
            this.gPUTableAdapter = new АРМ_менеджер.compsDataSetTableAdapters.GPUTableAdapter();
            this.hDDTableAdapter = new АРМ_менеджер.compsDataSetTableAdapters.HDDTableAdapter();
            this.motherboardTableAdapter = new АРМ_менеджер.compsDataSetTableAdapters.MotherboardTableAdapter();
            this.power_unitTableAdapter = new АРМ_менеджер.compsDataSetTableAdapters.Power_unitTableAdapter();
            this.rAMTableAdapter = new АРМ_менеджер.compsDataSetTableAdapters.RAMTableAdapter();
            this.sSDTableAdapter = new АРМ_менеджер.compsDataSetTableAdapters.SSDTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.accemblyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gPUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cPUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.motherboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.rAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.powerunitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.sSDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.hDDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ram_countTextBox = new System.Windows.Forms.TextBox();
            this.Кнопка_Добавить = new System.Windows.Forms.Button();
            this.Кнопка_Сохранить = new System.Windows.Forms.Button();
            cpu_idLabel = new System.Windows.Forms.Label();
            gpu_idLabel = new System.Windows.Forms.Label();
            motherboard_idLabel = new System.Windows.Forms.Label();
            ram_countLabel = new System.Windows.Forms.Label();
            ram_idLabel = new System.Windows.Forms.Label();
            power_unit_idLabel = new System.Windows.Forms.Label();
            ssd_idLabel = new System.Windows.Forms.Label();
            hdd_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.compsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accemblyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accemblyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherboardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerunitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cpu_idLabel
            // 
            cpu_idLabel.AutoSize = true;
            cpu_idLabel.Location = new System.Drawing.Point(101, 108);
            cpu_idLabel.Name = "cpu_idLabel";
            cpu_idLabel.Size = new System.Drawing.Size(39, 13);
            cpu_idLabel.TabIndex = 2;
            cpu_idLabel.Text = "cpu id:";
            // 
            // gpu_idLabel
            // 
            gpu_idLabel.AutoSize = true;
            gpu_idLabel.Location = new System.Drawing.Point(101, 147);
            gpu_idLabel.Name = "gpu_idLabel";
            gpu_idLabel.Size = new System.Drawing.Size(39, 13);
            gpu_idLabel.TabIndex = 3;
            gpu_idLabel.Text = "gpu id:";
            // 
            // motherboard_idLabel
            // 
            motherboard_idLabel.AutoSize = true;
            motherboard_idLabel.Location = new System.Drawing.Point(59, 71);
            motherboard_idLabel.Name = "motherboard_idLabel";
            motherboard_idLabel.Size = new System.Drawing.Size(81, 13);
            motherboard_idLabel.TabIndex = 5;
            motherboard_idLabel.Text = "Motherboard id:";
            // 
            // ram_countLabel
            // 
            ram_countLabel.AutoSize = true;
            ram_countLabel.Location = new System.Drawing.Point(83, 225);
            ram_countLabel.Name = "ram_countLabel";
            ram_countLabel.Size = new System.Drawing.Size(57, 13);
            ram_countLabel.TabIndex = 7;
            ram_countLabel.Text = "ram count:";
            // 
            // ram_idLabel
            // 
            ram_idLabel.AutoSize = true;
            ram_idLabel.Location = new System.Drawing.Point(102, 185);
            ram_idLabel.Name = "ram_idLabel";
            ram_idLabel.Size = new System.Drawing.Size(38, 13);
            ram_idLabel.TabIndex = 9;
            ram_idLabel.Text = "ram id:";
            // 
            // power_unit_idLabel
            // 
            power_unit_idLabel.AutoSize = true;
            power_unit_idLabel.Location = new System.Drawing.Point(70, 269);
            power_unit_idLabel.Name = "power_unit_idLabel";
            power_unit_idLabel.Size = new System.Drawing.Size(70, 13);
            power_unit_idLabel.TabIndex = 11;
            power_unit_idLabel.Text = "power unit id:";
            // 
            // ssd_idLabel
            // 
            ssd_idLabel.AutoSize = true;
            ssd_idLabel.Location = new System.Drawing.Point(103, 308);
            ssd_idLabel.Name = "ssd_idLabel";
            ssd_idLabel.Size = new System.Drawing.Size(37, 13);
            ssd_idLabel.TabIndex = 13;
            ssd_idLabel.Text = "ssd id:";
            // 
            // hdd_idLabel
            // 
            hdd_idLabel.AutoSize = true;
            hdd_idLabel.Location = new System.Drawing.Point(101, 351);
            hdd_idLabel.Name = "hdd_idLabel";
            hdd_idLabel.Size = new System.Drawing.Size(39, 13);
            hdd_idLabel.TabIndex = 15;
            hdd_idLabel.Text = "hdd id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(345, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сборка";
            // 
            // compsDataSet
            // 
            this.compsDataSet.DataSetName = "compsDataSet";
            this.compsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accemblyBindingSource
            // 
            this.accemblyBindingSource.DataMember = "Accembly";
            this.accemblyBindingSource.DataSource = this.compsDataSet;
            // 
            // accemblyTableAdapter
            // 
            this.accemblyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccemblyTableAdapter = this.accemblyTableAdapter;
            this.tableAdapterManager.AccountingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.CPUTableAdapter = this.cPUTableAdapter;
            this.tableAdapterManager.GPUTableAdapter = this.gPUTableAdapter;
            this.tableAdapterManager.HDDTableAdapter = this.hDDTableAdapter;
            this.tableAdapterManager.MotherboardTableAdapter = this.motherboardTableAdapter;
            this.tableAdapterManager.PCTableAdapter = null;
            this.tableAdapterManager.Power_unitTableAdapter = this.power_unitTableAdapter;
            this.tableAdapterManager.RAMTableAdapter = this.rAMTableAdapter;
            this.tableAdapterManager.SSDTableAdapter = this.sSDTableAdapter;
            this.tableAdapterManager.UpdateOrder = АРМ_менеджер.compsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cPUTableAdapter
            // 
            this.cPUTableAdapter.ClearBeforeFill = true;
            // 
            // gPUTableAdapter
            // 
            this.gPUTableAdapter.ClearBeforeFill = true;
            // 
            // hDDTableAdapter
            // 
            this.hDDTableAdapter.ClearBeforeFill = true;
            // 
            // motherboardTableAdapter
            // 
            this.motherboardTableAdapter.ClearBeforeFill = true;
            // 
            // power_unitTableAdapter
            // 
            this.power_unitTableAdapter.ClearBeforeFill = true;
            // 
            // rAMTableAdapter
            // 
            this.rAMTableAdapter.ClearBeforeFill = true;
            // 
            // sSDTableAdapter
            // 
            this.sSDTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accemblyBindingSource1, "gpu_id", true));
            this.comboBox1.DataSource = this.gPUBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "id";
            // 
            // accemblyBindingSource1
            // 
            this.accemblyBindingSource1.DataMember = "Accembly";
            this.accemblyBindingSource1.DataSource = this.compsDataSet;
            // 
            // gPUBindingSource
            // 
            this.gPUBindingSource.DataMember = "GPU";
            this.gPUBindingSource.DataSource = this.compsDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accemblyBindingSource1, "cpu_id", true));
            this.comboBox2.DataSource = this.cPUBindingSource;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(146, 105);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(205, 21);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.ValueMember = "id";
            // 
            // cPUBindingSource
            // 
            this.cPUBindingSource.DataMember = "CPU";
            this.cPUBindingSource.DataSource = this.compsDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accemblyBindingSource1, "Motherboard_id", true));
            this.comboBox3.DataSource = this.motherboardBindingSource;
            this.comboBox3.DisplayMember = "name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(146, 68);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(205, 21);
            this.comboBox3.TabIndex = 16;
            this.comboBox3.ValueMember = "id";
            this.comboBox3.SelectedValueChanged += new System.EventHandler(this.comboBox3_SelectedValueChanged);
            // 
            // motherboardBindingSource
            // 
            this.motherboardBindingSource.DataMember = "Motherboard";
            this.motherboardBindingSource.DataSource = this.compsDataSet;
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accemblyBindingSource1, "ram_id", true));
            this.comboBox5.DataSource = this.rAMBindingSource;
            this.comboBox5.DisplayMember = "name";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(146, 182);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(205, 21);
            this.comboBox5.TabIndex = 16;
            this.comboBox5.ValueMember = "id";
            // 
            // rAMBindingSource
            // 
            this.rAMBindingSource.DataMember = "RAM";
            this.rAMBindingSource.DataSource = this.compsDataSetBindingSource;
            // 
            // compsDataSetBindingSource
            // 
            this.compsDataSetBindingSource.DataSource = this.compsDataSet;
            this.compsDataSetBindingSource.Position = 0;
            // 
            // comboBox6
            // 
            this.comboBox6.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accemblyBindingSource1, "power_unit_id", true));
            this.comboBox6.DataSource = this.powerunitBindingSource;
            this.comboBox6.DisplayMember = "name";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(146, 266);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(205, 21);
            this.comboBox6.TabIndex = 16;
            this.comboBox6.ValueMember = "id";
            // 
            // powerunitBindingSource
            // 
            this.powerunitBindingSource.DataMember = "Power_unit";
            this.powerunitBindingSource.DataSource = this.compsDataSet;
            // 
            // comboBox7
            // 
            this.comboBox7.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accemblyBindingSource1, "ssd_id", true));
            this.comboBox7.DataSource = this.sSDBindingSource;
            this.comboBox7.DisplayMember = "name";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(146, 305);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(205, 21);
            this.comboBox7.TabIndex = 16;
            this.comboBox7.ValueMember = "id";
            // 
            // sSDBindingSource
            // 
            this.sSDBindingSource.DataMember = "SSD";
            this.sSDBindingSource.DataSource = this.compsDataSet;
            // 
            // comboBox8
            // 
            this.comboBox8.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.accemblyBindingSource1, "hdd_id", true));
            this.comboBox8.DataSource = this.hDDBindingSource;
            this.comboBox8.DisplayMember = "name";
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(146, 348);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(205, 21);
            this.comboBox8.TabIndex = 16;
            this.comboBox8.ValueMember = "id";
            // 
            // hDDBindingSource
            // 
            this.hDDBindingSource.DataMember = "HDD";
            this.hDDBindingSource.DataSource = this.compsDataSet;
            // 
            // ram_countTextBox
            // 
            this.ram_countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accemblyBindingSource1, "ram_count", true));
            this.ram_countTextBox.Location = new System.Drawing.Point(146, 222);
            this.ram_countTextBox.Name = "ram_countTextBox";
            this.ram_countTextBox.Size = new System.Drawing.Size(47, 20);
            this.ram_countTextBox.TabIndex = 18;
            // 
            // Кнопка_Добавить
            // 
            this.Кнопка_Добавить.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Кнопка_Добавить.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Кнопка_Добавить.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Кнопка_Добавить.Location = new System.Drawing.Point(542, 144);
            this.Кнопка_Добавить.Name = "Кнопка_Добавить";
            this.Кнопка_Добавить.Size = new System.Drawing.Size(94, 43);
            this.Кнопка_Добавить.TabIndex = 7;
            this.Кнопка_Добавить.Text = "Добавить";
            this.Кнопка_Добавить.UseVisualStyleBackColor = false;
            this.Кнопка_Добавить.Click += new System.EventHandler(this.Кнопка_Добавить_Click);
            // 
            // Кнопка_Сохранить
            // 
            this.Кнопка_Сохранить.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Кнопка_Сохранить.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Кнопка_Сохранить.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Кнопка_Сохранить.Location = new System.Drawing.Point(542, 211);
            this.Кнопка_Сохранить.Name = "Кнопка_Сохранить";
            this.Кнопка_Сохранить.Size = new System.Drawing.Size(94, 43);
            this.Кнопка_Сохранить.TabIndex = 6;
            this.Кнопка_Сохранить.Text = "Сохранить";
            this.Кнопка_Сохранить.UseVisualStyleBackColor = false;
            this.Кнопка_Сохранить.Click += new System.EventHandler(this.Кнопка_Сохранить_Click);
            // 
            // Assembly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Кнопка_Добавить);
            this.Controls.Add(this.Кнопка_Сохранить);
            this.Controls.Add(this.ram_countTextBox);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(hdd_idLabel);
            this.Controls.Add(ssd_idLabel);
            this.Controls.Add(power_unit_idLabel);
            this.Controls.Add(ram_idLabel);
            this.Controls.Add(ram_countLabel);
            this.Controls.Add(motherboard_idLabel);
            this.Controls.Add(gpu_idLabel);
            this.Controls.Add(cpu_idLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Assembly";
            this.Text = "Assembly";
            this.Load += new System.EventHandler(this.Assembly_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accemblyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accemblyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherboardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerunitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private compsDataSet compsDataSet;
        private System.Windows.Forms.BindingSource accemblyBindingSource;
        private compsDataSetTableAdapters.AccemblyTableAdapter accemblyTableAdapter;
        private compsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private compsDataSetTableAdapters.CPUTableAdapter cPUTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.BindingSource cPUBindingSource;
        private System.Windows.Forms.BindingSource accemblyBindingSource1;
        private compsDataSetTableAdapters.MotherboardTableAdapter motherboardTableAdapter;
        private System.Windows.Forms.BindingSource motherboardBindingSource;
        private compsDataSetTableAdapters.GPUTableAdapter gPUTableAdapter;
        private System.Windows.Forms.BindingSource gPUBindingSource;
        private System.Windows.Forms.BindingSource compsDataSetBindingSource;
        private compsDataSetTableAdapters.RAMTableAdapter rAMTableAdapter;
        private System.Windows.Forms.BindingSource rAMBindingSource;
        private compsDataSetTableAdapters.Power_unitTableAdapter power_unitTableAdapter;
        private System.Windows.Forms.TextBox ram_countTextBox;
        private System.Windows.Forms.BindingSource powerunitBindingSource;
        private compsDataSetTableAdapters.SSDTableAdapter sSDTableAdapter;
        private System.Windows.Forms.BindingSource sSDBindingSource;
        private compsDataSetTableAdapters.HDDTableAdapter hDDTableAdapter;
        private System.Windows.Forms.BindingSource hDDBindingSource;
        private System.Windows.Forms.Button Кнопка_Добавить;
        private System.Windows.Forms.Button Кнопка_Сохранить;
    }
}