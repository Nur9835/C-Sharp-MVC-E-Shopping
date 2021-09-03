﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Entities;
using ShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Controllers
{
    
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public AdminController(IProductService productService,ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult ProductList()
        {
            return View(new ProductListModel()
            {
                Products = _productService.GetAll()
            });
        }





        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductModel model, IFormFile file)
        {
            if (file != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                var entity = new Product
                {
                    Name = model.Name,
                    Description = model.Description,
                    ImageUrl = file.FileName,
                   Price = model.Price
                };

                _productService.Create(entity);

            }

            return Redirect("ProductList");

       


        //if (ModelState.IsValid)
        //{
        //    var entity = new Product()
        //    {
        //        Name = model.Name,
        //        Price = model.Price,
        //        Description = model.Description,
        //        ImageUrl = model.ImageUrl
        //    };

        //    if (_productService.Create(entity))
        //    {
        //        return RedirectToAction("ProductList");

        //    }

        //    ViewBag.ErrorMessage = _productService.ErrorMessage;
        //    return View(model);
        //}
        //return View(model);
   }

















            [HttpGet]
        public IActionResult CreateProduct()
        {
            return View(new ProductModel());
        }





        public IActionResult EditProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _productService.GetByIdWithCategories((int)id);

            if (entity == null)
            {
                return NotFound();
            }

            var model = new ProductModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                Description = entity.Description,
                ImageUrl = entity.ImageUrl,
                SelectedCategories = entity.ProductCategories.Select(i => i.Category).ToList()
            };

            ViewBag.Categories = _categoryService.GetAll();

            return View(model);
        }




        [HttpPost]
        public async Task<IActionResult> EditProduct(ProductModel model, int[] categoryIds, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var entity = _productService.GetById(model.Id);

                if (entity == null)
                {
                    return NotFound();
                }

                entity.Name = model.Name;
                entity.Description = model.Description;
                entity.Price = model.Price;

                if (file!= null)
                {
                    entity.ImageUrl = file.FileName;

                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }

                _productService.Update(entity,categoryIds);

                return RedirectToAction("ProductList");

            }

            ViewBag.Categories = _categoryService.GetAll();

            return View(model);
        }









        [HttpPost]
        public IActionResult DeleteProduct(int productId)
        {
            var entity = _productService.GetById(productId);

            if (entity != null)
            {
                _productService.Delete(entity);
            }


            return RedirectToAction("ProductList");
        }




        public IActionResult CategoryList()
        {

            return View(new CategoryListModel()
            {
                Categories = _categoryService.GetAll()

            });
        }


        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var enitiy = _categoryService.GetByIdWithProducts(id);

            return View(new CategoryModel()
            {
                Id = enitiy.Id,
                Name = enitiy.Name,
                Products = enitiy.ProductCategories.Select(p => p.Product).ToList()

            }) ;

        }


        [HttpPost]
        public IActionResult EditCategory(CategoryModel model)
        {
            var entity = _categoryService.GetById(model.Id);
            if (entity == null)
            {
                return NotFound();
            }

            entity.Name = model.Name;
            _categoryService.Update(entity);

            return RedirectToAction("CategoryList");
        }


        [HttpGet]
        public IActionResult CreateCategory()
        {

            return View();

        }      
        

        [HttpPost]
        public IActionResult CreateCategory(CategoryModel model)
        {
            var entity = new Category()
            {
                Name = model.Name
            };


            _categoryService.Create(entity);
            return RedirectToAction("CategoryList");
        }




        [HttpPost]
        public IActionResult DeleteCategory(int categoryId)
        {
            var entity = _categoryService.GetById(categoryId);

            if (entity != null)
            {
                _categoryService.Delete(entity);
            }

            return RedirectToAction("CategoryList");
        }

         [HttpPost]


         public IActionResult DeleteFromCategory(int categoryId,int productId)
        {
            _categoryService.DeleteFromCategory(categoryId, productId);
            return Redirect("/admin/editcategory/"+ categoryId);
        }













    }
}
