using Microsoft.AspNetCore.Mvc;
using MicroSource.Api.Models;
using RepositoryPattern.Interface;
using System;
using System.Collections.Generic;

namespace RepositoryPattern.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //--------- Create

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productRepository.Create(product);
            return RedirectToAction("Index");
        }

        //--------- Read

        public IActionResult Index()
        {
            var products = _productRepository.GetAll();
            return View(products); // Passando a lista de produtos para a view
        }

        //--------- Update

        public ActionResult Edit(Guid id)
        {
            var product = _productRepository.GetById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _productRepository.Update(product);
            return RedirectToAction("Index");
        }

        //--------- Delete

        public IActionResult Delete(Guid id)
        {
            var product = _productRepository.GetById(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _productRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
