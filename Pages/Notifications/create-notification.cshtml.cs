using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class CreateNotificationModel : PageModel
{
    private readonly ILogger<CreateNotificationModel> _logger;

    public CreateNotificationModel(ILogger<CreateNotificationModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
