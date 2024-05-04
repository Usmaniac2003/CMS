using MaterialSkin;
using MaterialSkin.Controls;
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

namespace CafeManagementSystem
{
    public partial class SalesmanPanel : MaterialForm
    {
        int EmployeeId;
        public SalesmanPanel(int ei)
        {
            EmployeeId = ei;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);
            string Name = GetEmployeeName(EmployeeId); // adminId should be accessible here
            materialTextBox5.Text = Name;
            string email = GetEmployeeEmail(EmployeeId);
            materialTextBox6.Text = email;

        }// Function to retrieve Employee name from the database based on Employee ID
        private string GetEmployeeName(int employeeId)
        {
            string employeeName = "";

            // Your database query to retrieve Employee name based on Employee ID
            string query = "SELECT Username FROM Employees WHERE EmployeeID = @EmployeeID";
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeID", employeeId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Retrieve the employee name from the reader
                        employeeName = reader.GetString(reader.GetOrdinal("Username"));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return employeeName;
        }

        // Function to retrieve Employee email from the database based on Employee ID
        private string GetEmployeeEmail(int employeeId)
        {
            string employeeEmail = "";
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";

            // Your database query to retrieve Employee email based on Employee ID
            string query = "SELECT Email FROM Employees WHERE EmployeeID = @EmployeeID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeID", employeeId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Retrieve the employee email from the reader
                        employeeEmail = reader.GetString(reader.GetOrdinal("Email"));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return employeeEmail;
        }

