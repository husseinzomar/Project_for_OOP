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
    public partial class Lessons : Form
    {
        string cor;
        public Lessons()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinkedList<string> obj3 = new

            LinkedList<string>();
            obj3.AddLast(cor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Home frm = new Home();
            frm.Show();
        }

        private void Lessons_Load(object sender, EventArgs e)
        {

        }
    }
}
