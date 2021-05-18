using Microsoft.AspNetCore.Mvc;
using RLS.AwesomeBar.API.Database;
using RLS.AwesomeBar.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RLS.AwesomeBar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CocktailsController : ControllerBase
    {
        private readonly CocktailService service;

        public CocktailsController(CocktailService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Cocktail>> GetCocktail()
        {
            return await service.GetCocktailsAsync();
        }

       
        [HttpGet(), Route("SearchCocktail")]
        public async Task<IEnumerable<Cocktail>> SearchCocktail(string cocktailName="", string ingredientName="")
        {
            var cocktail = await service.GetCocktailsAsync(cocktailName,ingredientName);

            if (cocktail == null)
            {
                return await service.GetCocktailsAsync();
            }

            return cocktail;
        }

        [HttpGet(), Route("RandomCocktail")]
        public async Task<Cocktail> RandomCocktail()
        {
            return await service.GetRandomCocktail();
            
        }
    }
}
