using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarefas.Domain.Models;
using Tarefas.Domain.Interfaces.Repositories;
using Tarefas.Domain.Interfaces.Services;
using System.Threading;
using Mapster;
using Tarefas.Application.Exceptions;
using Tarefas.Application.Utils;
using Tarefas.Domain.Contracts;

namespace Tarefas.Application.Services
{
    public class TarefaService : ITarefaService
    {
        private readonly IRepositoryManager _repositoryManager;

        public TarefaService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task<IEnumerable<Tarefa>> GetAllAsync(CancellationToken cancellationToken)
        {
            var repo = _repositoryManager.TarefaRepository;
            var databaseResult = await repo.GetAsync(cancellationToken);
            return databaseResult;
        }

        public async Task<TarefaDto> CreateTarefaAsync(TarefaCreateDto tarefaDto, CancellationToken cancellationToken)
        {
            if (!await _repositoryManager.StatusRepository.ExistsAsync(s => s.Id == (int)StatusEnum.A_Fazer,cancellationToken))
                throw new TarefaInvalidaException("Status da Tarefa Inválido");

            if (!await _repositoryManager.UsuarioRepository.ExistsAsync(u => u.Id == tarefaDto.UsuarioId, cancellationToken))
                throw new UsuarioInvalidoException("O Usuário é inválido");
            
            var status = (await _repositoryManager.StatusRepository.GetAsync(s => s.Id == (int)StatusEnum.A_Fazer, cancellationToken))
                .First();

            var usuario = await _repositoryManager.UsuarioRepository.GetByIdAsync(tarefaDto.UsuarioId, cancellationToken);

            var tarefa = tarefaDto.Adapt<Tarefa>();
            tarefa.Usuario = usuario;
            tarefa.Status = status;

            await _repositoryManager.TarefaRepository.InsertAsync(tarefa, cancellationToken);
            await _repositoryManager.UnitOfWork.SaveChangesAsync(cancellationToken);

            return tarefa.Adapt<TarefaDto>();
        }

        public Task<TarefaDto> UpdateTarefaAsync(TarefaUpdateDto tarefaDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTarefaAsync(int tarefaId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
