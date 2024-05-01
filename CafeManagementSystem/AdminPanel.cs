﻿using System;
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
        public AdminPanel()
            {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);
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
            string AvailaibleChoice=add_itemavailaible.Text;
            bool available = true;
            if (AvailaibleChoice!="Yes") {
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
            string availaibility=edit_availaibility.Text;
            bool status = true; // Assuming user input is in string format
            if(availaibility!="Yes")
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

    }
}
