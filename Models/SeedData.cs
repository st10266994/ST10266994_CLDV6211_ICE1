using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReadingRecords.Data;
using System;
using System.Linq;
namespace ReadingRecords.Models;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ReadingRecordsContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ReadingRecordsContext>>()))
        {
            // Look for any movies.
            if (context.Book.Any())
            {
                return;   // DB has been seeded
            }
            context.Book.AddRange(
                new Book
                {
                    ISBN = "1002768534251",

                    Title = "Book Lovers",
                    Author = "Emily Henry",

                    PublicationDate = DateTime.Parse("2024-2-12"),
                    Genre = "Contemporary Romance",

                    Price = 95.00M
                },
                new Book
                {
                    ISBN = "1006568573671",

                    Title = "Wuthering Heights",
                    Author = "Emily Bronte",

                    PublicationDate = DateTime.Parse("1847-12-12"),
                    Genre = "Gothic Fiction",

                    Price = 95.00M
                },
                new Book
                {
                    ISBN = "1006568571231",

                    Title = "Fourth Wing",
                    Author = " Rebecca Yarros",

                    PublicationDate = DateTime.Parse("2023-4-2"),
                    Genre = "Fantasy",

                    Price = 75.00M
                    
                },
                new Book
                {
                    ISBN = "1006444371231",

                    Title = "Iron Flame",
                    Author = " Rebecca Yarros",

                    PublicationDate = DateTime.Parse("2024-1-2"),
                    Genre = "Fantasy",

                    Price = 75.00M
                }
            );
            context.SaveChanges();
        }
    }
}
