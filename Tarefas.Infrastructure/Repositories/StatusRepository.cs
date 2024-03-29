﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Domain.Models;
using Tarefas.Infrastructure.Context;

namespace Tarefas.Infrastructure.Repositories;

public class StatusRepository : IStatusRepository
{
    //TODO: Continue a partir daqui -> https://github.com/CodeMazeBlog/onion-architecture-aspnetcore/blob/7e7f37bb2a8722cddb9d584c7c561556097f5b5f/OnionArchitecutre/Persistence/Repositories/AccountRepository.cs#L18
    private readonly RepositoryDbContext _context;
    public StatusRepository(RepositoryDbContext context) => _context = context;

    public async Task<IEnumerable<Status>> GetAll(CancellationToken token) =>
        await _context.Statuses.ToListAsync(token);
}