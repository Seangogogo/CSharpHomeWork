using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Example6_1.OrderServiceSource;

namespace Example8_1
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            textBox_ID.DataBindings.Add("Text", this, "ID");
            textBox_CN.DataBindings.Add("Text", this, "CN");
        }

        public int ID { set; get; }
        public string CN { set; get; }

        public Order order;

        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (CN == null)
            {
                MessageBox.Show("Please input the CustomerName!");
                return;
            }
            order = new Order(ID, CN);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
