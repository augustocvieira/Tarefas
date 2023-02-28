using Microsoft.EntityFrameworkCore;
using Tarefas.Domain.Models;

namespace Tarefas.Infrastructure.Mappings;

public static class StatusMap
{
    public static void Map(ModelBuilder builder)
    {
        builder.Entity<Status>()
            .Property(t => t.Id)
            .IsRequired()
            .HasColumnName("Id");

        builder.Entity<Status>()
            .Property(t => t.Descricao)
            .IsRequired()
            .HasColumnName("Descricao");

        builder.Entity<Status>()
            .HasKey(t => t.Id);


        builder.Entity<Status>().ToTable("Status", "dbo");
    }
}