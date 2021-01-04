
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Backend.Core.Responses;
using Backend.Core.Request;
using Backend.Models;
using System;
using Backend.Services.Request;

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
        public ActionResult<ResponseRegister> Register(RequestRegisterProduct request)
        {
            var responseRegister = new ResponseRegister();
            using (var db = new MySqlContext())
            {
                var category_id = request.Category_id;
                var title = request.Title;
                var description = request.Description;
                var price = request.Price;
                var discount = request.Discount;
                var stock = request.Stock;
                var url_image = request.Url_image;
                var is_promotion = request.Is_promotion;
                var is_activate = request.Is_activate;
                
                
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
