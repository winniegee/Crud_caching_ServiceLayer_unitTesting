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
    public class IngredientsController : ControllerBase
    {
        private readonly IngredientService service;
        private IMemoryCache memoryCache;
        public IngredientsController(IngredientService service, IMemoryCache memoryCache)
        {
            this.service = service;
            this.memoryCache = memoryCache;
        }

        [HttpGet]
        public async Task<IEnumerable<Ingredient>> GetIngredients()
        {
            var ingredients = await memoryCache.GetOrCreateAsync<IEnumerable<Ingredient>>("ingredients", async entry =>
            {
                entry.SetSlidingExpiration(TimeSpan.FromSeconds(30));
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(120);
                return await service.GetIngredientsAsync();
            });

            return ingredients;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ingredient>> GetIngredient(Guid Id)
        {
            var ingredient = await memoryCache.GetOrCreateAsync<Ingredient>("ingredient " + Id, async entry =>
            {
                entry.SetSlidingExpiration(TimeSpan.FromSeconds(30));
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(120);
                return service.GetIngredient(Id);
            });


            if (ingredient == null)
            {
                return NotFound();
            }

            return ingredient;
        }
    }
}
