using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace zerix_fe_dev.Pages;

public class EmailIndexModel : PageModel
{
    private readonly ILogger<EmailIndexModel> _logger;

    public EmailIndexModel(ILogger<EmailIndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
