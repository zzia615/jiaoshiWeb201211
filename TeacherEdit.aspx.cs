﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace jiaoshiWeb
{
    public partial class TeacherEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            (this.Master as EditSite).PageTitle = "修改教师";
            if (!IsPostBack)
            {
                string code = Request.QueryString["code"];
                if (!string.IsNullOrEmpty(code))
                {
                    SqlConnection con = new SqlConnection(GlobalVal.ConStr);
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "select * from jiaoshixx where code=@code";
                    cmd.Parameters.Add(new SqlParameter("@code", code));

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        tbCode.Text = reader["code"].ToString();
                        tbName.Text = reader["name"].ToString();
                        tbSex.Text = reader["sex"].ToString();
                        tbBirtday.Text = DateTime.Parse(reader["birthday"].ToString()).ToString("yyyy-MM-dd");
                        tbPhone.Text = reader["phone"].ToString();
                        tbAddress.Text = reader["address"].ToString();
                        tbCourse.Text = reader["course"].ToString();
                    }
                    else
                    {
                        Response.Write("<script>alert('教师信息不存在');window.location.href='TeacherList.aspx'</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('教师信息不存在');window.location.href='TeacherList.aspx'</script>");
                }

            }
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
                cmd.CommandText = "update jiaoshixx set name=@name,sex=@sex,birthday=@birthday,phone=@phone,address=@address,course=@course where code=@code";
                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@sex", sex));
                cmd.Parameters.Add(new SqlParameter("@birthday", birthday));
                cmd.Parameters.Add(new SqlParameter("@phone", phone));
                cmd.Parameters.Add(new SqlParameter("@address", address));
                cmd.Parameters.Add(new SqlParameter("@course", course));
                cmd.Parameters.Add(new SqlParameter("@code", code));

                int ret = cmd.ExecuteNonQuery();
                if (ret>0)
                {
                    Response.Write("<script>alert('修改教师信息成功');window.location.href='TeacherList.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('修改教师信息失败');</script>");
                }
            }
        }
    }
}