using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CompaniesInfoTO.Models;

namespace CompaniesInfoTO.Data
{
    public class CompaniesInfoTOContext : DbContext
    {
        public CompaniesInfoTOContext (DbContextOptions<CompaniesInfoTOContext> options)
            : base(options)
        {
        }

        public DbSet<CompaniesInfoTO.Models.Company> Company { get; set; } = default!;
    }
}
