using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Drinago
{
    public partial class Feedback : System.Web.UI.Page
    {
        SqlConnection vid = new SqlConnection("data source=drinago.database.windows.net;initial catalog=Users;user id=drinagoadmin;password=Digitalni2k;MultipleActiveResultSets=True;App=EntityFramework");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            string str = "select * from komentari where (Name like '%' + @search + '%')";
            SqlCommand xp = new SqlCommand(str, vid);
            xp.Parameters.Add("@search", SqlDbType.NVarChar).Value = TextBox1.Text;
            vid.Open();
            xp.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = xp;
            DataSet ds = new DataSet();
            da.Fill(ds, "Name");
            GridView1.DataSource = ds;
            GridView1.DataBind();
            vid.Close();
        }
    }
}