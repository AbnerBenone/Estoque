using System;
using System.Net;
using System.Web.Mvc;
using AB.Estoque.Application.Interfaces;
using AB.Estoque.Application.Services;
using AB.Estoque.Application.ViewModel.Fornecedor;
using AB.Estoque.Application.ViewModel.Produto;

namespace AB.Estoque.UI.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private IProdutosAppService _produtosAppService;
        public ProdutosController()
        {
            _produtosAppService = new ProdutoAppService();
        }
        
        public ActionResult Index()
        {
            return View(_produtosAppService.ObterAtivos());
        }
        
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var produtoViewModel = _produtosAppService.ObterPorId(id.Value);

            if (produtoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(produtoViewModel);
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
                _produtosAppService.Adicionar(fornecedorProdutoViewModel);
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

            var produtoViewModel = _produtosAppService.ObterPorId(id.Value);

            if (produtoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(produtoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
            {
                _produtosAppService.Atualizar(produtoViewModel);
                return RedirectToAction("Index");
            }
            return View(produtoViewModel);
        }

        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var produtoViewModel = _produtosAppService.ObterPorId(id.Value);

            if (produtoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(produtoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _produtosAppService.Remover(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _produtosAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
