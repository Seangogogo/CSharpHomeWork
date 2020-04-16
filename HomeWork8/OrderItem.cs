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
    public partial class OrderItemForm : Form
    {
        public OrderItemForm()
        {
            InitializeComponent();
            textBox_OrderID.DataBindings.Add("Text", this, "OrderID");
            textBox_OrderItemID.DataBindings.Add("Text", this, "OrderItemID");
            textBox_PN.DataBindings.Add("Text", this, "PN");
            textBox_Price.DataBindings.Add("Text", this, "Price");
            textBox_Quantity.DataBindings.Add("Text", this, "Quantity");
        }

        public int OrderID { get; set; }
        public int OrderItemID { get; set; }
        public string PN { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        
        public OrderItem orderItem;

        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (PN == null)
            {
                MessageBox.Show("Please input the ProductName!");
                return;
            }
            orderItem = new OrderItem(OrderItemID, PN, Price, Quantity);
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
