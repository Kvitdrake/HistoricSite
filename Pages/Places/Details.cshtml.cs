using HistoricSite.Data;
using HistoricSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistoricSite.Pages.Places
{
    public class DetailsModel : PageModel
    {
        private readonly HistoricSite.Data.HistoricSiteContext _context;

        public DetailsModel(HistoricSite.Data.HistoricSiteContext context)
        {
            _context = context;
        }

        public Place Place { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Place == null)
            {
                return NotFound();
            }

            var place = await _context.Place.FirstOrDefaultAsync(m => m.Id == id);
            if (place == null)
            {
                return NotFound();
            }
            else
            {
                Place = place;
            }
            return Page();
        }
    }
}
