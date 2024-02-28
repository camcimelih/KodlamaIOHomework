using KodlamaIOHomework.Abstract;
using KodlamaIOHomework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOHomework.Concreate
{
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructors;
        public InstructorDal() 
        {
            _instructors = new List<Instructor>
            {
                new Instructor{Id=1,FirstName="Melih",LastName="CAMCI"}, 
                new Instructor{ Id = 2, FirstName = "DERİN", LastName = "DERMİROG" }
            };
        }
        public void Add(Instructor ınstructor)
        {
            _instructors.Add(ınstructor);
            Console.WriteLine("Eğitmen başarıyla eklendi");
        }

        public void Update(Instructor ınstructor)
        {
            Console.WriteLine("Eğitmen bilgleri güncellendi");
        }

        public void Delete(Instructor ınstructor)
        {
            _instructors.Remove(ınstructor);
            Console.WriteLine("Eğitmen kaydı başarıyla silindi");
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }
    }
}
