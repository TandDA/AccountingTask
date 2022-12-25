namespace AccountingTask.Models
{
    public class ConsumptionModel
    {
        public int Id { get; set; }
        public int ConsumptionSum { get; set; }
        public string ConsumptionText { get; set; } = null!;
        public int ApplicationUserId { get; set; }
    }
}
