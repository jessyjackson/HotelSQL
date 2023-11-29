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
        public void RemoveClient(string name)
        {
            con.Open();
            string query = @"DELETE FROM client WHERE Name = @name";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("name", name);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateClient(string name, string mail)
        {
            con.Open();
            string query = @"UPDATE client SET mail = @mail WHERE Name = @name";
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
        public void RemoveRoom(int id)
        {
            con.Open();
            string query = @"DELETE FROM room WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateRoom(int id, int maxPeople, int type)
        {
            con.Open();
            string query = @"UPDATE room SET MaxPeople = @maxPeople, TypeId = @type WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("maxPeople", maxPeople);
            cmd.Parameters.AddWithValue("type", type);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        #endregion
        #region service
        public void AddService(string name, double price)
        {
            con.Open();
            string query = @"INSERT INTO service (Name,Price) values (@name,@price)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("price", price);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void RemoveService(int id)
        {
            con.Open();
            string query = @"DELETE FROM service WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UpdateService(int id, string name, double price)
        {
            con.Open();
            string query = @"UPDATE service SET Name = @name, Price = @price WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("price", price);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
        #region reservation
        
        #endregion
    }
}
