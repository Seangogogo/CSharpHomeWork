using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using static Example6_1.OrderServiceSource;

namespace Example8_1
{
    public partial class OrderServiceForm : Form
    {
        OrderService orderService;

        public OrderServiceForm()
        {
            InitializeComponent();
            orderService = new OrderService();
            OrderBindingSource.DataSource = orderService.Orders;
            key = "*";
            textBox_OrderQuery.DataBindings.Add("Text", this, "key");
            comboBox_OrderProperty.DataSource = properties;
        }

        private void OrderServiceForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                Order order = new Order(i, ((char)((int)'a' + 1)).ToString());
                for (int j = i + 10; j < 20; j++)
                {
                    OrderItem orderItem = new OrderItem(j, j + "PN", i, j);
                    order.AddOrderItem(orderItem);
                }
                orderService.AddOrder(order);
            }
            OrderBindingSource.ResetBindings(true);
        }

        public string[] properties = 
        {
            "OrderID",
            "CustomerName",
            "TotalPrice",
            "OrderItemID",
            "ProductName",
            "Price",
            "Quantity"
        };

        public string key { get; set; }

        private void OrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order;
            using(OrderForm orderform = new OrderForm())
            {
                if (orderform.ShowDialog() == DialogResult.OK)
                {
                    order = new Order(orderform.order);
                }
                else return;
            }
            try
            {
                orderService.AddOrder(order);
                OrderBindingSource.ResetBindings(true);
                MessageBox.Show("Add Order successfully!");
            }
            catch(MatchException me)
            {
                MessageBox.Show(me.Message);
            }
        }

        private void OrderItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderItem orderItem;
            int ID;
            using(OrderItemForm orderitemform = new OrderItemForm())
            {
                if (orderitemform.ShowDialog() == DialogResult.OK)
                {
                    orderItem = new OrderItem(orderitemform.orderItem);
                    ID = orderitemform.OrderID;
                }
                else return;
            }
            try
            {
                orderService.AddOrderItem(ID, orderItem);
                OrderBindingSource.ResetBindings(true);
                MessageBox.Show("Add OrderItem successfully!");
            }
            catch (MatchException me)
            {
                MessageBox.Show(me.Message);
            }
        }

        private void DeleteOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID;
            using (DeleteOrderForm deleteOrderForm = new DeleteOrderForm())
            {
                if (deleteOrderForm.ShowDialog() == DialogResult.OK)
                {
                    ID = deleteOrderForm.ID;
                }
                else return;
            }
            try
            {
                orderService.DeleteOrder(ID);
                OrderBindingSource.ResetBindings(true);
                MessageBox.Show("Delete Order successfully!");
            }
            catch (MatchException me)
            {
                MessageBox.Show(me.Message);
            }
        }

        private void DeleteOrderItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OrderID, OrderItemID;
            using (DeleteOrderItemForm deleteOrderItemForm = new DeleteOrderItemForm())
            {
                if (deleteOrderItemForm.ShowDialog() == DialogResult.OK)
                {
                    OrderID = deleteOrderItemForm.OrderID;
                    OrderItemID = deleteOrderItemForm.OrderItemID;
                }
                else return;
            }
            try
            {
                orderService.DeleteOrderItem(OrderID, OrderItemID);
                OrderBindingSource.ResetBindings(true);
                MessageBox.Show("Delete OrderItem successfully!");
            }
            catch (MatchException me)
            {
                MessageBox.Show(me.Message);
            }
        }

        private void UpdateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order;
            using (OrderForm orderform = new OrderForm())
            {
                if (orderform.ShowDialog() == DialogResult.OK)
                {
                    order = new Order(orderform.order);
                }
                else return;
            }
            try
            {
                Order neworder = new Order(orderService.FindOrder(order.ID));
                neworder.CustomerName = order.CustomerName;
                orderService.UpdateOrder(order.ID, neworder);
                OrderBindingSource.ResetBindings(true);
                MessageBox.Show("Update Order successfully!");
            }
            catch (MatchException me)
            {
                MessageBox.Show(me.Message);
            }
        }

        private void UpdateOrderItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderItem orderItem;
            int ID;
            using (OrderItemForm orderitemform = new OrderItemForm())
            {
                if (orderitemform.ShowDialog() == DialogResult.OK)
                {
                    orderItem = new OrderItem(orderitemform.orderItem);
                    ID = orderitemform.OrderID;
                }
                else return;
            }
            try
            {
                orderService.UpdateOrderItem(ID, orderItem.ID, orderItem);
                OrderBindingSource.ResetBindings(true);
                MessageBox.Show("Update OrderItem successfully!");
            }
            catch (MatchException me)
            {
                MessageBox.Show(me.Message);
            }
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            OrderItemsBindingSource.DataSource = OrderBindingSource;
            int index = comboBox_OrderProperty.Items.IndexOf(comboBox_OrderProperty.Text);

            if (key == null || key == "*")
            {
                key = "";
            }
            if (OrderBindingSource.Count == 0 && index > 2)
            {
                return;
            }

            Order order = (Order)OrderBindingSource.Current;

            switch (index)
            {
                case 0:
                    OrderBindingSource.DataSource = 
                        orderService.FindOrder(o => { return o.ID.ToString().Contains(key); });
                    break;
                case 1:
                    OrderBindingSource.DataSource = 
                        orderService.FindOrder(o => { return o.CustomerName.Contains(key); });
                    break;
                case 2:
                    OrderBindingSource.DataSource =
                        orderService.FindOrder(o => { return o.TotalPrice.ToString().Contains(key); });
                    break;
                case 3:
                    OrderItemsBindingSource.DataSource = orderService.FindOrderItem
                        (order.ID, oi => { return oi.ID.ToString().Contains(key); });
                    break;
                case 4:
                    OrderItemsBindingSource.DataSource = orderService.FindOrderItem
                        (order.ID, oi => { return oi.ProductName.Contains(key); });
                    break;
                case 5:
                    OrderItemsBindingSource.DataSource = orderService.FindOrderItem
                        (order.ID, oi => { return oi.Price.ToString().Contains(key); });
                    break;
                case 6:
                    OrderItemsBindingSource.DataSource = orderService.FindOrderItem
                        (order.ID, oi => { return oi.Quantity.ToString().Contains(key); });
                    break;
            }
        }

        private void OrderGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            OrderItemsBindingSource.DataSource = OrderBindingSource;
            OrderItemsBindingSource.DataMember = "OrderItems";
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FileName;
            using(FileForm fileForm = new FileForm())
            {
                if (fileForm.ShowDialog() == DialogResult.OK)
                {
                    FileName = fileForm.FN;
                }
                else return;
            }
            try
            {
                orderService.Import(FileName + ".xml");
                OrderBindingSource.DataSource = orderService.Orders;
                OrderBindingSource.ResetBindings(true);
                MessageBox.Show("Import successfully!");

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found!");
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FileName;
            using (FileForm fileForm = new FileForm())
            {
                if (fileForm.ShowDialog() == DialogResult.OK)
                {
                    FileName = fileForm.FN;
                }
                else return;
            }
            orderService.Export(FileName + ".xml");
            MessageBox.Show("Export successfully!");
        }
        
    }
}
