using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }


        //[Required(ErrorMessage = "Ürün adı belirtiniz")]
        //[StringLength(50,MinimumLength =5,ErrorMessage ="Ürün ismi minimum 5 maximum 50 karakter olmalı")]
        public string Name { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        //[Required(ErrorMessage = "Açıklama belirtiniz")]
        //[StringLength(10000, MinimumLength = 10, ErrorMessage = "Ürün açıklaması minimum 10 maximum 80 karakter olmalı")]
        public string Description { get; set; }

        //[Required(ErrorMessage ="Fiyat belirtiniz")]
        //[Range(1,100000)]
        public decimal? Price { get; set; }

        public List<Category> SelectedCategories { get; set; }
    
    }
}
