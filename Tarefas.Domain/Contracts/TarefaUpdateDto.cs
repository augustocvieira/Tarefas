namespace Tarefas.Domain.Contracts;

public class TarefaUpdateDto
{
    public int Id { get; private set; }
    public string Descricao { get; set; }
    public virtual int StatusId { get; set; }
}