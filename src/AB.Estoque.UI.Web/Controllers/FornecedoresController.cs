using System;
using System.Net;
using System.Web.Mvc;
using AB.Estoque.Application.Interfaces;
using AB.Estoque.Application.Services;
using AB.Estoque.Application.ViewModel.Fornecedor;

namespace AB.Estoque.UI.Web.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly IFornecedoresAppService _fornecedorAppService;
        public FornecedoresController()
        {
            _fornecedorAppService = new FornecedorAppService();
        }

        public ActionResult Index()
        {
            return View(_fornecedorAppService.ObterAtivos());
        }
        
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var fornecedorViewModel = _fornecedorAppService.ObterPorId(id.Value);

            if (fornecedorViewModel == null)
            {
                return HttpNotFound();
            }
            return View(fornecedorViewModel);
        }
       
        public ActionResult Create()
        {
            return View();
        }
     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FornecedorProdutoViewModel fornecedorProdutoViewModel)
        {
            if (ModelState.IsValid)
            {
                _fornecedorAppService.Adicionar(fornecedorProdutoViewModel);
                return RedirectToAction("Index");
            }

            return View(fornecedorProdutoViewModel);
        }
        
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var fornecedorViewModel = _fornecedorAppService.ObterPorId(id.Value);

            if (fornecedorViewModel == null)
            {
                return HttpNotFound();
            }
            return View(fornecedorViewModel);
        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RazaoSocial,NomeFantasia,CNPJ,InscricaoEstadual,Email,Telefone,Ativo,Excluido")] FornecedorViewModel fornecedorViewModel)
        {
            if (ModelState.IsValid)
            {
                _fornecedorAppService.Atualizar(fornecedorViewModel);
                return RedirectToAction("Index");
            }
            return View(fornecedorViewModel);
        }
        
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var fornecedorViewModel = _fornecedorAppService.ObterPorId(id.Value);

            if (fornecedorViewModel == null)
            {
                return HttpNotFound();
            }
            return View(fornecedorViewModel);
        }
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _fornecedorAppService.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _fornecedorAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
