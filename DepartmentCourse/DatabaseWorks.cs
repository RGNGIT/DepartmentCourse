using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace DepartmentCourse
{
    internal class DatabaseWorks : IDisposable
    {
        private readonly MySqlConnection _connection;

        public DatabaseWorks() 
        {
            _connection = new MySqlConnection(Config.connectionString);

            _connection.Open();
        }

        public void Dispose() 
        {
            _connection?.Close();
            _connection?.Dispose();
        }

        public DataTable SelectScript(string query) 
        {
            MySqlCommand cmd = new MySqlCommand(query, _connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        public void AddRoomType(string Name) 
        {
            string query = $"INSERT INTO room_type (Name) VALUES ('{Name}');";
            MySqlCommand command = new MySqlCommand(query, _connection);

            command.ExecuteNonQuery();
        }

        public void AddAction(string Name) 
        {
            string query = $"INSERT INTO action (Name) VALUES ('{Name}');";
            MySqlCommand command = new MySqlCommand(query, _connection);

            command.ExecuteNonQuery();
        }

        public void AddRoom(string Name, float Square, int RoomTypeId) 
        {
            string query = $"INSERT INTO room (name, Square, idroomtype) VALUES ('{Name}', '{Square}', '{RoomTypeId}');";
            MySqlCommand command = new MySqlCommand(query, _connection);

            command.ExecuteNonQuery();
        }

        public void AddDocument(string Name, string DateClaim, string DateGive, int RoomId, int DptId) 
        {
            string query = $"INSERT INTO document (name, Date_zakrepleniya, Data_peredachi, RoomID, DepartamentID) VALUES ('{Name}', '{DateClaim}', '{DateGive}', '{RoomId}', '{DptId}');";
            MySqlCommand command = new MySqlCommand(query, _connection);

            command.ExecuteNonQuery();
        }

        public void AddDepartment(string Name, string ShortName, string Rod, string Dat, string HeadDepartment)
        {
            if (!string.IsNullOrEmpty(HeadDepartment)) 
            {
                string query = $"INSERT INTO department (Name, ShortName, Rod, Dat, id_head_department) VALUES ('{Name}', '{ShortName}', '{Rod}', '{Dat}', '{HeadDepartment.Split(' ')[0]}');";
                MySqlCommand command = new MySqlCommand(query, _connection);

                command.ExecuteNonQuery();
            } 
            else 
            {
                string query = $"INSERT INTO department (Name, ShortName, Rod, Dat) VALUES ('{Name}', '{ShortName}', '{Rod}', '{Dat}');";
                MySqlCommand command = new MySqlCommand(query, _connection);

                command.ExecuteNonQuery();
            }
        }
    }
}
