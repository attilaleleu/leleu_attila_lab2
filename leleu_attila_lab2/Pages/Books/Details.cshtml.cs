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
    public class DetailsModel : PageModel
    {
        private readonly leleu_attila_lab2.Data.leleu_attila_lab2Context _context;

        public DetailsModel(leleu_attila_lab2.Data.leleu_attila_lab2Context context)
        {
            _context = context;
        }

      public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
