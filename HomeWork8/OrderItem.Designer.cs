namespace Example8_1
{
    partial class OrderItemForm
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
            this.button_cancle = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.textBox_OrderID = new System.Windows.Forms.TextBox();
            this.label_OrderID = new System.Windows.Forms.Label();
            this.label_PN = new System.Windows.Forms.Label();
            this.textBox_PN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.textBox_OrderItemID = new System.Windows.Forms.TextBox();
            this.label_OrderItemID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_cancle
            // 
            this.button_cancle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_cancle.Font = new System.Drawing.Font("宋体", 12F);
            this.button_cancle.Location = new System.Drawing.Point(280, 340);
            this.button_cancle.Name = "button_cancle";
            this.button_cancle.Size = new System.Drawing.Size(150, 50);
            this.button_cancle.TabIndex = 10;
            this.button_cancle.Text = "Cancel";
            this.button_cancle.UseVisualStyleBackColor = true;
            this.button_cancle.Click += new System.EventHandler(this.button_cancle_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_confirm.Font = new System.Drawing.Font("宋体", 12F);
            this.button_confirm.Location = new System.Drawing.Point(50, 340);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(150, 50);
            this.button_confirm.TabIndex = 9;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // textBox_OrderID
            // 
            this.textBox_OrderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_OrderID.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_OrderID.Location = new System.Drawing.Point(300, 40);
            this.textBox_OrderID.Name = "textBox_OrderID";
            this.textBox_OrderID.Size = new System.Drawing.Size(150, 30);
            this.textBox_OrderID.TabIndex = 6;
            // 
            // label_OrderID
            // 
            this.label_OrderID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_OrderID.AutoSize = true;
            this.label_OrderID.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_OrderID.ForeColor = System.Drawing.Color.Black;
            this.label_OrderID.Location = new System.Drawing.Point(30, 40);
            this.label_OrderID.Name = "label_OrderID";
            this.label_OrderID.Size = new System.Drawing.Size(151, 34);
            this.label_OrderID.TabIndex = 5;
            this.label_OrderID.Text = "OrderID:";
            // 
            // label_PN
            // 
            this.label_PN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_PN.AutoSize = true;
            this.label_PN.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_PN.Location = new System.Drawing.Point(30, 160);
            this.label_PN.Name = "label_PN";
            this.label_PN.Size = new System.Drawing.Size(219, 34);
            this.label_PN.TabIndex = 7;
            this.label_PN.Text = "ProductName:";
            // 
            // textBox_PN
            // 
            this.textBox_PN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_PN.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_PN.Location = new System.Drawing.Point(300, 160);
            this.textBox_PN.Name = "textBox_PN";
            this.textBox_PN.Size = new System.Drawing.Size(150, 30);
            this.textBox_PN.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.textBox_OrderID);
            this.panel1.Controls.Add(this.label_Quantity);
            this.panel1.Controls.Add(this.label_OrderID);
            this.panel1.Controls.Add(this.textBox_Quantity);
            this.panel1.Controls.Add(this.button_cancle);
            this.panel1.Controls.Add(this.button_confirm);
            this.panel1.Controls.Add(this.label_Price);
            this.panel1.Controls.Add(this.textBox_Price);
            this.panel1.Controls.Add(this.textBox_OrderItemID);
            this.panel1.Controls.Add(this.label_OrderItemID);
            this.panel1.Controls.Add(this.label_PN);
            this.panel1.Controls.Add(this.textBox_PN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 433);
            this.panel1.TabIndex = 11;
            // 
            // label_Quantity
            // 
            this.label_Quantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Quantity.AutoSize = true;
            this.label_Quantity.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Quantity.Location = new System.Drawing.Point(30, 280);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(168, 34);
            this.label_Quantity.TabIndex = 11;
            this.label_Quantity.Text = "Quantity:";
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Quantity.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_Quantity.Location = new System.Drawing.Point(300, 280);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(150, 30);
            this.textBox_Quantity.TabIndex = 12;
            // 
            // label_Price
            // 
            this.label_Price.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Price.Location = new System.Drawing.Point(30, 220);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(117, 34);
            this.label_Price.TabIndex = 9;
            this.label_Price.Text = "Price:";
            // 
            // textBox_Price
            // 
            this.textBox_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Price.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_Price.Location = new System.Drawing.Point(300, 220);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(150, 30);
            this.textBox_Price.TabIndex = 10;
            // 
            // textBox_OrderItemID
            // 
            this.textBox_OrderItemID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_OrderItemID.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_OrderItemID.Location = new System.Drawing.Point(300, 100);
            this.textBox_OrderItemID.Name = "textBox_OrderItemID";
            this.textBox_OrderItemID.Size = new System.Drawing.Size(150, 30);
            this.textBox_OrderItemID.TabIndex = 7;
            // 
            // label_OrderItemID
            // 
            this.label_OrderItemID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_OrderItemID.AutoSize = true;
            this.label_OrderItemID.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_OrderItemID.ForeColor = System.Drawing.Color.Black;
            this.label_OrderItemID.Location = new System.Drawing.Point(30, 100);
            this.label_OrderItemID.Name = "label_OrderItemID";
            this.label_OrderItemID.Size = new System.Drawing.Size(219, 34);
            this.label_OrderItemID.TabIndex = 6;
            this.label_OrderItemID.Text = "OrderItemID:";
            // 
            // OrderItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 433);
            this.Controls.Add(this.panel1);
            this.Name = "OrderItemForm";
            this.Text = "OrderItem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_cancle;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.TextBox textBox_OrderID;
        private System.Windows.Forms.Label label_OrderID;
        private System.Windows.Forms.Label label_PN;
        private System.Windows.Forms.TextBox textBox_PN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_OrderItemID;
        private System.Windows.Forms.Label label_OrderItemID;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label_Quantity;
        private System.Windows.Forms.TextBox textBox_Quantity;
    }
}