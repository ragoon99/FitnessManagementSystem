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
    public partial class Register : Form {
        private MapField<int, int> secondary = new MapField<int, int>();

        public Register() {
            InitializeComponent();

            primary_CBox.SelectedIndex = 0;
            gender_ComboBox.SelectedIndex = 0;
        }

        private void login_Label_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void submit_button_Click(object sender, EventArgs e) {

            if (password_TBox.Text != cPassword_TBox.Text) {
                error_label.Text = "Password and Confirm Password Does Not Match";
                
                return;
            }

            var txtBoxCollection = new[] {
                address_TBox, cPassword_TBox, email_TBox, fname_TBox, lname_TBox, password_TBox,
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
            user.email = email_TBox.Text;
            user.password = password_TBox.Text;
            user.current_weight = currentWeight_TBox.Text;
            user.target_weight = targetWeight_TBox.Text;
            user.primary_subscription = primary_CBox.SelectedIndex + 1;
            user.secondary_subscription = secondary;

            bool status = new UserController().AddUser(user);

            if (status) {
                MessageBox.Show("Account Created Successfully...", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            } else {
                MessageBox.Show("Error While Creating Account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void sauna_ChkBox_CheckedChanged(object sender, EventArgs e) {
            if (sauna_ChkBox.Checked) {
                secondary.Add(2, (int)sauna_Sessions.Value);
            } else {
                secondary.Remove(2);
            }
        }

        private void swimming_ChkBox_CheckedChanged(object sender, EventArgs e) {
            if (swimming_ChkBox.Checked) {
                secondary.Add(3, (int)swimming_Session.Value);
            }
            else {
                secondary.Remove(3);
            }
        }

        private void pvtTrainer_ChkBox_CheckedChanged(object sender, EventArgs e) {
            if (pvtTrainer_ChkBox.Checked) {
                secondary.Add(1, (int)pvtTrainer_hrs.Value);
            }
            else {
                secondary.Remove(1);
            }
        }
    
    }
}
