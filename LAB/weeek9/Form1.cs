using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace weeek9
{
    public partial class Form1 : Form
    {

        int deletionProcess = 0;
        public Form1()
        {
            InitializeComponent();
            string[] positions = { "Doctor", "Engineer", "Police" };
            comboBox1.Items.AddRange(positions);
            label6.Text = "0";
            
      
        }

        OleDbConnection accessCon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=your_data_base");
        private void showInformation()
        {
           
            //listView1.Columns.Add("ID");
            //listView1.Columns.Add("Name");
            //listView1.Columns.Add("Surname");
            //listView1.Columns.Add("Mail");
            //listView1.Columns.Add("Position");


            // Delete ListView before showing Informations;
            listView1.Items.Clear();
            // Delete ListView before showing Informations;


            accessCon.Open();
            OleDbCommand AccessCommand = new OleDbCommand();
            AccessCommand.Connection = accessCon;
            AccessCommand.CommandText = ("Select * from Person");
            OleDbDataReader read = AccessCommand.ExecuteReader();


            while (read.Read())
            {
                ListViewItem addNew = new ListViewItem();

             
                //addNew.Text = read["ID"].ToString();
                addNew.SubItems.Add(read["ID"].ToString());
                addNew.SubItems.Add(read["fName"].ToString()); 
                addNew.SubItems.Add(read["sName"].ToString());
                addNew.SubItems.Add(read["pMail"].ToString());
                addNew.SubItems.Add(read["pPosition"].ToString());

                listView1.Items.Add(addNew);
            }
            accessCon.Close();
            clearAllInputs();
            updateRecordNumber();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // INDEX -> 0 COMBO BOX , INDEX -> 1 ID  (WE SKIPPED THEM)

            if (deletionProcess != 1)
            {
                textBox1.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[2].Text;
                textBox2.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[3].Text;
                textBox3.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[4].Text;
                comboBox1.Text = listView1.Items[listView1.FocusedItem.Index].SubItems[5].Text;

            }

           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showInformation();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int checkedNumber = listView1.CheckedItems.Count;
            foreach (ListViewItem item in listView1.CheckedItems) {


                // Storing item's Id before deleting it.
                string id = item.SubItems[1].Text;
                accessCon.Open();
                string sqlText = "DELETE FROM Person WHERE Id = " + id + " ";

                OleDbCommand AccessCommand = new OleDbCommand(sqlText, accessCon);

                AccessCommand.ExecuteNonQuery();
                accessCon.Close();

                showInformation();
                clearAllInputs();
                item.Remove();
                updateRecordNumber();

               
            }

            MessageBox.Show(checkedNumber + " Tane Kayıt Silindi.");
            updateRecordNumber();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addRecord();
        }

 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

  

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[2].Text == textBox4.Text)
                    MessageBox.Show("Değer Bulundu!\nİsim:"+
                        listView1.Items[i].SubItems[1].Text+
                        "Soy isim: "+
                        listView1.Items[i].SubItems[2].Text +
                        "Mail:"+
                        listView1.Items[i].SubItems[3].Text
                        );
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            updateRecordNumber();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateRecord();           
        }

        private void updateRecordNumber()
        {

            label6.Text = listView1.Items.Count.ToString();

        }

        

        

        private void button7_Click(object sender, EventArgs e)
        {
            deletionProcess = 1;
            deleteRecord();
            deletionProcess = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void updateRecord()
        {

            String name = textBox1.Text;
            String surname = textBox2.Text;
            String mail = textBox3.Text;
            String position = comboBox1.Text;
            String Id = listView1.Items[listView1.FocusedItem.Index].SubItems[1].Text;

            accessCon.Open();
            string sqlText = "   UPDATE Person SET fName = '" + name + "', sName = '" + surname + "', pMail = '" + mail + "' , pPosition = '" + position + "' WHERE Id = " + Id + " ";
            Console.WriteLine(sqlText);
            OleDbCommand AccessCommand = new OleDbCommand(sqlText, accessCon);

            AccessCommand.ExecuteNonQuery();
            accessCon.Close();

            listView1.Clear();
            clearAllInputs();
            comboBox1.Refresh();

            showInformation();
            updateRecordNumber();

        }

        private void addRecord()
        {
            String name = textBox1.Text;
            String surname = textBox2.Text;
            String mail = textBox3.Text;
            String position = comboBox1.Text;

            accessCon.Open();
            string sqlText = "INSERT INTO Person (fName,sName,pMail,pPosition) values('   " + name + "  '  ,  '  " + surname + "  ' , ' " + mail + "  '  ,   '" + position + "' )";
            OleDbCommand AccessCommand = new OleDbCommand(sqlText, accessCon);
            AccessCommand.ExecuteNonQuery();
            accessCon.Close();

            clearAllInputs();
            showInformation();

            updateRecordNumber();
        }

        private void deleteRecord()
        {
            int selectedNumber = listView1.SelectedItems.Count;
            foreach (ListViewItem item in listView1.SelectedItems)
            {


                // Storing item's Id before deleting it.
                string id = item.SubItems[1].Text;
                Console.WriteLine(id);
                accessCon.Open();
                string sqlText = "DELETE FROM Person WHERE Id = " + id + " ";

                OleDbCommand AccessCommand = new OleDbCommand(sqlText, accessCon);
                AccessCommand.ExecuteNonQuery();
                accessCon.Close();

                showInformation();
                clearAllInputs();
                item.Remove();
                
            }
            MessageBox.Show(selectedNumber + " Tane Kayıt Silindi.");
            updateRecordNumber();
        }

        private void clearAllInputs() {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text=string.Empty;

        }
    }
}
