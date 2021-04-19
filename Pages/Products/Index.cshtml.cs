using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ps05IKS.Data;
using ps05IKS.Models;

namespace ps05IKS.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ps05IKS.Data.ProductContext _context;

        public IndexModel(ps05IKS.Data.ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
