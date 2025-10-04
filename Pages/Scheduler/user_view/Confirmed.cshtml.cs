using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages.Scheduler
{
    public class ConfirmedModel : PageModel
    {
        private readonly ILogger<ConfirmedModel> _logger;

        public ConfirmedModel(ILogger<ConfirmedModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }
    }
}
