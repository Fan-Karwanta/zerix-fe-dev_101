using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_fe_dev.Pages.Forms;

public class FormQuestion
{
    public int Id { get; set; }
    public string QuestionText { get; set; } = string.Empty;
    public string QuestionType { get; set; } = string.Empty; // dropdown, radio, checkbox, text
    public List<string> Options { get; set; } = new();
    public string DefaultValue { get; set; } = string.Empty;
}

public class FormDetail
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<FormQuestion> Questions { get; set; } = new();
}

public class TakeFormModel : PageModel
{
    private readonly ILogger<TakeFormModel> _logger;

    public FormDetail Form { get; set; } = new();

    public TakeFormModel(ILogger<TakeFormModel> logger)
    {
        _logger = logger;
    }

    public void OnGet(int id = 1)
    {
        Form = new FormDetail
        {
            Id = id,
            Title = "Employee Satisfaction Survey 2026",
            Description = "We value your feedback! This survey aims to understand your experience working with us and identify areas for improvement. Your responses will remain confidential and will help us create a better workplace for everyone.",
            Questions = new List<FormQuestion>
            {
                new FormQuestion
                {
                    Id = 1,
                    QuestionText = "Department",
                    QuestionType = "dropdown",
                    Options = new List<string> { "Human Resources", "Engineering", "Marketing", "Finance", "Operations", "Sales" },
                    DefaultValue = "Human Resources"
                },
                new FormQuestion
                {
                    Id = 2,
                    QuestionText = "How satisfied are you with your current role?",
                    QuestionType = "radio",
                    Options = new List<string> { "Very satisfied", "Satisfied", "Neutral", "Dissatisfied", "Very dissatisfied" },
                    DefaultValue = "Very satisfied"
                },
                new FormQuestion
                {
                    Id = 3,
                    QuestionText = "Which of the following benefits do you use?",
                    QuestionType = "checkbox",
                    Options = new List<string> { "Health insurance", "Work-from-home option", "Paid time off", "Learning & development programs" },
                    DefaultValue = ""
                },
                new FormQuestion
                {
                    Id = 4,
                    QuestionText = "What suggestions do you have for improving the workplace?",
                    QuestionType = "text",
                    Options = new List<string>(),
                    DefaultValue = ""
                }
            }
        };
    }
}
