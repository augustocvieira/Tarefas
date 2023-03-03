using Tarefas.Domain.Models;

namespace Tarefas.Domain.Contracts;

public class TarefaCreateDto
{
    public string Descricao { get; set; }
    public int UsuarioId { get; set; }
}