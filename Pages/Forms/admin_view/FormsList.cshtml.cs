using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages.Forms.admin_view;

public class AdminFormItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string CreatedBy { get; set; } = string.Empty;
}

public class FormsListModel : PageModel
{
    private readonly ILogger<FormsListModel> _logger;

    public List<AdminFormItem> Forms { get; set; } = new();

    public FormsListModel(ILogger<FormsListModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Forms = new List<AdminFormItem>
        {
            new AdminFormItem
            {
                Id = 1,
                Title = "Christmas Party 2026",
                CreatedBy = "Juan Dela Cruz"
            },
            new AdminFormItem
            {
                Id = 2,
                Title = "Systems Feedback Survey",
                CreatedBy = "Juan Dela Cruz"
            }
        };
    }
}
