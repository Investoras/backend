using System.Transactions;

namespace Investoras_Backend.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsIncome { get; set; } // Доход или расход
        public List<Transaction> Transactions { get; set; }
    }
}
