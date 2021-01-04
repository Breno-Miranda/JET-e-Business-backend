
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Backend.Core.Responses;
using Backend.Core.Request;
using Backend.Models;
using System;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController()
        {
            
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<object> Index()
        {
            using (var db = new MySqlContext())
            {
                return  await db.Product.ToListAsync();
            }
        }
        
        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        public ActionResult<ResponseRegister> Register(RequestRegisterProduct requestRegisterProduct)
        {
            var responseRegister = new ResponseRegister();
            using (var db = new MySqlContext())
            {
                var category_id = requestRegisterProduct.Category_id;
                var title = requestRegisterProduct.Title;
                var description = requestRegisterProduct.Description;
                var price = requestRegisterProduct.Price;
                var discount = requestRegisterProduct.Discount;
                var stock = requestRegisterProduct.Stock;
                var url_image = requestRegisterProduct.Url_image;
                var is_promotion = requestRegisterProduct.Is_promotion;
                var is_activate = requestRegisterProduct.Is_activate;
                
                
                var product = new Product();
                product.Category_id = category_id;
                product.Title = title;
                product.Description = description;
                product.Price =  Decimal.Parse(price);
                product.Discount = Decimal.Parse(discount);
                product.Stock = stock;
                product.Url_image = url_image;
                product.Is_promotion = is_promotion;
                product.Is_activate = is_activate;
            
                db.Product.Add(product);
                db.SaveChanges();
                responseRegister.Success = true;
            }
            return responseRegister;
        }
    }
}
