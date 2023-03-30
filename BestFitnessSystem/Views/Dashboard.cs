using BestFitnessSystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestFitnessSystem.Views {
    public partial class Dashboard : Form {
        UserDetails user;
        public Dashboard(UserDetails user) {
            InitializeComponent();

            this.user = UserController.FetchUserDetails(user.email);
        }

        private void label1_Click(object sender, EventArgs e) {
            this.Close();
            
            new Login().Show();
        }

        private void Dashboard_Load(object sender, EventArgs e) {
            client_name.Text = user.fname + " " + user.lname;
            current_weight.Text = user.current_weight;
            target_weight.Text = user.target_weight;

            UserController.GenerateBill(user, dataGridView1, totalCost);
        }
    }
}
