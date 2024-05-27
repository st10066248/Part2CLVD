using Microsoft.AspNetCore.Mvc;
using Part2CLVD.Models;
using Part2CLVD.Services;

namespace Part2CLVD.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext context;

        public ProductsController(ApplicationDbContext context) 
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var products =context.Products.OrderByDescending(p => p.Id).ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
		public IActionResult Create(ProductDto productDto)
		{
            if (productDto.Name == null)
            {
                ModelState.AddModelError("Name", "The name is required");
            }
            if (!ModelState.IsValid)
            {
				return View(productDto);
			}

            Product product = new Product()
            {
                Name = productDto.Name,
                Description = productDto.Description,
                Category = productDto.Category,
                Price = productDto.Price,
                Availibility = productDto.Availibility
            };

            context.Products.Add(product);  
            context.SaveChanges();  


			return RedirectToAction("Index","Products");
		}

        public IActionResult Edit(int id)
        {
            var product = context.Products.Find(id);

            if (product == null) 
            {
                return RedirectToAction("Index", "Products");
            }


            // Create productDto from product
            var productDto = new ProductDto()
            {
                Name = product.Name,
                Description = product.Description,
                Category = product.Category,
                Price = product.Price,
                Availibility = product.Availibility
            };

            ViewData["id"] = id;    
            return View(productDto);    

            
		}
        [HttpPost]
		public IActionResult Edit(int id, ProductDto productDto)
        {
            var product = context.Products.Find(id);

            if (product == null) 
            {
                return RedirectToAction("Index", "Products");
            }

            if (!ModelState.IsValid) 
            {
				ViewData["id"] = id;

				return View(productDto);    
            }

            product.Name = productDto.Name;
            product.Description = productDto.Description;   
            product.Category = productDto.Category;
            product.Price = productDto.Price;
            product.Availibility = productDto.Availibility;

            context.SaveChanges();

            return RedirectToAction("Index", "Products");
        }

        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(id);

            if (product == null)
            {
                return RedirectToAction("Index", "Products");
            }

            context.Products.Remove(product);   
            context.SaveChanges();
            return RedirectToAction("Index", "Products");
        }



	}

  
}
