using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class LoginModel : PageModel
{
    private readonly ILogger<LoginModel> _logger;

    public LoginModel(ILogger<LoginModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
