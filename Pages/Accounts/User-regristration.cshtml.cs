using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class UserRegistrationModel : PageModel
{
    private readonly ILogger<UserRegistrationModel> _logger;

    public UserRegistrationModel(ILogger<UserRegistrationModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
