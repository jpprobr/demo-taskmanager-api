namespace TaskManager.API.Models.InputModels
{
    public class TarefaInputModel
    {
        public string Nome { get; set; }

        public string Detalhes { get; set; }

        public bool? Concluido { get; set; }
    }
}
