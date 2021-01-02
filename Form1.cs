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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            student obj = new student();
            obj.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Exite","Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Login log = new Login();
                log.Show();
                this.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teaching_assistants t = new Teaching_assistants();
            t.Show();
            this.Visible = false;
        }
    }
}
