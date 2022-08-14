
using BankEncapsulation;

var account = new BankAccount();

Console.WriteLine("Deposit Amount?");
var amountToDeposit = double.Parse(Console.ReadLine());
account.Deposit(amountToDeposit);
Console.WriteLine($"Thanks. Balance is now ${amountToDeposit}");