using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Projectt.DAL;
using Final_Projectt.Extentions;
using Final_Projectt.Models;
using Final_Projectt.Utilities;
using Final_Projectt.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace Final_Projectt.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = Utility.AdminRole)]
    public class ProductController : Controller
    {
        private AppDbContext _context;
        private IHostingEnvironment _env;
        public ProductController(AppDbContext context,IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            var product = _context.Products.Include(p => p.ProductImages).ToList();
            return View(product);
        }

    
        public IActionResult Create()
        {
            var product = _context.Products.Include(x => x.ProductImages)
                                           .Include(c => c.MarkaCategory.Category)
                                           .Include(m => m.MarkaCategory.Marka).ToList();
            ProductViewModel productViewModel = new ProductViewModel
            {
                Products = product,
                ProductImages = _context.ProductImages,
                Categories = _context.Categorys,
                Markas = _context.Markas
            };
            return View(productViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product,ProductImage productImage,MarkaCategory markaCategory)
        {

            if (ModelState.IsValid)
            {
                return View();
            }

            var id = 0;
            if (! _context.MarkaCategorys.Any(x => x.CategoryId == markaCategory.CategoryId && x.MarkaId == markaCategory.MarkaId))
            {
               
                var newMarkaCategory = new MarkaCategory
                {
                    CategoryId = markaCategory.CategoryId,
                    MarkaId = markaCategory.MarkaId
                };

                await _context.MarkaCategorys.AddAsync(newMarkaCategory);
                await _context.SaveChangesAsync();
                id = newMarkaCategory.Id;
            }
            else
            {
                id = _context.MarkaCategorys.FirstOrDefault(x => x.CategoryId == markaCategory.CategoryId && x.MarkaId == markaCategory.MarkaId).Id;
            }
       
            await _context.Products.AddAsync(new Product
            {
                Name = product.Name,
                MarkaCategoryId = id,
                Price = product.Price,
                Count = product.Count,
                Discount = product.Discount,
                Date = DateTime.Now,
                Description = product.Description
            });
            await _context.SaveChangesAsync();

            var productId = _context.Products.LastOrDefault();
            foreach (var item in productImage.Photo)
            {
                if (!item.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil seçin");
                    return View();
                }

                if (!item.ImageSizeCheck(2))
                {
                    ModelState.AddModelError("Photo", "Şəkilin ölçüsü 2Mb-dan artıq ola bilməz");
                    return View();
                }

                string filename = await item.CopyImages(_env.WebRootPath, "product");
                productImage.Image = filename;
                await _context.ProductImages.AddAsync(new ProductImage
                {
                    ProductId = productId.Id,
                    Image = productImage.Image
                });
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}