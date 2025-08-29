using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class SuperAdminLoginModel : PageModel
{
    private readonly ILogger<SuperAdminLoginModel> _logger;

    public SuperAdminLoginModel(ILogger<SuperAdminLoginModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
