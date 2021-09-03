
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShopApp.Business.Abstract;
using ShopApp.Business.Concrete;
using ShopApp.Business.Conctere;
using ShopApp.DataAccess.Abstract;
using ShopApp.DataAccess.Concrete.EfCore;
using ShopApp.WebUI.EmailServices;
using ShopApp.WebUI.Identity;
using ShopApp.WebUI.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUI
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        
        public void ConfigureServices(IServiceCollection services)
        {

         services.AddDbContext<ApplicationIdentityDbContext>(options =>
          options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
           .AddEntityFrameworkStores<ApplicationIdentityDbContext>()
           .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                // password

                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;

                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;

                // options.User.AllowedUserNameCharacters = "";
                options.User.RequireUniqueEmail = true;//ayný mail adresiyle birden fazla üyelik olmaz

                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });


            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.SlidingExpiration = true;
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".ShopApp.Security.Cookie",
                    SameSite=SameSiteMode.Strict
                };

            });


            services.AddScoped<IProductDal, EfCoreProductDal>();
            services.AddScoped<ICategoryDal, EfCoreCategoryDal>();
            services.AddScoped<ICartDal, EfCoreCartDal>();
            services.AddScoped<IOrderDal, EfCoreOrderDal>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICartService, CartManager>();
            services.AddScoped<IOrderService, OrderManager>();

            services.AddTransient<IEmailSender, EmailSender>();

            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);

            //services.AddMvc(option => option.EnableEndpointRouting = false);
            //IProduct,EfCoreProductDal
            //IProduct, MySqlProductDal



            services.AddRazorPages();
        }






        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {



            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                SeedDatabase.Seed();
            }
         app.UseStaticFiles();
           app.CustomStaticFiles();
        app.UseAuthentication();

            app.UseHttpsRedirection();

          
          
    //app.UseEndpoints(endpoints =>
    //        {
    //            endpoints.MapRazorPages();
    //        });
      

 app.UseCors();


            app.UseRouting();
            app.UseAuthorization();

           

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute("products", "products/{category?}",
                defaults: new { controller = "Shop", action = "List" });


               endpoints.MapControllerRoute("adminProducts", "admin/products",
                defaults: new { controller = "Admin", action = "ProductList" });


             endpoints.MapControllerRoute("adminProducts", "admin/products/{id?}",
                defaults: new { controller = "Admin", action = "EditProduct" });



                
             endpoints.MapControllerRoute("cart", "cart",
                defaults: new { controller = "Cart", action = "Index" });           
                
                
                
                endpoints.MapControllerRoute("orders", "orders",
                defaults: new { controller = "Cart", action = "GetOrders" });


                      endpoints.MapControllerRoute("checkout", "checkout",
                defaults: new { controller = "Cart", action = "Checkout" });





                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

            SeedIdentity.Seed(userManager, roleManager, Configuration).Wait();

        }
    }
}
