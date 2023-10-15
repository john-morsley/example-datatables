using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor.Models;

namespace Razor.Pages;

public class DataModel : PageModel
{
    private readonly ILogger<DataModel> _logger;

    public DataModel(ILogger<DataModel> logger)
    {
        _logger = logger;
    }

    //public IActionResult OnGetJson()
    //{
    //    // This action will return raw JSON to be consumed by the DataTable.

    //    var jsonData = new
    //    {
    //        id = Guid.NewGuid().ToString(),
    //        name = "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
    //        // Add more data as needed
    //    };

    //    // Serialize the data to JSON and return it
    //    return new JsonResult(jsonData);
    //}

    //public async Task<IActionResult> OnGet()
    public async Task<IActionResult> OnGet()
    {
        // This action will return raw JSON to be consumed by the DataTable.

        var tests = new List<Test>();

        for (int i = 1; i <= 10; i++)
        {
            tests.Add(new Test { Id = Guid.NewGuid().ToString(), Name = $"Test {i:0#}" });
        }

        //var jsonData = new
        //{
        //    data = tests
        //};

        //var jsonData = new
        //{
        //    tests
        //};

        await Task.CompletedTask; // Simulate an asynchronous call

        // Serialize the data to JSON and return it
        //var jsonResult = new JsonResult(jsonData);
        var jsonResult = new JsonResult(tests);
        return jsonResult;
    }
}