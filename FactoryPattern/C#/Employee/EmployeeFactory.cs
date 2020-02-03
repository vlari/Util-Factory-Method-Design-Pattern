public interface IEmployee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public decimal Salary { get; set; }
    public string DocumentType { get; set; }

}

public class Manager : IEmployee{
    public string StoreAddress { get; set; }
    public int EmployeeCount { get; set; }
} 

public class SalesPerson : IEmployee{
    public int SalesLimit { get; set; }
    public List<Product> ProductsForSale { get; set; }
}

public abstract class EmployeeFactory{
    public IEmployee GetEmployee(string employee);
}

public class EmployeeCreator : EmployeeFactory{
    public override IEmployee GetEmployee(string employeeType){
        var employee = null;
        
        switch (employee)
        {
            case "Manager":
                employee = new Manager();
            case "SalesPerson":
                employee = new SalesPerson();
            default:
        }
    }
}