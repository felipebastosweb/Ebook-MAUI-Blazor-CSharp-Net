using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CondominioServer.Data;

using CondominioServer.Data.Models;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Configurações adicionais do modelo podem ser feitas aqui

        // Relacionamentos de Condominio
        builder.Entity<Condominio>(entity => {

            // Condominio tem um SindicoAtivo (1:1) e uma lista de Sindicos (1:N)
            entity
                .HasOne(c => c.SindicoAtivo)
                .WithOne(s => s.Condominio)
                .HasForeignKey<Sindico>(s => s.CondominioId)
                .OnDelete(DeleteBehavior.NoAction);

            // Condominio tem muitos Sindicos (1:N)
            entity
                .HasMany(c => c.Sindicos)
                .WithOne(s => s.Condominio)
                .HasForeignKey(s => s.CondominioId)
                .OnDelete(DeleteBehavior.NoAction);

            // Condominio tem muitas Unidades (1:N)
            entity
                .HasMany(c => c.Unidades)
                .WithOne(u => u.Condominio)
                .HasForeignKey(u => u.CondominioId)
                .OnDelete(DeleteBehavior.NoAction);
        });

        // Relacionamentos de Unidade
        builder.Entity<Unidade>(entity => {
            // Unidade tem um Proprietario (1:1)
            entity
                .HasOne(u => u.ProprietarioInfo)
                .WithOne(p => p.Unidade)
                .HasForeignKey<Proprietario>(p => p.UnidadeId)
                .OnDelete(DeleteBehavior.NoAction);
         });
    }
}
