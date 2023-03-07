// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

For_Savings.SavingsAccount saver1 = new For_Savings.SavingsAccount(2000);

For_Savings.SavingsAccount.ModifyInterestRate();
Console.WriteLine(saver1.CalculatemonthlyInterst());


For_Savings.SavingsAccount saver2 = new For_Savings.SavingsAccount(3000);
Console.WriteLine(saver2.CalculatemonthlyInterst());
