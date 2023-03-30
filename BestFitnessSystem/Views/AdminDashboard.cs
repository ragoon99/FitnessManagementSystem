using BestFitnessSystem.Controllers;
using System;
using System.Windows.Forms;

namespace BestFitnessSystem.Views {
    public partial class AdminDashboard : Form {
        public AdminDashboard() {
            InitializeComponent();
        }

        private void test_Click(object sender, EventArgs e) {
            this.Show();
        }

        private void AdminDashboard_Load(object sender, EventArgs e) {
            loadPlanTable();
            loadClientInfo();
        }

        public void loadPlanTable() {
            new PlanTableController().GeneratePlanTable(plan_table);
        }

        public void loadClientInfo() {
            UserController.GenerateTable(client_table, "SELECT * FROM client_info");
        }

        private void addClient_button_Click(object sender, EventArgs e) {
            Register reg = new Register();

            reg.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e) {
            this.Close();
            new Login().Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            UserController.GenerateTable(client_table, "SELECT * FROM client_info WHERE fname LIKE '%" + searchBar.Text +"%'");
        }

        private void client_table_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex== 0) {
                UserDetails user = new UserDetails();

                user.id = int.Parse(client_table.Rows[e.RowIndex].Cells[2].Value.ToString());
                user.fname = client_table.Rows[e.RowIndex].Cells[3].Value.ToString();
                user.lname = client_table.Rows[e.RowIndex].Cells[4].Value.ToString();
                user.address = client_table.Rows[e.RowIndex].Cells[5].Value.ToString();
                user.gender = client_table.Rows[e.RowIndex].Cells[6].Value.ToString();
                user.dob = client_table.Rows[e.RowIndex].Cells[7].Value.ToString();
                user.current_weight = client_table.Rows[e.RowIndex].Cells[8].Value.ToString();
                user.target_weight = client_table.Rows[e.RowIndex].Cells[9].Value.ToString();

                EditUser reg = new EditUser(user);
                reg.ShowDialog();
                loadClientInfo();
            }
            else if (e.ColumnIndex== 1) {
                if (MessageBox.Show("Do you want to delete user information?", "Delete?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes) {
                    UserController.DeleteUser(client_table.Rows[e.RowIndex].Cells[2].Value.ToString());
                    loadClientInfo();
                }
            }
        }
    }
}
