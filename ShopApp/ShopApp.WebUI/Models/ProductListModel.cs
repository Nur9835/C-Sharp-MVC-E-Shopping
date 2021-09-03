using ShopApp.Entities;
using ShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI.Models
{  
    public class PageInfo
            {
            public int TotalItems { get; set; } //total product
            public int ItemsPerPage { get; set; } //her sayfada eleman sayısı
           public int CurrentPage { get; set; }   //aktif page no
           public string CurrentCategory { get; set; }   //aktif category bilgisi
    
       public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItems/ItemsPerPage);
         
        }
    
    
    }
    public class ProductListModel
    { 
     public List<Product> Products { get; set; }
  public PageInfo PageInfo { get; set; }

    
}
}
