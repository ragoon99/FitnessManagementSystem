using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using BestFitnessSystem.Controlles;
using BestFitnessSystem.Views;

namespace BestFitnessSystem {

    public partial class Login : Form {
        protected static bool IsAdmin = false;

        public Login() {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e) {
            String email = email_TBox.Text;
            String password = password_TBox.Text;

            if (email.Length == 0 || password.Length == 0) {
                error_Label.Text = "Please Enter Email and Password...";

            } else {
                UserDetails user = new UserDetails();
                user.email = email;
                user.password = password;

                bool status = new LoginLogoutController().AdminLogin(user) ? IsAdmin : new LoginLogoutController().Login(user);

                if (status) {
                    MessageBox.Show("Logged In Successfully...", "Logged In!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    
                    if (IsAdmin) {
                       new AdminDashboard().Show();
                    } else {
                        Dashboard dashboard = new Dashboard(user);
                        dashboard.Show();
                    }

                } else {
                    MessageBox.Show("Email and Password Doesn't Match...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e) {
            if (password_TBox.UseSystemPasswordChar) {
                showPass_label.Text = "Hide Password";
                password_TBox.UseSystemPasswordChar = false;
            } else {
                showPass_label.Text = "Show Password";
                password_TBox.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            new Register().ShowDialog();
        }

        private void adminMode_Click(object sender, EventArgs e) {
            if (IsAdmin) {
                IsAdmin = false;
                adminMode.ForeColor = Color.Gray;
            } else {
                IsAdmin = true;
                adminMode.ForeColor = Color.Black;
            }
        }
    }
}
