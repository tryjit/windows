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
    public partial class 웹메인 : Form
    {


        public 웹메인()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            로그인 show로그인 = new 로그인();
            show로그인.ShowDialog();
        }

          

          private void 웹메인_Load_1(object sender, EventArgs e)
          {
              // TODO: 이 코드는 데이터를 'testDataSet1.Table' 테이블에 로드합니다. 필요한 경우 이 코드를 이동하거나 제거할 수 있습니다.
           

          }

     
    }
    }

