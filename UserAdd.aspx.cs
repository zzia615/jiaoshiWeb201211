using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jiaoshiWeb
{
    public partial class UserAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as EditSite).PageTitle = "新增用户";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string code = tbCode.Text;
            string pwd = tbPwd.Text;
            string sex = tbSex.Text;
            string name = tbName.Text;
            string birthday = tbBirtday.Text;

            if (Page.IsValid)
            {
                SqlConnection con = new SqlConnection(GlobalVal.ConStr);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "insert into denglu(code,password,name,sex,birthday) values(@code,@pwd,@name,@sex,@birthday)";
                cmd.Parameters.Add(new SqlParameter("@code", code));
                cmd.Parameters.Add(new SqlParameter("@pwd", pwd));
                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@sex", sex));
                cmd.Parameters.Add(new SqlParameter("@birthday", birthday));

                int ret = cmd.ExecuteNonQuery();
                if (ret>0)
                {
                    Response.Write("<script>alert('新增用户信息成功');window.location.href='UserList.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('新增用户信息失败');</script>");
                }
            }
        }
    }
}