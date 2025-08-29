
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class ForgotPasswordModel : PageModel
{
    private readonly ILogger<ForgotPasswordModel> _logger;

    public ForgotPasswordModel(ILogger<ForgotPasswordModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
