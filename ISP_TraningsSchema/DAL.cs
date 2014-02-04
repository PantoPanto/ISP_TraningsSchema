using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace ISP_TraningsSchema
{

    class DAL
    {

         private Controller ctrl;

        public DAL(Controller ctrl)
        {
            this.ctrl = ctrl;
        }

    public static void getAll()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=ICSSQL12\\Grupp12,1512,;Initial Catalog=ISP;Integrated Security=True";
        con.Open();
        SqlCommand command = new SqlCommand("SELECT * FROM TestDb2", con);
        SqlDataReader reader = command.ExecuteReader();
     
        while (reader.Read())
		{
        	System.Windows.Forms.MessageBox.Show(reader.GetString(0)+reader.GetString(1));
        }
      

    }


    }


}
