using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessCard
{
    public partial class Form1 : Form
    {
        string DirectoryPath = AppDomain.CurrentDomain.BaseDirectory;//获取程序所在路径
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDb();
            dataList.AutoGenerateColumns = false;
            dataList.DataSource = GetPeoples();
        }


        private List<People> GetPeoples(string name = "",int Id = 0)
        {
            string sql = "select * from Info where state='0' ";
            if (Id != 0)
            {
                sql += "and id=" + Id;
            }
            if (!string.IsNullOrEmpty(name))
            {
                sql += "and name like '%" + name + "%' or company like '%" + name + "%'";
            }
            DataSet info = DbHelperACE.Query(sql);
            List<People> peoples = new List<People>();
            if (info.Tables.Count >= 1)
            {
                DataTable dt = info.Tables[0];
                foreach (DataRow var in dt.Rows)
                {
                    peoples.Add(Peoples(var));
                }
            }
            return peoples;
        }


        private People Peoples(DataRow info)
        {
            DataRow dr = info;
            People people = new People()
            {
                Id = dr["id"].ToString(),
                Name = dr["name"].ToString(),
                Sex = dr["sex"].ToString(),
                Phone = dr["phone"].ToString(),
                Company = dr["company"].ToString(),
                Positions = dr["positions"].ToString(),
                Address = dr["address"].ToString(),
                CreationTime = DateTime.Parse(dr["creationtime"].ToString()),
                State = dr["state"].ToString()
            };
            return people;
        }


        /// <summary>
        /// 创建数据库
        /// </summary>
        private void CreateDb()
        {
            if (Directory.Exists(DirectoryPath + "\\Data") == false)//如果不存在就创建Data文件夹
            {
                Directory.CreateDirectory(DirectoryPath + "\\Data");
            }
            //判断文件的存在
            if (!File.Exists(DirectoryPath + "\\Data\\BC.accdb"))
            {
                // string OleDbConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = .\\Data\\BC.accdb;Jet OLEDB:Database Password = 123456";
                string OleDbConnectionString = ConfigurationManager.AppSettings["AccessConnectionString"];

                ADOX.Catalog catalog = new ADOX.Catalog();
                //创建Library数据库
                catalog.Create(OleDbConnectionString);
                //释放Catalog对Student.accdb的占用
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(catalog.ActiveConnection);
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(catalog);

                //创建表
                OleDbConnection cnn = new OleDbConnection(OleDbConnectionString);
                cnn.Open();
                string sql = "create table Info (";
                sql += "id Counter(1,1) primary key, ";
                sql += "name char(50), ";
                sql += "sex char(50), ";
                sql += "phone char(50), ";
                sql += "company char(50), ";
                sql += "positions char(50), ";
                sql += "address char(50), ";
                sql += "creationtime char(50), ";
                sql += "state char(50) ";
                sql += " )";
                OleDbCommand cmd = new OleDbCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cnn.Close();
                cnn.Dispose();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
        }

        private void search_Click(object sender, EventArgs e)
        {
            dataList.DataSource = null;
            dataList.DataSource = GetPeoples(tb_search.Text);
        }

        private void dataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataList.Columns[e.ColumnIndex].Name == "Operation")
            {
                string Id = dataList.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                Details details = new Details(Id);
                details.ShowDialog();
            }

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            dataList.DataSource = null;
            dataList.DataSource = GetPeoples();
        }
    }
}
