namespace Tarefas.Domain.Interfaces.Services;

public interface IServiceManager
{
    IStatusService StatusService { get; }
    IUsuarioService UsuarioService { get; }
    ITarefaService TarefaService { get; }
}