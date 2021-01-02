using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace prohect_for_OOP
{
    public partial class Teaching_assistants : Form
    {
        public Teaching_assistants()
        {
            InitializeComponent();
        }
        List<Personl> assistants = new List<Personl>();
        LinkedList<Personl> obj = new LinkedList<Personl>();
        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Assistant_First_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void assistant_last_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
           
        }

        private void Save_Click(object sender, EventArgs e)
        {
            
        }

        private void Assistant_Birthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void assistant_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void assistant_phone_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void assistant_adress_TextChanged(object sender, EventArgs e)
        {

        }

        private void get_data_Click(object sender, EventArgs e)
        {

        }

        private void upload_assistant_picture_Click(object sender, EventArgs e)
        {
            
        }

        private void back_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void get_data_Click_1(object sender, EventArgs e)
        {
            Show_Teaching GetData = new Show_Teaching(assistants);
            GetData.Show();
        }

        private void Assistant_First_name_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Save_Click_1(object sender, EventArgs e)
        {
            assistants.Add(new Personl()
            {
                assistant_last_name = assistant_last_name.Text,
                Assistant_Email = assistant_email.Text,
                Assistant_First_name = Assistant_First_name.Text,
                Assistant_Number = assistant_phone_number.Text,
                assistant_address = assistant_adress.Text
            });
            obj.AddLast(new Personl()
            {
                assistant_last_name = assistant_last_name.Text,
                Assistant_Email = assistant_email.Text,
                Assistant_First_name = Assistant_First_name.Text,
                Assistant_Number = assistant_phone_number.Text,
                assistant_address = assistant_adress.Text
            });
        }

        private void clear_Click_1(object sender, EventArgs e)
        {
            assistant_email.Clear();
            assistant_last_name.Clear();
            assistant_adress.Clear();
            Assistant_First_name.Clear();
            assistant_phone_number.Clear();
            radioFemale.Checked = false;
            radioMale.Checked = false;
            Assistant_picture.Image = null;
        }

        private void upload_assistant_picture_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog m = new OpenFileDialog();
            if (m.ShowDialog() == DialogResult.OK)
            {
                Bitmap v = new Bitmap(m.FileName);
                Assistant_picture.Image = v;
            }
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
            this.Visible = false;
        }
    }
    public class Personl
    {
        public string Assistant_First_name { get; set; }
        public string assistant_last_name { get; set; }
        public string Assistant_Email { get; set; }
        public string Assistant_Number { get; set; }
        public string radioFemale { get; set; }
        public string radioMale { get; set; }
        public string assistant_address { get; set; }





    }
}
