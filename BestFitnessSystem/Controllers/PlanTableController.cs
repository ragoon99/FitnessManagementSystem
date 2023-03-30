using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestFitnessSystem.Controllers {
    public class PlanTableController {
        public void GeneratePlanTable(DataGridView dgv) {
            MySqlConnection conn = new DB().conn;

            MySqlCommand cmd = new MySqlCommand("SELECT 'Primary' as 'plan_type', plan_id, plan_name, cost, paymentType, session FROM traningplan UNION SELECT 'Optional' as 'plan_type', plan_id, plan_name, cost, paymentType, 1 as 'session' FROM traningplan_optional;", conn);

            try {
                conn.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgv.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex) { 
                MessageBox.Show("Error While Fetching Table From the Server.", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
