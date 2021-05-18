using Microsoft.EntityFrameworkCore;
using RLS.AwesomeBar.API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RLS.AwesomeBar.API.Services
{
    public class CocktailService
    {
        private readonly BarContext context;

        public CocktailService(BarContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Cocktail>> GetCocktailsAsync()
        {
            return await context.Cocktails.ToListAsync();
        }

        
        public async Task<List<Cocktail>> GetCocktailsAsync(string name="", string ingredient="")
        {
            List<Cocktail> cocktail = new List<Cocktail>();
            List<Cocktail> dbCocktails= await context.Cocktails.ToListAsync();
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(ingredient))
            {
                foreach (var x in dbCocktails.Where(s => s.Name.Contains(name, StringComparison.CurrentCultureIgnoreCase) && s.Ingredients.Contains(ingredient)))
                {
                     cocktail.Add(x);
                }
                
            }
            if (!string.IsNullOrEmpty(name))
            {
                foreach (var x in dbCocktails.Where(s=>s.Name.Contains(name, StringComparison.CurrentCultureIgnoreCase)))
                {
                    if (!cocktail.Contains(x)) cocktail.Add(x);
                }
            }
            if (!string.IsNullOrEmpty(ingredient))
            {
                foreach (var x in dbCocktails.Where(s=>s.Ingredients.Contains(ingredient, StringComparison.CurrentCultureIgnoreCase)))
                {
                    if (!cocktail.Contains(x)) cocktail.Add(x);
                }
            }
            return cocktail;
        }
        public async Task<Cocktail> GetRandomCocktail()
        {
            List<Cocktail> dbCocktails = await context.Cocktails.ToListAsync();
            Cocktail randCocktail =  (from x in dbCocktails
                                     orderby Guid.NewGuid()
                                     select x).FirstOrDefault();
            return randCocktail;
        }
        public Cocktail GetCocktail(Guid id)
        {
            var cocktail = context.Cocktails.FirstOrDefault(x => x.ID == id);
            if (cocktail == null)
            {
                return null;
            }
            return cocktail;
        }
    }
}
