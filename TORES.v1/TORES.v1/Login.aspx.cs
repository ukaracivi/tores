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
    public partial class Login : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            lbelKulAd.Font.Bold = true;
            lbelKulSifre.Font.Bold = true;
        }

        protected void btonOK_Click(object sender, EventArgs e)
        {
            // textbox a girilen değerler db den kontrol ediliyor...
            string kulad, kulsifre;

            kulad = tboxKulAd.Text.Trim();
            kulsifre = tboxKulSifre.Text.Trim();


            SqlConnection connLocal = new SqlConnection();

            connLocal.ConnectionString = "Data Source=302--00; Initial Catalog=TORESv1; User ID=sa; Password=1234;";
//            connLocal.ConnectionString = connStr_Local;

            connLocal.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM datPersonel WHERE PersUID='" + kulad + "' AND PersPass='" + kulsifre + "'", connLocal);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                Server.Transfer("Default.aspx");


            }
            else
            {
                Server.Transfer("Hata.aspx");
                //Response.Redirect("Hata.aspx");
            }

            connLocal.Close();



        }
    }
}