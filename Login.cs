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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name, Password;
            name = txt_Username.Text;
            Password = txt_Password.Text;

            if (name == "theteam" && Password == "12345678")
            {
                MessageBox.Show("تم تسجيل الدخول بنجاح");
                Form1 f = new Form1();
                f.Show();
            }
            else
            {
                MessageBox.Show("عرا تحقق من كلمة المرور و اسم المستخدم");

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
