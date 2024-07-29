using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_aula29072024.Models;

namespace API_aula29072024.Data
{
    public class API_aula29072024Context : DbContext
    {
        public API_aula29072024Context (DbContextOptions<API_aula29072024Context> options)
            : base(options)
        {
        }

        public DbSet<API_aula29072024.Models.Produto> Produto { get; set; }
    }
}
