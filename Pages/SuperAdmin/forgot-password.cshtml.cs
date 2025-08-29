
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class SuperAdminForgotPasswordModel : PageModel
{
    private readonly ILogger<SuperAdminForgotPasswordModel> _logger;

    public SuperAdminForgotPasswordModel(ILogger<SuperAdminForgotPasswordModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
