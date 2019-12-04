using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Product.Data;
using Product.Models;

namespace Product.Pages_Prooducts
{
    public class IndexModel : PageModel
    {
        private readonly Product.Data.ProductContext _context;

        public IndexModel(Product.Data.ProductContext context)
        {
            _context = context;
        }

        public IList<Products> Products { get;set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}
