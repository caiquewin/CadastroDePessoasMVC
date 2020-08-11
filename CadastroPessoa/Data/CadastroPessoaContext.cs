using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroPessoa.Models;

namespace CadastroPessoa.Data
{
    public class CadastroPessoaContext : DbContext
    {
        public CadastroPessoaContext (DbContextOptions<CadastroPessoaContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroPessoa.Models.Cliente> Cliente { get; set; }
    }
}
