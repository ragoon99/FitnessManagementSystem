using BestFitnessSystem.Controllers;
using Google.Protobuf.Collections;
using MySql.Data.Types;
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
    public partial class EditUser : Form {

        public EditUser(UserDetails user) {
            InitializeComponent();

            fname_TBox.Text = user.fname;
            lname_TBox.Text = user.lname;
            address_TBox.Text = user.address;
            gender_ComboBox.Text = user.gender;
            dob.Text = user.dob;
            currentWeight_TBox.Text = user.current_weight;
            targetWeight_TBox.Text = user.target_weight;
        }

        private void login_Label_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void submit_button_Click(object sender, EventArgs e) {

            var txtBoxCollection = new[] {
                address_TBox, fname_TBox, lname_TBox,
                currentWeight_TBox, targetWeight_TBox
            };

            bool emptyBox = txtBoxCollection.Any(t => String.IsNullOrWhiteSpace(t.Text));

            if (emptyBox) {
                error_label.Text = "All Fields are Mandatory";

                return;
            }

            UserDetails user = new UserDetails();

            user.fname = fname_TBox.Text;
            user.lname = lname_TBox.Text;
            user.address = address_TBox.Text;
            user.gender = gender_ComboBox.Text; 
            user.dob = dob.Text;
            user.current_weight = currentWeight_TBox.Text;
            user.target_weight = targetWeight_TBox.Text;

            bool status = new UserController().UpdateUser(user);
            if (status) {
                MessageBox.Show("Account Update Successfully...", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            } else {
                MessageBox.Show("Error While Updating Account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void currentWeight_TBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }
    
    }
}
