using System;
using System.Windows.Forms;
using IRCLib;

namespace IRCLibTestbed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ircl = new IRCLine(textBox1.Text);

            MessageBox.Show(ircl.Prefix);
            MessageBox.Show(ircl.Command);
            MessageBox.Show("now for params:");
            foreach (var str in ircl.Params)
            {
                MessageBox.Show(str);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ircl = new IRCLine(textBox2.Text);

            MessageBox.Show(ircl.Prefix);
            MessageBox.Show(ircl.Command);
            MessageBox.Show("now for params:");
            foreach (var str in ircl.Params)
            {
                MessageBox.Show(str);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ircl = new IRCLine(textBox3.Text);

            MessageBox.Show(ircl.Prefix);
            MessageBox.Show(ircl.Command);
            MessageBox.Show("now for params:");
            foreach (var str in ircl.Params)
            {
                MessageBox.Show(str);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var ircl = new IRCLine(textBox4.Text);

            MessageBox.Show(ircl.Prefix);
            MessageBox.Show(ircl.Command);
            MessageBox.Show("now for params:");
            foreach (var str in ircl.Params)
            {
                MessageBox.Show(str);
            }
        }
    }
}
