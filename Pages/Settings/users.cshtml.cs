
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class UsersSettingsModel : PageModel
{
    private readonly ILogger<UsersSettingsModel> _logger;

    public UsersSettingsModel(ILogger<UsersSettingsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
