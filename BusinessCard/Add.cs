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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_name.Text))
            {
                MessageBox.Show("请填写姓名！");
            }
            if (string.IsNullOrEmpty(tb_phone.Text))
            {
                MessageBox.Show("请填写手机号！");
            }
            string sex = "1";
            if (rb_woman.Checked)
            {
                sex = "2";
            }

            string sql = "INSERT INTO Info(name,sex,phone,company,positions,address,creationtime,state) ";
            sql += $"VALUES ('{tb_name.Text}','{sex}','{tb_phone.Text}','{tb_company.Text}','{tb_position.Text}','{tb_address.Text}','{DateTime.Now}','0') ";
            int res = DbHelperACE.ExecuteSql(sql);
            if (res > 0)
            {
                MessageBox.Show("新增成功！");
            }

        }
    }
}
