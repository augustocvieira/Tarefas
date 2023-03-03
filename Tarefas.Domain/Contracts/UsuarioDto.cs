using System.Collections.Generic;
using Tarefas.Domain.Models;

namespace Tarefas.Domain.Contracts;

public class UsuarioDto
{
    public int Id { get; private set; }
    public string Login { get; set; }
    public string Senha { get; set; }
    public virtual IEnumerable<TarefaCreateDto> Tarefas { get; set; }
}