using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // initialize for comboBox

            comboBox1.Items.Add("Man");
            comboBox1.Items.Add("Women");
            comboBox1.Items.Add("Other");
            

            // select one when onLoad

            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedItem = 0;

            // initialize for checkedListBox

            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Satruday", "Sunday" };

            checkedListBox1.Items.AddRange(days);

            checkedListBox1.SetItemChecked(5, true) ; // to select weekend at start
            checkedListBox1.SetItemChecked(6, true);
        

            textBox2.PasswordChar = '!';


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + textBox1.Text +
                " Password: " + textBox2.Text +
                " \nOccupation(RadioButton): " +
                (radioButton1.Checked == true ? "Engineer" :
                (radioButton2.Checked == true ? "Doctor" :
                (radioButton3.Checked == true ? "UnEmployed" : ""))) +
                " \nOccupation(CheckBox): " +
                (checkBox1.Checked == true ? "Engineer," :"")+
                (checkBox2.Checked == true ? "Doctor," : "") +
                (checkBox3.Checked == true ? "UnEmployed," : "")+
                " \nGender: " + comboBox1.SelectedItem+"\nSelected Days: " +Form1.findDays(checkedListBox1)
);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private static string findDays(CheckedListBox days)
        {
            string rValue = "";
            foreach (int value in days.CheckedIndices) 
            
            {
                  rValue += days.Items[value].ToString()+",";
       
            }
            return rValue;
        }
    }
}
