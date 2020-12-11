using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jiaoshiWeb
{
    public partial class TeacherList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as MainSite).PageTitle = "教师信息";
            if (!IsPostBack)
            {
                Button1_Click(null, null);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(GlobalVal.ConStr);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            string sql = "select * from jiaoshixx where 1=1";

           
            if (!string.IsNullOrWhiteSpace(tbCode.Text))
            {
                sql += " and code=@code";
                cmd.Parameters.Add(new SqlParameter("@code", tbCode.Text));
            }

            if (!string.IsNullOrWhiteSpace(tbName.Text))
            {
                sql += " and name like @name";
                cmd.Parameters.Add(new SqlParameter("@name", "%"+tbName.Text+"%"));
            }

            if (!string.IsNullOrWhiteSpace(DropDownList1.Text))
            {
                sql += " and sex=@sex";
                cmd.Parameters.Add(new SqlParameter("@sex", DropDownList1.Text));
            }

            cmd.CommandText = sql;
            SqlDataAdapter dapt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            dapt.Fill(table);
            GridView1.DataSource = table;
            GridView1.DataBind();
        }
    }
}