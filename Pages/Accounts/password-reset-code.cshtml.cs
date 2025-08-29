
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class PasswordResetCode : PageModel
{
    private readonly ILogger<PasswordResetCode> _logger;

    public PasswordResetCode(ILogger<PasswordResetCode> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
