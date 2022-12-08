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
    public partial class Not_Member : Form
    {
        string connstr = "Server = 127.0.0.1;Port=3306;Database=member;Uid=root;Pwd=root";

        public Not_Member()
        {
            InitializeComponent();
        }

        public Login login;

        public DataSet Order_Search()
        {
            string sql = "select 상품명 from member_not where 받는_사람 = '" + groupBox2.Text + "' and 비밀번호 = '" + login.textBox5.Text + "'";
            DataSet ds = new DataSet();

            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { }
            }
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {

                    {
                        conn.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                        da.Fill(ds);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return ds;
        }
        public void Order_Load()
        {
            DataSet ds;
            ds = Order_Search();

            int number = 0;

            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            number++;

                            Label labels = (Controls.Find("List" + number.ToString(), true)[0] as Label);
                            labels.Text = row["상품명"].ToString();

                            /*if(number == 1)
                            {
                                List1.Text = row["상품명"].ToString();
                            }
                            else if (number == 2)
                            {
                                List2.Text = row["상품명"].ToString();
                            }
                            else if (number == 3)
                            {
                                List3.Text = row["상품명"].ToString();
                            }
                            else if (number == 4)
                            {
                                List4.Text = row["상품명"].ToString();
                            }
                            else if (number == 5)
                            {
                                List5.Text = row["상품명"].ToString();
                            }
                            else if (number == 6)
                            {
                                List6.Text = row["상품명"].ToString();
                            }*/
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public void Order1()
        {
            string sql = "select 가격, 결제방식, 은행, 카드번호1, 카드번호2, 카드번호3, 카드번호4, 받는_사람, 주소 from member_not where 받는_사람 = '" + groupBox2.Text + "' and 상품명 = '" + List1.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    label5.Text = reader["가격"].ToString();
                    label2.Text = reader["결제방식"].ToString();
                    label7.Text = reader["은행"].ToString();
                    label8.Text = (reader["카드번호1"].ToString() + " - " + reader["카드번호2"].ToString() + " - " + reader["카드번호3"].ToString() + " - " + reader["카드번호4"].ToString());
                    label10.Text = reader["받는_사람"].ToString();
                    label12.Text = reader["주소"].ToString();

                    if(label2.Text == "무통장 입금")
                    {
                        label6.Text = "입금 계좌";
                        label7.Text = "OO은행";
                        label8.Text = "998877-00-123456";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Order2()
        {
            string sql = "select 가격, 결제방식, 은행, 카드번호1, 카드번호2, 카드번호3, 카드번호4, 받는_사람, 주소 from member_not where 받는_사람 = '" + groupBox2.Text + "' and 상품명 = '" + List2.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    label5.Text = reader["가격"].ToString();
                    label2.Text = reader["결제방식"].ToString();
                    label7.Text = reader["은행"].ToString();
                    label8.Text = (reader["카드번호1"].ToString() + " - " + reader["카드번호2"].ToString() + " - " + reader["카드번호3"].ToString() + " - " + reader["카드번호4"].ToString());
                    label10.Text = reader["받는_사람"].ToString();
                    label12.Text = reader["주소"].ToString();

                    if (label2.Text == "무통장 입금")
                    {
                        label6.Text = "입금 계좌";
                        label7.Text = "OO은행";
                        label8.Text = "998877-00-123456";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Order3()
        {
            string sql = "select 가격, 결제방식, 은행, 카드번호1, 카드번호2, 카드번호3, 카드번호4, 받는_사람, 주소 from member_not where 받는_사람 = '" + groupBox2.Text + "' and 상품명 = '" + List3.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    label5.Text = reader["가격"].ToString();
                    label2.Text = reader["결제방식"].ToString();
                    label7.Text = reader["은행"].ToString();
                    label8.Text = (reader["카드번호1"].ToString() + " - " + reader["카드번호2"].ToString() + " - " + reader["카드번호3"].ToString() + " - " + reader["카드번호4"].ToString());
                    label10.Text = reader["받는_사람"].ToString();
                    label12.Text = reader["주소"].ToString();

                    if (label2.Text == "무통장 입금")
                    {
                        label6.Text = "입금 계좌";
                        label7.Text = "OO은행";
                        label8.Text = "998877-00-123456";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Order4()
        {
            string sql = "select 가격, 결제방식, 은행, 카드번호1, 카드번호2, 카드번호3, 카드번호4, 받는_사람, 주소 from member_not where 받는_사람 = '" + groupBox2.Text + "' and 상품명 = '" + List4.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    label5.Text = reader["가격"].ToString();
                    label2.Text = reader["결제방식"].ToString();
                    label7.Text = reader["은행"].ToString();
                    label8.Text = (reader["카드번호1"].ToString() + " - " + reader["카드번호2"].ToString() + " - " + reader["카드번호3"].ToString() + " - " + reader["카드번호4"].ToString());
                    label10.Text = reader["받는_사람"].ToString();
                    label12.Text = reader["주소"].ToString();

                    if (label2.Text == "무통장 입금")
                    {
                        label6.Text = "입금 계좌";
                        label7.Text = "OO은행";
                        label8.Text = "998877-00-123456";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Order5()
        {
            string sql = "select 가격, 결제방식, 은행, 카드번호1, 카드번호2, 카드번호3, 카드번호4, 받는_사람, 주소 from member_not where 받는_사람 = '" + groupBox2.Text + "' and 상품명 = '" + List5.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    label5.Text = reader["가격"].ToString();
                    label2.Text = reader["결제방식"].ToString();
                    label7.Text = reader["은행"].ToString();
                    label8.Text = (reader["카드번호1"].ToString() + " - " + reader["카드번호2"].ToString() + " - " + reader["카드번호3"].ToString() + " - " + reader["카드번호4"].ToString());
                    label10.Text = reader["받는_사람"].ToString();
                    label12.Text = reader["주소"].ToString();

                    if (label2.Text == "무통장 입금")
                    {
                        label6.Text = "입금 계좌";
                        label7.Text = "OO은행";
                        label8.Text = "998877-00-123456";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Order6()
        {
            string sql = "select 가격, 결제방식, 은행, 카드번호1, 카드번호2, 카드번호3, 카드번호4, 받는_사람, 주소 from member_not where 받는_사람 = '" + groupBox2.Text + "' and 상품명 = '" + List6.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
 
                    label5.Text = reader["가격"].ToString();
                    label2.Text = reader["결제방식"].ToString();
                    label7.Text = reader["은행"].ToString();
                    label8.Text = (reader["카드번호1"].ToString() + " - " + reader["카드번호2"].ToString() + " - " + reader["카드번호3"].ToString() + " - " + reader["카드번호4"].ToString());
                    label10.Text = reader["받는_사람"].ToString();
                    label12.Text = reader["주소"].ToString();

                    if (label2.Text == "무통장 입금")
                    {
                        label6.Text = "입금 계좌";
                        label7.Text = "OO은행";
                        label8.Text = "998877-00-123456";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Order7()
        {
            string sql = "select 가격, 결제방식, 은행, 카드번호1, 카드번호2, 카드번호3, 카드번호4, 받는_사람, 주소 from member_not where 받는_사람 = '" + groupBox2.Text + "' and 상품명 = '" + List7.Text + "'";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    label5.Text = reader["가격"].ToString();
                    label2.Text = reader["결제방식"].ToString();
                    label7.Text = reader["은행"].ToString();
                    label8.Text = (reader["카드번호1"].ToString() + " - " + reader["카드번호2"].ToString() + " - " + reader["카드번호3"].ToString() + " - " + reader["카드번호4"].ToString());
                    label10.Text = reader["받는_사람"].ToString();
                    label12.Text = reader["주소"].ToString();

                    if (label2.Text == "무통장 입금")
                    {
                        label6.Text = "입금 계좌";
                        label7.Text = "OO은행";
                        label8.Text = "998877-00-123456";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Not_Member_Load(object sender, EventArgs e)
        {
            Order_Load();
        }

        private void List1_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            Order1();
        }

        private void List2_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            Order2();
        }

        private void List3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            Order3();
        }

        private void List4_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            Order4();
        }

        private void List5_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            Order5();
        }

        private void List6_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            Order6();
        }

        private void List7_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            Order7();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
