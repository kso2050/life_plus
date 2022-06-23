using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace youtube_db
{
	public partial class Form10 : Form
	{
		string Conn = "Server=localhost;Database=youtube;Uid=root;Pwd=0330;";
		public Form10()
		{
			InitializeComponent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(Conn))
			{
				DataSet ds = new DataSet();
				string sql = "SELECT * FROM ask";
				MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
				adpt.Fill(ds, "ask");

				//받아온 table 전체를 순회
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					//한 레코드씩 리스트뷰에 집어넣는 과정
					ListViewItem lvi = new ListViewItem();
					lvi.Text = ds.Tables[0].Rows[i]["ANum"].ToString();

					//두번째부터는 이렇게 작성
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["AName"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["AGroup"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["ACon"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["AAnswer"].ToString());


					listView1.Items.Add(lvi);

				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
			{
				MessageBox.Show("내용을 입력해주세요.");
			}
			else
			{
				//DB에 데이터 삽입
				using (MySqlConnection conn = new MySqlConnection(Conn))
				{
					conn.Open();
					MySqlCommand msc = new MySqlCommand("insert into ask(ANum, AName, AGroup, ACon) values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')", conn);
					int result = msc.ExecuteNonQuery();

					if (result == 1)
					{
						MessageBox.Show("문의사항이 작성되었습니다!");

					}
				}
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
		}
	}
}
