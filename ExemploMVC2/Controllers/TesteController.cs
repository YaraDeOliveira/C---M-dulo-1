using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExemploMVC2.Models;

namespace ExemploMVC2.Controllers
{
    public class TesteController : Controller
    {
        public string Exemplo01()
        {
            return "Isto é um método.";
        }


        public ViewResult Exemplo02()
        {
            return View();
        }

        public ViewResult Exemplo03()
        {
            var fornecedor = new FornecedorViewModel();
            fornecedor.Nome = "Papelaria Asp.Net";
            fornecedor.Email = "papel@asp.net";
            fornecedor.Telefone = "555-3434";

            return View(fornecedor);
        }
    }
}