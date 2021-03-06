﻿using System;
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
    public partial class FileForm : Form
    {
        public FileForm()
        {
            InitializeComponent();
            textBox_FN.DataBindings.Add("Text", this, "FN");
        }

        public string FN { get; set; }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (FN == null)
            {
                MessageBox.Show("Please input the FileName!");
                return;
            }
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
