using Tarefas.Domain.Models;

namespace Tarefas.Domain.Contracts;

public class TarefaCreateDto
{
    public string Descricao { get; set; }
    public virtual int UsuarioId { get; set; }
}