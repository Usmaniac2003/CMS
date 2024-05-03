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
        public SalesmanPanel()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);
        }

        private void SalesmanPanel_Load(object sender, EventArgs e)
        {
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
                    dataGridView1.DataSource = dataTable;
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
                    dataGridView2.DataSource = dataTable;
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
                    dataGridView2.DataSource = dataTable;
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
    }
}
