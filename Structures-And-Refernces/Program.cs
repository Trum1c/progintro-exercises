// 12.1: Customers Topic
class Program{
    public static void Main()
    {
        Customer aCustomer = new Customer("Alex", 1);
        aCustomer.Deposit(30);
        aCustomer.Withdraw(20);
        Console.WriteLine(aCustomer.GetBalance());
    }
}
public class Customer
{
    // Attribute:
    public string name;
    public int id;
    public double balance;

    public Customer(string name_val, int id_val)
    {
        //constructor 
        name = name_val;
        id = id_val;
        balance = 0;
    }
    public Customer(string name_val, int id_val, double balance_val)
    {
        //constructor 
        name = name_val;
        id = id_val;
        balance = balance_val;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }
    
    public void Withdraw(double amount)
    {
        if (balance>=amount)
        {
            balance -= amount;
        }
    }

    public double GetBalance()
    {
       return balance;
    }
    
}
// 12.2: Customer Database Topic
public class CustomerDatabase
{
    //Attribute
    public Customer[] customers;

    public CustomerDatabase()
    {
        customers = new Customer[10];        
    }

    public void AddCustomer(Customer customer)
    {
        for (int x = 0 ; x<customers.Length ; x++)
        {
            if (customers[x] == null)
            {
                customers[x] = customer;
                break;
            }
        }
    }

    public void SearchCostomer(int customers)
    {
        for (int i = 0; i<customers.Length ; i++)
        {
            if (customers[i].id == id && customers[i] != null){
                customers[i] = null;
                break;
            }
        }
    }

    public Customer[] GetCustomers()
    {
    return customers;
    }

    public void PrintCustomer()
    {
        for (int p = 0 ; p<customers.Length ; p++)
        {
            if (customers[p] != null)
            {
                Console.WriteLine(customers[p].name +"" + customers[p].id + "" + customers[p].balance);
            }
        }
    }
}
