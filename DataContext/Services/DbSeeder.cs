using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataContext.Services
{
    public static class DbSeeder
    {
        public static void SeedAll(EFDataContext context) 
        {
            SeedCat(context);
        }

        private static void SeedCat(EFDataContext context) 
        {
            if (!context.cats.Any()) 
            {
                context.cats.Add(new DataContextEntities.AppCat { 
                Name = "Манул",
                ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d6/Manoel.jpg/275px-Manoel.jpg",
                Birthday = DateTime.Now
                });

                context.SaveChanges();
            }
        }
    }
}
