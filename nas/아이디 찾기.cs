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
    public partial class 아이디_찾기 : Form
    {
        public 아이디_찾기()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                MessageBox.Show("본인핸드폰으로 찾기.");
            }
            if (radioButton1.Checked)
            {
                MessageBox.Show("등록된 이메일로 찾기.");
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("이름/생년월일/성별로 찾기.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.Visible = false;
            비밀번호찾기 show비밀번호찾기 = new 비밀번호찾기();
            show비밀번호찾기.ShowDialog();

        }
    }
}
