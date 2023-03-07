using System;
namespace For_Savings;
public class SavingsAccount
{
    // static int AnnualInterestRate = 0;
    public static int AnnualInterestRate { get; set; }

    private static int savingsbalance;

    public SavingsAccount(int _savingbalance)
    {
        savingsbalance = _savingbalance;
    }

    // private instance variable indicating the amount the saver currently has on deposit
    
    // Provide method that calculates the monthly interest of the user
    public double CalculatemonthlyInterst()
    {
        int rateandbalance = AnnualInterestRate * savingsbalance;
        double balance = rateandbalance / 12;
        double interest = balance + savingsbalance;
        return interest;
    }
    public static void ModifyInterestRate()
    {
        AnnualInterestRate= 20;
    }
}

