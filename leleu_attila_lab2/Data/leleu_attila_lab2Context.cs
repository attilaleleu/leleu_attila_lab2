using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using leleu_attila_lab2.Models;

namespace leleu_attila_lab2.Data
{
    public class leleu_attila_lab2Context : DbContext
    {
        public leleu_attila_lab2Context (DbContextOptions<leleu_attila_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<leleu_attila_lab2.Models.Book> Book { get; set; } = default!;
    }
}
