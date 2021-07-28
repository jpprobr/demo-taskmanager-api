using System.Collections.Generic;
using TaskManager.API.Models;

namespace TaskManager.API.Data.Repositories
{
    public interface ITarefasRepository
    {
        void Adicionar(Tarefa tarefa);

        void Atualizar(string id, Tarefa tarefaAtualizada);

        IEnumerable<Tarefa> Buscar();

        Tarefa Buscar(string id);

        void Remover(string id);
    }
}
