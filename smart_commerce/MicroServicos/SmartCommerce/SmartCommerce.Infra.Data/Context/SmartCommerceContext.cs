using Microsoft.EntityFrameworkCore;
using SmartCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCommerce.Infra.Data.Context
{
    /// <summary>
    /// Contexto da aplicação
    /// </summary>
    public class SmartCommerceContext : DbContext
    {

        public DbSet<Local> Local { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Segmento> Segmento { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Votacao> Votacao { get; set; }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="options">DbContext para injeção</param>
        public SmartCommerceContext(DbContextOptions<SmartCommerceContext> options = null) : base(options)
        {
        }
    }
}
