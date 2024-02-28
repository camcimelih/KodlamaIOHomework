using KodlamaIOHomework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOHomework.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        public void Add(Category category);
        public void Update(Category category);
        public void Delete(Category category);
    }
}
