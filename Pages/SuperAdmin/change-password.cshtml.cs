
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class SuperAdminChangePasswordModel : PageModel
{
    private readonly ILogger<SuperAdminChangePasswordModel> _logger;

    public SuperAdminChangePasswordModel(ILogger<SuperAdminChangePasswordModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
