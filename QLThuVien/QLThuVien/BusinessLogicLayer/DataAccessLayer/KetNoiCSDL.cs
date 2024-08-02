using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// File: DataAccessLayer/KetNoiCSDL.cs
namespace DataAccessLayer
{
    internal class KetNoiCSDL
    {
        private static KetNoiCSDL instance;
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataSet ds;

        private KetNoiCSDL()
        {
            string str = @"Data Source=ANNN\ANNN;Initial Catalog=QLSACH;Integrated Security=True;Encrypt=False";
            conn = new SqlConnection(str);
        }

        public static KetNoiCSDL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KetNoiCSDL();
                }
                return instance;
            }
        }

        public void openConnection()
        {
            if (ConnectionState.Closed == conn.State)
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối, vui lòng check Connection string");
                }
            }
        }

        public void closeConnection()
        {
            if (ConnectionState.Open == conn.State)
            {
                try
                {
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối, vui lòng check Connection string");
                }
            }
        }

        public DataTable Execute(string query)
        {
            DataTable dt = new DataTable();
            openConnection();

            try
            {
                adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }

        public void ExecuteNonQuery(string query)
        {
            openConnection();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi query, vui long thu lai");
            }
            finally
            {
                closeConnection();
            }
        }
    }
}
