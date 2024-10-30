using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //windowの大きさ固定
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            label1.Text = "現状で考えている研究テーマについて教えてください※気になっているものやキーワードでも構いません\r\n";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            MessageBox.Show("入力されたテキスト: " + inputText);
        }
        private void next_button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
