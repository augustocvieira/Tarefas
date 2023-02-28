using Microsoft.EntityFrameworkCore;
using Tarefas.Domain.Models;

namespace Tarefas.Infrastructure.Mappings;

public static class TarefaMap
{
    public static void Map(ModelBuilder builder)
    {

        builder.Entity<Tarefa>()
            .Property(t => t.Id)
            .HasColumnName("Id");

        builder.Entity<Tarefa>()
            .Property(t => t.Descricao)
            .HasMaxLength(1000)
            .IsRequired()
            .HasColumnName("Descricao");

        builder.Entity<Tarefa>()
            .HasOne(s => s.Status)
            .WithMany()
            .HasForeignKey("StatusId");

        builder.Entity<Tarefa>()
            .HasOne(u => u.Usuario)
            .WithMany(t => t.Tarefas)
            .HasForeignKey("UsuarioId");

        builder.Entity<Tarefa>()
            .ToTable("Tarefa", "dbo");

    }
}
