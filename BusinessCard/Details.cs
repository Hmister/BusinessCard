using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessCard
{
    public partial class Details : Form
    {
        string Id = string.Empty;
        public Details(string _Id)
        {
            InitializeComponent();
            Id = _Id;
        }

        private void Details_Load(object sender, EventArgs e)
        {
            var list = GetPeoples(Id);
            if (list[0] != null)
            {
                _name.Text = list[0].Name.Trim();
                _sex.Text = list[0].Sex.Trim() == "1" ? "男" : "女";
                tb_phone.Text = list[0].Phone.Trim();
                tb_company.Text = list[0].Company.Trim();
                tb_position.Text = list[0].Positions.Trim();
                tb_address.Text = list[0].Address.Trim();
            }
        }


        private List<People> GetPeoples(string Id)
        {
            string sql = "select * from Info where state='0' and id=" + Id;

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

        private void btn_del_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE Info SET state = '1' WHERE id = {Id}";
            int res = DbHelperACE.ExecuteSql(sql);
            if (res > 0)
            {
                MessageBox.Show("删除成功！");
            }
        }

        private void btn_updata_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE Info SET  phone='{tb_phone.Text}', company='{tb_company.Text}', positions='{tb_position.Text}', address='{tb_address.Text}' WHERE id = {Id}";
            int res = DbHelperACE.ExecuteSql(sql);
            if (res > 0)
            {
                MessageBox.Show("修改成功！");
            }
        }
    }
}
