using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace week10
{
    public partial class Form1 : Form
    {

        float pr1, pr2, pr3;
       
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            this.MouseMove += Form1_MouseMove;

        }



        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            float r1, r2, r3, total;

            r1 = int.Parse(textBox1.Text);
            r2 = int.Parse(textBox2.Text);
            r3 = int.Parse(textBox3.Text);

            total = r1 + r2 + r3;


            pr1 = (r1 / total) * 360;
            pr2 = (r2 / total) * 360;
            pr3 = (r3 / total) * 360;

            Pen p = new Pen(Form1.DefaultBackColor);
            if (checkBox1.Checked == true)
            {
                p.Color = Color.Black;
                p.Width = 8;


            }
            else
            {
                p.Color = Form1.DefaultBackColor;
                p.Width = 40;
            }


            Graphics areaGreen = this.CreateGraphics();
            Graphics areaRed = this.CreateGraphics();
            Graphics areaOrange = this.CreateGraphics();

          
            Rectangle recGreen = new Rectangle(button1.Location.X + button1.Size.Width + 300, 80, 250, 250);
            Rectangle recRed = new Rectangle(button1.Location.X + button1.Size.Width + 300, 80, 250, 250);
            Rectangle recOrange = new Rectangle(button1.Location.X + button1.Size.Width + 300, 80, 250, 250);

            Brush b1 = new SolidBrush(Color.Green);
            Brush b2 = new SolidBrush(Color.Red);
            Brush b3 = new SolidBrush(Color.Orange);

         
            
            areaGreen.DrawPie(p, recGreen, 0, pr1);
            areaGreen.FillPie(b1, recGreen, 0, pr1);

            areaRed.DrawPie(p, recRed, pr1, pr2);
            areaRed.FillPie(b2, recRed, pr1, pr2);

            areaOrange.DrawPie(p, recOrange, pr1 + pr2, pr3);
            areaOrange.FillPie(b3, recOrange, pr1 + pr2, pr3);

            /*
            Pen rectPenGreen = new Pen(Color.Green, 2);
            Pen rectPenRed = new Pen(Color.Red, 2);
            Pen rectPenOrange = new Pen(Color.Orange, 2);
            areaGreen.DrawRectangle(rectPenGreen, recGreen);
            areaRed.DrawRectangle(rectPenRed, recRed);
            areaOrange.DrawRectangle(rectPenOrange, recOrange);*/

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsPointInsidePieSlice(e.Location))
            {

                label6.Text = "Yeşil: " + pr1.ToString() + "\n" + "Kırmızı: " + pr2.ToString() + "\n" + "Turuncu" + pr3.ToString();
            }
            else { label6.Text = "Yeşil: " + "0" + "\n" + "Kırmızı: " + "0" + "\n" + "Turuncu" + "0"; }
        }


        
        private bool IsPointInsidePieSlice(Point point)
        {
            Rectangle recGreen = new Rectangle(button1.Location.X + button1.Size.Width + 300, 80, 250, 250);
            Rectangle recRed = new Rectangle(button1.Location.X + button1.Size.Width + 300, 80, 250, 250);
            Rectangle recOrange = new Rectangle(button1.Location.X + button1.Size.Width + 300, 80, 250, 250);
            

            if (recGreen.Contains(point))
            {

                return true;
            }
            else if (recRed.Contains(point))
            {
                
                return true;
            }
            else if (recOrange.Contains(point))
            {

                return true;
            }

            return false;
        }

      

    } 
} 



