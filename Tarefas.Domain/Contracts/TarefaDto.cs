using Tarefas.Domain.Models;

namespace Tarefas.Domain.Contracts;

public class TarefaDto
{
    public int Id { get; private set; }
    public string Descricao { get; set; }
    public virtual StatusDto Status { get; set; }
    public virtual UsuarioDto Usuario { get; set; }
}