using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DevCA.App.Models;

namespace DevCA.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("erro/{id:length(3,3)}")]
        public IActionResult Error(int id)
        {
            var modelError = new ErrorViewModel();

            switch (id)
            {
                case 500:
                    modelError.Mensagem = "Ocorreu um erro! Tente novamente mais tarde ou contate nosso suporte.";
                    modelError.Titulo = "Ocorreu um erro";
                    modelError.ErrorCode = id;
                    break;
                case 404:
                    modelError.Mensagem = "A página que você procura não existe! <br />Em caso de dúvidas entre em contato com o nosso suporte.";
                    modelError.Titulo = "Ops! Pagina não encontrada.";
                    modelError.ErrorCode = id;
                    break;
                case 403:
                    modelError.Mensagem = "Você não tem permissão para fazer isso.";
                    modelError.Titulo = "Acesso negado";
                    modelError.ErrorCode = id;
                    break;
                default:
                    return StatusCode(404);
            }


            return View("Error", modelError);
        }
    }
}
