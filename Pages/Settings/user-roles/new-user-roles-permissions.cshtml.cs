
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class NewUserRolesPermissionsPage : PageModel
{
    private readonly ILogger<NewUserRolesPermissionsPage> _logger;

    public NewUserRolesPermissionsPage(ILogger<NewUserRolesPermissionsPage> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
