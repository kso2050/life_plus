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
	public partial class Form7 : Form
	{
		string Conn = "Server=localhost;Database=youtube;Uid=root;Pwd=0330;";
		public Form7()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (MySqlConnection conn = new MySqlConnection(Conn))
			{


				if (textBox1.Text == "***")
				{
					MessageBox.Show("로그인 성공");
					this.Dispose();
					new Form6().ShowDialog();

				}
				else
				{
					MessageBox.Show("로그인 실패");
				}
			}
			
			
		}
	}
}
