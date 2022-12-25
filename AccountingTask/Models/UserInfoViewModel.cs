using AccountingTask.Areas.Identity.Data;

namespace AccountingTask.Models
{
    public class UserInfoViewModel
    {
        public ApplicationUser User { get; set; }
        public List<ConsumptionModel> Consumptions { get; set; }

        public UserInfoViewModel(ApplicationUser user, List<ConsumptionModel> consumptions)
        {
            User = user;
            Consumptions = consumptions;
        }
    }
}
