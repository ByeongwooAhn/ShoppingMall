using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySqlCommand = MySql.Data.MySqlClient.MySqlCommand;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;

namespace Shoppingmall
{
    public partial class Pay_m : Form
    {
        string connstr = "Server = 127.0.0.1;Port=3306;Database=member;Uid=root;Pwd=root";

        public Pay_m()
        {
            InitializeComponent();
        }

        public void member_infor()
        {
            string sql1 = "Insert Into member_pay (받는_사람, 주소, 전화번호, 결제방식)" +
                            "values ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + Pay_Card.Text + "')";
            string sql2 = "Insert Into member_pay (받는_사람, 주소, 전화번호, 결제방식)" +
                            "values ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + Pay_Cash.Text + "')";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    if (Pay_Card.Checked == true && Pay_Cash.Checked == false)
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql1, conn);
                        cmd.ExecuteNonQuery();
                    }

                    else if (Pay_Card.Checked == false && Pay_Cash.Checked == true)
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand(sql2, conn);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. 개인정보 수집목적 및 이용목적 : 비회원 구매 서비스 제공\n2. 수집하는 개인정보 항목- 주문 시, 성명, 주소, 전화번호, 이메일, 결제정보, 비회원 결제 비밀번호- 취소/교환/반품 신청 시, 환불계좌정보(은행명, 계좌번호, 예금주)\n3. 개인정보의 보유기간 및 이용기간원칙적으로, 개인정보 수집 및 이용목적이 달성된 후에는 해당 정보를 지체 없이 파기합니다.\n단, 다음의 정보에 대해서는 아래의 이유로 명시한 기간 동안 보존합니다.\n가. 회사 내부 방침에 의한 정보 보유 사유· 부정거래 방지 및 쇼핑몰 운영방침에 따른 보관 : OO년\n나. 관련 법령에 의한 정보보유 사유\no 계약 또는 청약철회 등에 관한 기록-보존이유 : 전자상거래등에서의소비자보호에관한법률-보존기간 : 5년\no 대금 결제 및 재화 등의 공급에 관한 기록-보존이유: 전자상거래등에서의소비자보호에관한법률-보존기간 : 5년\no 소비자 불만 또는 분쟁처리에 관한 기록-보존이유 : 전자상거래등에서의소비자보호에관한법률-보존기간 : 3년\no 로그 기록 -보존이유: 통신비밀보호법-보존기간 : 3개월\n※ 동의를 거부할 수 있으나 거부시 비회원 구매 서비스 이용이 불가능합니다.", "개인정보 처리방침");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                MessageBox.Show("약관에 동의해 주세요.");
            }
            else if (radioButton1.Checked == true)
            {
                member_infor();
                if (Pay_Card.Checked == true && Pay_Cash.Checked == false)
                {
                    Card_m _m = new Card_m(this);
                    _m.Show();
                }
                else if (Pay_Cash.Checked == true && Pay_Card.Checked == false)
                {
                    MessageBox.Show("결제가 완료되었습니다.\n금일 24시까지 OO은행 998877-00-123456으로 입금해 주세요");
                }
            }
        }
    }
}
