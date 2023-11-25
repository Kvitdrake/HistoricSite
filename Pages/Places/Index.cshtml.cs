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
    public class IndexModel : PageModel
    {
        private readonly HistoricSite.Data.HistoricSiteContext _context;

        public IndexModel(HistoricSite.Data.HistoricSiteContext context)
        {
            _context = context;
        }

        public IList<Place> Place { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Place != null)
            {
                Place = await _context.Place.ToListAsync();
            }
        }
    }
}
