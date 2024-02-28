using KodlamaIOHomework.Abstract;
using KodlamaIOHomework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOHomework.Concreate
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> _categories;
        public CategoryDal() {
            _categories = new List<Category>
            {
                new Category{Id=1,Name="yazılım"}
            };
            }    
        

        public void Add(Category category)
        {
           _categories.Add(category);
            Console.WriteLine("Kategori başarıyla eklendi");
        }

        public void Update(Category category)
        {
            Console.WriteLine("Katefgori başarıyla güncellendi");
        }

        public void Delete(Category category)
        {
            _categories.Remove(category);
            Console.WriteLine("Kategori başarıyla silindi");
        }

        public List<Category> GetAll()
        {
            return _categories;
        }
    }
}
