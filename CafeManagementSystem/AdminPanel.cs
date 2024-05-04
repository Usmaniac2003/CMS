using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;
namespace CafeManagementSystem
{
    public partial class AdminPanel : MaterialForm
    {
        int Adminid;
        public AdminPanel(int AdminId)
        {
            Adminid = AdminId;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);
            string adminName = GetAdminName(Adminid); // adminId should be accessible here
            materialTextBox5.Text = adminName;
            string email = GetAdminEmail(Adminid);
            materialTextBox6.Text = email;
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {
            //live bar chart code here

        }

        private void chart1_Click(object sender, EventArgs e)
        {



        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {


        }

        private void Items_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialCard4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void materialCard11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialCard3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged_1(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage7_Click_1(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            string name = emp_name.Text;
            string password = emp_password.Text;
            decimal salary = Convert.ToDecimal(emp_salary.Text);
            // Set the hire date to the current date
            string hireDate = DateTime.Today.ToString("yyyy-MM-dd");

            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";

            // SQL query to insert a new employee into the Employees table
            string query = "INSERT INTO Employees (Username, [Password], [Role], Email, Salary, HireDate) " +
                           "VALUES (@Username, @Password, @Role, @Email, @Salary, @HireDate)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", name);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Role", "Employee");
                // Assuming email is not mandatory and can be left empty
                command.Parameters.AddWithValue("@Email", DBNull.Value);
                command.Parameters.AddWithValue("@Salary", salary);
                command.Parameters.AddWithValue("@HireDate", hireDate);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee added successfully!");
                        // Clear the input fields after successful addition
                        emp_name.Text = "";
                        emp_password.Text = "";
                        emp_salary.Text = "";
                        // No need to clear the hire date field if it's set to the current date
                    }
                    else
                    {
                        MessageBox.Show("Failed to add employee!");
                    }
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

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafe1DataSet7.MenuItems' table. You can move, or remove it, as needed.
            this.menuItemsTableAdapter1.Fill(this.cafe1DataSet7.MenuItems);
            // TODO: This line of code loads data into the 'cafe1DataSet6.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter1.Fill(this.cafe1DataSet6.Inventory);
            // TODO: This line of code loads data into the 'cafe1DataSet2.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.cafe1DataSet2.Inventory);
            // TODO: This line of code loads data into the 'cafe1DataSet1.MenuItems' table. You can move, or remove it, as needed.
            this.menuItemsTableAdapter.Fill(this.cafe1DataSet1.MenuItems);
            // TODO: This line of code loads data into the 'cafe1DataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter1.Fill(this.cafe1DataSet.Employees);
            // TODO: This line of code loads data into the 'rMS2DataSet.Employees' table. You can move, or remove it, as needed.

        }

        private void materialTabSelector3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel15_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel19_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            string id = emp_id.Text;

            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";

            // SQL query to delete an employee from the Employees table based on EmployeeID
            string query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeID", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee removed successfully!");
                        // Clear the input field after successful removal
                        emp_id.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No employee found with the provided ID!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            string name = add_item_name.Text;
            decimal price = Convert.ToDecimal(add_itemprice.Text);
            string desc = add_itemdesc.Text;
            string category = add_itemcategory.Text;
            string AvailaibleChoice = add_itemavailaible.Text;
            bool available = true;
            if (AvailaibleChoice != "Yes")
            {
                available = false;
            }

            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";

