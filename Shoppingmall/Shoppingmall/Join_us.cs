using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;

namespace Shoppingmall
{
    public partial class Join_us : Form
    {
        string connstr = "Server = 127.0.0.1;Port=3306;Database=member;Uid=root;Pwd=root";

        public Join_us()
        {
            InitializeComponent();
        }

        public void SignUp()
        {
            string sql = "Insert Into member_name (아이디, 비밀번호, 질문, 답변, 주소, 핸드폰, 이메일)" +
                "values ('" + ID.Text + "', '" + PW.Text + "', '" + PW_Q.Text + "', '" + PW_A.Text + "', '" + Address.Text + "', '" + Phone.Text + "', '" + E_mail.Text + "')";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void REGISTER_Click(object sender, EventArgs e)
        {
            SignUp();
            MessageBox.Show("정상적으로 회원가입이 완료 되었습니다.", "알림");
            Close();
            
        }
    }
}
