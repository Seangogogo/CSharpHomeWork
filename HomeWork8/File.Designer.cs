namespace Example8_1
{
    partial class FileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_FN = new System.Windows.Forms.TextBox();
            this.button_cancle = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_cancle);
            this.panel1.Controls.Add(this.button_confirm);
            this.panel1.Controls.Add(this.textBox_FN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 203);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "FileName:";
            // 
            // textBox_FN
            // 
            this.textBox_FN.Font = new System.Drawing.Font("宋体", 20F);
            this.textBox_FN.Location = new System.Drawing.Point(215, 27);
            this.textBox_FN.Name = "textBox_FN";
            this.textBox_FN.Size = new System.Drawing.Size(250, 46);
            this.textBox_FN.TabIndex = 1;
            this.textBox_FN.Text = "Order";
            this.textBox_FN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_cancle
            // 
            this.button_cancle.Font = new System.Drawing.Font("宋体", 12F);
            this.button_cancle.Location = new System.Drawing.Point(350, 120);
            this.button_cancle.Name = "button_cancle";
            this.button_cancle.Size = new System.Drawing.Size(150, 50);
            this.button_cancle.TabIndex = 6;
            this.button_cancle.Text = "Cancel";
            this.button_cancle.UseVisualStyleBackColor = true;
            this.button_cancle.Click += new System.EventHandler(this.button_cancle_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Font = new System.Drawing.Font("宋体", 12F);
            this.button_confirm.Location = new System.Drawing.Point(70, 120);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(150, 50);
            this.button_confirm.TabIndex = 5;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 20F);
            this.label2.Location = new System.Drawing.Point(471, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = ".xml";
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 203);
            this.Controls.Add(this.panel1);
            this.Name = "FileForm";
            this.Text = "File";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_FN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_cancle;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Label label2;
    }
}