        private void SalesmanPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafe1DataSet8.MenuItems' table. You can move, or remove it, as needed.
            this.menuItemsTableAdapter.Fill(this.cafe1DataSet8.MenuItems);
            // TODO: This line of code loads data into the 'cafe1DataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.cafe1DataSet.Employees);

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT C.CustomerID,C.Username, COALESCE(O.OrderCount, 0) AS OrderCount\r\nFROM Customers C\r\n JOIN (\r\n    SELECT CustomerID, COUNT(*) AS OrderCount\r\n    FROM Orders\r\n    GROUP BY CustomerID\r\n    HAVING COUNT(*) > 0 \r\n) O ON C.CustomerID = O.CustomerID;\r\n;";//Analyzes Customer Order Count
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Set the DataTable as the DataSource for dataGridView4
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT R.TableNumber, COUNT(*) AS ReservationCount, \r\n       STRING_AGG(C.Username, ', ') AS ReservedBy\r\nFROM Reservations R\r\nJOIN Customers C ON R.CustomerID = C.CustomerID\r\nGROUP BY R.TableNumber\r\nHAVING COUNT(*) > 0;\r\n";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Set the DataTable as the DataSource for dataGridView4
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void materialButton3_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT [Role], AVG(Salary) AS AvgSalary\r\nFROM Employees\r\nGROUP BY [Role]\r\nHAVING AVG(Salary) > 3000;\r\n";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Set the DataTable as the DataSource for dataGridView4
                    }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT E.EmployeeID, E.Username AS EmployeeName, SUM(OD.Quantity) AS TotalItemsSold\r\nFROM Employees E\r\nJOIN Orders O ON E.EmployeeID = O.EmployeeID\r\nJOIN OrderDetails OD ON O.OrderID = OD.OrderID\r\nGROUP BY E.EmployeeID, E.Username;\r\n";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Set the DataTable as the DataSource for dataGridView4
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
           
        }

        private void materialButton16_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Hide();

            // Show the authentication form
            Auth authForm = new Auth();
            authForm.Show();
        }

        private void materialTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            // Connection string for your database
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            int EmpId = EmployeeId; //Update this Id into Orders table

            MessageBox.Show(EmpId.ToString());
            // Example order ID - this could come from user input or previous context
            if (!int.TryParse(materialTextBox4.Text, out int orderId))
            {
                MessageBox.Show("Invalid order ID. Please enter a valid numeric order ID.", "Error");
                return;
            }

            // StringBuilder to build the bill
            StringBuilder bill = new StringBuilder();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve order details
                    string orderQuery = "SELECT * FROM dbo.Orders WHERE OrderID = @OrderID";
                    using (SqlCommand orderCommand = new SqlCommand(orderQuery, connection))
                    {
                        orderCommand.Parameters.AddWithValue("@OrderID", orderId);

                        using (SqlDataReader reader = orderCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Get basic order information
                                int customerId = reader.GetInt32(reader.GetOrdinal("CustomerID"));
                                int employeeId = reader.IsDBNull(reader.GetOrdinal("EmployeeID")) ? 0 : reader.GetInt32(reader.GetOrdinal("EmployeeID"));
                                decimal totalAmount = reader.GetDecimal(reader.GetOrdinal("TotalAmount"));
                                DateTime orderDate = reader.GetDateTime(reader.GetOrdinal("OrderDate"));

                                bill.AppendLine($"Order ID: {orderId}");
                                bill.AppendLine($"Customer ID: {customerId}");
                                bill.AppendLine($"Employee ID: {employeeId}");
                                bill.AppendLine($"Order Date: {orderDate}");
                                bill.AppendLine($"Total Amount: ${totalAmount:F2}");
                            }
                            else
                            {
                                MessageBox.Show($"Order with ID {orderId} not found.", "Error");
                                return;
                            }
                        }
                    }

                    // Retrieve order items
                    string orderDetailsQuery = "SELECT * FROM dbo.OrderDetails WHERE OrderID = @OrderID";
                    using (SqlCommand detailsCommand = new SqlCommand(orderDetailsQuery, connection))
                    {
                        detailsCommand.Parameters.AddWithValue("@OrderID", orderId);

                        bill.AppendLine("Order Items:");

                        using (SqlDataReader reader = detailsCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int menuItemId = reader.GetInt32(reader.GetOrdinal("MenuItemID"));
                                int quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                                decimal unitPrice = reader.GetDecimal(reader.GetOrdinal("UnitPrice"));
                                decimal subtotal = quantity * unitPrice;

                                bill.AppendLine($"Menu Item ID: {menuItemId}, Quantity: {quantity}, Subtotal: Rs{subtotal:F2}");
                            }
                        }
                    }

                    // Retrieve payment information
                    string paymentQuery = "SELECT * FROM dbo.Payments WHERE OrderID = @OrderID";
                    using (SqlCommand paymentCommand = new SqlCommand(paymentQuery, connection))
                    {
                        paymentCommand.Parameters.AddWithValue("@OrderID", orderId);

                        using (SqlDataReader reader = paymentCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DateTime paymentDate = reader.GetDateTime(reader.GetOrdinal("PaymentDate"));
                                string paymentMethod = reader.GetString(reader.GetOrdinal("PaymentMethod"));
                                decimal paymentAmount = reader.GetDecimal(reader.GetOrdinal("Amount"));

                                bill.AppendLine($"Payment Method: {paymentMethod}");
                                bill.AppendLine($"Payment Date: {paymentDate}");
                                bill.AppendLine($"Payment Amount: Rs{paymentAmount:F2}");
                            }
                        }
                    }

                    // Set order status to "Completed" and update employee ID
                    string updateStatusQuery = "UPDATE dbo.Orders SET Status = 'Completed', EmployeeID = @EmployeeID WHERE OrderID = @OrderID AND EmployeeID IS NULL";
                    using (SqlCommand updateCommand = new SqlCommand(updateStatusQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@OrderID", orderId);
                        updateCommand.Parameters.AddWithValue("@EmployeeID", EmpId);
                        updateCommand.ExecuteNonQuery();
                    }
                    // Set order status to "Completed" and update employee ID
                    string StatusQuery = "UPDATE dbo.Orders SET Status = 'Completed' WHERE OrderID = @OrderID";
                    using (SqlCommand updateCommand = new SqlCommand(StatusQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@OrderID", orderId);
                        updateCommand.ExecuteNonQuery();
                    }
                }

                // Display the generated bill
                materialMultiLineTextBox1.Text = bill.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                return;
            }
        }

        private void materialTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void materialButton5_Click_1(object sender, EventArgs e)
        {
            // Connection string for your database
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve pending orders
                    string pendingOrdersQuery = "SELECT * FROM dbo.Orders WHERE Status = 'Pending'";
                    using (SqlCommand command = new SqlCommand(pendingOrdersQuery, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView5.DataSource = dataTable;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            // Connection string for your database
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";

            try
            {
                // Retrieve the employee ID
                int empId = EmployeeId; // Replace EmployeeId with the actual variable or property that holds the employee ID

                // SQL query to retrieve sales by employee ID
                string salesQuery = "SELECT O.OrderID, O.OrderDate, O.TotalAmount\r\nFROM Orders O\r\nINNER JOIN Employees E ON O.EmployeeID = E.EmployeeID\r\nWHERE E.EmployeeID = @EmployeeID\r\n";

                // Create a new SqlConnection and SqlCommand
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(salesQuery, connection))
                {
                    // Add the EmployeeID parameter to the command
                    command.Parameters.AddWithValue("@EmployeeID", empId);

                    // Create a SqlDataAdapter and DataTable to hold the results
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    // Open the connection, fill the DataTable with data, and close the connection
                    connection.Open();
                    adapter.Fill(dataTable);
                    connection.Close();

                    // Bind the DataTable to the DataGridView
                    dataGridView6.DataSource = dataTable;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
