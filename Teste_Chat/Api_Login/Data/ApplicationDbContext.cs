using Api_Login.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Api_Login.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Contatos> contatos { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Contatos>().HasData(
            new Contatos { Id = 1, Nome = "Luciano Soares", Email = "lucianoSoares@teste.com" },
            new Contatos { Id = 2, Nome = "Luiz Silva", Email = "luiz@teste.com" },
            new Contatos { Id = 3, Nome = "Maria Oliveira", Email = "maria.oliveira@teste.com" },
            new Contatos { Id = 4, Nome = "João Santos", Email = "joao.santos@teste.com" },
            new Contatos { Id = 5, Nome = "Ana Souza", Email = "ana.souza@teste.com" },
            new Contatos { Id = 6, Nome = "Carlos Pereira", Email = "carlos.pereira@teste.com" },
            new Contatos { Id = 7, Nome = "Fernanda Lima", Email = "fernanda.lima@teste.com" },
            new Contatos { Id = 8, Nome = "Paulo Andrade", Email = "paulo.andrade@teste.com" },
            new Contatos { Id = 9, Nome = "Juliana Costa", Email = "juliana.costa@teste.com" },
            new Contatos { Id = 10, Nome = "Rafael Carvalho", Email = "rafael.carvalho@teste.com" }
            );
    }
}
