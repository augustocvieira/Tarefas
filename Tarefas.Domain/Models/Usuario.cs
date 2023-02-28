using System;
using System.Collections.Generic;

namespace Tarefas.Domain.Models;

public class Usuario
{
    public int Id { get; private set; }
    public string Login { get; set; }
    public string Senha { get; set; }
    public virtual IEnumerable<Tarefa> Tarefas { get; set; }
}