using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.DataAccess.Concrete.EfCore
{
   public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();


            if(context.Database.GetPendingMigrations().Count()== 0)
            {
                if(context.Categories.Count()==0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategory);
                }

                context.SaveChanges();

            }
        }




        private static Category[] Categories =
        {
            new Category(){Name="Telefon"},
            new Category(){Name="Elektrikli Ev Aletleri"},
            new Category(){Name="TV,Ses ve Görüntü Sistemleri"},
            new Category(){Name="Kişisel Bakım"},
            new Category(){Name="Oyun Konsolları,Fotoğraf Makinesi ve Kamera"},
            new Category(){Name="Bilgisayar"}


        };


        private static Product[] Products =
        {
                new Product(){Name="Samsung S6",ImageUrl="1.jpg",Price=250000,Description="<p> Güzel Telefon</p>"},
                new Product(){Name="Samsung A6",ImageUrl="2.jpg",Price=5000,Description="<p> Güzel Telefon</p>"},
                new Product(){Name="Samsung S5",ImageUrl="3.jpg",Price=2000,Description="<p> Güzel Telefon</p>"},
                new Product(){ Name="Samsung A5",ImageUrl="4.jpg",Price=4500,Description="<p> Güzel Telefon</p>"},
                new Product(){ Name="Arzum AR596 İmaj İyonlu Saç Kurutma Makinesi (2200W)",ImageUrl="5.jpg",Price=200,Description="<p> Güzel Telefon</p>"},
                new Product(){ Name="Fakir Capello Saç Kurutma Makinesi ",ImageUrl="6.jpg",Price=300,Description="<p> Güzel Telefon</p>"},
                new Product(){ Name="Philips HP8361/00 ProCare Keratin Saç Düzleştirici",ImageUrl="7.jpg",Price=900,Description="<p> Güzel Telefon</p>"},
                new Product(){ Name="Remington S8598 Keratin Protect Saç Düzleştirici",ImageUrl="8.jpg",Price=600,Description="<p> Güzel Telefon</p>"}
        };


        private static ProductCategory[] ProductCategory =
        {
            new ProductCategory(){Product=Products[0],Category=Categories[0]},
            new ProductCategory(){Product=Products[1],Category=Categories[0]},
            new ProductCategory(){Product=Products[2],Category=Categories[0]},
            new ProductCategory(){Product=Products[3],Category=Categories[0]},
            new ProductCategory(){Product=Products[4],Category=Categories[1]},
            new ProductCategory(){Product=Products[4],Category=Categories[3]},   
            new ProductCategory(){Product=Products[5],Category=Categories[1]},
            new ProductCategory(){Product=Products[5],Category=Categories[3]},         
            new ProductCategory(){Product=Products[6],Category=Categories[1]},
            new ProductCategory(){Product=Products[6],Category=Categories[3]},      
            new ProductCategory(){Product=Products[7],Category=Categories[1]},
            new ProductCategory(){Product=Products[7],Category=Categories[3]},
        };

    }

}
