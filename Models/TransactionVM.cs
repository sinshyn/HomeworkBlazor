namespace homework.Models;


public class Transaction
{
    public string Type { get; set; }      // "Deposit" hoặc "Withdraw"
    public decimal Amount { get; set; }
    public DateTime Time { get; set; }
}