using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace zerix_fe_dev.Pages;

public class ContactIndexModel : PageModel
{
    private readonly ILogger<ContactIndexModel> _logger;

    public ContactIndexModel(ILogger<ContactIndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
