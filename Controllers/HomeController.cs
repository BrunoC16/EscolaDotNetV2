using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EscolaDotNet.Models;
using EscolaDotNet.ViewModels;

namespace EscolaDotNet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {   
        // var- declaração da variável
        // new - operador de instanciação
        // Curso() - chamada ao Construtor da classe Curso
        // Construtor - construir o objeto na memória.
        // para gerar um construtor 
        var curso = new Curso()
        {
            //Mock (dados de teste para visualização)
            Id = 1,
            Nome = "Introdução à programação",
            Titulo = "Primeiros passos na programação",
            Descricao = "Fundamentos de programação e algoritmos estruturas",
            Perfil = "estudantes e aprendizes em geral",
            PreRequisitos = "informática básica",
            Conteudo = "1-Introdução 2- Lógica 3-Estruturas 4- Vetores 5-Funções 6-Matrizes 7-Estruturas de dados 8-Registros",
            CargaHoraria = 40,
            PrazoMeses = 1,
        };

        ViewData["title"] = "Principal";
        ViewBag.Curso = curso;
        TempData["mensagem"] = "Mensagem vinda da Action Index";
        
        
        return View();
    }

    public IActionResult Mensagem()
    {
        return View();
    }

    public IActionResult ViewModel()
    {
        //copie e cole o curso da outra Action  que está acima em new Curso() 

        var curso = new Curso()
        { //
          //Mock (dados de teste - fictício)
          //Propriedades automáticas
            Id = 1,
            Nome = "Introdução à Programação",
            Titulo = "Primeiros passos na programação",
            Descricao = "Fundamentos de programação e algoritmos estruturados",
            Perfil = "estudantes e aprendizes no geral",
            PreRequisitos = "informática básica",
            Conteudo = "1-introdução 2-lógica 3-estruturas 4-vetores 5-funções 6-matrizes 7-estruturas de dados 8-registros",
            CargaHoraria = 40,
            PrazoMeses = 1

        };
        var viewModel = new DetalhesCursoViewModel
        {   //Apertando CTRL + Spaço irá mostrar todas Action
            Curso = curso,
            TituloPagina = "Detalhes do Curso"

        };
        return View(viewModel); // Serve para passar um objeto para view
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}




// public IActionResult Index()
// {   
//     int ch =40;

//     /*Dicionário (ViewDataDictionary) */
//     //ViewData[] Serve para transportar dados do controller para View. Ele Possui uma chave e valor. ELe usa tipagem de valor(es).
//     //TempData é semelhante as variáveis que trabalham com sessão (manter o estado do HTTP)
//     //ViewBag não precisa de tipagem forte. Ele usa a idéia do dynamic (o tipo é definido em tempo de execução).>>> ViewBag"."
//     // ViewData ["Title"] = ".Net";
//     // ViewData ["curso"] ="TI Essencial";
//     // ViewData ["Titulo"]="Uma visão geral da TI";
//     // ViewData ["Descricao"]=" A Tecnologia da Informação segue uma dinâmica própria, com mudanças que acontecem a cada dia, provocando elevado grau de obsolescência de tecnologias muitas vezes consolidadas. Devido a esta característica singular, as empresas de TI, como a Essencial Tecnologia da Informação Ltda, tem no constante reposicionamento a condição para assegurar o seu crescimento.";
//     // ViewData ["ch"]=$" Teremos {ch} horas de imersão nos fundamentos da TI ";
//     // ViewData [""]="";
//     // ViewData [""]="";
//     // ViewData [""]="";
//     /*
//     Para transportar dados de um controller para uma View
//     Podemos usar ViewData, ViewBag e TemData

//     Competência ViewData
//     Competência ViewBag 
//     Competência TemData
//     */
//     return View();

// }