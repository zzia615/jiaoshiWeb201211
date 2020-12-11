using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jiaoshiWeb
{
    public partial class TeacherAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as EditSite).PageTitle = "新增教师";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string code = tbCode.Text;
            string address = tbAddress.Text;
            string phone = tbPhone.Text;
            string course = tbCourse.Text;
            string sex = tbSex.Text;
            string name = tbName.Text;
            string birthday = tbBirtday.Text;

            if (Page.IsValid)
            {
                SqlConnection con = new SqlConnection(GlobalVal.ConStr);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "insert into jiaoshixx(code,name,sex,birthday,phone,address,course) values(@code,@name,@sex,@birthday,@phone,@address,@course)";
                cmd.Parameters.Add(new SqlParameter("@code", code));
                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@sex", sex));
                cmd.Parameters.Add(new SqlParameter("@birthday", birthday));
                cmd.Parameters.Add(new SqlParameter("@phone", phone));
                cmd.Parameters.Add(new SqlParameter("@address", address));
                cmd.Parameters.Add(new SqlParameter("@course", course));

                int ret = cmd.ExecuteNonQuery();
                if (ret>0)
                {
                    Response.Write("<script>alert('新增教师信息成功');window.location.href='TeacherList.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('新增教师信息失败');</script>");
                }
            }
        }
    }
}