using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace CafeManagementSystem
{
    public partial class Auth : MaterialForm
    {
        public Auth()
        {
            InitializeComponent();
            
            var greenColorScheme = new ColorScheme(
    Primary.Green800,   // Primary color for the UI elements like the app bar
    Primary.Green900,   // Darker primary color for darker UI elements
    Primary.Green500,   // Lighter shade for secondary UI elements
    Accent.LightGreen700, // Accent color for highlights and icons
    TextShade.WHITE      // Text color to ensure good contrast
);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = greenColorScheme;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            string name = username_register.Text;
            string Email = email.Text;
            string Contact = contact.Text;
            string password = password_register.Text;
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";

            // SQL query to insert a new customer into the Customers table
            string query = "INSERT INTO Customers (Username, Email, [Password], [Role]) " +
                           "VALUES (@Username, @Email, @Password, @Role)";

            // Assuming default role for customers
            string role = "Customer";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", name);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Role", role);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful!");
                        // Clear the input fields after successful registration
                        username_register.Text = "";
                        email.Text = "";
                        contact.Text = "";
                        password_register.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Registration failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void materialTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = username_login.Text;
            string password = password_login.Text;
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";

            // SQL query to select admin based on username and password
            string adminQuery = "SELECT * FROM Admins WHERE Username = @Username AND [Password] = @Password";

            // SQL query to select employee based on username and password
            string employeeQuery = "SELECT * FROM Employees WHERE Username = @Username AND [Password] = @Password";

            // SQL query to select customer based on username and password
            string customerQuery = "SELECT * FROM Customers WHERE Username = @Username AND [Password] = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                SqlDataReader reader = null;

                try
                {
                    connection.Open();

                    // Check Admins table
                    command.CommandText = adminQuery;
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int adminId = reader.GetInt32(reader.GetOrdinal("AdminID"));

                        // Admin found, redirect to AdminPanel
                        AdminPanel adminPanel = new AdminPanel(adminId);
                        adminPanel.Show();
                        this.Hide();
                        return;
                    }
                    reader.Close();

                    // Check Employees table
                    command.CommandText = employeeQuery;
                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                    int EmployeeId = reader.GetInt32(reader.GetOrdinal("EmployeeId"));
                        // Employee found, redirect to EmployeePanel
                        SalesmanPanel employeePanel = new SalesmanPanel(EmployeeId);
                        employeePanel.Show();
                        this.Hide();
                        return;
                    }
                    reader.Close();

                    // Check Customers table
                    command.CommandText = customerQuery;
                    reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                    int CustomerId = reader.GetInt32(reader.GetOrdinal("CustomerId"));
                        // Customer found, redirect to CustomerPanel
                        CustomerPanel customerPanel = new CustomerPanel(CustomerId);
                        customerPanel.Show();
                        this.Hide();
                        return;
                    }

                    // No user found with the provided credentials
                    MessageBox.Show("Invalid username or password");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                }
            }
        }


    }
}
