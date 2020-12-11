using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jiaoshiWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as EditSite).PageTitle = "用户登录";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string code = tbCode.Text;
            string pwd = tbPwd.Text;

            if (Page.IsValid)
            {
                SqlConnection con = new SqlConnection(GlobalVal.ConStr);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select * from denglu where code=@code and password=@pwd";
                cmd.Parameters.Add(new SqlParameter("@code", code));
                cmd.Parameters.Add(new SqlParameter("@pwd", pwd));

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Response.Write("<script>alert('登录成功');window.location.href='Home.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('账号密码输入有误，请重试');window.location.href='Default.aspx'</script>");
                }
            }
        }
    }
}