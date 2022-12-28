using AccountingTask.Areas.Identity.Data;

namespace AccountingTask.Models
{
    public class UserInfoViewModel
    {
        public ApplicationUser User { get; set; }
        public List<Consumption> Consumptions { get; set; }

        public UserInfoViewModel(ApplicationUser user, List<Consumption> consumptions)
        {
            User = user;
            Consumptions = consumptions;
        }
    }
}
