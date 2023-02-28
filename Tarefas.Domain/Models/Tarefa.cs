using System;

namespace Tarefas.Domain.Models
{
    public class Tarefa
    {
        public int Id { get; private set; }
        public string Descricao { get; set; }
        private int StatusId { get; set; }
        public virtual Status Status { get; set; }
        private int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
