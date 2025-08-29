using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class NotificationsIndexModel : PageModel
{
    private readonly ILogger<NotificationsIndexModel> _logger;

    public NotificationsIndexModel(ILogger<NotificationsIndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
