using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Projectt.DAL;
using Final_Projectt.Models;
using Final_Projectt.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Final_Projectt.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [Authorize(Roles = Utility.AdminRole)]
    public class SocialMediaController : Controller
    {
        private AppDbContext _context;
        public SocialMediaController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Bios);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Bio slider)
        {
            if (ModelState["Facebook"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Twitter"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Instagram"].ValidationState == ModelValidationState.Invalid ||
                ModelState["Youtube"].ValidationState == ModelValidationState.Invalid )
            {
                return View();
            }
            
            await _context.Bios.AddAsync(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}