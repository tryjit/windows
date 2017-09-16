using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace nas
{
    public partial class 회원가입 : Form
    {
        public 회원가입()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DIDQ7GM;Initial Catalog=test;Integrated Security=False;User ID=hh4325;Password=hhh7764;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        int n1 = 0, n2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from USERINFO where Id='" + textBox2.Text + "'", con);

            DataTable newtable = new DataTable();

            sda.Fill(newtable);

            if (newtable.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("중복된 이메일이 있습니다.\n다시 입력해 주세여!");
            }
            else
            {
                n1 = 1;
                MessageBox.Show("사용 가능합니다.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda1 = new SqlDataAdapter("Select count(*) from USERINFO where name='" + textBox4.Text + "'", con);

            DataTable newtable1 = new DataTable();

            sda1.Fill(newtable1);

            if (newtable1.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("중복된 닉네임이 있습니다.\n다시 입력해 주세여!");
            }
            else
            {
                n2 = 1;
                MessageBox.Show("사용 가능합니다.");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text==textBox3.Text)//비밀번호 확인
            {
                label5.Text = "확인되었습니다.";
            }
            else
            {
                label5.Text = "다시 입력해 주십시오.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (n1 == 1) && (textBox3.Text != "") && (n2 == 1) && (label5.Text == "확인되었습니다."))
            {
                MessageBox.Show("사용 가능합니다.");
               SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO USERINFO VALUES ('"+textBox2.Text+"','"+textBox1.Text+"','"+textBox4.Text+"')", con);
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("입력해 주세요.");
            }
        }
    }
}
