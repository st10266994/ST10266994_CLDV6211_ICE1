using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReadingRecords.Models;

namespace ReadingRecords.Data
{
    public class ReadingRecordsContext : DbContext
    {
        public ReadingRecordsContext (DbContextOptions<ReadingRecordsContext> options)
            : base(options)
        {
        }

        public DbSet<ReadingRecords.Models.Book> Book { get; set; } = default!;
    }
}
