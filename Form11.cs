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
	public partial class Form11 : Form
	{
		string Conn = "Server=localhost;Database=youtube;Uid=root;Pwd=0330;";
		public Form11()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(Conn))
			{
				DataSet ds = new DataSet();
				string sql = "SELECT * FROM notice";
				MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
				adpt.Fill(ds, "notice");

				//받아온 table 전체를 순회
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					//한 레코드씩 리스트뷰에 집어넣는 과정
					ListViewItem lvi = new ListViewItem();
					lvi.Text = ds.Tables[0].Rows[i]["NNum"].ToString();

					//두번째부터는 이렇게 작성
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["NName"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["NGroup"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["NCon"].ToString());

					listView1.Items.Add(lvi);

				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(Conn))
			{
				DataSet ds = new DataSet();

				string combo = comboBox1.SelectedItem.ToString();
				string sql = "select * from notice where NGroup = '" + combo + "'";
				MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
				adpt.Fill(ds, "notice");


				//받아온 결과를 리스트뷰2에 출력
				//받아온 table 전체를 순회
				for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
				{
					//한 레코드씩 리스트뷰에 집어넣는 과정
					ListViewItem lvi = new ListViewItem();
					lvi.Text = ds.Tables[0].Rows[i]["Nnum"].ToString();

					lvi.SubItems.Add(ds.Tables[0].Rows[i]["Nname"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["NGroup"].ToString());
					lvi.SubItems.Add(ds.Tables[0].Rows[i]["NCon"].ToString());
					

					listView1.Items.Add(lvi);
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
