using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HMWRK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User(textBox1.Text, textBox2.Text, textBox3.Text, maskedTextBox1.Text, Vaxt.Value);
            listBox1.Items.Add(user);
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            maskedTextBox1.ResetText();
            Vaxt.ResetText();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                if (!File.Exists(textBox4.Text))
                {
                    File.WriteAllText(textBox4.Text, JsonConvert.SerializeObject(listBox1.Items));
                    listBox1.Items.Clear();
                }
                else
                {
                    MessageBox.Show("This File is Aviable");
                }
            }

            else
            {
                MessageBox.Show("!!!!");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                if (File.Exists(textBox4.Text))
                {
                    var list= JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(textBox4.Text));

                    foreach (var item in list)
                    {
                        listBox1.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("File Doesnt Exist");
                }
            }

            else
            {
                MessageBox.Show("!!!");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
