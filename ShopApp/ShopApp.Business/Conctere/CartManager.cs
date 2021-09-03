using ShopApp.Business.Abstract;
using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Conctere
{
    public class CartManager : ICartService
    {
        private ICartDal _cartDal;
        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public void AddToCart(string userId, int productId, int quantity)
        {
            var cart = GetCartByUserId(userId);  

            if(cart!=null)
            {
           var index = cart.CartItems.FindIndex(i => i.ProductId == productId);
               
                if(index<0)  //eklenmek istenen ürün önceden sepette değilse
                {

                    cart.CartItems.Add(new CartItem()
                    {
                        ProductId = productId,
                        Quantity = quantity,
                        CartId = cart.Id
                    });


                }
                else //aynı ürün tekrar eklenmek istendiğinde
                {
                    cart.CartItems[index].Quantity += quantity;
                }

                _cartDal.Update(cart);

            }
        }

        public void DeleteCart(string userId, int productId)
        {
            var cart = GetCartByUserId(userId);
            if(cart!=null)
            {
                var cartıd = cart.Id;

                _cartDal.DeleteCart(cart.Id,productId);
            }

        }
        public void ClearCart(string cartId)
        {
            _cartDal.ClearCart(cartId);
        }
        public Cart GetCartByUserId(string userId)
        {
            return _cartDal.GetByUserId(userId);
        }

        public void InitializeCart(string userId)
        {
            _cartDal.Create(new Cart() { UserId = userId });
        }
    }
}
