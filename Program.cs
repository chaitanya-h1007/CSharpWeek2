using System.Collections.Concurrent;

namespace DigitalCashLedger
{
    public class Program
    {
        // this remain in the memory till the program executes

        //Income Ledger 
        public static Legder<IncomeTransaction> incomeLedger = new Legder<IncomeTransaction>();
        //ExpenseTransaction Leger to store the Expenses
        public static Legder<ExpenseTransaction> expenseLedger = new Legder<ExpenseTransaction>();
        // Base class Reference
        public static List<Transaction> AllTransaction = new List<Transaction>();

        public static void Main(string[] args)
        {


            while (true)
            {
                //Menu
                Console.WriteLine("\n===== DIGITAL CASH LEDGER =====");
                Console.WriteLine("1. Add Income");
                Console.WriteLine("2. Add Expense");
                Console.WriteLine("3. View Summary");
                Console.WriteLine("4. Calculate Expense");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                // store the user input as integer and as choice
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }
                // This hadles the User Input And call the functions
                switch (choice)
                {
                    case 1:
                        AddIncome(); //IncomeTransaction created
                        break;

                    case 2:
                        AddExpense(); //Expense Transaction Created
                        break;

                    case 3:
                        ShowSummary(); //summary printed
                        break;

                    case 4:
                        Calculate(); //Calulate the total expense till now using the ledger.
                        break;
                    case 5:
                        Console.WriteLine("Exiting application...");
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

            } 

        }
            
        /// <summary>
        /// this will return the total expense till now
        /// </summary>
        public static void Calculate()
        {
            decimal ExpenseTotal = expenseLedger.CalculateTotal();
            decimal IncomeTotal = incomeLedger.CalculateTotal();

            //Calculate the Total 
            Console.WriteLine($"Recived: ${IncomeTotal}");
            Console.WriteLine($"Spent  : ${ExpenseTotal}");
            Console.WriteLine($"Net Balance: ${IncomeTotal - ExpenseTotal}");
        }

        /// <summary>
        /// This will take input from users -> create a object for the income transaction
        /// and then add the transaction to the income ledger
        /// </summary>
        public static void AddIncome()
        {
            Console.Write("Enter Amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter Category: ");
            string source = Console.ReadLine();


            IncomeTransaction income = new IncomeTransaction
            {
                Id = incomeLedger.GetEntries().Count + 1,
                Date = DateTime.Now,
                Amount = amount,
                Description = description,
                Source = source
            };

            incomeLedger.AddEntry(income);
            Console.WriteLine("Income Added");
        }

        /// <summary>
        /// This will take input from users -> create a object for the expense transaction
        /// and then add the transaction to the expense ledger
        /// </summary>
        public static void AddExpense()
        {
            Console.Write("Enter Amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter Category: ");
            string category = Console.ReadLine();

            ExpenseTransaction expense = new ExpenseTransaction
            {
                Id = expenseLedger.GetEntries().Count + 1,
                Date = DateTime.Now,
                Amount = amount,
                Description = description,
                Category = category
            };

            expenseLedger.AddEntry(expense);
            Console.WriteLine("Expense added successfully.");
        }


        public static void ShowSummary()
        {
            /// Polymorphism DEMO
            ///  List<Transaction> should be able to call GetSummary() and display unique details for both Income and Expenses
            // Why AddRange : Because we are returning the list of transaction multiple objects
            // but in Add we only have to add single Object.


            AllTransaction.AddRange(incomeLedger.GetEntries());
            AllTransaction.AddRange(expenseLedger.GetEntries());

            foreach (Transaction txn in AllTransaction)
            {
                //Run time polymorphism

                Console.WriteLine(txn.GetSummary());
            }

        }

    }
}