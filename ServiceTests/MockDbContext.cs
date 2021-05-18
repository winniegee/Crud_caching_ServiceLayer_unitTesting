using Microsoft.EntityFrameworkCore;
using Moq;
using RLS.AwesomeBar.API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceTest
{
    public static class MockDbContext
    {
        public static Mock<BarContext> CategoryGetQueryableMockDbSet()
        {

            var sourceList = DataGeneration.GetCategoryFakeData().AsQueryable();
            var mockDbSet = new Mock<DbSet<Category>>();
            mockDbSet.As<IAsyncEnumerable<Category>>().Setup(m => m.GetAsyncEnumerator(new CancellationToken())).Returns(new TestDbAsyncEnumerator<Category>(sourceList.GetEnumerator()));
            mockDbSet.As<IQueryable<Category>>().Setup(m => m.Provider).Returns(sourceList.Provider);
            mockDbSet.As<IQueryable<Category>>().Setup(m => m.Expression).Returns(sourceList.Expression);
            mockDbSet.As<IQueryable<Category>>().Setup(m => m.ElementType).Returns(sourceList.ElementType);
            mockDbSet.As<IQueryable<Category>>().Setup(m => m.GetEnumerator()).Returns(sourceList.GetEnumerator());


            var mockContext = new Mock<BarContext>();
            mockContext.Setup(c => c.Categories).Returns(mockDbSet.Object);
            return mockContext;
        }

        public static Mock<BarContext> IngredientGetQueryableMockDbSet()
        {

            var sourceList = DataGeneration.GetIngredientsFakeData().AsQueryable();
            var mockDbSet = new Mock<DbSet<Ingredient>>();
            mockDbSet.As<IAsyncEnumerable<Ingredient>>().Setup(m => m.GetAsyncEnumerator(new CancellationToken())).Returns(new TestDbAsyncEnumerator<Ingredient>(sourceList.GetEnumerator()));
            mockDbSet.As<IQueryable<Ingredient>>().Setup(m => m.Provider).Returns(sourceList.Provider);
            mockDbSet.As<IQueryable<Ingredient>>().Setup(m => m.Expression).Returns(sourceList.Expression);
            mockDbSet.As<IQueryable<Ingredient>>().Setup(m => m.ElementType).Returns(sourceList.ElementType);
            mockDbSet.As<IQueryable<Ingredient>>().Setup(m => m.GetEnumerator()).Returns(sourceList.GetEnumerator());


            //cdbSet.Setup(c => c.Add(It.IsAny<T>())).Callback<T>((s) => source.Add(s));

            var mockContext = new Mock<BarContext>();
            mockContext.Setup(c => c.Ingredients).Returns(mockDbSet.Object);
            return mockContext;
        }

        public static Mock<BarContext> CocktailGetQueryableMockDbSet()
        {

            var sourceList = DataGeneration.GetCocktailsFakeData().AsQueryable();
            var mockDbSet = new Mock<DbSet<Cocktail>>();
            mockDbSet.As<IAsyncEnumerable<Cocktail>>().Setup(m => m.GetAsyncEnumerator(new CancellationToken())).Returns(new TestDbAsyncEnumerator<Cocktail>(sourceList.GetEnumerator()));
            mockDbSet.As<IQueryable<Cocktail>>().Setup(m => m.Provider).Returns(sourceList.Provider);
            mockDbSet.As<IQueryable<Cocktail>>().Setup(m => m.Expression).Returns(sourceList.Expression);
            mockDbSet.As<IQueryable<Cocktail>>().Setup(m => m.ElementType).Returns(sourceList.ElementType);
            mockDbSet.As<IQueryable<Cocktail>>().Setup(m => m.GetEnumerator()).Returns(sourceList.GetEnumerator());


            //cdbSet.Setup(c => c.Add(It.IsAny<T>())).Callback<T>((s) => source.Add(s));

            var mockContext = new Mock<BarContext>();
            mockContext.Setup(c => c.Cocktails).Returns(mockDbSet.Object);
            return mockContext;
        }
    }
}
