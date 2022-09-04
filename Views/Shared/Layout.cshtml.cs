using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blazor.Bootstrap.Pages
{
    public class LayoutModel : PageModel
    {

        [BindProperty]
        public LayoutSettings Model { get; set; } = new LayoutSettings();

        public bool Test { get; set; }
        public class LayoutSettings
        {
            public bool DarkColors { get; set; } = false;
            public bool HierNav { get; set; } = true;

            public bool IconsOnly { get; set; } = true;
        }

        public async Task<IActionResult> OnGet(bool IconsOnly=false)
        {
            Model.IconsOnly = IconsOnly;
            return Page();
        }
    }
}
