using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;

namespace TORES.v1
{
    public partial class TORES : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsUser user = new clsUser();
            string ad, soyad;

            ad = user.PersAd;
            soyad = user.PersSoyad;


            lbelBaslik.Text = "Merhaba " + ad + " " + soyad;


            //Student st = new Student();
            //// s1 and s2 will return null if no result found.
            //Student s1 = st.getStudent(28, "Minh Sang");
            //Student s2 = st.getByIndex(7);

            //if (s1 != null)
            //    Console.WriteLine(s1.Age);
            //Console.WriteLine(s1.Name);
            //if (s2 != null)
            //    Console.WriteLine(s2.Age);
            //Console.WriteLine(s2.Name);




            //SqlConnection connLocal = new SqlConnection();

            //connLocal.ConnectionString = "Data Source=302--00; Initial Catalog=TORESv1; User ID=sa; Password=1234;";
            ////            connLocal.ConnectionString = connStr_Local;

            //connLocal.Open();

            //SqlCommand cmd = new SqlCommand("SELECT PersAd,PersSoyad FROM datPersonel WHERE PersUID='" + kulad + "' AND PersPass='" + kulsifre + "'", connLocal);

            //SqlDataAdapter da = new SqlDataAdapter(cmd);

            //DataTable dt = new DataTable();

            //da.Fill(dt);

            //if (dt.Rows.Count > 0)
            //{

            //    Server.Transfer("Default.aspx");


            //}
            //else
            //{
            //    Server.Transfer("Hata.aspx");
            //    //Response.Redirect("Hata.aspx");
            //}
        }
    }
}