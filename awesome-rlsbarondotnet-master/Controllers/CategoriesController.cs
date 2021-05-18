using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using RLS.AwesomeBar.API.Database;
using RLS.AwesomeBar.API.Services;

namespace RLS.AwesomeBar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CategoryService service;
        private IMemoryCache memoryCache;

        public CategoriesController(CategoryService service, IMemoryCache memoryCache)
        {
            this.service = service;
            this.memoryCache = memoryCache;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetCategories()
        {
            var categories = await memoryCache.GetOrCreateAsync<IEnumerable<Category>>("categories",async entry=>
            {
                entry.SetSlidingExpiration(TimeSpan.FromSeconds(30));
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(120);
                return await service.GetCategoriesAsync();
            });
           
            return categories;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(Guid id)
        {
            var category = await memoryCache.GetOrCreateAsync<Category>("category "+id, async entry =>
            {
                entry.SetSlidingExpiration(TimeSpan.FromSeconds(30));
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(120);
                return  service.GetCategory(id);
            });


            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }
    }
}
