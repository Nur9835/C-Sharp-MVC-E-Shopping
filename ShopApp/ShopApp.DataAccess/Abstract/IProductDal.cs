using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.DataAccess.Abstract
{
    public interface IProductDal:IRepository<Product>
    {
        IEnumerable<Product> GetPopularProducts();

        Product GetProductDetails(int id);


        List<Product> GetProductsByCategory(string category,int page,int pageSize);
        int GetCountByCategory(string category);
        Product GetByIdWithCategories(int id);
        void Update(Product entity, int[] categoryIds);
    }
}
