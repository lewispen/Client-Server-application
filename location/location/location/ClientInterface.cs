using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace location
{
    public partial class ClientInterface : Form
    {

        static string locationUI = null;
        static string usernameUI = null;
        static int portUI = 0;
        static string serverUI = null;
        static string protocolUI = null;
        static int timeoutUI = 0;

        List<string> sendcontent = new List<string>();

        public ClientInterface()
        {
            InitializeComponent();

        }

        private void ClientInterface_Load(object sender, EventArgs e)
        {
            //pictureBox1.SendToBack();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            usernameUI = usernameTxtbox.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (searchrdbtn.Checked == true)
            {
                serverTxtbox.Show();
                timeoutTxtbox.Show();
                portTxtbox.Show();
                label1.Show();
                label2.Show();
                label3.Show();
                label8.Show();
                panel3.Show();
                usernameTxtbox.Show();
                label4.Show();
                
            }
            else if (searchrdbtn.Checked == false)
            {
                label8.Hide();
                panel3.Hide();
                label4.Hide();
                usernameTxtbox.Clear();
                usernameTxtbox.Hide();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (changelocrdbtn.Checked == true)
            {
                serverTxtbox.Show();
                timeoutTxtbox.Show();
                portTxtbox.Show();
                label1.Show();
                label2.Show();
                label3.Show();
                label8.Show();
                panel3.Show();
                label5.Show();
                label4.Show();
                usernameTxtbox.Show();
                locationTxtbox.Show();
                
            }
            else
            {
                label8.Hide();
                panel3.Hide();
                label5.Hide();
                label4.Hide();
                usernameTxtbox.Clear();
                usernameTxtbox.Hide();
                locationTxtbox.Clear();
                locationTxtbox.Hide();
            }
        }
        static bool validinput = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (changelocrdbtn.Checked == true)
            {
                if (string.IsNullOrEmpty(usernameTxtbox.Text))
                {
                    //MessageBox.Show("ENTER A USERNAME!");
                    validinput = false;
                }
                else if (string.IsNullOrEmpty(locationTxtbox.Text))
                {
                    //MessageBox.Show("ENTER A LOCATION!");
                    validinput = false;
                }
                else if (string.IsNullOrEmpty(portTxtbox.Text))
                {
                    //MessageBox.Show("ENTER A PORT!");
                    validinput = false;
                }
                else if (string.IsNullOrEmpty(serverTxtbox.Text))
                {
                    //MessageBox.Show("ENTER A SERVER!");
                    validinput = false;
                }
                else if (string.IsNullOrEmpty(timeoutTxtbox.Text))
                {
                    //MessageBox.Show("ENTER A TIMEOUT!");
                    validinput = false;
                }
                else
                {
                    validinput = true;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(usernameTxtbox.Text))
                {
                    //MessageBox.Show("ENTER A USERNAME!");
                    validinput = false;
                }
                else if (string.IsNullOrEmpty(portTxtbox.Text))
                {
                    //MessageBox.Show("ENTER A PORT!");
                    validinput = false;
                }
                else if (string.IsNullOrEmpty(serverTxtbox.Text))
                {
                    //MessageBox.Show("ENTER A SERVER!");
                    validinput = false;
                }
                else if (string.IsNullOrEmpty(timeoutTxtbox.Text))
                {
                    //MessageBox.Show("ENTER A TIMEOUT!");
                    validinput = false;
                }
                else
                {
                    validinput = true;
                }
            }
            
            if (validinput == true)
            {
                if (locationTxtbox != null)
                {
                    locationUI = locationTxtbox.Text;
                }
                usernameUI = usernameTxtbox.Text;
                portUI = int.Parse(portTxtbox.Text);
                serverUI = serverTxtbox.Text;
                timeoutUI = int.Parse(timeoutTxtbox.Text);

                if (locationUI != "")
                {
                    //POST/PUT
                    sendcontent.Add(usernameUI.Trim());
                    sendcontent.Add(locationUI.Trim());
                    sendcontent.Add("-p");
                    sendcontent.Add(portUI.ToString().Trim());
                    sendcontent.Add("-h");
                    sendcontent.Add(serverUI.Trim());
                    sendcontent.Add("-t");
                    sendcontent.Add(timeoutUI.ToString().Trim());
                    sendcontent.Add(protocolUI);
                    this.Close();
                }
                else
                {
                    //GET
                    sendcontent.Add(usernameUI);
                    sendcontent.Add("-p");
                    sendcontent.Add(portUI.ToString());
                    sendcontent.Add("-h");
                    sendcontent.Add(serverUI);
                    sendcontent.Add("-t");
                    sendcontent.Add(timeoutUI.ToString());
                    sendcontent.Add(protocolUI);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please make sure you've entered a value for everything!");
            }
            
        }

        public List<string> GetList()
        {
            return sendcontent;
        }

        private void protocolrdbtn11_CheckedChanged(object sender, EventArgs e)
        {
            if (protocolrdbtn11.Checked == true)
            {
                protocolUI = "-h1";
                submitbtn.Show();
            }
        }

        private void locationTxtbox_TextChanged(object sender, EventArgs e)
        {
            locationUI = locationTxtbox.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void protocolrdbtn10_CheckedChanged(object sender, EventArgs e)
        {
            if (protocolrdbtn10.Checked == true)
            {
                protocolUI = "-h0";
                submitbtn.Show();
            }
        }

        private void protocolrdbtn09_CheckedChanged(object sender, EventArgs e)
        {
            if (protocolrdbtn09.Checked == true)
            {
                protocolUI = "-h9";
                submitbtn.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void usernameTxtbox_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void locationTxtbox_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void serverTxtbox_Validating(object sender, CancelEventArgs e)
        {
            

        }

        private void timeoutTxtbox_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void portTxtbox_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                protocolUI = "whois";
                submitbtn.Show();
            }
        }

        private void serverTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void protocollbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void portTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
