using AccountingTask.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace AccountingTask.Models
{
    public class Consumption
    {
        [Key]
        public int Id { get; set; }
        public double ConsumptionSum { get; set; }
        public string ConsumptionText { get; set; } = null!;
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public Consumption(double consumptionSum, string consumptionText, string applicationUserId)
        {
            ConsumptionSum = consumptionSum;
            ConsumptionText = consumptionText;
            ApplicationUserId = applicationUserId;
        }
    }
}
