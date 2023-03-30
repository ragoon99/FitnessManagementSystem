using System;
using MySql.Data.MySqlClient;

namespace BestFitnessSystem.Controlles {
    class InitilizeDB {

        private MySqlConnection _conn = new DB().conn;

        public InitilizeDB() {
            string db = "BFS";

            try {
                _conn.Open();

                MySqlCommand cmd = new MySqlCommand("CREATE DATABASE IF NOT EXISTS " + db, _conn);
                cmd.ExecuteNonQuery();

                _conn.ChangeDatabase(db);

                cmd = new MySqlCommand(
                    "CREATE TABLE IF NOT EXISTS UserInfo " +
                    "(id INT NOT NULL AUTO_INCREMENT, fname VARCHAR(50), lname VARCHAR(50), email VARCHAR(50), " +
                    "PRIMARY KEY (id), UNIQUE (email));", _conn);
                cmd.ExecuteNonQuery();

                _conn.Close();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
