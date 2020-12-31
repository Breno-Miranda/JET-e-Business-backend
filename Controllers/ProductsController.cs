
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using Backend.Core.Responses;
using Backend.Core.Requests;
using Backend.Core.Request;
using Backend.Models;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public ProductsController(IConfiguration configuration )
        {
            _configuration = configuration;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("/")]
        public ActionResult<ResponseLogin> Get(RequestLogin requestLogin)
        {
            var responseLogin = new ResponseLogin();
            
            return responseLogin;
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
                product.Price = price;
                product.Discount = discount;
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
