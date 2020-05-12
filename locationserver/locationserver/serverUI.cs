using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace locationserver
{
    public partial class serverUI : Form
    {
        List<string> changecontent = new List<string>();
        public serverUI()
        {
            InitializeComponent();
        }

        private void serverUI_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Unable to Retreive content";
            textBox2.Text = "Unable to Retreive Content";
        }

        public List<string> GetList()
        {
            return changecontent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
