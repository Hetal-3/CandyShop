using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        { 
            new Category{CategoryId=1,CategoryDescription="Awesome and delicious hard candy",CategoryName="Hard Candy"},
            new Category{CategoryId=2,CategoryDescription="Scrumptious chocolate candy",CategoryName="Chocolate candy"},
            new Category{ CategoryId=3,CategoryName="Fruit candy",CategoryDescription="Sweet and sour fruit candy"}
            
        };
    }
}
