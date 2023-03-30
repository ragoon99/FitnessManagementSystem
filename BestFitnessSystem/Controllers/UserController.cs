using MySql.Data.MySqlClient;
using Mysqlx.Notice;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace BestFitnessSystem.Controllers {
    public class UserController {

        public int GetId() {
            try {
                MySqlConnection conn = new DB().conn;

                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT id FROM client_info ORDER BY id DESC LIMIT 1;", conn);

                int id = int.Parse(cmd.ExecuteScalar().ToString());

                conn.Close();

                return id;
            }
            catch (Exception ex) {
                return 0;
            }
        }

        public bool AddUser(UserDetails user) { 
            try {
                MySqlConnection conn = new DB().conn;

                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO client_info " +
                    "(fname, lname, address, gender, dob, `current_weight(kg)`, `target_weight(kg)`) " +
                    " VALUES (@1, @2, @3, @4, @5, @6, @7);", conn);

                user.id = GetId();
                cmd.Parameters.AddWithValue("@1", user.fname);
                cmd.Parameters.AddWithValue("@2", user.lname);
                cmd.Parameters.AddWithValue("@3", user.address);
                cmd.Parameters.AddWithValue("@4", user.gender);
                cmd.Parameters.AddWithValue("@5", user.dob);
                cmd.Parameters.AddWithValue("@6", user.current_weight);
                cmd.Parameters.AddWithValue("@7", user.target_weight);

                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand("INSERT INTO userinfo (email, password) VALUES (@1, @2);", conn);
                cmd.Parameters.AddWithValue("@3", user.id);
                cmd.Parameters.AddWithValue("@1", user.email);
                cmd.Parameters.AddWithValue("@2", user.password);

                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand("INSERT INTO client_subscriptions (plan_id, client_id) " +
                    "VALUES (@1, @2);", conn);
                cmd.Parameters.AddWithValue("@2", user.id);
                cmd.Parameters.AddWithValue("@1", user.primary_subscription);

                cmd.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch(Exception ex) {
                return false;
            }
        }

        public bool UpdateUser(UserDetails user) {
            try {
                MySqlConnection conn = new DB().conn;

                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE INTO client_info SET fname = @1, lname = @2, address = @3, gender = @4, dob = @5, `current_weight(kg)` = @6, `target_weight(kg)` = @7 WHERE id=@8;", conn);
                cmd.Parameters.AddWithValue("@1", user.fname);
                cmd.Parameters.AddWithValue("@2", user.lname);
                cmd.Parameters.AddWithValue("@3", user.address);
                cmd.Parameters.AddWithValue("@4", user.gender);
                cmd.Parameters.AddWithValue("@5", user.dob);
                cmd.Parameters.AddWithValue("@6", user.current_weight);
                cmd.Parameters.AddWithValue("@6", user.target_weight);
                cmd.Parameters.AddWithValue("@6", user.id);

                cmd.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public static bool DeleteUser(String id) {
            try {
                MySqlConnection conn = new DB().conn;

                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM client_info WHERE id=@1;", conn);
                cmd.Parameters.AddWithValue("@1", id);

                cmd.ExecuteNonQuery();

                conn.Close();

                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }

        public static void GenerateTable(DataGridView dgv, String search) {
            MySqlConnection conn = new DB().conn;

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(search, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dgv.DataSource = dataTable;

            conn.Close();
        }

        public static void GenerateBill(UserDetails user, DataGridView dgv, Label totalCost) {
            int total = 0;

            try {
                MySqlConnection conn = new DB().conn; 
                
                conn.Open();

                // selecting the primary subscription
                MySqlCommand cmd = new MySqlCommand("SELECT traningplan.plan_name, traningplan.cost FROM traningplan INNER JOIN client_subscriptions ON traningplan.plan_id = client_subscriptions.plan_id WHERE client_subscriptions.client_id = @1 AND MONTH(start_date) = MONTH(CURRENT_DATE()) AND YEAR(start_date) = YEAR(CURRENT_DATE());", conn);
                cmd.Parameters.AddWithValue("@1", user.id);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    total += reader.GetInt32("cost");
                    dgv.Rows.Add(reader.GetString("plan_name"), reader.GetString("cost"));
                }
                reader.Close();

                cmd = new MySqlCommand("SELECT traningplan_optional.plan_name, traningplan_optional.cost FROM traningplan_optional INNER JOIN client_optionalsubscriptions ON traningplan_optional.plan_id = client_optionalsubscriptions.plan_id WHERE client_optionalsubscriptions.client_id = 9 AND MONTH(start_date) = MONTH(CURRENT_DATE()) AND YEAR(start_date) = YEAR(CURRENT_DATE())", conn);
                cmd.Parameters.AddWithValue("@1", user.id);
                reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    total += reader.GetInt32("cost");
                    dgv.Rows.Add(reader.GetString("plan_name"), reader.GetString("cost"));
                }
                reader.Close();

                totalCost.Text = total.ToString();

                conn.Close();
            }
            catch(Exception ex) {
            }
        }
    
        public static UserDetails FetchUserDetails(String email) {
            UserDetails user = new UserDetails();

            MySqlConnection conn = new DB().conn;

            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `client_info` INNER JOIN userinfo ON client_info.id = userinfo.id WHERE email=@1;", conn);
            cmd.Parameters.AddWithValue("@1", email);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                user.id = reader.GetInt32("id");
                user.fname = reader.GetString("fname");
                user.lname = reader.GetString("lname");
                user.current_weight = reader.GetString("current_weight(kg)");
                user.target_weight = reader.GetString("target_weight(kg)");
            }

            conn.Close();

            return user;
        }
    }
}
