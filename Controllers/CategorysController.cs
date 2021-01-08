
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Backend.Core.Responses;
using Backend.Models;
using System;
using System.Linq;
using Backend.Services.Request;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorysController : ControllerBase
    {
        public CategorysController()
        {

        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<object>  Index()
        {
            using (var db = new MySqlContext())
            {
                return await db.Category.Take(8).ToListAsync();
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        public ActionResult<ResponseRegister> Register(RequestRegisterCategory request)
        {
            var responseRegister = new ResponseRegister();
            using (var db = new MySqlContext())
            {
                var title = request.Title;
                var description = request.Description;
                var discount = request.Discount;
                var stock = request.Stock;
                var url_image = request.Url_image;
                var is_promotion = request.Is_promotion;
                var is_activate = request.Is_activate;


                var category = new Category();
                category.Title = title;
                category.Description = description;
                category.Discount = Decimal.Parse(discount);
                category.Stock = stock;
                category.Url_image = url_image;
                category.Is_promotion = is_promotion;
                category.Is_activate = is_activate;

                db.Category.Add(category);
                db.SaveChanges();
                responseRegister.Success = true;
            }
            return responseRegister;
        }
    }
}
