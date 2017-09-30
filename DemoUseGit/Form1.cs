using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoUseGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int soThuNhat = int.Parse(textEdit1.Text);
            int soThuHai = int.Parse(textEdit2.Text);
            int tong = soThuNhat + soThuHai;
            textEdit3.Text = tong.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soThuNhat = int.Parse(textEdit1.Text);
            int soThuHai = int.Parse(textEdit2.Text);
            int tong = soThuNhat - soThuHai;
            textEdit3.Text = tong.ToString();
        }
    }
}
