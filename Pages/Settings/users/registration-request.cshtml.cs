
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class AccountRegistrationRequestModel : PageModel
{
    private readonly ILogger<AccountRegistrationRequestModel> _logger;

    public AccountRegistrationRequestModel(ILogger<AccountRegistrationRequestModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
