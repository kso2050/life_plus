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
	public partial class Form8 : Form
	{
		string Conn = "Server=localhost;Database=youtube;Uid=root;Pwd=0330;";
		public Form8()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(Conn))
			{
				DataSet ds = new DataSet();
				string sql = "SELECT * FROM play";
				MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
				adpt.Fill(ds, "play");

				//받아온 table 전체를 순회
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					//한 레코드씩 리스트뷰에 집어넣는 과정
					ListViewItem lvi = new ListViewItem();
					lvi.Text = ds.Tables[0].Rows[i]["PNum"].ToString();

					//두번째부터는 이렇게 작성
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["PName"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["PCon"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["PAll"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["PTime"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["PTag"].ToString());


					listView1.Items.Add(lvi);

				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
			{
				MessageBox.Show("내용이 입력되지 않았습니다.");
			}
			else
			{

				using (MySqlConnection conn = new MySqlConnection(Conn))
				{
					conn.Open();
					MySqlCommand msc = new MySqlCommand("insert into play(PNum, PName, PCon, PAll, PTime, PTag) values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')", conn);
					int result = msc.ExecuteNonQuery();

					if (result == 1)
					{
						MessageBox.Show("저장되었습니다!");
					}
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(Conn))
			{
				DataSet ds = new DataSet();

				string combo = comboBox1.SelectedItem.ToString();
				string sql = "select * from play where PTag = '" + combo + "'";
				MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
				adpt.Fill(ds, "play");


				//받아온 결과를 리스트뷰2에 출력
				//받아온 table 전체를 순회
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					//한 레코드씩 리스트뷰에 집어넣는 과정
					ListViewItem lvi = new ListViewItem();
					lvi.Text = ds.Tables[0].Rows[i]["Pnum"].ToString();

					lvi.SubItems.Add(ds.Tables[0].Rows[i]["Pname"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["PCon"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["PAll"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["PTime"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["PTag"].ToString());

					listView1.Items.Add(lvi);
				}
			}
		}
	}
}
