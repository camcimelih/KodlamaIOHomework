using KodlamaIOHomework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOHomework.Abstract
{
    public interface IInstructorDal
    {
        List<Instructor> GetAll();
        public void Add(Instructor instructor);
        public void Update(Instructor instructor);
        public void Delete(Instructor instructor);
    }
}
