using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nas
{
    public partial class 비밀번호찾기 : Form
    {
        public 비밀번호찾기()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            아이디_찾기 show아이디찾기 = new 아이디_찾기();
            show아이디찾기.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            아이디_찾기 show아이디찾기 = new 아이디_찾기();
            show아이디찾기.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                MessageBox.Show("본인핸드폰으로 찾기.");
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("등록된 이메일로 찾기.");
            }
        }
    }
}
