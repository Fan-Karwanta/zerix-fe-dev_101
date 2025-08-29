
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages;

public class TextClientPage : PageModel
{
    private readonly ILogger<TextClientPage> _logger;

    public TextClientPage(ILogger<TextClientPage> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
