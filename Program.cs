using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankApplication
{


    //Multocast Delegation ......!
    public delegate void displayDelegate();

    // Creating an ExceptionClasss
    public class LimitExceedExcep : Exception

    {

        public LimitExceedExcep(string message) : base(message)
        {
        }



    }

    //Customer Object Declaration 
    public class Customer

    {
        public string Username
        {
            get;
            set;

        }
        public string Password
        {
            get;
            set;

        }
        public int AccountNumber
        {
            get;
            set;
        }
        public string name

        {

            get;

            set;

        }

        public int Age

        {

            get; set;

        }



        public string AccountType

        {

            get;

            set;

        }

        public string Address

        {

            get;

            set;

        }

        public string Contact

        {

            get;

            set;

        }

        public double Balance

        {

            get;

            set;

        }



    }

    //Class for creatig Personal Account 
    public class CreatePersonalAccount
    {
        //Complex List Declraration
        public static List<Customer> CustomerDetails = new List<Customer>();


        // Method for Adding Customer Details Statically
        public void StaticCustomerDetails()
        {
            Customer c1 = new Customer()

            {

                Username = "Sakth101",
                Password = "1233",
                AccountNumber = 101,

                name = "Shakthi",

                Age = 23,

                AccountType = "savings Account",

                Address = "Chennai",

                Contact = "3451278909",

                Balance = 10000



            };

            Customer c2 = new Customer()

            {
                Username = "john121",
                Password = "123993",
                AccountNumber = 102,
                name = "John",

                Age = 26,

                AccountType = "CurrentAccount",

                Address = "Bangalore",

                Contact = "7825962909",

                Balance = 10000



            };

            Customer c3 = new Customer()

            {
                Username = "Divya123",
                Password = "123312",
                AccountNumber = 102,
                name = "Divya",

                Age = 27,

                AccountType = "Savings Account",

                Address = "Coimbatore",

                Contact = "7532850589",

                Balance = 10000



            };



            CustomerDetails.Add(c1);

            CustomerDetails.Add(c2);

            CustomerDetails.Add(c3);
        }


        //Login Details 
        public void LoginPage()
        {

        }
        public void data()
        {
            StreamWriter sw = new StreamWriter("C:\\First.txt");
            Console.WriteLine("enter the data you want to write in file");
            sw.WriteLine("||Account Number||Name || Age||AccountType|| Address || Contact Number || Balance || ");
            foreach (Customer c in CustomerDetails)
            {
                sw.WriteLine("||{0}||{1}||{2}||{3}||{4}||{5}||{6}", c.AccountNumber, c.name, c.Age, c.AccountType, c.Address, c.Contact, c.Balance);
            }

            sw.Flush();
            sw.Close();
        }

        //Methos for Creating Account
        public void CreateAccount()
        {
            Console.WriteLine("Choose Option Below \n 1.Saving Account \n 2.Current Account \n 3.ChildCare Account \n 4.Exit\n");
            Console.WriteLine(new string('*', 100));
            int choice = Convert.ToInt32(Console.ReadLine());
            int accountNumber;
            string nameOff, address, contact, username, pass;
            int age;
            double balance;

            if (choice > 0 && choice < 4)
            {
                Console.WriteLine("Enter Account Number ");
                accountNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your Name ");
                nameOff = Console.ReadLine();
                Console.WriteLine("Enter Your age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your adress:");
                address = Console.ReadLine();
                Console.WriteLine("Enter Your MObile Number:");
                contact = Console.ReadLine();
                Console.WriteLine("Enter Your Amout You Want to Deposite");
                balance = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter your UserName");
                username = Console.ReadLine();
                Console.WriteLine("Enter Password");
                pass = Console.ReadLine();

                switch (choice)
                {
                    case 1:
                        try
                        {

                            if (balance < 100000)
                            {
                                Customer EnteredDetails = new Customer()
                                {
                                    AccountNumber = accountNumber,
                                    name = nameOff,
                                    Age = age,
                                    AccountType = "saving Account ",
                                    Address = address,
                                    Contact = contact,
                                    Balance = balance,
                                    Username = username,
                                    Password = pass,

                                };
                                CustomerDetails.Add(EnteredDetails);

                            }
                            else
                            {
                                throw (new LimitExceedExcep("Note : You Have to Deposite mare than 100000/- Rs  !!"));
                            }
                        }
                        catch (LimitExceedExcep e)
                        {
                            Console.WriteLine(e);
                        }

                        break;
                    case 2:
                        try
                        {

                            if (balance < 200000)
                            {
                                Customer EnteredDetails1 = new Customer()
                                {
                                    AccountNumber = accountNumber,
                                    name = nameOff,
                                    Age = age,
                                    AccountType = "Current  Account ",
                                    Address = address,
                                    Contact = contact,
                                    Balance = balance,
                                    Username = username,
                                    Password = pass,

                                };
                                CustomerDetails.Add(EnteredDetails1);
                            }
                            else
                            {
                                throw (new LimitExceedExcep("Note : Your daily limit exceeded !!"));
                            }
                        }
                        catch (LimitExceedExcep e)
                        {
                            Console.WriteLine(e);
                        }
                        break;
                    case 3:
                        try
                        {

                            if (balance < 50000)
                            {

                                Customer EnteredDetails2 = new Customer()
                                {
                                    AccountNumber = accountNumber,
                                    name = nameOff,
                                    Age = age,
                                    AccountType = "ChildCare Account ",
                                    Address = address,
                                    Contact = contact,
                                    Balance = balance,
                                    Username = username,
                                    Password = pass,

                                };
                                CustomerDetails.Add(EnteredDetails2);
                            }
                            else
                            {
                                throw (new LimitExceedExcep("Note : Your daily limit exceeded !!"));
                            }
                        }
                        catch (LimitExceedExcep e)
                        {
                            Console.WriteLine(e);
                        }

                        break;
                    default:
                        {
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Opps! Choose the Correct one");

            }


        }

        //Method  for Dispaly ALL Customeres lst 
        public void displayDetails()
        {

            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", " ****Available Account Details****"));
            data();
            foreach (Customer c in CustomerDetails)
            {

                Console.WriteLine(new string('=', 100));
                Console.WriteLine("||Username ||Account Number||Name || Age||AccountType|| Address || Contact Number || Balance ||PassWord ");
                Console.WriteLine("||{0}||{1}||{2}||{3}||{4}||{5}||{6}||{7}||", c.Username, c.AccountNumber, c.name, c.Age, c.AccountType, c.Address, c.Contact, c.Balance, c.Password);
                Console.WriteLine(new string('=', 100));
            }
        }

    }

    //class for DepositeAmount into account 
    class depositeAmount : CreatePersonalAccount
    {
        double bal;

        // Method For Depositing the AMOUNT iNTO ACCOUNT 
        public void deposite()
        {
            Console.WriteLine("Enter Amount:\n");
            bal = Convert.ToDouble(Console.ReadLine());
            depositeCustomerById(CustomerDetails);
        }
        //Method to find the particular customer details from the list and Deposite some money (Lambda Expressions)
        public void depositeCustomerById(List<Customer> CustomerDetails)
        {
            Console.WriteLine("Enter Account number");
            int accNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter UserName ");
            string uname = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string pas = Console.ReadLine();
            if (CustomerDetails.Count > 0)
            {
                var Detail = CustomerDetails.FirstOrDefault(x => x.AccountNumber == accNumber && x.Username == uname && x.Password == pas);

                if (Detail != null)
                {
                    List<Customer> acFound = new List<Customer>();
                    acFound.Add(Detail);
                    foreach (Customer c in acFound)
                    {
                        c.Balance += bal;
                        Console.WriteLine(new string(' ', 50) + "Amount Credited  successfully \n AvailableBalance:-{0} ", c.Balance);
                    }
                }
                else
                {
                    Console.WriteLine("Sorry :( no Records  find !" + "\u003A");
                    CreateAccount();
                }

            }


        }
    }

    //Class for Withdraw Money From a perticular Account 
    class withDrawAmount : depositeAmount
    {
        double amount1;
        // With draw money from the specified account was given (Lmbda Expressions)
        public void withDrawCustomerById(List<Customer> CustomerDetails)
        {
            Console.WriteLine("Enter Account number");
            int accNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter UserName ");
            string uname1 = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string pas1 = Console.ReadLine();
            if (CustomerDetails.Count > 0)
            {
                var Detail = CustomerDetails.FirstOrDefault(x => x.AccountNumber == accNumber && x.Username == uname1 && x.Password == pas1);

                if (Detail != null)
                {
                    List<Customer> acFound = new List<Customer>();
                    acFound.Add(Detail);
                    foreach (Customer c in acFound)
                    {
                        c.Balance -= amount1;

                        Console.WriteLine("Amount Debited successfully \n AvailableBalance:-{0} ", c.Balance);
                        Console.WriteLine(new string('*', 100));
                    }
                }
                else
                {
                    Console.WriteLine("\n\nSorry :( no Records  find !\n");
                    CreateAccount();
                }

            }



        }
        //Metod For With Draww mONEY 
        public void WithDraw(int count)
        {
            Console.WriteLine("Enter Amount");
            amount1 = Convert.ToDouble(Console.ReadLine());
            withDrawCustomerById(CustomerDetails);




        }
    }
    // Class for home page
    class HomePage : withDrawAmount
    {
        //Home page Where all the details are vailable

        public void HomeSection()
        {
            int count = 0;
            while (true)
            {
                if (count < 3)
                {
                    Console.WriteLine(new string('*', 100));
                    displayCustomerById(CustomerDetails);
                    Console.WriteLine("Choose Below Detailss \n1.deposite\n2.Withdraw\n3.Check Balance\n4.Logout");
                    Console.WriteLine(new string('*', 100));


                    int option = Convert.ToInt32(Console.ReadLine());


                    if (option == 1)
                    {
                        deposite();
                    }
                    else if (option == 2)
                    {
                        count += 1;
                        WithDraw(count);
                    }
                    else if (option == 3)
                    {
                        Console.WriteLine("Check Details");
                        displayCustomerById(CustomerDetails);
                    }
                    else if (option == 4)
                    {

                        Console.Clear();
                        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
                        Console.WriteLine("\t\t\t\t\t\tTh@Nk YoU\t\t\t\t\t\t");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Choose Correct Option ");
                        break;

                    }
                }
                else
                {
                    Console.WriteLine("Transaction Limit Excceeded!:(");
                    break;
                }
            }
        }

        //display the details of the customer  when account number is provided 
        //Lambda Expressions

        public void displayCustomerById(List<Customer> CustomerDetails)
        {
            Console.WriteLine("Enter Account number");
            int accNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter UserName ");
            string uname2 = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string pas2 = Console.ReadLine();
            if (CustomerDetails.Count > 0)
            {
                var Detail = CustomerDetails.FirstOrDefault(x => x.AccountNumber == accNumber && x.Username == uname2 && x.Password == pas2);


                if (Detail != null)
                {
                    List<Customer> acFound = new List<Customer>();
                    acFound.Add(Detail);
                    foreach (Customer c in acFound)
                    {
                        Console.WriteLine(new string('=', 100));
                        Console.WriteLine("||Account Number||Name || Age||AccountType|| Address || Contact Number || Balance || ");
                        Console.WriteLine("||{0}\t\t||{1}\t||{2}\t||{3}\t||{4}\t||{5}\t||{6}\t||", c.AccountNumber, c.name, c.Age, c.AccountType, c.Address, c.Contact, c.Balance);
                        Console.WriteLine(new string('=', 100));
                        Console.WriteLine($"\n \t\t\tWelcome  Mr/Mrs.{c.name}\t\t\t");
                        Console.WriteLine($"\nYour Account Balance is = {c.Balance}/-Rs \n");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry :( no Records  find ! Please Sign in !" + "\u003A");
                    CreateAccount();
                }

            }


        }

    }
    class Program
    {

        static void Main(string[] args)
        {   //Login Page 
            HomePage pa = new HomePage();
            Console.WriteLine("\n" + new string('*', 100));
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "==>\tWelcome to StarkCorpBank <=="));
            Console.WriteLine(new string('*', 100));
            Console.WriteLine("\n1.SignUp\n2.Already Have Account?\n");
            Console.WriteLine(new string('*', 100));


            int choice1 = Convert.ToInt32(Console.ReadLine());
            if (choice1 == 1)
            {
                pa.StaticCustomerDetails();
                Console.WriteLine(new string('*', 100));
                pa.CreateAccount();
                displayDelegate ob = new displayDelegate(pa.displayDetails);
                ob();
                Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "==>\t Atm Transaction <=="));
                displayDelegate obj = new displayDelegate(pa.HomeSection);
                obj();

            }
            else
            {
                pa.StaticCustomerDetails();
                Console.WriteLine(new string('*', 100));
                Console.WriteLine("\nProvide Your account details\n");
                displayDelegate obj = new displayDelegate(pa.HomeSection);
                obj();

            }
            Console.ReadKey();
        }
    }
}