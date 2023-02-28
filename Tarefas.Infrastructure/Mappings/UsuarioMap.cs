using Microsoft.EntityFrameworkCore;
using Tarefas.Domain.Models;

namespace Tarefas.Infrastructure.Model_Builders;

public static class UsuarioMap
{
    public static void Build(ModelBuilder builder)
    {
        builder.Entity<Usuario>()
            .Property(t => t.Id)
            .IsRequired()
            .HasColumnName("Id");

        builder.Entity<Usuario>()
            .Property(t => t.Login)
            .IsRequired()
            .HasMaxLength(255)
            .HasColumnName("Login");

        builder.Entity<Usuario>()
            .Property(t => t.Senha)
            .IsRequired()
            .HasMaxLength(255)
            .HasColumnName("Senha");

        builder.Entity<Usuario>()
            .HasMany(t => t.Tarefas)
            .WithOne(s => s.Usuario)
            .HasForeignKey("UsuarioId");

        builder.Entity<Usuario>()
            .HasKey(t => t.Id);

        builder.Entity<Usuario>()
            .ToTable("Usuario", "dbo");

    }
}