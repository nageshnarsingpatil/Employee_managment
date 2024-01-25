
using System;
using System.Data;

public class BusinessLogic
{
    private readonly DataAccess dataAccess;

    public BusinessLogic(DataAccess dataAccess)
    {
        this.dataAccess = dataAccess;
    }

    public DataTable GetEmployees()
    {
        return dataAccess.GetEmployees();
    }

    public void InsertEmployee(string firstName, string lastName, int age, decimal salary)
    {
        dataAccess.InsertEmployee(firstName, lastName, age, salary);
    }


}
