using Microsoft.AspNetCore.Mvc;
using SocialSolutionMVC_Imobiliaria.Models;
using SocialSolutionMVC_Imobiliaria.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialSolutionMVC_Imobiliaria.Controllers
{
    public class ImoveisController : Controller
    {
        private readonly IImovelRepository _imovelRepository;
        public ImoveisController(IImovelRepository imovelRepository)
        {
            _imovelRepository = imovelRepository;
        }

        public IActionResult Index()
        {
            List<ImovelModel> imoveis = _imovelRepository.BuscarTodos();
            return View(imoveis);
        }
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ImovelModel imovel)
        {
            //if (ModelState.IsValid)
            //{
                _imovelRepository.Adicionar(imovel);
                return RedirectToAction("Index");
            //}
            //return View(imovel);
        }

        public IActionResult Editar(int id)
        {
            ImovelModel imovel = _imovelRepository.ListarPorId(id);
            return View(imovel);

        }

        [HttpPost]
        public IActionResult Alterar(ImovelModel imovel)
        {
            _imovelRepository.Atualizar(imovel);
            return RedirectToAction("Index");
        }

        public IActionResult DeletarConfirmacao(int id)
        {
            ImovelModel imovel = _imovelRepository.ListarPorId(id);
            return View(imovel);

        }
        public IActionResult Apagar(int id)
        {
            _imovelRepository.Apagar(id);
            return RedirectToAction("Index");
        }



    }
}
