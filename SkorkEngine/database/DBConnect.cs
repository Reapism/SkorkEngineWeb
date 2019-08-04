using System.Data.SqlClient;

namespace SkorkEngine.database {

    public class DBConnect {

        private static DBConnect INSTANCE;

        static DBConnect() {
            INSTANCE = new DBConnect();
        }

        private DBConnect() { }

        public static DBConnect Instance => INSTANCE;

        private static string GetConnectionString() {
            return "";
        }

        public static int Query() {
            try {
                SqlConnection connection = new SqlConnection(GetConnectionString());
                connection.Open();



                connection.Close();
                return 1;
            } catch (System.InvalidOperationException) {
                return -1;
            } catch (SqlException) {
                return -2;
            }
        }
    }
}
