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
        public CustomerPanel()
            {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);
        }

        private void CustomerPanel_Load(object sender, EventArgs e)
        {
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
            string customerName = customer_name.Text;

            // Assuming you have a database table structure where customer name is unique and can identify a customer uniquely
            // You can modify the query accordingly based on your database schema

            // Query to retrieve order history based on customer name
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT O.OrderID, O.OrderDate, O.TotalAmount, O.Status " +
                           "FROM Orders O " +
                           "JOIN Customers C ON O.CustomerID = C.CustomerID " +
                           "WHERE C.Username = @CustomerName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerName", customerName);

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
            string id = Itemid.Text;
        }
    }
}
