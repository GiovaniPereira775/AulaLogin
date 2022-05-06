using Login.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Login.Controllers
{

    [Authorize(AuthenticationSchemes = "CookieAuthentication")]
    public class ClientesController : Controller
    {
        
        public IActionResult Index()
        {
            Random rand = new Random();
            List<ClientesModel> model = new List<ClientesModel>();
            for (int i = 0; i < rand.Next(20,99); i++)
            {
                ClientesModel cliente = new ClientesModel();
                cliente.CPF = rand.Next(111, 999) + "." + rand.Next(111, 999) + "." + rand.Next(111, 999) + "-" + rand.Next(11, 99);
                cliente.Nome = "Nome do Cliente " + i;
                cliente.Telefone = "16" + rand.Next(1000, 9999) + "-" + rand.Next(1000, 9999);
                cliente.Id = rand.Next(1000, 9999);
                model.Add(cliente);

            }
            return View(model);
        }
    }
}
