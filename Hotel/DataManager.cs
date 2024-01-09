using Hotel.DbEntities;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;
using System.Reflection.Emit;

namespace Hotel
{
    internal class DataManager
    {
        private readonly MySqlConnection Connection;
        public DataManager()
        {
            // string connection to db
            string connection = "database=hotel; host=127.0.0.1; port=3306; user=root; pwd=password";
            Connection = new MySqlConnection(connection);
        }
        public static object ToDBNull(object? value)
        {
            if (null != value) { return value; }
            return DBNull.Value;
        }
        #region Client
        public void AddClient(string name, string ?mail)
        {
            Connection.Open();
            string query = @"INSERT INTO client(Name,mail) values (@name,@mail)";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("mail", ToDBNull(mail));
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        public List<Client> GetAllClients()
        {
            Connection.Open();
            string query = @"SELECT ID,Name,Mail FROM client WHERE Deleted = 0";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Client> clients = new();
            while (reader.Read())
            {
                Client client = new()
                {
                    ID = reader.GetInt32("ID"),
                    Name = reader.GetString("Name"),
                    Mail = reader.IsDBNull("Mail") ? null : reader.GetString("Mail")
                };
                clients.Add(client);
            }
            Connection.Close();
            return clients;
        
            }
        public  DataTable GetAllClientsForDataTable()
        {
            Connection.Open();
            string query = @"SELECT ID,Name,Mail,Deleted FROM client WHERE Deleted = 0";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable t = new DataTable();
            adapter.Fill(t);
            Connection.Close();
            return t;
        }
        public void UpdateClients(DataTable t)
        {
            string query = "UPDATE client SET Name = @Name, Mail = @Mail,Deleted = @Deleted WHERE ID = @ID";
            Connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, Connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.Parameters.Add("@Name", MySqlDbType.VarChar, 45, "Name");
            adapter.UpdateCommand.Parameters.Add("@Mail", MySqlDbType.VarChar, 45, "Mail");
            adapter.UpdateCommand.Parameters.Add("@Deleted", MySqlDbType.Bit, 1, "Deleted");
            adapter.UpdateCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");

            adapter.Update(t);
            Connection.Close();
        }

        #endregion
        #region Room
        public void AddRoom(int number, int maxPeople, int type)
        {
            Connection.Open();
            string query = @"INSERT INTO room (Number,MaxPeople,TypeId) values (@Number,@maxPeople,@type)";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("Number", number);
            cmd.Parameters.AddWithValue("MaxPeople", maxPeople);
            cmd.Parameters.AddWithValue("type", type);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        public bool NumberRoomExist(int number)
        {
            Connection.Open();
            string query = @"SELECT Number FROM room WHERE Number = @number";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("number", number);
            MySqlDataReader reader = cmd.ExecuteReader();
            bool exist = reader.HasRows;
            Connection.Close();
            return exist;
        }
        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new();
            Connection.Open();
            string query = @"SELECT * FROM room WHERE Deleted = 0";
            MySqlCommand cmd = new(query, Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Room room = new()
                {
                    Number = reader.GetInt32("Number"),
                    MaxPeople = reader.GetInt32("MaxPeople"),
                    TypeId = reader.GetInt32("TypeId"),
                    Deleted = reader.GetBoolean("Deleted"),
                    CreatedAt = reader.GetDateTime("CreatedAt")
                };
                rooms.Add(room);
            }
            Connection.Close();
            return rooms;
        }
        public DataTable GetAllRoomsForDataTable()
        {
            Connection.Open();
            string query = @"SELECT Number,MaxPeople,room_type.Name FROM room INNER JOIN room_type ON room.TypeId =  room_Type.ID WHERE room.Deleted = 0";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable t = new DataTable();
            adapter.Fill(t);
            Connection.Close();
            return t;
        }

        #endregion
        #region Service
        public void AddService(string name, double price)
        {
            Connection.Open();
            string query = @"INSERT INTO service (Name,Price) values (@name,@price)";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("price", price);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        public DataTable GetAllServicesForDataTable()
        {
            Connection.Open();
            string query = @"SELECT ID,Name,Price,Deleted FROM service WHERE Deleted = 0";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable t = new DataTable();
            adapter.Fill(t);
            Connection.Close();
            return t;
        }
        public void UpdateServices(DataTable t)
        {
            Connection.Open();
            string query = "UPDATE service SET Name = @Name, Price = @Price,Deleted = @Deleted WHERE ID = @ID";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.Parameters.Add("@Name", MySqlDbType.VarChar, 45, "Name");
            adapter.UpdateCommand.Parameters.Add("@Price", MySqlDbType.Double, 45, "Price");
            adapter.UpdateCommand.Parameters.Add("@Deleted", MySqlDbType.Bit, 1, "Deleted");
            adapter.UpdateCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
            adapter.Update(t);
            Connection.Close();

        }
        public List<Service> GetServicesToList()
        {
            Connection.Open();
            string query = @"SELECT ID,Name,Price FROM service WHERE Deleted = 0";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Service> services = new();
            while (reader.Read())
            {
                Service service = new()
                {
                    ID = reader.GetInt32("ID"),
                    Name = reader.GetString("Name"),
                    Price = reader.GetDouble("Price")
                };
                services.Add(service);
            }
            Connection.Close();
            return services;
        }
        #endregion
        #region Treatment
        public void AddTreatment(string name, double price)
        {
            Connection.Open();
            string query = @"INSERT INTO treatment (Name,Price) values (@name,@price)";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("price", price);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        public DataTable GetAllTreatmentsForDataTable()
        {
            Connection.Open();
            string query = @"SELECT Name,Price,Deleted FROM treatment WHERE Deleted = 0";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable t = new DataTable();
            adapter.Fill(t);
            Connection.Close();
            return t;
        }
        public List<Treatment> GetTreatmentsToList()
        {
            Connection.Open();
            string query = @"SELECT Name,Price FROM treatment WHERE Deleted = 0";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Treatment> treatments = new();
            while (reader.Read())
            {
                Treatment treatment = new()
                {
                    Name = reader.GetString("Name"),
                    Price = reader.GetDouble("Price")
                };
                treatments.Add(treatment);
            }
            Connection.Close();
            return treatments;
        }
        public void UpdateTreatments(DataTable t)
        {
            Connection.Open();
            string query = "UPDATE treatment SET Price = @Price,Deleted = @Deleted WHERE Name = @Name";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.Parameters.Add("@Name", MySqlDbType.VarChar, 50, "Name");
            adapter.UpdateCommand.Parameters.Add("@Price", MySqlDbType.Double, 11, "Price");
            adapter.UpdateCommand.Parameters.Add("@Deleted", MySqlDbType.Bit, 1, "Deleted");
            adapter.Update(t);
            Connection.Close();
        }

        #endregion
        #region Reservation
        //add reservation to db
        public void AddReservation( DateTime CheckIn, DateTime CheckOut, int ClientId, int numPeople,string TreatmentType, int roomNumber)
        {
            Connection.Open();
            string query = @"INSERT INTO reservation (CheckIn,CheckOut,NumPeople,ClientID,TreatmentType,RoomNum) values (@CheckIn,@CheckOut,@NumPeople,@ClientId,@TreatmentType,@roomNumber)";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("CheckIn", CheckIn);
            cmd.Parameters.AddWithValue("CheckOut", CheckOut);
            cmd.Parameters.AddWithValue("NumPeople", numPeople);
            cmd.Parameters.AddWithValue("ClientId", ClientId);
            cmd.Parameters.AddWithValue("TreatmentType", TreatmentType);
            cmd.Parameters.AddWithValue("roomNumber", roomNumber);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        public List<Room> GetAllFreeRoomsByPeriod(DateTime checkin,DateTime checkout,int numPeople)
        {
            Connection.Open();
            string query = @"SELECT DISTINCT * FROM room " +
                            "WHERE room.Number NOT IN (SELECT r.RoomNum FROM reservation AS r WHERE " +
                            "(r.CheckIn <= @checkout AND r.CheckOut >= @checkin)) AND room.MaxPeople >= @numpeople AND Deleted = 0";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("checkin", checkin.ToString("yyyy-MM-dd") );
            cmd.Parameters.AddWithValue("checkout", checkout.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("numpeople", numPeople);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<Room> rooms = new();
            while (reader.Read())
            {
                Room room = new()
                {
                    Number = reader.GetInt32("Number"),
                    MaxPeople = reader.GetInt32("MaxPeople"),
                    TypeId = reader.GetInt32("TypeId"),
                    Deleted = reader.GetBoolean("Deleted"),
                    CreatedAt = reader.GetDateTime("CreatedAt")
                };
                rooms.Add(room);
            }
            Connection.Close();
            return rooms;
        }
        public DataTable GetAllReservationsForDataTable()
        {
            Connection.Open();
            string query = @"SELECT reservation.ID,CheckIn,CheckOut,NumPeople,TreatmentType,RoomNum as RoomNumber,Name as Client, reservation.Deleted FROM reservation INNER JOIN client ON reservation.ClientID = client.ID WHERE reservation.Deleted = 0";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable t = new DataTable();
            adapter.Fill(t);
            Connection.Close();
            return t;
        }
        public void DeleteReservations(DataTable t)
        {
            Connection.Open();
            string query = "UPDATE reservation SET Deleted = @Deleted WHERE ID = @ID";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.Parameters.Add("@Deleted", MySqlDbType.Bit, 1, "Deleted");
            adapter.UpdateCommand.Parameters.Add("@ID", MySqlDbType.Int32, 11, "ID");
            adapter.Update(t);
            Connection.Close();
        }
        //return all reservations from db that are not deleted
        public Dictionary<Room,List<Reservation>> GetRoomsAndReservations()
        {

            Connection.Open();
            //query per connessione n- n
            //string query = @"SELECT r.Number,rr.ReservationId,r.MaxPeople,re.CheckIn,re.CheckOut,re.ClientID,c.Name " +
            //                "FROM room AS r " +
            //                "LEFT JOIN room_reservation as rr ON r.Number = rr.RoomNumber " +
            //                "LEFT JOIN reservation AS re ON re.ID = rr.ReservationId "+
            //                "LEFT JOIN client AS c ON re.ClientID = c.ID;";

            //query per connessione 1 - n
            string query = @"SELECT r.Number,r.MaxPeople,re.CheckIn,re.CheckOut,re.ClientID,c.Name " +
                "FROM room AS r " +
                "LEFT JOIN reservation AS re ON re.RoomNum = r.Number " +
                "LEFT JOIN client AS c ON re.ClientID = c.ID " +
                "WHERE re.Deleted = 0 OR re.Deleted IS NULL";

            MySqlCommand cmd = new MySqlCommand(query, Connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            Dictionary<Room, List<Reservation>> rooms = new();

            while (reader.Read())
            {
                Room r = new Room();
                r.Number = reader.IsDBNull("Number") ? 0 : reader.GetInt32("Number");
                r.MaxPeople = reader.IsDBNull("MaxPeople") ? 0 : reader.GetInt32("MaxPeople");

                Client c = new();
                c.Name = reader.IsDBNull("Name") ? null : reader.GetString("Name");

                Reservation re = new Reservation();
                re.CheckIn = reader.IsDBNull("CheckIn") ? null : reader.GetDateTime("CheckIn");
                re.CheckOut = reader.IsDBNull("CheckOut") ? null : reader.GetDateTime("CheckOut");
                re.ClientID = reader.IsDBNull("ClientID") ? null : reader.GetInt32("ClientID");
                re.Client = c;

                if (rooms.ContainsKey(r)) {
                    rooms[r].Add(re);
                }
                else
                {
                    rooms.Add(r, new List<Reservation>() { re });
                }
            }
            Connection.Close();
            return rooms;
        } 

        #endregion
        #region RoomType
        public void AddRoomType(string name,double price)
        {
            Connection.Open();
            string query = @"INSERT INTO room_type (Name,Price) values (@name,@price)";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("price", price);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        public DataTable GetAllRoomsTypeForDataTable()
        {
            Connection.Open();
            string query = @"SELECT ID,Name,Price,Deleted FROM room_type WHERE Deleted = 0";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable t = new DataTable();
            adapter.Fill(t);
            Connection.Close();
            return t;
        }
        public void UpdateRoomsType(DataTable t)
        {
            Connection.Open();
            string query = "UPDATE room_type SET Name = @Name, Price = @Price,Deleted = @Deleted WHERE ID = @ID";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.Parameters.Add("@Name", MySqlDbType.VarChar, 50, "Name");
            adapter.UpdateCommand.Parameters.Add("@Price", MySqlDbType.Double, 11, "Price");
            adapter.UpdateCommand.Parameters.Add("@Deleted", MySqlDbType.Bit, 1, "Deleted");
            adapter.UpdateCommand.Parameters.Add("@ID", MySqlDbType.Int32, 10, "ID");
            adapter.Update(t);
            Connection.Close();
        }
        public List<RoomType> GetRoomsTypeList()
        {
            Connection.Open();
            string query = @"SELECT ID,Name,Price FROM room_type WHERE Deleted = 0";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            List<RoomType> roomsType = new();
            while (reader.Read())
            {
                RoomType roomType = new()
                {
                    ID = reader.GetInt32("ID"),
                    Name = reader.GetString("Name"),
                    Price = reader.GetDouble("Price")
                };
                roomsType.Add(roomType);
            }
            Connection.Close();
            return roomsType;
        }

        #endregion
        #region RoomService

        public void AddRoomService(List<RoomService> services)
        {
            Connection.Open();
            string query = @"INSERT INTO room_service (RoomNumber,ServiceID) values (@RoomNumber,@ServiceId)";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            foreach (var item in services)
            {
                cmd.Parameters.AddWithValue("RoomNumber", item.RoomNumber);
                cmd.Parameters.AddWithValue("ServiceId", item.ServiceId);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            Connection.Close();
        }
        #endregion

    }
}
