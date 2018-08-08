using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineRemover
{
    public partial class Form1 : Form
    {
        private string[] lines;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                var input = File.ReadAllText(openFileDialog.FileName);
                textBox1.Text = input;
                lines = input.Split(new[] {"\r\n", "\r", "\n"}, StringSplitOptions.None);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox2.Text))
            {
                lines = lines.Where(l => l.Contains(textBox2.Text)).ToArray();
                textBox1.Text = String.Join("\r\n", lines);
            }
        }
    }
}
