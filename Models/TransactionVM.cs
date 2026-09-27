namespace homework.Models;

public enum TransType
{
    Deposit,
    Withdraw,
}

public class TransactionVM
{
    public TransType TypeTrans { get; set; } // "Deposit" hoặc "Withdraw"
    public string Amount { get; set; } //số tiền
    public DateTime Time { get; set; } 
}
