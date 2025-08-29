using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace zerix_fe_dev.Pages;

public class AddTemplatePage : PageModel
{
    private readonly ILogger<AddTemplatePage> _logger;

    public AddTemplatePage(ILogger<AddTemplatePage> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
