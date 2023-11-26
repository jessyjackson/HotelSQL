using MySql.Data.MySqlClient;

namespace Hotel
{
    internal class DataManager
    {
        private MySqlConnection con;

        public DataManager()
        {
            // string connection to db
            string connection = "";
            con = new MySqlConnection(connection);
        }
        #region Client
        public void AddClient(string name, string ?mail)
        {
            con.Open();
            string query = @"INSERT INTO client(Name,mail) values (@name,@mail)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("mail", mail);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
        #region Room
        public void AddRoom(int maxPeople,int type)
        {
            con.Open();
            string query = @"INSERT INTO room (MAxPeople,TypeId) values (@maxPeople,@type)";
            MySqlCommand cmd = new MySqlCommand(query, con);

        }
        #endregion

    }
}
