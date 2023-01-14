using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClassLibraryDAL;

namespace ClassLibraryModel
{
    public class ReportNewThreatDAL
    {
        public static int SaveRNT(ReportNewThreatModel RNT)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("SaveRNT", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", RNT.Name);
            cmd.Parameters.AddWithValue("@email", RNT.Email);
            cmd.Parameters.AddWithValue("@TD", RNT.ThreatDescription);
            int i= cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public static List<ReportNewThreatModel> GetRNT()
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("ReturnRNT", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            List<ReportNewThreatModel> RNT = new List<ReportNewThreatModel>();
            while (reader.Read())
            {
                ReportNewThreatModel RNTD = new ReportNewThreatModel();
                RNTD.ThreatId = int.Parse(reader["NewThreatID"].ToString());
                RNTD.Name = reader["Name"].ToString();
                RNTD.Email = reader["Email"].ToString();
                RNTD.ThreatDescription= reader["ThreatDescription"].ToString();
                RNT.Add(RNTD);
            }
            con.Close();
            return RNT;

        }
        public static int DeleteRNT(int id)
        {
            SqlConnection con = DBHelper.GetConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("DeleteRNT", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
