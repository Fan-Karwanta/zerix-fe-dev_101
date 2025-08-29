using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace zerix_fe_dev.Pages;

public class TemplatesPage : PageModel
{
    private readonly ILogger<TemplatesPage> _logger;

    public TemplatesPage(ILogger<TemplatesPage> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
