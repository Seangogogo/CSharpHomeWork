namespace Example8_1
{
    partial class OrderServiceForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OrderItemGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Property = new System.Windows.Forms.Label();
            this.comboBox_OrderProperty = new System.Windows.Forms.ComboBox();
            this.button_done = new System.Windows.Forms.Button();
            this.label_Query = new System.Windows.Forms.Label();
            this.textBox_OrderQuery = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteOrderItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DpdateOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DpdateOrderItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderItemGridView
            // 
            this.OrderItemGridView.AutoGenerateColumns = false;
            this.OrderItemGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OrderItemGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderItemGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ProductName,
            this.Price,
            this.Quantity});
            this.OrderItemGridView.DataSource = this.OrderItemsBindingSource;
            this.OrderItemGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderItemGridView.Location = new System.Drawing.Point(505, 159);
            this.OrderItemGridView.Name = "OrderItemGridView";
            this.OrderItemGridView.ReadOnly = true;
            this.OrderItemGridView.RowTemplate.Height = 27;
            this.OrderItemGridView.Size = new System.Drawing.Size(477, 394);
            this.OrderItemGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderItemID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // OrderItemsBindingSource
            // 
            this.OrderItemsBindingSource.DataMember = "OrderItems";
            this.OrderItemsBindingSource.DataSource = this.OrderBindingSource;
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataSource = typeof(Example6_1.OrderServiceSource.Order);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Property);
            this.panel1.Controls.Add(this.comboBox_OrderProperty);
            this.panel1.Controls.Add(this.button_done);
            this.panel1.Controls.Add(this.label_Query);
            this.panel1.Controls.Add(this.textBox_OrderQuery);
            this.panel1.Controls.Add(this.menuStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 159);
            this.panel1.TabIndex = 0;
            // 
            // label_Property
            // 
            this.label_Property.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Property.AutoSize = true;
            this.label_Property.Font = new System.Drawing.Font("宋体", 12F);
            this.label_Property.Location = new System.Drawing.Point(50, 50);
            this.label_Property.Name = "label_Property";
            this.label_Property.Size = new System.Drawing.Size(99, 20);
            this.label_Property.TabIndex = 10;
            this.label_Property.Text = "Property:";
            // 
            // comboBox_OrderProperty
            // 
            this.comboBox_OrderProperty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_OrderProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_OrderProperty.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBox_OrderProperty.FormattingEnabled = true;
            this.comboBox_OrderProperty.Items.AddRange(new object[] {
            "OrderID",
            "CustomerName"});
            this.comboBox_OrderProperty.Location = new System.Drawing.Point(250, 50);
            this.comboBox_OrderProperty.Name = "comboBox_OrderProperty";
            this.comboBox_OrderProperty.Size = new System.Drawing.Size(500, 28);
            this.comboBox_OrderProperty.TabIndex = 9;
            // 
            // button_done
            // 
            this.button_done.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_done.Font = new System.Drawing.Font("宋体", 15F);
            this.button_done.Location = new System.Drawing.Point(820, 70);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(100, 50);
            this.button_done.TabIndex = 8;
            this.button_done.Text = "Done";
            this.button_done.UseVisualStyleBackColor = true;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // label_Query
            // 
            this.label_Query.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Query.AutoSize = true;
            this.label_Query.Font = new System.Drawing.Font("宋体", 12F);
            this.label_Query.Location = new System.Drawing.Point(50, 100);
            this.label_Query.Name = "label_Query";
            this.label_Query.Size = new System.Drawing.Size(69, 20);
            this.label_Query.TabIndex = 7;
            this.label_Query.Text = "Query:";
            // 
            // textBox_OrderQuery
            // 
            this.textBox_OrderQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_OrderQuery.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_OrderQuery.Location = new System.Drawing.Point(250, 100);
            this.textBox_OrderQuery.Name = "textBox_OrderQuery";
            this.textBox_OrderQuery.Size = new System.Drawing.Size(500, 30);
            this.textBox_OrderQuery.TabIndex = 6;
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(5, 5, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(982, 31);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderToolStripMenuItem,
            this.OrderItemToolStripMenuItem});
            this.NewToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(59, 27);
            this.NewToolStripMenuItem.Text = "New";
            // 
            // OrderToolStripMenuItem
            // 
            this.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem";
            this.OrderToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.OrderToolStripMenuItem.Text = "Order";
            this.OrderToolStripMenuItem.Click += new System.EventHandler(this.OrderToolStripMenuItem_Click);
            // 
            // OrderItemToolStripMenuItem
            // 
            this.OrderItemToolStripMenuItem.Name = "OrderItemToolStripMenuItem";
            this.OrderItemToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.OrderItemToolStripMenuItem.Text = "OrderItem";
            this.OrderItemToolStripMenuItem.Click += new System.EventHandler(this.OrderItemToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteOrderToolStripMenuItem,
            this.DeleteOrderItemToolStripMenuItem,
            this.DpdateOrderToolStripMenuItem,
            this.DpdateOrderItemToolStripMenuItem});
            this.EditToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(53, 27);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // DeleteOrderToolStripMenuItem
            // 
            this.DeleteOrderToolStripMenuItem.Name = "DeleteOrderToolStripMenuItem";
            this.DeleteOrderToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.DeleteOrderToolStripMenuItem.Text = "Delete Order";
            this.DeleteOrderToolStripMenuItem.Click += new System.EventHandler(this.DeleteOrderToolStripMenuItem_Click);
            // 
            // DeleteOrderItemToolStripMenuItem
            // 
            this.DeleteOrderItemToolStripMenuItem.Name = "DeleteOrderItemToolStripMenuItem";
            this.DeleteOrderItemToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.DeleteOrderItemToolStripMenuItem.Text = "Delete OrderItem";
            this.DeleteOrderItemToolStripMenuItem.Click += new System.EventHandler(this.DeleteOrderItemToolStripMenuItem_Click);
            // 
            // DpdateOrderToolStripMenuItem
            // 
            this.DpdateOrderToolStripMenuItem.Name = "DpdateOrderToolStripMenuItem";
            this.DpdateOrderToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.DpdateOrderToolStripMenuItem.Text = "Update Order";
            this.DpdateOrderToolStripMenuItem.Click += new System.EventHandler(this.UpdateOrderToolStripMenuItem_Click);
            // 
            // DpdateOrderItemToolStripMenuItem
            // 
            this.DpdateOrderItemToolStripMenuItem.Name = "DpdateOrderItemToolStripMenuItem";
            this.DpdateOrderItemToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.DpdateOrderItemToolStripMenuItem.Text = "Update OrderItem";
            this.DpdateOrderItemToolStripMenuItem.Click += new System.EventHandler(this.UpdateOrderItemToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(141, 28);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(141, 28);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // totalPriceDataGridViewTextBoxColumn1
            // 
            this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
            this.totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "OrderID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // OrderGridView
            // 
            this.OrderGridView.AutoGenerateColumns = false;
            this.OrderGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CustomerName,
            this.totalPriceDataGridViewTextBoxColumn1});
            this.OrderGridView.DataSource = this.OrderBindingSource;
            this.OrderGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.OrderGridView.Location = new System.Drawing.Point(0, 159);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.ReadOnly = true;
            this.OrderGridView.RowTemplate.Height = 27;
            this.OrderGridView.Size = new System.Drawing.Size(495, 394);
            this.OrderGridView.TabIndex = 1;
            this.OrderGridView.CurrentCellChanged += new System.EventHandler(this.OrderGridView_CurrentCellChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(495, 159);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 394);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // OrderServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.OrderItemGridView);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.OrderGridView);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "OrderServiceForm";
            this.Text = "OrderService";
            this.Load += new System.EventHandler(this.OrderServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView OrderItemGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteOrderItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DpdateOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DpdateOrderItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderToolStripMenuItem;
        private System.Windows.Forms.BindingSource OrderItemsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label_Property;
        private System.Windows.Forms.ComboBox comboBox_OrderProperty;
        private System.Windows.Forms.Button button_done;
        private System.Windows.Forms.Label label_Query;
        private System.Windows.Forms.TextBox textBox_OrderQuery;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.BindingSource OrderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridView OrderGridView;
        private System.Windows.Forms.Splitter splitter1;
    }
}

