using KodlamaIOHomework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOHomework.Abstract
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        public void Add(Course course);
        public void Update(Course course);
        public void Delete(Course course);
    }
}
