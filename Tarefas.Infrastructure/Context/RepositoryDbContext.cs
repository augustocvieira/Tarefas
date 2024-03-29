﻿using Microsoft.EntityFrameworkCore;
using Tarefas.Domain.Models;
using Tarefas.Infrastructure.Mappings;

namespace Tarefas.Infrastructure.Context;

public class RepositoryDbContext : DbContext
{
    public DbSet<Status> Statuses { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Tarefa> Tarefas { get; set; }

    public RepositoryDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        StatusMap.Map(modelBuilder);
        UsuarioMap.Map(modelBuilder);
        TarefaMap.Map(modelBuilder);
    }
}