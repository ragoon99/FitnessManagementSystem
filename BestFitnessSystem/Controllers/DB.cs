using BestFitnessSystem.Controlles;
using MySql.Data.MySqlClient;

namespace BestFitnessSystem {
    class DB {
        private static string dbConfig = "datasource=127.0.0.1;username=root;password=;";
        private MySqlConnection _conn = new MySqlConnection(dbConfig);
    
        public MySqlConnection conn {
            get => _conn;
        }

        public DB() {
            MySqlCommand cmd = new MySqlCommand("SELECT schema_name from information_schema.schemata WHERE schema_name='bfs';", _conn);

            _conn.Open();

            bool status = cmd.ExecuteReader().HasRows;

            _conn.Close();

            if (status) {
                _conn.Open();

                _conn.ChangeDatabase("BFS");

                _conn.Close();

                return;
            }

            new InitilizeDB();
        }
    }
}
