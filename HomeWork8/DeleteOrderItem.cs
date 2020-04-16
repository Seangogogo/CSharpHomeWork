using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example8_1
{
    public partial class DeleteOrderItemForm : Form
    {
        public DeleteOrderItemForm()
        {
            InitializeComponent();
            textBox_OrderID.DataBindings.Add("Text", this, "OrderID");
            textBox_OrderItemID.DataBindings.Add("Text", this, "OrderItemID");
        }

        public int OrderID { get; set; }
        public int OrderItemID { get; set; }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_cancle_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