            // SQL query to insert a new item into the MenuItems table
            string query = "INSERT INTO MenuItems ([Name], Description, Price, Category, Available) " +
                           "VALUES (@Name, @Description, @Price, @Category, @Available)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", desc);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@Available", available);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item added successfully!");
                        // Clear the input fields after successful addition
                        add_item_name.Text = "";
                        add_itemprice.Text = "";
                        add_itemdesc.Text = "";
                        add_itemcategory.Text = "";
                        add_itemavailaible.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Failed to add item!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void materialLabel17_Click(object sender, EventArgs e)
        {

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            string id = remove_itemid.Text;

            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";

            // SQL query to delete an item from the MenuItems table based on MenuItemID
            string query = "DELETE FROM MenuItems WHERE MenuItemID = @MenuItemID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MenuItemID", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item removed successfully!");
                        remove_itemid.Text = ""; // Clear the input field after successful removal

                    }
                    else
                    {
                        MessageBox.Show("No item found with the provided ID!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            string id = edit_itemid.Text;
            string name = edit_itemname.Text;
            decimal price = Convert.ToDecimal(edit_itemprice.Text);
            string desc = edit_desc.Text;
            string availaibility = edit_availaibility.Text;
            bool status = true; // Assuming user input is in string format
            if (availaibility != "Yes")
            {
                status = false;
            }


            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";

            // SQL query to update an item in the MenuItems table based on MenuItemID
            string query = "UPDATE MenuItems SET [Name] = @Name, Price = @Price, Description = @Description, Available = @Available WHERE MenuItemID = @MenuItemID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Description", desc);
                command.Parameters.AddWithValue("@Available", status);
                command.Parameters.AddWithValue("@MenuItemID", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item updated successfully!");
                        // Clear the input fields after successful update
                        edit_itemid.Text = "";
                        edit_itemname.Text = "";
                        edit_itemprice.Text = "";
                        edit_desc.Text = "";
                        edit_availaibility.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("No item found with the provided ID!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT *\r\nFROM MenuItems\r\nWHERE Price > (\r\n    SELECT AVG(Price)\r\n    FROM MenuItems\r\n);\r\n"; // Replace YourTable with your actual table name
            //Retrieve the names of menu items that have a price higher than the average price of all menu items. SubQuery-1
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
                    dataGridView4.DataSource = dataTable;
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

        private void materialButton8_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT *\r\nFROM Employees\r\nWHERE EmployeeID IN (\r\n    SELECT EmployeeID\r\n    FROM (\r\n        SELECT EmployeeID, COUNT(*) AS NumShifts\r\n        FROM Shifts\r\n        GROUP BY EmployeeID\r\n    ) AS EmployeeShiftCounts\r\n    WHERE NumShifts > (\r\n        SELECT AVG(NumShifts)\r\n        FROM (\r\n            SELECT COUNT(*) AS NumShifts\r\n            FROM Shifts\r\n            GROUP BY EmployeeID\r\n        ) AS AvgShiftsPerEmployee\r\n    )\r\n);\r\n"; // Replace YourTable with your actual table name
            //Retrieve the names of employees who have worked more shifts than the average number of shifts worked by all employees.
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
                    dataGridView5.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT *, (\r\n    SELECT COUNT(*)\r\n    FROM MenuItems\r\n    WHERE Category = Categories.Category\r\n) AS ItemCount\r\nFROM (\r\n    SELECT DISTINCT Category\r\n    FROM MenuItems\r\n) AS Categories;\r\n"; // Replace YourTable with your actual table name
            //Count the number of menu items in each category.
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
                    dataGridView6.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }

        }

        private void materialButton10_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT *\r\nFROM Tables\r\nWHERE Capacity >= (\r\n    SELECT MAX(NumberOfPeople)\r\n    FROM Reservations\r\n    WHERE TableNumber = Tables.TableNumber\r\n);\r\n";
            //Check if any table has available capacity for a reservation with a specified number of people.

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
                    dataGridView7.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void materialButton11_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT E.EmployeeID, E.Username AS EmployeeName, \r\n       SUM(O.TotalAmount) AS TotalRevenue\r\nFROM Orders O\r\nJOIN Employees E ON O.EmployeeID = E.EmployeeID\r\nGROUP BY E.EmployeeID, E.Username\r\nHAVING SUM(O.TotalAmount) > 100;\r\n";
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
                    dataGridView8.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView8_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton12_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "\r\nSELECT C.CustomerID, C.Username AS CustomerName, SUM(O.TotalAmount) AS TotalSpent\r\nFROM Customers C\r\nJOIN Orders O ON C.CustomerID = O.CustomerID\r\nGROUP BY C.CustomerID, C.Username;";
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
                    dataGridView9.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton13_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT O.OrderID, O.OrderDate, O.TotalAmount, O.Status,\r\n       E.EmployeeID, E.Username AS EmployeeUsername, E.Email AS EmployeeEmail\r\nFROM Orders O\r\nJOIN Employees E ON O.EmployeeID = E.EmployeeID;\r\n";
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
                    dataGridView10.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView10_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            string search = itemSearch.Text;
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT * FROM Menuitems WHERE [Name] LIKE '%' + @Search + '%' OR Description LIKE '%' + @Search + '%'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Search", search);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    // Set the DataTable as the DataSource for dataGridView4
                    dataGridView11.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialTabSelector4_Click(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged_2(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
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


        private string GetAdminName(int adminId)
        {
            string adminName = "";

            // Your database query to retrieve Admin name based on Admin ID
            string query = "SELECT Username FROM Admins WHERE AdminID = @AdminID";
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AdminID", adminId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Retrieve the admin name from the reader
                        adminName = reader.GetString(reader.GetOrdinal("Username"));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return adminName;
        }
        private string GetAdminEmail(int adminId)
        {
            string adminName = "";

            // Your database query to retrieve Admin name based on Admin ID
            string query = "SELECT Email FROM Admins WHERE AdminID = @AdminID";
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AdminID", adminId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Retrieve the admin name from the reader
                        adminName = reader.GetString(reader.GetOrdinal("Email"));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return adminName;
        }

        private void materialLabel28_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel27_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialCard9_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void materialTabSelector4_Click_1(object sender, EventArgs e)
        {

        }

        private void materialButton5_Click_1(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT *\r\nFROM MenuItems\r\nWHERE Price > (\r\n    SELECT AVG(Price)\r\n    FROM MenuItems\r\n);\r\n"; // Replace YourTable with your actual table name
            //Retrieve the names of menu items that have a price higher than the average price of all menu items. SubQuery-1
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
                    dataGridView4.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void materialButton8_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT *\r\nFROM Employees\r\nWHERE EmployeeID IN (\r\n    SELECT EmployeeID\r\n    FROM (\r\n        SELECT EmployeeID, COUNT(*) AS NumShifts\r\n        FROM Shifts\r\n        GROUP BY EmployeeID\r\n    ) AS EmployeeShiftCounts\r\n    WHERE NumShifts > (\r\n        SELECT AVG(NumShifts)\r\n        FROM (\r\n            SELECT COUNT(*) AS NumShifts\r\n            FROM Shifts\r\n            GROUP BY EmployeeID\r\n        ) AS AvgShiftsPerEmployee\r\n    )\r\n);\r\n"; // Replace YourTable with your actual table name
            //Retrieve the names of employees who have worked more shifts than the average number of shifts worked by all employees.
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
                    dataGridView5.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void materialButton9_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT *, (\r\n    SELECT COUNT(*)\r\n    FROM MenuItems\r\n    WHERE Category = Categories.Category\r\n) AS ItemCount\r\nFROM (\r\n    SELECT DISTINCT Category\r\n    FROM MenuItems\r\n) AS Categories;\r\n"; // Replace YourTable with your actual table name
            //Count the number of menu items in each category.
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
                    dataGridView6.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }

        }

        private void materialButton13_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT O.OrderID, O.OrderDate, O.TotalAmount, O.Status,\r\n       E.EmployeeID, E.Username AS EmployeeUsername, E.Email AS EmployeeEmail\r\nFROM Orders O\r\nJOIN Employees E ON O.EmployeeID = E.EmployeeID;\r\n";
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
                    dataGridView10.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void materialTabSelector5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage26_Click(object sender, EventArgs e)
        {

        }

        private void materialButton17_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT \r\n    mi.Name AS MenuItem,\r\n    SUM(od.Quantity) AS TotalQuantitySold,\r\n    SUM(od.Quantity * od.UnitPrice) AS TotalRevenue\r\nFROM \r\n    OrderDetails AS od\r\nINNER JOIN \r\n    MenuItems AS mi ON od.MenuItemID = mi.MenuItemID\r\nINNER JOIN \r\n    Orders AS o ON od.OrderID = o.OrderID\r\nWHERE \r\n    o.OrderDate >= DATEADD(MONTH, -1, GETDATE())  -- Last month's data\r\nGROUP BY \r\n    mi.Name\r\nORDER BY \r\n    TotalRevenue DESC\r\n";
            //Retrieve the names of menu items that have a price higher than the average price of all menu items. SubQuery-1
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
                    dataGridView14.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void dataGridView14_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton18_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT \r\n    o.OrderID,\r\n    o.OrderDate,\r\n    e.Username AS EmployeeName,\r\n    s.ShiftDate,\r\n    s.StartTime,\r\n    s.EndTime\r\nFROM \r\n    Orders AS o\r\nINNER JOIN \r\n    Employees AS e ON o.EmployeeID = e.EmployeeID\r\nINNER JOIN \r\n    Shifts AS s ON e.EmployeeID = s.EmployeeID\r\nWHERE \r\n    s.ShiftDate = CAST(o.OrderDate AS DATE)  -- Ensure orders match shifts\r\n";
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
                    dataGridView15.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView15_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton19_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT \r\n    mi.Name AS MenuItemName,\r\n    i.StockLevel,\r\n    i.ReorderThreshold,\r\n    SUM(od.Quantity) AS TotalUsed,\r\n    MAX(i.LastUpdated) AS LastUpdated\r\nFROM \r\n    Inventory AS i\r\nINNER JOIN \r\n    MenuItems AS mi ON i.MenuItemID = mi.MenuItemID\r\nINNER JOIN \r\n    OrderDetails AS od ON mi.MenuItemID = od.MenuItemID\r\nGROUP BY \r\n    mi.Name, \r\n    i.StockLevel, \r\n    i.ReorderThreshold\r\n";
            //Retrieve the names of menu items that have a price higher than the average price of all menu items. SubQuery-1
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
                    dataGridView16.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void dataGridView16_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton20_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT\r\n    o.OrderID,\r\n    o.OrderDate,\r\n    c.Username AS CustomerName,\r\n    e.Username AS EmployeeName,\r\n    mi.Name AS MenuItemName,\r\n    od.Quantity,\r\n    od.UnitPrice,\r\n    (od.Quantity * od.UnitPrice) AS Subtotal\r\nFROM\r\n    Orders AS o\r\nINNER JOIN\r\n    Customers AS c ON o.CustomerID = c.CustomerID\r\nLEFT JOIN\r\n    Employees AS e ON o.EmployeeID = e.EmployeeID\r\nINNER JOIN\r\n    OrderDetails AS od ON o.OrderID = od.OrderID\r\nINNER JOIN\r\n    MenuItems AS mi ON od.MenuItemID = mi.MenuItemID\r\n";
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
                    dataGridView17.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridView17_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton21_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-B92AG2K\\SQLEXPRESS;Initial Catalog=cafe1;Integrated Security=True";
            string query = "SELECT\r\n    p.PaymentID,\r\n    p.PaymentDate,\r\n    p.PaymentMethod,\r\n    p.Amount,\r\n    c.Username AS CustomerName,\r\n    o.OrderID,\r\n    od.Quantity,\r\n    mi.Name AS MenuItemName\r\nFROM\r\n    Payments AS p\r\nINNER JOIN\r\n    Orders AS o ON p.OrderID = o.OrderID\r\nINNER JOIN\r\n    Customers AS c ON o.CustomerID = c.CustomerID\r\nINNER JOIN\r\n    OrderDetails AS od ON o.OrderID = od.OrderID\r\nINNER JOIN\r\n    MenuItems AS mi ON od.MenuItemID = mi.MenuItemID\r\n";
            //Check if any table has available capacity for a reservation with a specified number of people.

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
                    dataGridView18.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void dataGridView18_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton22_Click(object sender, EventArgs e)
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
                    dataGridView19.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void dataGridView19_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton23_Click(object sender, EventArgs e)
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
                    dataGridView20.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }

        }

        private void materialButton24_Click(object sender, EventArgs e)
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
                    dataGridView21.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void dataGridView21_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialButton25_Click(object sender, EventArgs e)
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
                    dataGridView22.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }
    }
}
