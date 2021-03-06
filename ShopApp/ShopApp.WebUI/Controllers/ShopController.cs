using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Entities;
using ShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    public class ShopController : Controller
    {
        private IProductService _productService;
       public ShopController(IProductService productService)
        {
            _productService = productService;

        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult List(string category, int page = 1)
        {
            const int pageSize = 6;
            return View(new ProductListModel()
            {
                Products = _productService.GetProductsByCategory(category, page, pageSize),
                PageInfo = new PageInfo()
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = _productService.GetCountByCategory(category),
                    CurrentCategory = category
                }
            });
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product product = _productService.GetProductDetails((int)id);

            if (product == null)
            {
                return NotFound();
            }

            return View(new ProductDetailsModel()
            {
                Product = product,
                Categories = product.ProductCategories.Select(i => i.Category).ToList()
            }); 
            
        }



    }
}
