using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace STAMP2023.Pages
{
    public class NewsDetailModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public NewsDetailModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}