using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace zerix_fe_dev.Pages;

public class CustomFieldContactPage : PageModel
{
    private readonly ILogger<CustomFieldContactPage> _logger;

    public CustomFieldContactPage(ILogger<CustomFieldContactPage> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
