namespace Example8_1
{
    partial class DeleteOrderItemForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_OrderID = new System.Windows.Forms.TextBox();
            this.label_OrderID = new System.Windows.Forms.Label();
            this.textBox_OrderItemID = new System.Windows.Forms.TextBox();
            this.label_OrderItemID = new System.Windows.Forms.Label();
            this.button_cancle = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_cancle);
            this.panel1.Controls.Add(this.button_confirm);
            this.panel1.Controls.Add(this.textBox_OrderID);
            this.panel1.Controls.Add(this.label_OrderID);
            this.panel1.Controls.Add(this.textBox_OrderItemID);
            this.panel1.Controls.Add(this.label_OrderItemID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 253);
            this.panel1.TabIndex = 0;
            // 
            // textBox_OrderID
            // 
            this.textBox_OrderID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_OrderID.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_OrderID.Location = new System.Drawing.Point(280, 30);
            this.textBox_OrderID.Name = "textBox_OrderID";
            this.textBox_OrderID.Size = new System.Drawing.Size(219, 30);
            this.textBox_OrderID.TabIndex = 9;
            // 
            // label_OrderID
            // 
            this.label_OrderID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_OrderID.AutoSize = true;
            this.label_OrderID.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_OrderID.ForeColor = System.Drawing.Color.Black;
            this.label_OrderID.Location = new System.Drawing.Point(30, 30);
            this.label_OrderID.Name = "label_OrderID";
            this.label_OrderID.Size = new System.Drawing.Size(151, 34);
            this.label_OrderID.TabIndex = 8;
            this.label_OrderID.Text = "OrderID:";
            // 
            // textBox_OrderItemID
            // 
            this.textBox_OrderItemID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_OrderItemID.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_OrderItemID.Location = new System.Drawing.Point(280, 100);
            this.textBox_OrderItemID.Name = "textBox_OrderItemID";
            this.textBox_OrderItemID.Size = new System.Drawing.Size(219, 30);
            this.textBox_OrderItemID.TabIndex = 11;
            // 
            // label_OrderItemID
            // 
            this.label_OrderItemID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_OrderItemID.AutoSize = true;
            this.label_OrderItemID.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_OrderItemID.ForeColor = System.Drawing.Color.Black;
            this.label_OrderItemID.Location = new System.Drawing.Point(30, 100);
            this.label_OrderItemID.Name = "label_OrderItemID";
            this.label_OrderItemID.Size = new System.Drawing.Size(219, 34);
            this.label_OrderItemID.TabIndex = 10;
            this.label_OrderItemID.Text = "OrderItemID:";
            // 
            // button_cancle
            // 
            this.button_cancle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_cancle.Font = new System.Drawing.Font("宋体", 12F);
            this.button_cancle.Location = new System.Drawing.Point(320, 175);
            this.button_cancle.Name = "button_cancle";
            this.button_cancle.Size = new System.Drawing.Size(150, 50);
            this.button_cancle.TabIndex = 13;
            this.button_cancle.Text = "Cancel";
            this.button_cancle.UseVisualStyleBackColor = true;
            this.button_cancle.Click += new System.EventHandler(this.button_cancle_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_confirm.Font = new System.Drawing.Font("宋体", 12F);
            this.button_confirm.Location = new System.Drawing.Point(60, 175);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(150, 50);
            this.button_confirm.TabIndex = 12;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // DeleteOrderItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 253);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteOrderItemForm";
            this.Text = "DeleteOrderItem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_OrderID;
        private System.Windows.Forms.Label label_OrderID;
        private System.Windows.Forms.TextBox textBox_OrderItemID;
        private System.Windows.Forms.Label label_OrderItemID;
        private System.Windows.Forms.Button button_cancle;
        private System.Windows.Forms.Button button_confirm;
    }
}