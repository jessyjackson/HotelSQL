using Hotel.DbEntities;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Hotel
{
    internal class DataManager
    {
        private MySqlConnection Connection;
        public DataManager()
        {
            // string connection to db
            string connection = "";
            Connection = new MySqlConnection(connection);
        }
        #region Client
        public void AddClient(string name, string ?mail)
        {
            Connection.Open();
            string query = @"INSERT INTO client(Name,mail) values (@name,@mail)";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("mail", mail);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        //delete client from db
        public void DeleteClient(string name)
        {
            Connection.Open();
            string query = @"DELETE FROM client WHERE Name = @name";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("name", name);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        //remove client from db by using delted flag
        public void RemoveClient(string name)
        {
            Connection.Open();
            string query = @"UPDATE client SET Deleted = 1 WHERE Name = @name";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("name", name);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        //update client mail
        public void UpdateClientMail(string name, string mail)
        {
            Connection.Open();
            string query = @"UPDATE client SET mail = @mail WHERE Name = @name";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("mail", mail);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }   

        #endregion
        #region Room
        public void AddRoom(int maxPeople,int type)
        {
            Connection.Open();
            string query = @"INSERT INTO room (MaxPeople,TypeId) values (@maxPeople,@type)";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("MaxPeople", maxPeople);
            cmd.Parameters.AddWithValue("type", type);
            cmd.ExecuteNonQuery();
        }
        //delete room from db
        public void DeleteRoom(int number)
        {
            Connection.Open();
            string query = @"DELETE FROM room WHERE Number = @number";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("number", number);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        //remove room from db by using delted flag
        public void RemoveRoom(int number)
        {
            Connection.Open();
            string query = @"UPDATE room SET deleted = 1 WHERE Number = @number";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("Number",number);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        //update room
        public void UpdateRoom(int number, int maxPeople, int type)
        {
            Connection.Open();
            string query = @"UPDATE room SET MaxPeople = @maxPeople, TypeId = @type WHERE Number = @number";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("number", number);
            cmd.Parameters.AddWithValue("maxPeople", maxPeople);
            cmd.Parameters.AddWithValue("type", type);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        //get all rooms from db
        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();
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
        //remove service from db by using delted flag
        public void RemoveService(int id)
        {
            Connection.Open();
            string query = @"UPDATE service SET Deleted = 1 WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        //delete service from db
        public void DeleteService(int id)
        {
            Connection.Open();
            string query = @"DELETE FROM service WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        //update service
        public void UpdateService(int id, string name, double price)
        {
            Connection.Open();
            string query = @"UPDATE service SET Name = @name, Price = @price WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("price", price);
            cmd.ExecuteNonQuery();
            Connection.Close();
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
        //delete treatment from db
        public void DeleteTreatment(string name)
        {
            Connection.Open();
            string query = @"DELETE FROM treatment WHERE Name = @name";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("name", name);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        //remove treatment from db by using delted flag
        public void RemoveTreatment(string name)
        {
            Connection.Open();
            string query = @"UPDATE treatment SET Deleted = 1 WHERE Name = @name";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("name", name);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        //update treatment price
        public void UpdateTreatmentPrice(string name, double price)
        {
            Connection.Open();
            string query = @"UPDATE treatment SET Price = @price WHERE Name = @name";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("price", price);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        #endregion
        #region Reservation
        //add reservation to db
        public void AddReservation(int ClientId, DateTime CheckIn, DateTime CheckOut,int numPeople)
        {
            Connection.Open();
            string query = @"INSERT INTO reservation (CheckIn,CheckOut,NumPeople,ClientID,TreatmentType) values (@CheckIn,@CheckOut,@NumPeople,@ClientId,@TreatmentType)";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("CheckIn", CheckIn);
            cmd.Parameters.AddWithValue("CheckOut", CheckOut);
            cmd.Parameters.AddWithValue("NumPeople", numPeople);
            cmd.Parameters.AddWithValue("ClientId", ClientId);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        //return all reservations from db that are not deleted
        public List<object[]> GetRoomReservations()
        {
            Connection.Open();
            string query = "SELECT room.Number,re.CheckIn,re.CheckOut,client.ID " +
                "FROM room_reservation AS rr " +
                "INNER JOIN room ON rr.RoomNumber = room.Number " +
                "INNER JOIN reservation AS re ON rr.ReservationId = re.ID " +
                "INNER JOIN client ON re.ClientID = client.ID " +
                "WHERE rr.Deleted = 0";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            List<object[]> list = new List<object[]>();
            while (reader.Read())
            {
                //object structure
                //{
                // RoomNumber = int
                // CheckIn = DateTime
                // CheckOut = DateTime
                // ClientID = int
                //}
                object[] tmp = new object[4];
                tmp[0] = reader.GetInt32("Number");
                tmp[1] = reader.GetDateTime("CheckIn");
                tmp[2] = reader.GetDateTime("CheckOut");
                tmp[3] = reader.GetInt32("ID");
                list.Add(tmp);
            }
            return list;
        } 
        #endregion
        #region RoomReservation
        public void AddRoomReservation(int ReservationId, int RoomNumber)
        {
            Connection.Open();
            string query = @"INSERT INTO room_reservation (ReservationId,RoomNumber) values (@ReservationId,@RoomNumber)";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("ReservationId", ReservationId);
            cmd.Parameters.AddWithValue("RoomNumber", RoomNumber);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        //delete roomreservation from db
        public void DeleteRoomReservation(int ReservationId, int RoomNumber)
        {
            Connection.Open();
            string query = @"DELETE FROM room_reservation WHERE ReservationId = @ReservationId AND RoomNumber = @RoomNumber";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("ReservationId", ReservationId);
            cmd.Parameters.AddWithValue("RoomNumber", RoomNumber);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        //remove roomreservation from db by using delted flag
        public void RemoveRoomReservation(int ReservationId, int RoomNumber)
        {
            Connection.Open();
            string query = @"UPDATE room_reservation SET Deleted = 1 WHERE ReservationId = @ReservationId AND RoomNumber = @RoomNumber";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("ReservationId", ReservationId);
            cmd.Parameters.AddWithValue("RoomNumber", RoomNumber);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        //update roomreservation
        public void UpdateRoomReservation(int ReservationId, int RoomNumber)
        {
            Connection.Open();
            string query = @"UPDATE room_reservation SET ReservationId = @ReservationId, RoomNumber = @RoomNumber WHERE ReservationId = @ReservationId AND RoomNumber = @RoomNumber";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("ReservationId", ReservationId);
            cmd.Parameters.AddWithValue("RoomNumber", RoomNumber);
            cmd.ExecuteNonQuery();
            Connection.Close();
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
        //delete roomtype from db
        public void DeleteRoomType(int id)
        {
            Connection.Open();
            string query = @"DELETE FROM room_type WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        //remove roomtype from db by using delted flag
        public void RemoveRoomType(int id)
        {
            Connection.Open();
            string query = @"UPDATE room_type SET Deleted = 1 WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        //update roomtype price
        public void UpdateRoomTypePrice(int id, double price)
        {
            Connection.Open();
            string query = @"UPDATE room_type SET Price = @price WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("price", price);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        #endregion
        #region RoomService
        public void AddRoomService(int RoomNumber, int ServiceId)
        {
            Connection.Open();
            string query = @"INSERT INTO room_service (RoomNumber,ServiceID) values (@RoomNumber,@ServiceId)";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("RoomNumber", RoomNumber);
            cmd.Parameters.AddWithValue("ServiceId", ServiceId);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        //delete roomservice from db
        public void DeleteRoomService(int RoomNumber, int ServiceId)
        {
            Connection.Open();
            string query = @"DELETE FROM room_service WHERE RoomNumber = @RoomNumber AND ServiceID = @ServiceId";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("RoomNumber", RoomNumber);
            cmd.Parameters.AddWithValue("ServiceId", ServiceId);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        //remove roomservice from db by using delted flag
        public void RemoveRoomService(int RoomNumber, int ServiceId)
        {
            Connection.Open();
            string query = @"UPDATE room_service SET Deleted = 1 WHERE RoomNumber = @RoomNumber AND ServiceID = @ServiceId";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("RoomNumber", RoomNumber);
            cmd.Parameters.AddWithValue("ServiceId", ServiceId);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        //update roomservice
        public void UpdateRoomService(int RoomNumber, int ServiceId)
        {
            Connection.Open();
            string query = @"UPDATE room_service SET RoomNumber = @RoomNumber, ServiceID = @ServiceId WHERE RoomNumber = @RoomNumber AND ServiceID = @ServiceId";
            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.Parameters.AddWithValue("RoomNumber", RoomNumber);
            cmd.Parameters.AddWithValue("ServiceId", ServiceId);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
        #endregion

    }
}
