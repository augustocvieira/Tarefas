namespace Tarefas.Domain.Interfaces.Repositories;

public interface IRepositoryManager
{
    IUsuarioRepository UsuarioRepository { get;  }
    IStatusRepository StatusRepository { get; }
    ITarefaRepository TarefaRepository { get; }
}