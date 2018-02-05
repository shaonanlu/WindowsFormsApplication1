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
            txtacc.Focus();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (驗證帳號密碼(txtacc.Text,txtpwd.Text))
            {
                /*新增一個MDI Child，登入介面需隱藏。
                  
                */
            }
        }

        private bool 驗證帳號密碼(string text1, string text2)
        {
            return true;
        }
    }
}
