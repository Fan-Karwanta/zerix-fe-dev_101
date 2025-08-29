
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class SuperAdminPasswordResetCode : PageModel
{
    private readonly ILogger<SuperAdminPasswordResetCode> _logger;

    public SuperAdminPasswordResetCode(ILogger<SuperAdminPasswordResetCode> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
