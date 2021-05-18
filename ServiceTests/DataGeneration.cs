
using GenFu;
using RLS.AwesomeBar.API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTest
{
    public static class DataGeneration
    {
        public static List<Category> GetCategoryFakeData()
        {
            string i = "bfab7f2e-2816-4661-89d5-ef258ddcb720";
            var categories = A.ListOf<Category>(26);
            foreach (var x in categories)
            {
                x.ID = Guid.Parse(i);
                i = Guid.NewGuid().ToString();
            }
            return categories.Select(_ => _).ToList();
        }

        public static List<Ingredient> GetIngredientsFakeData()
        {
            string i = "bfab7f2e-2816-4661-89d5-ef258ddcb720";
            var ingredients = A.ListOf<Ingredient>(26);
            foreach (var x in ingredients)
            {
                x.ID = Guid.Parse(i);
                i = Guid.NewGuid().ToString();
            }
            return ingredients.Select(_ => _).ToList();
        }

        public static List<Cocktail> GetCocktailsFakeData()
        {
           
          var cocktails = new List<Cocktail> { new Cocktail { ID = Guid.Parse("bfab7f2e-2816-4661-89d5-ef258ddcb720"), Name = "cocktailName1", Ingredients = "cocktailIngredient1" },
        new Cocktail { ID = Guid.Parse("bfab7f2e-2816-8961-89d5-ef258ddcb720"), Name = "cocktailName12", Ingredients = "cocktailIngredient11"},
         new Cocktail { ID = Guid.Parse("bfab7f2e-2816-5561-89d5-ef258ddcb720"), Name = "cocktailName20", Ingredients = "cocktailIngredient22" },
         new Cocktail { ID = Guid.Parse("bfab7f2e-2816-5561-89d5-ef245ddcb720"), Name = "cocktailName40", Ingredients = "cocktailIngredient42" }
        };
            return cocktails.Select(_ => _).ToList();
        }
    }
}
