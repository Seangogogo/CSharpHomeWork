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
    public partial class DeleteOrderForm : Form
    {
        public DeleteOrderForm()
        {
            InitializeComponent();
            textBox_ID.DataBindings.Add("Text", this, "ID");
        }

        public int ID { get; set; }

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
