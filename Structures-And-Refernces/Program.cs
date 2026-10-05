class Program{
    public static void Main (){
        Customer aCustomer = new Customer ("Alex", 1);
        aCustomer.Deposit(1000);
        aCustomer.Withdraw(30);
        Console.WriteLine(aCustomer.GetBalance());

        CustomerDatabase aCustomerDatabase = new CustomerDatabase ();
            aCustomerDatabase.Add_customer(aCustomer);
            aCustomerDatabase.Print_customers();
    }
}


public class CustomerDatabase {
    public Customer[] customers;
    
    public CustomerDatabase(){
        customers = new Customer[10];
    }
    public void Add_customer(Customer customer) {
        for (int x = 0 ; x < customers.Length ; x++) {
            if (customers[x] == null){
                customers[x] = customer;
                break;
            }
        }
    }
    public void Search_customer(int customer) {
        for (int x = 0 ; x < customers.Length ; x++) {
            if (customers[x] != null && customers[x].id == customer){
                customers[x] = null;
                break;
            }
        }
    }
    public Customer[] Get_customer(){
        return customers;
    }
    public void Print_customers(){
        for (int x = 0 ; x < customers.Length ; x++){
            if (customers[x] != null) {
            Console.WriteLine(customers[x].name + " " + customers[x].id + " " + customers[x].balance);
            }
        }
    }
}

public class Customer {
    public string name ;
    public int id ; 
    public double balance ;

    public Customer (string name_val, int id_val) {
        name = name_val;
        id = id_val;
        balance = 0;
    }
    public Customer (string name_val, int id_val, double balance_val){
        name = name_val;
        id = id_val;
        balance = balance_val;
    }
    public void Deposit (double amount) {
        balance += amount;
    }
    public void Withdraw (double amount) {
        if (balance >= amount) {
            balance -= amount;
        }
    }
    public double GetBalance() {
        return balance;
    }
}