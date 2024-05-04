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
using System.Windows.Media.Media3D;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CafeManagementSystem
    {
    public partial class CustomerPanel : MaterialForm
        {
        int CustomerId;
        public CustomerPanel(int ci)
            {
            CustomerId= ci;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);
            string Name = GetCustomerName(CustomerId); // adminId should be accessible here
            materialTextBox5.Text = Name;
            string email = GetCustomerEmail(CustomerId);
            materialTextBox6.Text = email;

        }
        // Function to retrieve Customer name from the database based on Customer ID
        private string GetCustomerName(int customerId)
        {
            string customerName = "";

            // Your database query to retrieve Customer name based on Customer ID
            string query = "SELECT Username FROM Customers WHERE CustomerID = @CustomerID";
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Retrieve the customer name from the reader
                        customerName = reader.GetString(reader.GetOrdinal("Username"));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return customerName;
        }

        // Function to retrieve Customer email from the database based on Customer ID
        private string GetCustomerEmail(int customerId)
        {
            string customerEmail = "";
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";

            // Your database query to retrieve Customer email based on Customer ID
            string query = "SELECT Email FROM Customers WHERE CustomerID = @CustomerID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Retrieve the customer email from the reader
                        customerEmail = reader.GetString(reader.GetOrdinal("Email"));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return customerEmail;
        }

        private void CustomerPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafe1DataSet9.Promotions' table. You can move, or remove it, as needed.
            this.promotionsTableAdapter.Fill(this.cafe1DataSet9.Promotions);
            // TODO: This line of code loads data into the 'cafe1DataSet5.MenuItems' table. You can move, or remove it, as needed.
            this.menuItemsTableAdapter.Fill(this.cafe1DataSet5.MenuItems);

        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            // Retrieve the table ID and number of people from the input fields
            string tableId = table_id.Text;
            string numberOfPeople = peoplecount.Text;

            // Current date and time for reservation date
            DateTime reservationDate = DateTime.Now;

            // Assuming you have a variable to hold the customer ID, let's name it customerId
            int customerId = 1; // Replace 1 with the actual customer ID

            // Insert the reservation details into the Reservations table
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "INSERT INTO Reservations (CustomerID, ReservationDate, NumberOfPeople, TableNumber) VALUES (@CustomerId, @ReservationDate, @NumberOfPeople, @TableNumber)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerId", customerId);
                command.Parameters.AddWithValue("@ReservationDate", reservationDate);
                command.Parameters.AddWithValue("@NumberOfPeople", numberOfPeople);
                command.Parameters.AddWithValue("@TableNumber", tableId);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Table reserved successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to reserve the table.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            // Retrieve the customer name from the input field

            // Assuming you have a database table structure where customer name is unique and can identify a customer uniquely
            // You can modify the query accordingly based on your database schema

            // Query to retrieve order history based on customer name
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT O.OrderID, O.OrderDate, O.TotalAmount, O.Status " +
                           "FROM Orders O " +
                           "JOIN Customers C ON O.CustomerID = C.CustomerID " +
                           "WHERE C.CustomerId = @CustomerId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerId", CustomerId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Display order history in a DataGridView or any other UI component
                        DataTable orderHistory = new DataTable();
                        orderHistory.Load(reader);
                        dataGridView2.DataSource = orderHistory;
                    }
                    else
                    {
                        MessageBox.Show("No order history found for the customer.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Gather data from form controls
            string customerIDText = this.CustomerId.ToString(); // Customer ID
            string salesItemText = Itemid.Text; // Item IDs (possibly CSV)
            string quantityText = materialTextBox1.Text; // Quantities (corresponding CSV)

            // Validate the inputs to ensure they are not empty
            if (string.IsNullOrWhiteSpace(customerIDText) ||
                string.IsNullOrWhiteSpace(salesItemText) ||
                string.IsNullOrWhiteSpace(quantityText))
            {
                MessageBox.Show("Please ensure all fields are filled in.", "Validation Error");
                return;
            }

            try
            {
                // Convert text input into appropriate data types
                int customerID = int.Parse(customerIDText); // Customer ID
               

                // Split and parse item IDs and quantities
                string[] itemIDs = salesItemText.Split(',');
                string[] quantities = quantityText.Split(',');

                // Ensure the lengths of item IDs and quantities are the same
                if (itemIDs.Length != quantities.Length)
                {
                    MessageBox.Show("Item IDs and quantities must have the same length.", "Validation Error");
                    return;
                }

                // Create a DataTable to represent the OrderItemsType table-valued parameter
                DataTable menuItems = new DataTable();
                menuItems.Columns.Add("MenuItemID", typeof(int));
                menuItems.Columns.Add("Quantity", typeof(int));

                // Add rows to the DataTable
                for (int i = 0; i < itemIDs.Length; i++)
                {
                    int itemID = int.Parse(itemIDs[i]);
                    int quantity = int.Parse(quantities[i]);

                    DataRow row = menuItems.NewRow();
                    row["MenuItemID"] = itemID;
                    row["Quantity"] = quantity;

                    menuItems.Rows.Add(row);
                }

                // Set up the SQL connection
                string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";// Your SQL Server connection string

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Open the connection

                    // Create a SqlCommand to call the stored procedure
                    using (SqlCommand command = new SqlCommand("CreateOrderWithDetails", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters for the stored procedure
                        command.Parameters.AddWithValue("@CustomerID", customerID); // Customer ID
                        command.Parameters.AddWithValue("@MenuItems", menuItems); // Order items
                        command.Parameters.AddWithValue("@PaymentMethod", "Cash"); // Default to cash if not specified

                        // Execute the command to call the stored procedure
                        command.ExecuteNonQuery(); // Executes the stored procedure

                        // Inform the user that the order was created successfully
                        MessageBox.Show("Order created successfully!", "Success");
                    }
                }
            }
            catch (FormatException ex)
            {
                // Handle format errors
                MessageBox.Show($"Invalid input format: {ex.Message}", "Format Error");
            }
            catch (SqlException ex)
            {
                // Handle SQL errors
                MessageBox.Show($"Database error: {ex.Message}", "Database Error");
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }





        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel17_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton6_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel19_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector3_Click(object sender, EventArgs e)
        {

        }

        private void materialButton11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void materialButton7_Click(object sender, EventArgs e)
        {

        }

        private void materialButton5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton9_Click(object sender, EventArgs e)
        {

        }

        private void materialButton10_Click(object sender, EventArgs e)
        {

        }

        private void materialButton12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel27_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel28_Click(object sender, EventArgs e)
        {

        }

        private void materialButton16_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void materialButton16_Click_1(object sender, EventArgs e)
        {
            // Close the current form
            this.Hide();

            // Show the authentication form
            Auth authForm = new Auth();
            authForm.Show();
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
