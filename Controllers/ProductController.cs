using Microsoft.AspNetCore.Mvc;
using SportsStore3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore3.Controllers
{
    public class ProductController : Controller
    {
        //Dependency injection
        private IProductRepository repository;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Products);
    }
}
