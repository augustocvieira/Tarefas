using System;

namespace Tarefas.Domain.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        private int statusId;
        public Status Status { get; set; }
        private int usuarioId;
        public Usuario Usuario { get; set; }
    }
}
