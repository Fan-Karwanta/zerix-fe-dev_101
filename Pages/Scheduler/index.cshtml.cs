using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages.Scheduler
{
    public class SchedulerIndexModel : PageModel
    {
        private readonly ILogger<SchedulerIndexModel> _logger;

        public SchedulerIndexModel(ILogger<SchedulerIndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }
    }
}
