using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NUTRIFY.Components.Domain;

namespace NUTRIFY.Data
{
    public class NUTRIFYContext : DbContext
    {
        public NUTRIFYContext (DbContextOptions<NUTRIFYContext> options)
            : base(options)
        {
        }

        public DbSet<NUTRIFY.Components.Domain.EmotionalLog> EmotionalLog { get; set; } = default!;
        public DbSet<NUTRIFY.Components.Domain.FoodItem> FoodItem { get; set; } = default!;
    }
}
