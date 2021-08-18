using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSE.WebApp.MVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NSE.WebApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

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
            var modelErro = new ErrorViewModel();

            if(id == 500)
            {
                modelErro.ErrorCode = id;
                modelErro.Titulo = "Ocorreu um erro";
                modelErro.Mensagem = "Ocorreu um erro! Tente novamente mais tarde ou entre em contato com o suporte!";
            }
            else if (id == 404)
            {
                modelErro.ErrorCode = id;
                modelErro.Titulo = "Ops! Página não encontrada!";
                modelErro.Mensagem = "Ocorreu um erro! A pagina não existe. Entre em contato com o Suporte!";
            }
            else if (id == 403)
            {
                modelErro.ErrorCode = id;
                modelErro.Titulo = "Acesso Negado!";
                modelErro.Mensagem = "Você não tem permissão para fazer isso!";
            }
            else
            {
                return StatusCode(404);
            }

            return View("Error", modelErro);
        }
    }
}
