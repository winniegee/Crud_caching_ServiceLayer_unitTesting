using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RLS.AwesomeBar.API.Database;

namespace RLS.AwesomeBar.API.Services
{
    public class IngredientService
    {
        private readonly BarContext context;

        public IngredientService(BarContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Ingredient>> GetIngredientsAsync()
        {
            return await context.Ingredients.ToListAsync();
        }

        public Ingredient GetIngredient(Guid id)
        {
            var ingredient = context.Ingredients.FirstOrDefault(x => x.ID == id);
            if (ingredient == null)
            {
                return null;
            }
            return ingredient;
        }
    }
}
