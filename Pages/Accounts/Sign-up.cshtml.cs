using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class SignUpModel : PageModel
{
    private readonly ILogger<SignUpModel> _logger;

    public SignUpModel(ILogger<SignUpModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
