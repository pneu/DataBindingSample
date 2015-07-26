using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingTest
{
    public partial class Form1 : Form
    {
        MyData DataInstance;

        public Form1() {
            InitializeComponent();
            DataInstance = new MyData() { Number = 100 };
            this.bindingSource1.DataSource = DataInstance;
            this.bindingSource1.DataSourceChanged += bindingSource1_DataSourceChanged;
        }

        void bindingSource1_DataSourceChanged(object sender, EventArgs e) {
            MessageBox.Show("DataSourceChanged");
        }

        private void button1_Click(object sender, EventArgs e) {
            this.DataInstance = new MyData() { Number = 200 };
            this.bindingSource1.DataSource = DataInstance;
            this.bindingSource1.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e) {
            DataInstance.Number *= 5;
            this.bindingSource1.ResetBindings(false);
        }
    }
}
