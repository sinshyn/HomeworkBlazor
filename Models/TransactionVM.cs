namespace homework.Models;


public class TransactionVM
{
    public string Type { get; set; }      // "Deposit" hoặc "Withdraw"
    public decimal Amount { get; set; }
    public DateTime Time { get; set; }
}