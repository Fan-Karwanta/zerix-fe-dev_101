
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class UserRolesPage : PageModel
{
    private readonly ILogger<UserRolesPage> _logger;

    public UserRolesPage(ILogger<UserRolesPage> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
