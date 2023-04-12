using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EstoqueGeral.Models;

namespace EstoqueGeral.Data
{
    public class EstoqueGeralContext : DbContext
    {
        public EstoqueGeralContext (DbContextOptions<EstoqueGeralContext> options)
            : base(options)
        {
        }

        public DbSet<EstoqueGeral.Models.Teste> Teste { get; set; } = default!;
    }
}
