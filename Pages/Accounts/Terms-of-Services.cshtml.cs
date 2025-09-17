using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class TermsOfServicesModel : PageModel
{
    private readonly ILogger<TermsOfServicesModel> _logger;

    public TermsOfServicesModel(ILogger<TermsOfServicesModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
