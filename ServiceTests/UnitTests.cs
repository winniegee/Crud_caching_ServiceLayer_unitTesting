using Microsoft.EntityFrameworkCore;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using RLS.AwesomeBar.API.Database;
using RLS.AwesomeBar.API.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceTest
{

    public class Tests
    {

        [Test]
        public async Task GetAllCategoriesTest()
        {
            var context = MockDbContext.CategoryGetQueryableMockDbSet();
            var service = new CategoryService(context.Object);
            var result = await service.GetCategoriesAsync();
            var count = result.Count();
            Assert.AreEqual(26, count);
        }

        [Test]
        public void GetCategoryByIDTest()
        {
            var context = MockDbContext.CategoryGetQueryableMockDbSet();
            var service = new CategoryService(context.Object);
            var result = service.GetCategory(Guid.Parse("bfab7f2e-2816-4661-89d5-ef258ddcb720"));
            Assert.AreEqual(Guid.Parse("bfab7f2e-2816-4661-89d5-ef258ddcb720"), result.ID);
        }
        [Test]
        public async Task GetAllIngredientTest()
        {
            var context = MockDbContext.IngredientGetQueryableMockDbSet();
            var service = new IngredientService(context.Object);
            var result = await service.GetIngredientsAsync();
            var count = result.Count();
            Assert.AreEqual(26, count);
        }

        [Test]
        public void GetIngredientByIDTest()
        {
            var context = MockDbContext.IngredientGetQueryableMockDbSet();
            var service = new IngredientService(context.Object);
            var result = service.GetIngredient(Guid.Parse("bfab7f2e-2816-4661-89d5-ef258ddcb720"));
            Assert.AreEqual(Guid.Parse("bfab7f2e-2816-4661-89d5-ef258ddcb720"), result.ID);
        }

        [Test]
        public async Task GetAllCocktailsTest()
        {
            var context = MockDbContext.CocktailGetQueryableMockDbSet();
            var service = new CocktailService(context.Object);
            var result = await service.GetCocktailsAsync();
            var count = result.Count();
            Assert.AreEqual(4, count);
        }

        [Test]
        public void GetCocktailByIDTest()
        {
            var context = MockDbContext.CocktailGetQueryableMockDbSet();
            var service = new CocktailService(context.Object);
            var result = service.GetCocktail(Guid.Parse("bfab7f2e-2816-4661-89d5-ef258ddcb720"));
            Assert.AreEqual(Guid.Parse("bfab7f2e-2816-4661-89d5-ef258ddcb720"), result.ID);
        }

        [Test]
        public async Task GetCocktailBySearchParameters()
        {

            string name = "cocktailName1";
            string ingredient = "cocktailIngredient1";
            var context = MockDbContext.CocktailGetQueryableMockDbSet();
            var service = new CocktailService(context.Object);
            var result = await service.GetCocktailsAsync(name, ingredient);
            var cocktailExpected = new List<Cocktail> { new Cocktail { ID = Guid.Parse("bfab7f2e-2816-4661-89d5-ef258ddcb720"), Name = "cocktailName1", Ingredients = "cocktailIngredient1" },
        new Cocktail {  ID = Guid.Parse("bfab7f2e-2816-8961-89d5-ef258ddcb720"), Name = "cocktailName12", Ingredients = "cocktailIngredient11"} };
            //Assert.IsTrue(result.SequenceEqual(cocktail));
           var resultJson = JsonConvert.SerializeObject(result);
            var cocktailExpectedJson = JsonConvert.SerializeObject(cocktailExpected);
            Assert.That(resultJson.Equals(cocktailExpectedJson));

          
        }

    }
}
