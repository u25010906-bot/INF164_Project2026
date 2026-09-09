using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164_Project2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Grab user inputs from the login screen
            string usernameInput = txtUsername.Text;
            string passwordInput = txtPassword.Text;

            // Make sure the user didn't leave either box blank
            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Please enter both username and password.");
                return; // Kick out early if fields are missing
            }

            // Check if what they typed matches an existing record in the file
            if (ValidateCredentials(usernameInput, passwordInput))
            {
                MessageBox.Show("Login successful! Welcome, " + usernameInput + ". Redirecting to Home.");
                // Allowing the log in form to close and make way for home page to be displayed
                Home HomeForm = new Home(usernameInput); // we directly passed usernameInput to Home form to facilitate customising the welcome message
                HomeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }

            //Was having issues with two log in forms opening at the same tim so had to
            // rectify issue byclosing one of the forms and leave one open after pressing log in
            //this.DialogResult = DialogResult.OK;
            //this.Close ();

        }
        
        // Helper function to check if the entered username and password pair exists
        public bool ValidateCredentials(string username, string password)
        {
            bool isValid = false;

            // Build the exact string format we expect to find in the text file
            string targetRecord = username + "," + password;

            try
            {
                // Load all lines from the file into an array
                string[] allLines = File.ReadAllLines("Password&Username.txt");

                // Loop through every line to see if we get a match
                for (int i = 0; i < allLines.Length; i++)
                {
                    // Check if the whole line matches "username,password"
                    if (allLines[i] == targetRecord)
                    {
                        isValid = true; // Match found!
                        break; // No need to keep looking
                    }
                }
            }
            catch (FileNotFoundException)
            {
                // If the file hasn't been created yet, nobody can log in
                isValid = false;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error reading file: " + error.Message);
            }

            return isValid;
        }

        // Navigation button if the user needs to create an account first
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
            this.Hide(); // Close login window when opening SignUp
        }
   
    }
}