using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using C_Website.Data;
using C_Website.Models;

namespace C_Website.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly C_Website.Data.C_WebsiteContext _context;

        public IndexModel(C_Website.Data.C_WebsiteContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Person != null)
            {
                Person = await _context.Person.ToListAsync();
            }
        }
    }
}
