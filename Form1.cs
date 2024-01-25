
using System;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private readonly BusinessLogic businessLogic;

    public Form1()
    {
        InitializeComponent();
        string connectionString = "Your_Connection_String"; 
        DataAccess dataAccess = new DataAccess(connectionString);
        businessLogic = new BusinessLogic(dataAccess);
        LoadDataGrid();
    }

    private void LoadDataGrid()
    {
        dataGridView1.DataSource = businessLogic.GetEmployees();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        string firstName = txtFirstName.Text;
        string lastName = txtLastName.Text;
        int age = Convert.ToInt32(txtAge.Text);
        decimal salary = Convert.ToDecimal(txtSalary.Text);

        businessLogic.InsertEmployee(firstName, lastName, age, salary);
        LoadDataGrid();
    }

    
}
