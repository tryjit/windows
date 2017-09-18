
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
    public partial class 로그인 : Form
    {
        public 로그인()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            회원가입 show회원가입 = new 회원가입();
            show회원가입.ShowDialog();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string testdata = @"Data Source=DESKTOP-DIDQ7GM;Initial Catalog=test;Integrated Security=False;User ID=hh4325;Password=hhh7764;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(testdata);
            SqlDataAdapter sda= new SqlDataAdapter("Select count(*) from USERINFO where Id='"+textBox1.Text+"' and pass='"+textBox2.Text+"'",con);
            DataTable newtable= new DataTable();
            sda.Fill(newtable);
           if (newtable.Rows[0][0].ToString() == "1")
            {
                this.Visible = false;
                웹메인 show웹메인 = new 웹메인();
                show웹메인.ShowDialog();
            }
            else
            {
                MessageBox.Show("틀렸습니다.모르면 찾으세요!!");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            아이디_찾기 show아이디찾기 = new 아이디_찾기();
            show아이디찾기.ShowDialog();
            탐색기 show탐색기 = new 탐색기();
            show탐색기.ShowDialog();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            비밀번호찾기 show비밀번호찾기 = new 비밀번호찾기();
            show비밀번호찾기.ShowDialog();
        }
    }
}
