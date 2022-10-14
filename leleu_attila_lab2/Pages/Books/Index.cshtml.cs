using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using leleu_attila_lab2.Data;
using leleu_attila_lab2.Models;

namespace leleu_attila_lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly leleu_attila_lab2.Data.leleu_attila_lab2Context _context;

        public IndexModel(leleu_attila_lab2.Data.leleu_attila_lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
