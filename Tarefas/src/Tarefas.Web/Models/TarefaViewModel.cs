namespace Tarefas.Web.Models{

    public class TarefasViewModel{
        [DisplayName("Titulo")]
        public string Titulo {get; set;}

        [DisplayName("Descrição")]
        public string Descricao {get; set;}

    }
}