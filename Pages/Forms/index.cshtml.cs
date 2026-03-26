using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages.Forms;

public class FormItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

public class FormsIndexModel : PageModel
{
    private readonly ILogger<FormsIndexModel> _logger;

    public List<FormItem> Forms { get; set; } = new();

    public FormsIndexModel(ILogger<FormsIndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Forms = new List<FormItem>
        {
            new FormItem
            {
                Id = 1,
                Title = "Christmas Party 2026",
                Description = "Please fill-out this form on or before November 25, 2026."
            },
            new FormItem
            {
                Id = 2,
                Title = "Christmas Party 2026",
                Description = "Please fill-out this form on or before November 25, 2026."
            },
            new FormItem
            {
                Id = 3,
                Title = "Christmas Party 2026",
                Description = "Please fill-out this form on or before November 25, 2026."
            }
        };
    }
}
