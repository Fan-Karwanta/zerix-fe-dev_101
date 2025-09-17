using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class TermsOfServicesStandaloneModel : PageModel
{
    private readonly ILogger<TermsOfServicesStandaloneModel> _logger;

    public TermsOfServicesStandaloneModel(ILogger<TermsOfServicesStandaloneModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
