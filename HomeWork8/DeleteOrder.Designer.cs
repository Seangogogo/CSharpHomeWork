namespace Example8_1
{
    partial class DeleteOrderForm
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
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.button_cancle = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_ID
            // 
            this.textBox_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_ID.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_ID.Location = new System.Drawing.Point(140, 40);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(193, 30);
            this.textBox_ID.TabIndex = 3;
            // 
            // label_ID
            // 
            this.label_ID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ID.Location = new System.Drawing.Point(30, 40);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(66, 34);
            this.label_ID.TabIndex = 2;
            this.label_ID.Text = "ID:";
            // 
            // button_cancle
            // 
            this.button_cancle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_cancle.Font = new System.Drawing.Font("宋体", 12F);
            this.button_cancle.Location = new System.Drawing.Point(200, 115);
            this.button_cancle.Name = "button_cancle";
            this.button_cancle.Size = new System.Drawing.Size(150, 50);
            this.button_cancle.TabIndex = 6;
            this.button_cancle.Text = "Cancel";
            this.button_cancle.UseVisualStyleBackColor = true;
            this.button_cancle.Click += new System.EventHandler(this.button_cancle_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_confirm.Font = new System.Drawing.Font("宋体", 12F);
            this.button_confirm.Location = new System.Drawing.Point(20, 115);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(150, 50);
            this.button_confirm.TabIndex = 5;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_cancle);
            this.panel1.Controls.Add(this.label_ID);
            this.panel1.Controls.Add(this.button_confirm);
            this.panel1.Controls.Add(this.textBox_ID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 193);
            this.panel1.TabIndex = 7;
            // 
            // DeleteOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 193);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteOrderForm";
            this.Text = "DeleteOrder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Button button_cancle;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Panel panel1;
    }
}