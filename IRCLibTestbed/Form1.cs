using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            foreach (var str in ircl.Values)
            {
                MessageBox.Show(str);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ircl = new IRCLine(textBox2.Text);

            foreach (var str in ircl.Values)
            {
                MessageBox.Show(str);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ircl = new IRCLine(textBox3.Text);

            foreach (var str in ircl.Values)
            {
                MessageBox.Show(str);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var ircl = new IRCLine(textBox4.Text);

            foreach (var str in ircl.Values)
            {
                MessageBox.Show(str);
            }
        }
    }
}
