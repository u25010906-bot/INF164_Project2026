using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace INF164_Project2026
{
    public partial class SignUpForm : Form
    {

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // Grab inputs from the form textboxes
            string newUsername = txtUserName.Text;
            string newPassword = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Make sure the user didn't leave any box blank
            if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in missing field.");
                return; // Kick out early if something is missing
            }

            // Verify that both password entries match up
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return; // Stop here if passwords don't match
            }

            // Don't allow duplicate usernames
            if (IsUsernameTaken(newUsername))
            {
                MessageBox.Show("Username already exists. Please choose another one.");
            }
            else
            {
                // Write the new account details to our file
                SaveUser(newUsername, newPassword);
                MessageBox.Show("Sign Up successful. Redirecting to Login page.");

                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        // Helper function to scan the text file for existing usernames
        public bool IsUsernameTaken(string usernameToCheck)
        {
            bool isTaken = false;

            try
            {
                // Pull all saved user entries into an array
                string[] allLines = File.ReadAllLines("Password&Username.txt");

                // Step through each line to check for a matching username
                for (int i = 0; i < allLines.Length; i++)
                {
                    // Usernames are saved like "username,password" so we match the prefix
                    if (allLines[i].StartsWith(usernameToCheck + ","))
                    {
                        isTaken = true; // Found a matching name
                        break; // Stop looking since we already found it
                    }
                }
            }
            catch (FileNotFoundException)
            {
                // If the file doesn't exist yet, there are no users saved so it's safe
                isTaken = false;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error checking username: " + error.Message);
            }

            return isTaken;
        }

        // Appends a new username and password pair to the text file
        public void SaveUser(string username, string password)
        {
            try
            {
                // Set append mode to true so we don't overwrite existing entries
                StreamWriter outputFile = new StreamWriter("Password&Username.txt", true);

                // Save format: username,password
                outputFile.WriteLine(username + "," + password);

                // Close stream to flush and save file changes
                outputFile.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error saving user data: " + error.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            // Show the login screen and close this signUp window
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }
    }
}