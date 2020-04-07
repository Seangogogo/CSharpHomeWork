namespace Example7_1

{

    partial class CayleyTree

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

            this.button_clean = new System.Windows.Forms.Button();

            this.button_draw = new System.Windows.Forms.Button();

            this.panel1 = new System.Windows.Forms.Panel();

            this.label_depth = new System.Windows.Forms.Label();

            this.comboBox_color = new System.Windows.Forms.ComboBox();

            this.textBox_length = new System.Windows.Forms.TextBox();

            this.label_length = new System.Windows.Forms.Label();

            this.label_color = new System.Windows.Forms.Label();

            this.textBox_depth = new System.Windows.Forms.TextBox();

            this.label_l_a = new System.Windows.Forms.Label();

            this.label_r_a = new System.Windows.Forms.Label();

            this.trackBar_l_a = new System.Windows.Forms.TrackBar();

            this.trackBar_r_a = new System.Windows.Forms.TrackBar();

            this.trackBar_r_d = new System.Windows.Forms.TrackBar();

            this.trackBar_l_d = new System.Windows.Forms.TrackBar();

            this.label_r_d = new System.Windows.Forms.Label();

            this.label_l_d = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.trackBar_l_a)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.trackBar_r_a)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.trackBar_r_d)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.trackBar_l_d)).BeginInit();

            this.SuspendLayout();

            // 

            // button_clean

            // 

            this.button_clean.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            this.button_clean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.button_clean.Location = new System.Drawing.Point(825, 25);

            this.button_clean.Name = "button_clean";

            this.button_clean.Size = new System.Drawing.Size(125, 50);

            this.button_clean.TabIndex = 0;

            this.button_clean.Text = "clean(&C)";

            this.button_clean.UseVisualStyleBackColor = true;

            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);

            // 

            // button_draw

            // 

            this.button_draw.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            this.button_draw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.button_draw.Location = new System.Drawing.Point(1000, 25);

            this.button_draw.Name = "button_draw";

            this.button_draw.Size = new System.Drawing.Size(125, 50);

            this.button_draw.TabIndex = 1;

            this.button_draw.Text = "draw(&D)";

            this.button_draw.UseVisualStyleBackColor = true;

            this.button_draw.Click += new System.EventHandler(this.button_draw_Click);

            // 

            // panel1

            // 

            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;

            this.panel1.Location = new System.Drawing.Point(0, 0);

            this.panel1.Name = "panel1";

            this.panel1.Size = new System.Drawing.Size(800, 600);

            this.panel1.TabIndex = 2;

            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);

            // 

            // label_depth

            // 

            this.label_depth.AutoSize = true;

            this.label_depth.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            this.label_depth.Location = new System.Drawing.Point(825, 225);

            this.label_depth.Name = "label_depth";

            this.label_depth.Size = new System.Drawing.Size(69, 20);

            this.label_depth.TabIndex = 5;

            this.label_depth.Text = "depth:";

            this.label_depth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 

            // comboBox_color

            // 

            this.comboBox_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.comboBox_color.Font = new System.Drawing.Font("宋体", 12F);

            this.comboBox_color.FormattingEnabled = true;

            this.comboBox_color.Items.AddRange(new object[] {

            "black",

            "red",

            "yellow",

            "green",

            "blue"});

            this.comboBox_color.Location = new System.Drawing.Point(975, 120);

            this.comboBox_color.Name = "comboBox_color";

            this.comboBox_color.Size = new System.Drawing.Size(125, 28);

            this.comboBox_color.TabIndex = 6;

            this.comboBox_color.SelectedIndexChanged += new System.EventHandler(this.comboBox_color_SelectedIndexChanged);

            // 

            // textBox_length

            // 

            this.textBox_length.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            this.textBox_length.Location = new System.Drawing.Point(975, 170);

            this.textBox_length.Name = "textBox_length";

            this.textBox_length.Size = new System.Drawing.Size(125, 30);

            this.textBox_length.TabIndex = 7;

            // 

            // label_length

            // 

            this.label_length.AutoSize = true;

            this.label_length.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            this.label_length.Location = new System.Drawing.Point(825, 175);

            this.label_length.Name = "label_length";

            this.label_length.Size = new System.Drawing.Size(79, 20);

            this.label_length.TabIndex = 8;

            this.label_length.Text = "length:";

            // 

            // label_color

            // 

            this.label_color.AutoSize = true;

            this.label_color.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            this.label_color.Location = new System.Drawing.Point(825, 125);

            this.label_color.Name = "label_color";

            this.label_color.Size = new System.Drawing.Size(69, 20);

            this.label_color.TabIndex = 9;

            this.label_color.Text = "color:";

            // 

            // textBox_depth

            // 

            this.textBox_depth.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            this.textBox_depth.Location = new System.Drawing.Point(975, 220);

            this.textBox_depth.Name = "textBox_depth";

            this.textBox_depth.Size = new System.Drawing.Size(125, 30);

            this.textBox_depth.TabIndex = 10;

            // 

            // label_l_a

            // 

            this.label_l_a.AutoSize = true;

            this.label_l_a.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            this.label_l_a.Location = new System.Drawing.Point(825, 300);

            this.label_l_a.Name = "label_l_a";

            this.label_l_a.Size = new System.Drawing.Size(179, 20);

            this.label_l_a.TabIndex = 11;

            this.label_l_a.Text = "left attenuation:";

            this.label_l_a.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 

            // label_r_a

            // 

            this.label_r_a.AutoSize = true;

            this.label_r_a.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            this.label_r_a.Location = new System.Drawing.Point(825, 375);

            this.label_r_a.Name = "label_r_a";

            this.label_r_a.Size = new System.Drawing.Size(189, 20);

            this.label_r_a.TabIndex = 12;

            this.label_r_a.Text = "right attenuation:";

            this.label_r_a.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 

            // trackBar_l_a

            // 

            this.trackBar_l_a.BackColor = System.Drawing.SystemColors.Control;

            this.trackBar_l_a.Location = new System.Drawing.Point(1025, 300);

            this.trackBar_l_a.Name = "trackBar_l_a";

            this.trackBar_l_a.Size = new System.Drawing.Size(125, 56);

            this.trackBar_l_a.TabIndex = 14;

            this.trackBar_l_a.Scroll += new System.EventHandler(this.trackBar_l_a_Scroll);

            // 

            // trackBar_r_a

            // 

            this.trackBar_r_a.Location = new System.Drawing.Point(1025, 375);

            this.trackBar_r_a.Name = "trackBar_r_a";

            this.trackBar_r_a.Size = new System.Drawing.Size(125, 56);

            this.trackBar_r_a.TabIndex = 15;

            this.trackBar_r_a.Scroll += new System.EventHandler(this.trackBar_r_a_Scroll);

            // 

            // trackBar_r_d

            // 

            this.trackBar_r_d.Location = new System.Drawing.Point(1025, 525);

            this.trackBar_r_d.Maximum = 18;

            this.trackBar_r_d.Name = "trackBar_r_d";

            this.trackBar_r_d.Size = new System.Drawing.Size(125, 56);

            this.trackBar_r_d.TabIndex = 19;

            this.trackBar_r_d.Scroll += new System.EventHandler(this.trackBar_r_d_Scroll);

            // 

            // trackBar_l_d

            // 

            this.trackBar_l_d.Location = new System.Drawing.Point(1025, 450);

            this.trackBar_l_d.Maximum = 18;

            this.trackBar_l_d.Name = "trackBar_l_d";

            this.trackBar_l_d.Size = new System.Drawing.Size(125, 56);

            this.trackBar_l_d.TabIndex = 18;

            this.trackBar_l_d.Scroll += new System.EventHandler(this.trackBar_l_d_Scroll);

            // 

            // label_r_d

            // 

            this.label_r_d.AutoSize = true;

            this.label_r_d.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            this.label_r_d.Location = new System.Drawing.Point(825, 525);

            this.label_r_d.Name = "label_r_d";

            this.label_r_d.Size = new System.Drawing.Size(139, 20);

            this.label_r_d.TabIndex = 17;

            this.label_r_d.Text = "right degree:";

            this.label_r_d.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 

            // label_l_d

            // 

            this.label_l_d.AutoSize = true;

            this.label_l_d.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

            this.label_l_d.Location = new System.Drawing.Point(825, 450);

            this.label_l_d.Name = "label_l_d";

            this.label_l_d.Size = new System.Drawing.Size(129, 20);

            this.label_l_d.TabIndex = 16;

            this.label_l_d.Text = "left degree:";

            this.label_l_d.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 

            // CayleyTree

            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(1189, 603);

            this.Controls.Add(this.trackBar_r_d);

            this.Controls.Add(this.trackBar_l_d);

            this.Controls.Add(this.label_r_d);

            this.Controls.Add(this.label_l_d);

            this.Controls.Add(this.trackBar_r_a);

            this.Controls.Add(this.trackBar_l_a);

            this.Controls.Add(this.label_r_a);

            this.Controls.Add(this.label_l_a);

            this.Controls.Add(this.textBox_depth);

            this.Controls.Add(this.label_color);

            this.Controls.Add(this.label_length);

            this.Controls.Add(this.textBox_length);

            this.Controls.Add(this.comboBox_color);

            this.Controls.Add(this.label_depth);

            this.Controls.Add(this.button_clean);

            this.Controls.Add(this.panel1);

            this.Controls.Add(this.button_draw);

            this.Name = "CayleyTree";

            this.Text = "CayleyTree";

            ((System.ComponentModel.ISupportInitialize)(this.trackBar_l_a)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.trackBar_r_a)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.trackBar_r_d)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.trackBar_l_d)).EndInit();

            this.ResumeLayout(false);

            this.PerformLayout();



        }



        #endregion



        private System.Windows.Forms.Button button_clean;

        private System.Windows.Forms.Button button_draw;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label label_depth;

        private System.Windows.Forms.ComboBox comboBox_color;

        private System.Windows.Forms.TextBox textBox_length;

        private System.Windows.Forms.Label label_length;

        private System.Windows.Forms.Label label_color;

        private System.Windows.Forms.TextBox textBox_depth;

        private System.Windows.Forms.Label label_l_a;

        private System.Windows.Forms.Label label_r_a;

        private System.Windows.Forms.TrackBar trackBar_l_a;

        private System.Windows.Forms.TrackBar trackBar_r_a;

        private System.Windows.Forms.TrackBar trackBar_r_d;

        private System.Windows.Forms.TrackBar trackBar_l_d;

        private System.Windows.Forms.Label label_r_d;

        private System.Windows.Forms.Label label_l_d;

    }

}

