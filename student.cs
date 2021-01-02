using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prohect_for_OOP
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }
        List<Person> student2 = new List<Person>();
        LinkedList<Person> obj = new LinkedList<Person>();
        

        

        private void button3_Click(object sender, EventArgs e)
        {
            Show_STD_data obj = new Show_STD_data(student2);
            obj.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_email_st_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_name_st_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void but_clear_st_Click(object sender, EventArgs e)
        {
            text_name_st.Clear();
            text_last_st.Clear();
            text_email_st.Clear();
            text_addr_st.Clear();
            text_mobile_st.Clear();
            radio_female.Checked = false;
            redio_male.Checked = false;
            pic_st.Image = null;


        }

        private void but_save_st_Click(object sender, EventArgs e)
        {
            //Add to C# List
            student2.Add(new Person() { First_Name = text_name_st.Text, Last_Name = text_last_st.Text,Email = text_email_st.Text,Mobile = text_mobile_st.Text, Address = text_addr_st.Text });
            // Add to LinkedList
            obj.AddLast(new Person() { First_Name = text_name_st.Text,Last_Name = text_last_st.Text, Email = text_email_st.Text,Mobile = text_mobile_st.Text, Address = text_addr_st.Text});
        }

        private void back_st_Click(object sender, EventArgs e)
        {
            Form1 back1 = new Form1();
            back1.Show();
            this.Visible = false;
        }

        private void upl_st_Click(object sender, EventArgs e)
        {
            OpenFileDialog s = new OpenFileDialog();
            if (s.ShowDialog() == DialogResult.OK)
            {
                Bitmap f1 = new Bitmap(s.FileName);
                pic_st.Image = f1;
            }
        }

        private void pic_st_Click(object sender, EventArgs e)
        {

        }
    }
    public class Person
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }

    }
    class Node<H>
    {
        public H value;
        public Node<H> next;
        public Node(H s)
        {
            value = s;
            next = null;
        }
    }
    class linkedList<H>
    {
        public Node<H> start = null;
        public Node<H> tail = null;
        public void add(H data)
        {
            Node<H> m = new Node<H>(data);
            if (start == null)
            {
                start = tail = m;
            }
            else
            {
                tail.next = m;
                tail = m;
            }
        }
    }
}
