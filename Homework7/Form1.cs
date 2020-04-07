using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;



namespace Example7_1

{

    public partial class CayleyTree : Form

    {

        private Graphics graphics;

        double th1;//30 * Math.PI / 180;

        double th2;//20 * Math.PI / 180;

        double per1;//0.6;

        double per2;//0.7;

        int depth;

        double length;

        Pen pen;



        public CayleyTree()

        {

            InitializeComponent();

            graphics = panel1.CreateGraphics();

            comboBox_color.Text = "black";

            textBox_length.Text = "100";

            textBox_depth.Text = "10";

            trackBar_l_a.Value = 6;

            trackBar_r_a.Value = 7;

            trackBar_l_d.Value = 3;

            trackBar_r_d.Value = 2;

            th1 = 30 * Math.PI / 180;

            th2 = 20 * Math.PI / 180;

            per1 = 0.6;

            per2 = 0.7;

            depth = 100;

            length = 10;

            pen = Pens.Black;

        }



        void DrawCayleyTree(int n, double x0, double y0, double leng, double th)

        {

            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);

            double y1 = y0 + leng * Math.Sin(th);

            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);

            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);

            DrawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);

        }



        private void button_clean_Click(object sender, EventArgs e)

        {

            graphics.Clear(Color.White);

        }



        private void button_draw_Click(object sender, EventArgs e)

        {

            try

            {

                depth = int.Parse(textBox_depth.Text);

                length = double.Parse(textBox_length.Text);

                if (depth < 0 || length < 0)

                {

                    MessageBox.Show("Data Error!");

                    return;

                }

            }

            catch (FormatException)

            {

                MessageBox.Show("Format Error!");

                return;

            }

            DrawCayleyTree(depth, 300, 400, length, -Math.PI / 2);

        }



        private void comboBox_color_SelectedIndexChanged(object sender, EventArgs e)

        {

            switch (comboBox_color.Text)

            {

                case "black":

                    pen = Pens.Black;

                    break;

                case "red":

                    pen = Pens.Red;

                    break;

                case "yellow":

                    pen = Pens.Yellow;

                    break;

                case "green":

                    pen = Pens.Green;

                    break;

                case "blue":

                    pen = Pens.Blue;

                    break;

                default:

                    pen = Pens.Black;

                    break;

            }

        }



        private void panel1_Paint(object sender, PaintEventArgs e)

        {

            graphics.Clear(Color.White);

        }



        private void trackBar_l_a_Scroll(object sender, EventArgs e)

        {

            per1 = (double)trackBar_l_a.Value / (trackBar_l_a.Maximum - trackBar_l_a.Minimum);

        }



        private void trackBar_r_a_Scroll(object sender, EventArgs e)

        {

            per2 = (double)trackBar_r_a.Value / (trackBar_r_a.Maximum - trackBar_r_a.Minimum);

        }



        private void trackBar_l_d_Scroll(object sender, EventArgs e)

        {

            th1 = (double)trackBar_l_d.Value / (trackBar_l_d.Maximum - trackBar_l_d.Minimum) * Math.PI;

        }



        private void trackBar_r_d_Scroll(object sender, EventArgs e)

        {

            th2 = (double)trackBar_r_d.Value / (trackBar_r_d.Maximum - trackBar_r_d.Minimum) * Math.PI;

        }



    }

}
}
