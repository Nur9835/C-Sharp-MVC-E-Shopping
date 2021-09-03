using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
    public interface ICartService
    {
        void InitializeCart(string userId);
        void AddToCart(string userId, int productId, int quantity);

        Cart GetCartByUserId(string userId);
        void DeleteCart(string userId, int productId);
        void ClearCart(string cartId);
    }
}
