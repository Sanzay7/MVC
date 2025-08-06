using Day16.FirstMVCAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day16.FirstMVCAPP.Controllers
{
    public class ProductController : Controller
    {
        List<ProductModel> datas = new List<ProductModel>();
        public ProductController ()
        {
            datas.Add(new ProductModel {Id=1, Name = "COKE", Price = 45 });
            datas.Add(new ProductModel {Id=2, Name = "FANTA", Price = 40 });
            datas.Add(new ProductModel {Id=3, Name = "SPRITE", Price = 35 });
            datas.Add(new ProductModel {Id=4, Name = "DEW", Price = 50 });

        }

        public IActionResult Index()
        {
            
            

            return View(datas);
           
        }
        public IActionResult Detail(int id) 
        {
            var model = datas.FirstOrDefault(x => x.Id == id);

            return View(model); 
        }


    }
}
