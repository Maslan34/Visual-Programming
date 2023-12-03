using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;

            // Creating Button OnLoad without using toolbar

         
            // Creating Button using Button class 
            Button MyButton = new Button();

            // Set the location of the button 
            MyButton.Location = new Point(555, 558);

            // Set text inside the button 
            MyButton.Text = "Submit";

            // Set the AutoSize property of the button 
            MyButton.AutoSize = true;

            // Set the background color of the button 
            MyButton.BackColor = Color.LightBlue;

            // Set the padding of the button 
            MyButton.Padding = new Padding(6);

            // Set font of the text present in the button 
            MyButton.Font = new Font("French Script MT", 18);
            
             // Add this Button to form 
             this.Controls.Add(MyButton);

            //Another Examples

            // Creating and setting the properties of label
            Label l = new Label();
            l.AutoSize = true;
            l.Text = "Do you want to submit this ?";
            l.Location = new Point(222, 145);
            l.Font = new Font("French Script MT", 18);
            // Adding this label to form  
            this.Controls.Add(l);

            // Creating and setting the properties of Button  


            Button Mybutton = new Button();
            Mybutton.Location = new Point(225, 198);
            Mybutton.Text = "Submit";
            Mybutton.AutoSize = true;
            Mybutton.BackColor = Color.LightBlue;
            Mybutton.Padding = new Padding(6);
            Mybutton.Font = new Font("French Script MT", 18);

            // Adding this button to form  
            this.Controls.Add(Mybutton);

            // Creating and setting the properties of Button  
            Button Mybutton1 = new Button();
            Mybutton1.Location = new Point(360, 198);
            Mybutton1.Text = "Cancel";
            Mybutton1.AutoSize = true;
            Mybutton1.BackColor = Color.LightPink;
            Mybutton1.Padding = new Padding(6);
            Mybutton1.Font = new Font("French Script MT", 18);

            // Adding this button to form  
            this.Controls.Add(Mybutton1);

            // Creating TextBox

            // Creating and setting the properties of Lable1  
            Label Mylablel = new Label();
            Mylablel.Location = new Point(26, 54);
            Mylablel.Text = "City";
            Mylablel.AutoSize = true;
            Mylablel.BackColor = Color.LightGray;

            // Add this label to form  
            this.Controls.Add(Mylablel);

            // Creating and setting the properties of TextBox1  
            TextBox Mytextbox = new TextBox();
            Mytextbox.Location = new Point(107, 51);
            Mytextbox.BackColor = Color.LightGray;
            Mytextbox.ForeColor = Color.DarkOliveGreen;
            Mytextbox.AutoSize = true;
            Mytextbox.Name = "text_box1";
            Mytextbox.Text = "Enter City Name...";
            Mytextbox.TextAlign = HorizontalAlignment.Center;

            // Add this textbox to form  
            this.Controls.Add(Mytextbox);

            // PASSWORD CHAR

            // Creating and setting the properties of Lable1  
            Label Mylablel1 = new Label();
            Mylablel1.Location = new Point(26, 104);
            Mylablel1.Text = "Enter Name";
            Mylablel1.AutoSize = true;
            Mylablel1.BackColor = Color.LightGray;

            // Add this label to form  
            this.Controls.Add(Mylablel1);

            // Creating and setting the properties of TextBox1  
            TextBox Mytextbox1 = new TextBox();
            Mytextbox1.Location = new Point(120, 104);
            Mytextbox1.BackColor = Color.LightGray;
            Mytextbox1.AutoSize = true;
            Mytextbox1.Name = "text_box1";

            // Add this textbox to form  
            this.Controls.Add(Mytextbox1);

            // Creating and setting the properties of Lable1  
            Label Mylablel2 = new Label();
            Mylablel2.Location = new Point(26, 152);
            Mylablel2.Text = "Enter Password";
            Mylablel2.AutoSize = true;
            Mylablel2.BackColor = Color.LightGray;



            // Add this label to form  
            this.Controls.Add(Mylablel2);

            // Creating and setting the properties of TextBox2  
            TextBox Mytextbox2 = new TextBox();
            Mytextbox2.Location = new Point(120, 150);
            Mytextbox2.BackColor = Color.LightGray;
            Mytextbox2.AutoSize = true;
            Mytextbox2.PasswordChar = '^';
            Mytextbox2.Name = "text_box2";

            // Add this textbox to form  
            this.Controls.Add(Mytextbox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
