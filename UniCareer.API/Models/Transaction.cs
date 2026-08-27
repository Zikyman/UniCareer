namespace UniCareer.API.Models
{
    public class Transaction
    {
        public int Id {get; set;}
        public decimal Amount {get; set;}
        public TransactionType Type {get; set;} = TransactionType.None;
        public DateTime TransactionDate {get; set;} = DateTime.UtcNow;
        public int UserId {get; set;}
        public int CategoryId {get; set;}
    }

    public enum TransactionType
    {
        None
    }
}