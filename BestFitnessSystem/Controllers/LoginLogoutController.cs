using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestFitnessSystem.Controlles {
    class LoginLogoutController {
        public bool Login(UserDetails user) {
            try {
                MySqlConnection conn = new DB().conn;

                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT * FROM userinfo " +
                    "WHERE email=@email AND password=@password;", conn);

                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@password", user.password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    conn.Close();

                    return true;
                } else {
                    return false;
                }

            }
            catch(Exception e) {
                MessageBox.Show(e.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public bool Logout(UserDetails user) {
            return true;
        }

        public bool AdminLogin(UserDetails user) {
            try {
                MySqlConnection conn = new DB().conn;

                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT * FROM admininfo " +
                    "WHERE email=@email AND password=@password;", conn);

                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@password", user.password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) {
                    conn.Close();

                    return true;
                }
                else {
                    return false;
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }
    }
}
