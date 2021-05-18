using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RLS.AwesomeBar.API.Database;

namespace RLS.AwesomeBar.API.Services
{
    public class CategoryService
    {
        private readonly BarContext context;

        public CategoryService(BarContext context)
        {
            this.context = context;
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
           
            return await context.Categories.ToListAsync();
        }

        public Category GetCategory(Guid id)
        {
            var category =  context.Categories.FirstOrDefault(x=>x.ID==id);
            if (category == null)
            {
                return null;
            }
            return category;
        }
    }
}
