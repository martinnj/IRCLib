using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using IRCLib;

namespace IRCLibTestbed
{
    public partial class Form1 : Form
    {
        private Connection _con;
        public Form1()
        {
            InitializeComponent();
            var nicks = new List<string> { "IRCLIBtester" , "IRCLibTester123", "IRCLibTesterTest" };
            var conf = new ConnectionConfig("chat.freenode.net",
                6666,
                "conpass",
                "someuser",
                "Flanker IRCLibtest",
                nicks);
            _con = new Connection(conf);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _con.Send(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _con.Close("Leaving for now.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var message = _con.ReadLine();
            while (message != null)
            {
                
                richTextBox1.Text = richTextBox1.Text + message + Environment.NewLine;
                message = _con.ReadLine();
            }
        }
    }
}
