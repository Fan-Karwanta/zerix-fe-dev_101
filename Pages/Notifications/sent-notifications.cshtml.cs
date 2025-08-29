using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class SentNotificationsModel : PageModel
{
    private readonly ILogger<SentNotificationsModel> _logger;

    public SentNotificationsModel(ILogger<SentNotificationsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
