using EscolaDotNet.Models;

namespace EscolaDotNet.ViewModels;

//criar a classe
public class DetalhesCursoViewModel{
   //.NET 5
   //criar uma referência
   // por ser uma versão mais nova será acrescentado >> nulll!
   public Curso Curso { get; set; } = null!;
   public string TituloPagina { get; set; } = string.Empty;
}

