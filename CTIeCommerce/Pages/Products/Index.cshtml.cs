using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CTIeCommerce.Data;
using CTIeCommerce.Models;

namespace CTIeCommerce.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly CTIeCommerce.Data.CTIeCommerceContext _context;

        public IndexModel(CTIeCommerce.Data.CTIeCommerceContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
